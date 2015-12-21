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
    public partial class frmCategoryEditor : Form
    {
        private readonly CategoryInfo _category;

        public delegate void DataChangedHandler(object sender);

        public event DataChangedHandler DataChanged;

        public frmCategoryEditor()
        {
            InitializeComponent();
        }

        //通过构造函数传入要编辑的分类信息
        public frmCategoryEditor(CategoryInfo category)
        {
            InitializeComponent();
            if (category != null)
            {
                _category = category;
            }
        }

        //显示分类信息
        private void ShowCategoryInfo()
        {
            if (_category != null)
            {
                txtTitle.Text = _category.CategoryName;
            }
        }

        //点击 “确定”按钮
        private void btnOK_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();

            var newCategory = new CategoryInfo() {CategoryName = title};
            if (_category == null)
            {
                //添加新的分类
                CategoryDAL.Add(newCategory);
            }
            else
            {
                //修改已有分类
                CategoryDAL.Update(_category.ID, newCategory);
            }
            //触发 DataChanged 事件
            OnDataChanged();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCategoryEditor_Load(object sender, EventArgs e)
        {
            ShowCategoryInfo();
        }

        protected virtual void OnDataChanged()
        {
            DataChanged?.Invoke(this);
        }
    }
}