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
    public partial class frmRssEditor : Form
    {
        private readonly RssInfo _rss;

        public delegate void DataChangedHandler(object sender);

        public event DataChangedHandler DataChanged;

        public frmRssEditor()
        {
            InitializeComponent();
        }

        //通过构造函数传入要编辑的 RSS 信息
        public frmRssEditor(RssInfo rss)
        {
            InitializeComponent();
            if (rss != null)
            {
                _rss = rss;
            }
        }

        //显示 RSS 信息
        private void ShowRssInfo()
        {
            if (_rss != null)
            {
                txtTitle.Text = _rss.Title;
                txtUrl.Text = _rss.Url;
                txtDescription.Text = _rss.Description;
            }
        }

        //点击 “确定”按钮
        private void btnOK_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string url = txtUrl.Text.Trim();
            string desciption = txtDescription.Text.Trim();
            int category = Convert.ToInt32(Tag);

            var newRss = new RssInfo() {Title = title, Description = desciption, Url = url, Category = category};


            if (_rss == null)
            {
                //添加新的 RSS
                RssDAL.Add(newRss);
            }
            else
            {
                //修改已有 RSS
                RssDAL.Update(_rss.ID, newRss);
            }
            OnDataChanged();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRssEditor_Load(object sender, EventArgs e)
        {
            ShowRssInfo();
        }

        protected virtual void OnDataChanged()
        {
            DataChanged?.Invoke(this);
        }
    }
}