using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFiles
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label_version_info.Text = label_version_info.Text + " " + Assembly.GetEntryAssembly().GetName().Version.ToString(3);
            linkLabel_mrblackdemon.Links.Add(0, linkLabel_mrblackdemon.Text.Length, "http://mrblackdemon.altervista.org");
        }

        private void linkLabel_mrblackdemon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
