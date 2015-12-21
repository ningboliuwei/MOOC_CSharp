using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using RssReader.DAL;
using RssReader.Model;

namespace RssReader
{
    public partial class frmMain : Form
    {
        //得到 RSS 保存为的 XML 文件路径
        readonly string xmlPath = Application.StartupPath + "\\rss.xml";
        //用于转换 XML 文件的 XSL 文件
        readonly string xslPath = Application.StartupPath + "\\rss.xsl";
        //输出的结果 HTML 文件（用于显示在窗体中的 WebBrowser 控件中）
        readonly string resultPath = Application.StartupPath + "\\rss.html";

        public frmMain()
        {
            InitializeComponent();
        }

        //点击 “添加” 工具栏按钮
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            frmRssEditor frm = new frmRssEditor {Tag = trvwRsses.SelectedNode.Name};
            frm.DataChanged += Frm_DataChanged;
            frm.ShowDialog();
        }

        private void BindTreeView()
        {
            trvwRsses.Nodes.Clear();
            //增加根节点（全部分类）
            TreeNode rootNode = new TreeNode("所有分类", 0, 0) {Name = "/"};
            trvwRsses.Nodes.Add(rootNode);

            //增加所有分类
            foreach (var category in CategoryDAL.GetAllCategories())
            {
                rootNode.Nodes.Add(new TreeNode(category.CategoryName, 1, 1) {Name = category.ID.ToString()});
            }

            var rsses = RssDAL.GetAllRsses();

            //增加所有 RSS 节点
            foreach (TreeNode node in trvwRsses.Nodes["/"].Nodes)
            {
                foreach (var rss in rsses.Where(r => r.Category.ToString() == node.Name))
                {
                    node.Nodes.Add(new TreeNode(rss.Title, 2, 2)
                    {
                        Name = rss.ID.ToString(),
                        ToolTipText = rss.Description
                    });
                }
            }
            trvwRsses.ExpandAll();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //在树形视图中显示数据
            BindTreeView();
        }

        private void trvRsses_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //将当前选中节点的 KEY 赋值给 Tag 属性
            trvwRsses.Tag = trvwRsses.SelectedNode.Name;
            SetToolStrip();

            if (trvwRsses.SelectedNode.Level == 2) //选中的是 RSS 节点
            {
                SaveRssToXmlFile(RssDAL.GetRssById(Convert.ToInt32(trvwRsses.SelectedNode.Name)).Url);
                TransformResult();
                ShowResult();
            }
        }

        private void SetToolStrip()
        {
            //设置各个工具栏按钮的可用性
            if (trvwRsses.SelectedNode.Level == 0) //根节点
            {
                toolStripButtonAdd.Enabled = false;
                toolStripButtonDelete.Enabled = false;
                toolStripButtonEdit.Enabled = false;
                toolStripButtonNewCategory.Enabled = true;
            }
            else if (trvwRsses.SelectedNode.Level == 1) //分类节点
            {
                toolStripButtonAdd.Enabled = true;
                toolStripButtonDelete.Enabled = true;
                toolStripButtonEdit.Enabled = true;
                toolStripButtonNewCategory.Enabled = false;
            }
            else if (trvwRsses.SelectedNode.Level == 2) //RSS节点
            {
                toolStripButtonAdd.Enabled = false;
                toolStripButtonDelete.Enabled = true;
                toolStripButtonEdit.Enabled = true;
                toolStripButtonNewCategory.Enabled = false;
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (trvwRsses.SelectedNode.Level == 2) //删除RSS节点
            {
                if (DialogResult.Yes ==
                    MessageBox.Show("真的要删除选中的RSS来源吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))

                {
                    RssDAL.Delete(trvwRsses.SelectedNode.Name);
                    BindTreeView();
                }
            }
            else if (trvwRsses.SelectedNode.Level == 1) //删除分类节点
            {
                string categoryID = trvwRsses.SelectedNode.Name;

                if (DialogResult.Yes ==
                    MessageBox.Show("真的要删除选中的分类，包括分类下所有的RSS来源吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))

                {
                    //删除分类下的所有 RSS 来源
                    foreach (
                        var r in
                            RssDAL.GetAllRsses().Where(r => r.Category.ToString() == categoryID))
                    {
                        RssDAL.Delete(r.ID.ToString());
                    }

                    //删除分类本身
                    CategoryDAL.Delete(categoryID);
                    BindTreeView();
                }
            }
        }

        //点击 “编辑” 按钮
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (trvwRsses.SelectedNode.Level == 2) //RSS 节点
            {
                var frm = new frmRssEditor(RssDAL.GetRssById(Convert.ToInt32(trvwRsses.SelectedNode.Name)));
                //当在 RssEditor 窗体修改数据后执行 Frm_DataChanged 事件处理程序
                frm.DataChanged += Frm_DataChanged;
                frm.ShowDialog();
            }
            else if (trvwRsses.SelectedNode.Level == 1) //分类节点
            {
                var frm =
                    new frmCategoryEditor(CategoryDAL.GetCategoryById(Convert.ToInt32(trvwRsses.SelectedNode.Name)));
                //当在 CategoryEditor 窗体修改数据后执行 Frm_DataChanged 事件处理程序
                frm.DataChanged += Frm_DataChanged;
                frm.ShowDialog();
            }
        }

        // DataChanged 事件处理程序
        private void Frm_DataChanged(object sender)
        {
            BindTreeView();
        }

        //点击 “新建分类” 按钮
        private void toolStripButtonNewCategory_Click(object sender, EventArgs e)
        {
            var frm = new frmCategoryEditor();
            frm.DataChanged += Frm_DataChanged;
            frm.ShowDialog();
        }

        //将指定 URL 的 RSS 保存到本地，格式为 XML 文件
        public void SaveRssToXmlFile(string url)
        {
            XmlDocument rss = new XmlDocument();
            try
            {
                rss.Load(url);
                rss.Save(xmlPath);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //将 RSS XML 文件转换为 HTML 文件
        public void TransformResult()
        {
            var trans = new XslCompiledTransform();
            trans.Load(xslPath);
            trans.Transform(xmlPath, resultPath);
        }

        //将 HTML 结果文件显示在 WebBrowser 控件中
        public void ShowResult()
        {
            wbsResult.Navigate(resultPath);
        }
    }
}