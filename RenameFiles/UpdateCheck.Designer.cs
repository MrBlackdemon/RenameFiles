namespace RenameFiles
{
    partial class UpdateCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCheck));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_curr_version = new System.Windows.Forms.Label();
            this.label_new_version = new System.Windows.Forms.Label();
            this.groupBox_doanload = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_download = new System.Windows.Forms.Button();
            this.label_down_progress = new System.Windows.Forms.Label();
            this.progressBar_download = new System.Windows.Forms.ProgressBar();
            this.radioButton_portable = new System.Windows.Forms.RadioButton();
            this.radioButton_setup = new System.Windows.Forms.RadioButton();
            this.groupBox_doanload.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Version:";
            // 
            // label_curr_version
            // 
            this.label_curr_version.AutoSize = true;
            this.label_curr_version.Location = new System.Drawing.Point(91, 11);
            this.label_curr_version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_curr_version.Name = "label_curr_version";
            this.label_curr_version.Size = new System.Drawing.Size(10, 13);
            this.label_curr_version.TabIndex = 2;
            this.label_curr_version.Text = ".";
            // 
            // label_new_version
            // 
            this.label_new_version.AutoSize = true;
            this.label_new_version.Location = new System.Drawing.Point(91, 34);
            this.label_new_version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_new_version.Name = "label_new_version";
            this.label_new_version.Size = new System.Drawing.Size(10, 13);
            this.label_new_version.TabIndex = 3;
            this.label_new_version.Text = ".";
            // 
            // groupBox_doanload
            // 
            this.groupBox_doanload.Controls.Add(this.button_close);
            this.groupBox_doanload.Controls.Add(this.button_download);
            this.groupBox_doanload.Controls.Add(this.label_down_progress);
            this.groupBox_doanload.Controls.Add(this.progressBar_download);
            this.groupBox_doanload.Controls.Add(this.radioButton_portable);
            this.groupBox_doanload.Controls.Add(this.radioButton_setup);
            this.groupBox_doanload.Location = new System.Drawing.Point(12, 57);
            this.groupBox_doanload.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_doanload.Name = "groupBox_doanload";
            this.groupBox_doanload.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_doanload.Size = new System.Drawing.Size(375, 163);
            this.groupBox_doanload.TabIndex = 4;
            this.groupBox_doanload.TabStop = false;
            this.groupBox_doanload.Text = "DOWNLOAD";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(4, 127);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(365, 29);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(4, 92);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(365, 29);
            this.button_download.TabIndex = 6;
            this.button_download.Text = "DOWNLOAD";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // label_down_progress
            // 
            this.label_down_progress.AutoSize = true;
            this.label_down_progress.Location = new System.Drawing.Point(4, 42);
            this.label_down_progress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_down_progress.Name = "label_down_progress";
            this.label_down_progress.Size = new System.Drawing.Size(10, 13);
            this.label_down_progress.TabIndex = 5;
            this.label_down_progress.Text = ".";
            // 
            // progressBar_download
            // 
            this.progressBar_download.Location = new System.Drawing.Point(5, 63);
            this.progressBar_download.Name = "progressBar_download";
            this.progressBar_download.Size = new System.Drawing.Size(365, 23);
            this.progressBar_download.TabIndex = 2;
            // 
            // radioButton_portable
            // 
            this.radioButton_portable.AutoSize = true;
            this.radioButton_portable.Location = new System.Drawing.Point(85, 17);
            this.radioButton_portable.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_portable.Name = "radioButton_portable";
            this.radioButton_portable.Size = new System.Drawing.Size(82, 17);
            this.radioButton_portable.TabIndex = 1;
            this.radioButton_portable.Text = "PORTABLE";
            this.radioButton_portable.UseVisualStyleBackColor = true;
            // 
            // radioButton_setup
            // 
            this.radioButton_setup.AutoSize = true;
            this.radioButton_setup.Checked = true;
            this.radioButton_setup.Location = new System.Drawing.Point(4, 17);
            this.radioButton_setup.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_setup.Name = "radioButton_setup";
            this.radioButton_setup.Size = new System.Drawing.Size(61, 17);
            this.radioButton_setup.TabIndex = 0;
            this.radioButton_setup.TabStop = true;
            this.radioButton_setup.Text = "SETUP";
            this.radioButton_setup.UseVisualStyleBackColor = true;
            // 
            // UpdateCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 231);
            this.Controls.Add(this.groupBox_doanload);
            this.Controls.Add(this.label_new_version);
            this.Controls.Add(this.label_curr_version);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Files - New Version Available";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateCheck_FormClosing);
            this.groupBox_doanload.ResumeLayout(false);
            this.groupBox_doanload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_curr_version;
        private System.Windows.Forms.Label label_new_version;
        private System.Windows.Forms.GroupBox groupBox_doanload;
        private System.Windows.Forms.RadioButton radioButton_portable;
        private System.Windows.Forms.RadioButton radioButton_setup;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.Label label_down_progress;
        private System.Windows.Forms.ProgressBar progressBar_download;
        private System.Windows.Forms.Button button_close;
    }
}