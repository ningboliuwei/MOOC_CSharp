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
        private RssInfo _rss;

        public frmCategoryEditor()
        {
            InitializeComponent();
        }

        public frmCategoryEditor(RssInfo rss)
        {
            InitializeComponent();
            if (rss != null)
            {
                _rss = rss;
            }
        }

        private void ShowRssInfo()
        {
            if (_rss != null)
            {
                txtTitle.Text = _rss.Title;
                txtUrl.Text = _rss.Url;
                txtDescription.Text = _rss.Description;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string url = txtUrl.Text.Trim();
            string desciption = txtDescription.Text.Trim();
            int category = Convert.ToInt32(Tag);

            RssDAL.Add(new RssInfo() {Title = title, Description = desciption, Url = url, Category = category});
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
    }
}