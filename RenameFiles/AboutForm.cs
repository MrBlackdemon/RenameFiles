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
            this.label_version_info.Text = this.label_version_info.Text + " " + Assembly.GetEntryAssembly().GetName().Version.ToString(3);
            this.label_version_info.Top = (this.ClientSize.Height - this.label_version_info.Height) / 2;
            this.pictureBox_donate.Top = (this.ClientSize.Height - this.pictureBox_donate.Height) / 2;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void follow_Click(object sender, EventArgs e)
        {
            var tag = ((PictureBox)sender).Tag.ToString().ToLower();
            var url = "";
            switch (tag)
            {
                case "facebook":
                    url = "https://www.facebook.com/pages/Mrblackdemon/652670398170766";
                    break;
                case "odnoklassniki":
                    url = "http://ok.ru/group/52467647840387";
                    break;
                case "youtube":
                    url = "https://www.youtube.com/channel/UC64eV1HPVdYT1vELuafsREg";
                    break;
                case "website":
                    url = "http://mrblackdemon.altervista.org";
                    break;
                case "blog":
                    url = "http://mrblackdemon.altervista.org/blog/";
                    break;
                case "github":
                    url = "https://github.com/MrBlackdemon";
                    break;
                case "send_email":
                    url = "mailto:mrblackdemon01@gmail.com";
                    break;
                case "telegram":
                    url = "https://telegram.me/MrBlackDemon";
                    break;
                case "skype":
                    url = "skype:mrblackdemon?chat";
                    break;
            }

            if(!string.IsNullOrEmpty(url))
                Process.Start(url);
        }

        private void pictureBox_donate_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/paypalme/BlackDemonMr"); 
        }
    }
}
