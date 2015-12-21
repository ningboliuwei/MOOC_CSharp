using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RssReader.DAL;
using RssReader.Model;

namespace RssReader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            frmRssEditor frm = new frmRssEditor {Tag = trvwRsses.Tag};
            frm.ShowDialog();
        }

        private void BindTreeView()
        {
            trvwRsses.Nodes.Clear();
            //增加
            TreeNode rootNode = new TreeNode("所有分类", 0, 0) {Name = "/"};
            trvwRsses.Nodes.Add(rootNode);

            foreach (var category in CategoryDAL.GetAllCategories())
            {
                rootNode.Nodes.Add(new TreeNode(category.CategoryName, 1, 1) {Name = category.ID.ToString()});
            }

            var rsses = RssDAL.GetAllRsses();

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
            BindTreeView();
        }

        private void trvRsses_AfterSelect(object sender, TreeViewEventArgs e)
        {
            trvwRsses.Tag = trvwRsses.SelectedNode.Name;

            SetToolStrip();
        }

        private void SetToolStrip()
        {
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
            if (trvwRsses.SelectedNode.Level == 2)//删除RSS节点
            {
                if (DialogResult.Yes ==
                    MessageBox.Show("真的要删除选中的RSS来源吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))

                {
                    RssDAL.Delete(trvwRsses.SelectedNode.Name);
                    BindTreeView();
                }
            }
            else if (trvwRsses.SelectedNode.Level == 1)//删除分类节点
            {
                string categoryID = trvwRsses.SelectedNode.Name;

                if (DialogResult.Yes ==
                    MessageBox.Show("真的要删除选中的分类，包括分类下所有的RSS来源吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))

                {
                    foreach (
                        var r in
                            RssDAL.GetAllRsses().Where(r => r.Category.ToString() == categoryID))
                    {
                        RssDAL.Delete(r.ID.ToString());
                    }

                    CategoryDAL.Delete(categoryID);
                    BindTreeView();
                }
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            var frm = new frmRssEditor(RssDAL.GetRssById(trvwRsses.SelectedNode.Name));
            frm.ShowDialog();
        }
    }
}