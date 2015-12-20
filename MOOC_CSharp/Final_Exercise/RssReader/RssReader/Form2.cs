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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string desciption = textBox2.Text;
            string url = textBox3.Text;
            int category = Convert.ToInt32(Tag);


            RssDAL.Add(new RssInfo() {Title = title, Description = desciption, Url = url, Category = category});
            Close();
        }
    }
}