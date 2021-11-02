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
            this.textBox_txtToRemove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_txtToReplace = new System.Windows.Forms.TextBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.checkBox_save_folderLocation = new System.Windows.Forms.CheckBox();
            this.button_removeID = new System.Windows.Forms.Button();
            this.groupBox_informazioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_informazioni
            // 
            this.groupBox_informazioni.Controls.Add(this.richTextBox_Log);
            this.groupBox_informazioni.Controls.Add(this.label_Progresso);
            this.groupBox_informazioni.Controls.Add(this.label_LogVisual);
            this.groupBox_informazioni.Controls.Add(this.label_ProgressoVisual);
            this.groupBox_informazioni.Controls.Add(this.progressBar_progresso);
            this.groupBox_informazioni.Location = new System.Drawing.Point(12, 152);
            this.groupBox_informazioni.Name = "groupBox_informazioni";
            this.groupBox_informazioni.Size = new System.Drawing.Size(840, 220);
            this.groupBox_informazioni.TabIndex = 3;
            this.groupBox_informazioni.TabStop = false;
            this.groupBox_informazioni.Text = "Informations";
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(6, 32);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(828, 137);
            this.richTextBox_Log.TabIndex = 13;
            this.richTextBox_Log.Text = "";
            // 
            // label_Progresso
            // 
            this.label_Progresso.AutoSize = true;
            this.label_Progresso.Location = new System.Drawing.Point(69, 172);
            this.label_Progresso.Name = "label_Progresso";
            this.label_Progresso.Size = new System.Drawing.Size(10, 13);
            this.label_Progresso.TabIndex = 12;
            this.label_Progresso.Text = ".";
            // 
            // label_LogVisual
            // 
            this.label_LogVisual.AutoSize = true;
            this.label_LogVisual.Location = new System.Drawing.Point(6, 16);
            this.label_LogVisual.Name = "label_LogVisual";
            this.label_LogVisual.Size = new System.Drawing.Size(28, 13);
            this.label_LogVisual.TabIndex = 9;
            this.label_LogVisual.Text = "Log:";
            // 
            // label_ProgressoVisual
            // 
            this.label_ProgressoVisual.AutoSize = true;
            this.label_ProgressoVisual.Location = new System.Drawing.Point(6, 172);
            this.label_ProgressoVisual.Name = "label_ProgressoVisual";
            this.label_ProgressoVisual.Size = new System.Drawing.Size(51, 13);
            this.label_ProgressoVisual.TabIndex = 11;
            this.label_ProgressoVisual.Text = "Progress:";
            // 
            // progressBar_progresso
            // 
            this.progressBar_progresso.Location = new System.Drawing.Point(6, 189);
            this.progressBar_progresso.Name = "progressBar_progresso";
            this.progressBar_progresso.Size = new System.Drawing.Size(828, 23);
            this.progressBar_progresso.TabIndex = 0;
            // 
            // button_Rename
            // 
            this.button_Rename.Location = new System.Drawing.Point(12, 5);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(135, 43);
            this.button_Rename.TabIndex = 4;
            this.button_Rename.Text = "Rename Files";
            this.button_Rename.UseVisualStyleBackColor = true;
            this.button_Rename.Click += new System.EventHandler(this.button_Rename_Click);
            // 
            // textBox_txtToRemove
            // 
            this.textBox_txtToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_txtToRemove.Location = new System.Drawing.Point(254, 5);
            this.textBox_txtToRemove.Multiline = true;
            this.textBox_txtToRemove.Name = "textBox_txtToRemove";
            this.textBox_txtToRemove.Size = new System.Drawing.Size(598, 43);
            this.textBox_txtToRemove.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text to Remove:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Replace With:";
            // 
            // textBox_txtToReplace
            // 
            this.textBox_txtToReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_txtToReplace.Location = new System.Drawing.Point(254, 54);
            this.textBox_txtToReplace.Multiline = true;
            this.textBox_txtToReplace.Name = "textBox_txtToReplace";
            this.textBox_txtToReplace.Size = new System.Drawing.Size(598, 43);
            this.textBox_txtToReplace.TabIndex = 7;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(717, 103);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(135, 43);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // checkBox_save_folderLocation
            // 
            this.checkBox_save_folderLocation.AutoSize = true;
            this.checkBox_save_folderLocation.Location = new System.Drawing.Point(12, 103);
            this.checkBox_save_folderLocation.Name = "checkBox_save_folderLocation";
            this.checkBox_save_folderLocation.Size = new System.Drawing.Size(127, 17);
            this.checkBox_save_folderLocation.TabIndex = 10;
            this.checkBox_save_folderLocation.Text = "Save Folder Location";
            this.checkBox_save_folderLocation.UseVisualStyleBackColor = true;
            // 
            // button_removeID
            // 
            this.button_removeID.Location = new System.Drawing.Point(12, 54);
            this.button_removeID.Name = "button_removeID";
            this.button_removeID.Size = new System.Drawing.Size(135, 43);
            this.button_removeID.TabIndex = 11;
            this.button_removeID.Text = "Remove [ID...]";
            this.button_removeID.UseVisualStyleBackColor = true;
            this.button_removeID.Click += new System.EventHandler(this.button_removeID_Click);
            // 
            // Form_RenameFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 384);
            this.Controls.Add(this.button_removeID);
            this.Controls.Add(this.checkBox_save_folderLocation);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_txtToReplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_txtToRemove);
            this.Controls.Add(this.button_Rename);
            this.Controls.Add(this.groupBox_informazioni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_RenameFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Files - v{0} - by MrBlackDemon";
            this.groupBox_informazioni.ResumeLayout(false);
            this.groupBox_informazioni.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_txtToRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_txtToReplace;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.CheckBox checkBox_save_folderLocation;
        private System.Windows.Forms.Button button_removeID;
    }
}

