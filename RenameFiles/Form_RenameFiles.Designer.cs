namespace RenameFiles
{
    partial class Form_RenameFiles
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RenameFiles));
            this.groupBox_informazioni = new System.Windows.Forms.GroupBox();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.label_Progresso = new System.Windows.Forms.Label();
            this.label_LogVisual = new System.Windows.Forms.Label();
            this.label_ProgressoVisual = new System.Windows.Forms.Label();
            this.progressBar_progresso = new System.Windows.Forms.ProgressBar();
            this.button_Rename = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_txtToReplace = new System.Windows.Forms.TextBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.checkBox_save_folderLocation = new System.Windows.Forms.CheckBox();
            this.button_removeID = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_instructions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_check_update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_txtToRemove = new System.Windows.Forms.TextBox();
            this.checkBox_replace_with = new System.Windows.Forms.CheckBox();
            this.checkBox_use_regex = new System.Windows.Forms.CheckBox();
            this.groupBox_informazioni.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_informazioni
            // 
            this.groupBox_informazioni.Controls.Add(this.richTextBox_Log);
            this.groupBox_informazioni.Controls.Add(this.label_Progresso);
            this.groupBox_informazioni.Controls.Add(this.label_LogVisual);
            this.groupBox_informazioni.Controls.Add(this.label_ProgressoVisual);
            this.groupBox_informazioni.Controls.Add(this.progressBar_progresso);
            this.groupBox_informazioni.Location = new System.Drawing.Point(12, 140);
            this.groupBox_informazioni.Name = "groupBox_informazioni";
            this.groupBox_informazioni.Size = new System.Drawing.Size(840, 220);
            this.groupBox_informazioni.TabIndex = 9;
            this.groupBox_informazioni.TabStop = false;
            this.groupBox_informazioni.Text = "Informations";
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(6, 32);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(828, 137);
            this.richTextBox_Log.TabIndex = 10;
            this.richTextBox_Log.Text = "";
            // 
            // label_Progresso
            // 
            this.label_Progresso.AutoSize = true;
            this.label_Progresso.Location = new System.Drawing.Point(69, 172);
            this.label_Progresso.Name = "label_Progresso";
            this.label_Progresso.Size = new System.Drawing.Size(10, 13);
            this.label_Progresso.TabIndex = 11;
            this.label_Progresso.Text = ".";
            // 
            // label_LogVisual
            // 
            this.label_LogVisual.AutoSize = true;
            this.label_LogVisual.Location = new System.Drawing.Point(6, 16);
            this.label_LogVisual.Name = "label_LogVisual";
            this.label_LogVisual.Size = new System.Drawing.Size(28, 13);
            this.label_LogVisual.TabIndex = 12;
            this.label_LogVisual.Text = "Log:";
            // 
            // label_ProgressoVisual
            // 
            this.label_ProgressoVisual.AutoSize = true;
            this.label_ProgressoVisual.Location = new System.Drawing.Point(6, 172);
            this.label_ProgressoVisual.Name = "label_ProgressoVisual";
            this.label_ProgressoVisual.Size = new System.Drawing.Size(51, 13);
            this.label_ProgressoVisual.TabIndex = 13;
            this.label_ProgressoVisual.Text = "Progress:";
            // 
            // progressBar_progresso
            // 
            this.progressBar_progresso.Location = new System.Drawing.Point(6, 189);
            this.progressBar_progresso.Name = "progressBar_progresso";
            this.progressBar_progresso.Size = new System.Drawing.Size(828, 23);
            this.progressBar_progresso.TabIndex = 14;
            // 
            // button_Rename
            // 
            this.button_Rename.Location = new System.Drawing.Point(717, 91);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(135, 43);
            this.button_Rename.TabIndex = 6;
            this.button_Rename.Text = "Rename Files";
            this.button_Rename.UseVisualStyleBackColor = true;
            this.button_Rename.Click += new System.EventHandler(this.button_Rename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Text to Remove:";
            // 
            // textBox_txtToReplace
            // 
            this.textBox_txtToReplace.Enabled = false;
            this.textBox_txtToReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_txtToReplace.Location = new System.Drawing.Point(108, 60);
            this.textBox_txtToReplace.Multiline = true;
            this.textBox_txtToReplace.Name = "textBox_txtToReplace";
            this.textBox_txtToReplace.Size = new System.Drawing.Size(744, 25);
            this.textBox_txtToReplace.TabIndex = 3;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(435, 91);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(135, 43);
            this.button_Reset.TabIndex = 8;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // checkBox_save_folderLocation
            // 
            this.checkBox_save_folderLocation.AutoSize = true;
            this.checkBox_save_folderLocation.Location = new System.Drawing.Point(8, 117);
            this.checkBox_save_folderLocation.Name = "checkBox_save_folderLocation";
            this.checkBox_save_folderLocation.Size = new System.Drawing.Size(127, 17);
            this.checkBox_save_folderLocation.TabIndex = 5;
            this.checkBox_save_folderLocation.Text = "Save Folder Location";
            this.checkBox_save_folderLocation.UseVisualStyleBackColor = true;
            // 
            // button_removeID
            // 
            this.button_removeID.Location = new System.Drawing.Point(576, 91);
            this.button_removeID.Name = "button_removeID";
            this.button_removeID.Size = new System.Drawing.Size(135, 43);
            this.button_removeID.TabIndex = 7;
            this.button_removeID.Text = "Remove [ID...]";
            this.button_removeID.UseVisualStyleBackColor = true;
            this.button_removeID.Click += new System.EventHandler(this.button_removeID_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::RenameFiles.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_instructions,
            this.toolStripSeparator1,
            this.toolStripMenuItem_check_update,
            this.toolStripMenuItem_about});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem_instructions
            // 
            this.toolStripMenuItem_instructions.Image = global::RenameFiles.Properties.Resources.instruction;
            this.toolStripMenuItem_instructions.Name = "toolStripMenuItem_instructions";
            this.toolStripMenuItem_instructions.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem_instructions.Text = "Instructions";
            this.toolStripMenuItem_instructions.Click += new System.EventHandler(this.toolStripMenuItem_instructions_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripMenuItem_check_update
            // 
            this.toolStripMenuItem_check_update.Image = global::RenameFiles.Properties.Resources.update;
            this.toolStripMenuItem_check_update.Name = "toolStripMenuItem_check_update";
            this.toolStripMenuItem_check_update.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem_check_update.Text = "Check Update";
            this.toolStripMenuItem_check_update.Click += new System.EventHandler(this.toolStripMenuItem_check_update_Click);
            // 
            // toolStripMenuItem_about
            // 
            this.toolStripMenuItem_about.Image = global::RenameFiles.Properties.Resources.info;
            this.toolStripMenuItem_about.Name = "toolStripMenuItem_about";
            this.toolStripMenuItem_about.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem_about.Text = "About";
            this.toolStripMenuItem_about.Click += new System.EventHandler(this.toolStripMenuItem_about_Click);
            // 
            // textBox_txtToRemove
            // 
            this.textBox_txtToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_txtToRemove.Location = new System.Drawing.Point(108, 27);
            this.textBox_txtToRemove.Multiline = true;
            this.textBox_txtToRemove.Name = "textBox_txtToRemove";
            this.textBox_txtToRemove.Size = new System.Drawing.Size(744, 25);
            this.textBox_txtToRemove.TabIndex = 1;
            // 
            // checkBox_replace_with
            // 
            this.checkBox_replace_with.AutoSize = true;
            this.checkBox_replace_with.Location = new System.Drawing.Point(8, 66);
            this.checkBox_replace_with.Name = "checkBox_replace_with";
            this.checkBox_replace_with.Size = new System.Drawing.Size(94, 17);
            this.checkBox_replace_with.TabIndex = 2;
            this.checkBox_replace_with.Text = "Replace With:";
            this.checkBox_replace_with.UseVisualStyleBackColor = true;
            this.checkBox_replace_with.CheckedChanged += new System.EventHandler(this.checkBox_replace_with_CheckedChanged);
            // 
            // checkBox_use_regex
            // 
            this.checkBox_use_regex.AutoSize = true;
            this.checkBox_use_regex.Location = new System.Drawing.Point(8, 91);
            this.checkBox_use_regex.Name = "checkBox_use_regex";
            this.checkBox_use_regex.Size = new System.Drawing.Size(84, 17);
            this.checkBox_use_regex.TabIndex = 4;
            this.checkBox_use_regex.Text = "Use \'RegEx\'";
            this.checkBox_use_regex.UseVisualStyleBackColor = true;
            // 
            // Form_RenameFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 365);
            this.Controls.Add(this.checkBox_use_regex);
            this.Controls.Add(this.checkBox_replace_with);
            this.Controls.Add(this.textBox_txtToRemove);
            this.Controls.Add(this.button_removeID);
            this.Controls.Add(this.checkBox_save_folderLocation);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.textBox_txtToReplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Rename);
            this.Controls.Add(this.groupBox_informazioni);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_RenameFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Files - v{0} - by MrBlackDemon";
            this.Load += new System.EventHandler(this.Form_RenameFiles_Load);
            this.groupBox_informazioni.ResumeLayout(false);
            this.groupBox_informazioni.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_informazioni;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.Label label_Progresso;
        private System.Windows.Forms.Label label_LogVisual;
        private System.Windows.Forms.Label label_ProgressoVisual;
        private System.Windows.Forms.ProgressBar progressBar_progresso;
        private System.Windows.Forms.Button button_Rename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_txtToReplace;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.CheckBox checkBox_save_folderLocation;
        private System.Windows.Forms.Button button_removeID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_txtToRemove;
        private System.Windows.Forms.CheckBox checkBox_replace_with;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_instructions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_check_update;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_about;
        private System.Windows.Forms.CheckBox checkBox_use_regex;
    }
}

