namespace RenameFiles
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.linkLabel_mrblackdemon = new System.Windows.Forms.LinkLabel();
            this.label_version_info = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel_mrblackdemon
            // 
            this.linkLabel_mrblackdemon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel_mrblackdemon.Location = new System.Drawing.Point(12, 9);
            this.linkLabel_mrblackdemon.Name = "linkLabel_mrblackdemon";
            this.linkLabel_mrblackdemon.Size = new System.Drawing.Size(216, 44);
            this.linkLabel_mrblackdemon.TabIndex = 7;
            this.linkLabel_mrblackdemon.TabStop = true;
            this.linkLabel_mrblackdemon.Text = "Performed and designed by MrBlackDemon";
            this.linkLabel_mrblackdemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_mrblackdemon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_mrblackdemon_LinkClicked);
            // 
            // label_version_info
            // 
            this.label_version_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_version_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_version_info.Location = new System.Drawing.Point(12, 54);
            this.label_version_info.Name = "label_version_info";
            this.label_version_info.Size = new System.Drawing.Size(216, 26);
            this.label_version_info.TabIndex = 6;
            this.label_version_info.Text = "Version";
            this.label_version_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_close
            // 
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_close.Location = new System.Drawing.Point(89, 98);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(56, 23);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "OK";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 133);
            this.Controls.Add(this.linkLabel_mrblackdemon);
            this.Controls.Add(this.label_version_info);
            this.Controls.Add(this.button_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_mrblackdemon;
        private System.Windows.Forms.Label label_version_info;
        private System.Windows.Forms.Button button_close;
    }
}