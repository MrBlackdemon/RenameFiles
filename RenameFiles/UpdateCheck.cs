using System.Windows.Forms;

namespace RenameFiles
{
    using System;
    using System.IO;
    using System.Net;
    using System.Threading;
    using RenameFiles.Classes;
    using System.ComponentModel;
    using Microsoft.WindowsAPICodePack.Shell;

    public partial class UpdateCheck : Form
    {
        public string SetCurrentVersion { set { this.label_curr_version.Text = value; } }
        public string SetNewVersion { set { this.label_new_version.Text = value; } }
        
        private readonly string _doanload_base_path = "http://mrblackdemon.altervista.org/Programs/RenameFiles/Download/";
        private readonly string _portable_name = "Rename_Files_by_MrBlackDemon_PORTABLE.zip";
        private readonly string _setup_name = "Rename_Files_by_MrBlackDemon_SETUP.zip";
        private string _download_folder = KnownFolders.Downloads.Path;
        private bool _is_download_setup { get; set; }
        private string _download_name { get; set; }
        private bool _doanload_in_progress { get; set; }

        public UpdateCheck()
        {
            InitializeComponent();
        }

        private void UpdateCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._doanload_in_progress)
            {
                MessageBox.Show("Download in progress.\n\nPlease wait until it finish.", "Download in progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            this._is_download_setup = this.radioButton_setup.Checked;
            this._download_name = this._is_download_setup ? this._setup_name : this._portable_name;

            this.radioButton_setup.Enabled = false;
            this.radioButton_portable.Enabled = false;
            this.button_close.Enabled = false;
            this.button_download.Enabled = false;
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(this._doanload_base_path + this._download_name), Path.Combine(this._download_folder, this._download_name));
            });
            thread.Start();
        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker) delegate {
                
                this._doanload_in_progress = true;

                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                label_down_progress.Text = string.Format("Downloaded {0} MB of {1} MB", Functions.SizeSuffix(e.BytesReceived, 2), Functions.SizeSuffix(e.TotalBytesToReceive, 2));
                progressBar_download.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker) delegate {
                
                this._doanload_in_progress = false;
                
                label_down_progress.Text = "Download Completed";
                this.radioButton_setup.Enabled = true;
                this.radioButton_portable.Enabled = true;
                this.button_close.Enabled = true;
                this.button_download.Enabled = true;

                MessageBox.Show("Location:\n\n" + Path.Combine(this._download_folder, this._download_name), "Doanload Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                System.Diagnostics.Process.Start(this._download_folder);
            });
        }
    }
}
