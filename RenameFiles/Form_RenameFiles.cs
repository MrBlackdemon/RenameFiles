using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace RenameFiles
{
    public partial class Form_RenameFiles : Form
    {
        private string _lastFolderUsed { get; set; }
        private string _removeFromFile { get { return this.textBox_txtToRemove.Text; } }
        private string _replaceWith { get { return !string.IsNullOrEmpty(this.textBox_txtToReplace.Text) ? this.textBox_txtToReplace.Text : ""; } }

        public Form_RenameFiles()
        {
            InitializeComponent();
            this.richTextBox_Log.AppendText(string.Format("{0}: START LOGGING", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
            this.richTextBox_Log.Refresh();
            this.Text = string.Format(this.Text, Assembly.GetEntryAssembly().GetName().Version.ToString());
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            this._lastFolderUsed = string.Empty;
            this.richTextBox_Log.Text = string.Empty;
            this.richTextBox_Log.AppendText(string.Format("{0}: START LOGGING", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
            this.textBox_txtToRemove.Text = string.Empty;
            this.textBox_txtToReplace.Text = string.Empty;
            this.richTextBox_Log.Refresh();
            this.textBox_txtToRemove.Refresh();
            this.textBox_txtToReplace.Refresh();
        }

        private void button_Rename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this._removeFromFile))
            {
                this.ShowMessageBox("Set the TEXT to remove/replace from File.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_txtToRemove.Focus();
                return;
            }

            var directory = "";
            try
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.InitialDirectory = !string.IsNullOrEmpty(this._lastFolderUsed) ? this._lastFolderUsed : KnownFolders.Downloads.Path;

                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    string folderName = new DirectoryInfo(dialog.FileName).Name;
                    if (string.IsNullOrEmpty(dialog.FileName))
                    {
                        throw new Exception("Please select a valid folder.");
                    }

                    directory = dialog.FileName;
                    this._lastFolderUsed = this.checkBox_save_folderLocation.Checked ? directory : "";
                    this.AggiornaLog("Selected Folder: " + directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(directory))
            {
                this.BlockEnableFormElements(true);

                Task.Factory.StartNew(() =>
                {
                    var renamed = 0;
                    try
                    {
                        this.AggiornaLog("Start searching Files");
                        DirectoryInfo d = new DirectoryInfo(directory);
                        FileInfo[] infos = d.GetFiles(); 
                        var i = 1;
                        var totFiles = infos.Count();
                        this.SetMaximumProgressBar(totFiles);
                        this.AggiornaLog("Found: " + totFiles + " Files");
                        foreach (FileInfo f in infos)
                        {
                            this.IncrementProgressbar();
                            this.AggiornaProgresso(string.Format("{0}/{1}", i, totFiles));
                            this.AggiornaLog("File Processing: " + f.Name);

                            var path = f.DirectoryName;
                            var fName = Path.GetFileNameWithoutExtension(f.FullName);
                            var ext = f.Extension;

                            if (!fName.Contains(this._removeFromFile))
                            {
                                i++;
                                continue;
                            }

                            var fNameReplaced = fName.Replace(this._removeFromFile, this._replaceWith).Trim();
                            //var idToRemove = Regex.Match(fNameReplaced, @"\[ID(.*)\]").Value;
                            //if (!string.IsNullOrEmpty(idToRemove))
                            //    fNameReplaced = fNameReplaced.Replace(idToRemove, "");

                            var newFileName = string.Format("{0}{1}", fNameReplaced, ext);
                            var newPath = Path.Combine(path, newFileName);

                            if (File.Exists(newPath))
                            {
                                if(!Directory.Exists(Path.Combine(path, "Exists")))
                                    Directory.CreateDirectory(Path.Combine(path, "Exists"));

                                var newPath1 = Path.Combine(path, "Exists", newFileName);
                                File.Move(f.FullName, newPath1);
                            }
                            else
                            {
                                File.Move(f.FullName, newPath);
                            }

                            renamed++;
                        }
                    }
                    catch (Exception ex)
                    {
                        this.BlockEnableFormElements(false);
                        this.AggiornaLog("An error has occurred: " + ex.Message);
                    }

                    this.AggiornaLog("File renaming COMPLETED.");
                    this.AggiornaLog("Renamed with success: " + renamed + " Files");
                    this.ShowMessageBox("File renaming COMPLETED. \n\nRenamed with success: " + renamed + " Files.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BlockEnableFormElements(false);
                    this.ResetProgressBar();
                    this.AggiornaProgresso(".");
                });
            }
        }

        private void button_removeID_Click(object sender, EventArgs e)
        {
            var directory = "";
            using (var fbd = new FolderBrowserDialog())
            {
                if (this.checkBox_save_folderLocation.Checked)
                    if (!string.IsNullOrEmpty(this._lastFolderUsed))
                        fbd.SelectedPath = this._lastFolderUsed;

                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    directory = fbd.SelectedPath;
                    this._lastFolderUsed = directory;
                    this.AggiornaLog("Selected Folder: " + directory);
                }
            }

            if (!string.IsNullOrEmpty(directory))
            {
                this.BlockEnableFormElements(true);

                Task.Factory.StartNew(() =>
                {
                    var renamed = 0;
                    try
                    {
                        this.AggiornaLog("Start searching Files");
                        DirectoryInfo d = new DirectoryInfo(directory);
                        FileInfo[] infos = d.GetFiles();
                        var i = 1;
                        var totFiles = infos.Count();
                        this.SetMaximumProgressBar(totFiles);
                        this.AggiornaLog("Found: " + totFiles + " Files");
                        foreach (FileInfo f in infos)
                        {
                            this.IncrementProgressbar();
                            this.AggiornaProgresso(string.Format("{0}/{1}", i, totFiles));
                            this.AggiornaLog("File Processing: " + f.Name);

                            var path = f.DirectoryName;
                            var fName = Path.GetFileNameWithoutExtension(f.FullName);
                            var ext = f.Extension;

                            var idToRemove = Regex.Match(fName, @"\[ID(.*)\]").Value;
                            if (!string.IsNullOrEmpty(idToRemove))
                            {
                                fName = fName.Replace(idToRemove, "").Trim();
                                var newFileName = string.Format("{0}{1}", fName, ext);
                                var newPath = Path.Combine(path, newFileName);

                                if (File.Exists(newPath))
                                {
                                    if (!Directory.Exists(Path.Combine(path, "Exists")))
                                        Directory.CreateDirectory(Path.Combine(path, "Exists"));

                                    var newPath1 = Path.Combine(path, "Exists", newFileName);
                                    File.Move(f.FullName, newPath1);
                                }
                                else
                                {
                                    File.Move(f.FullName, newPath);
                                }

                                renamed++;
                            }
                            else
                            {
                                i++;
                                continue;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        this.BlockEnableFormElements(false);
                        this.AggiornaLog("An error has occurred: " + ex.Message);
                    }

                    this.AggiornaLog("File renaming COMPLETED.");
                    this.AggiornaLog("Renamed with success: " + renamed + " Files");
                    this.ShowMessageBox("File renaming COMPLETED. \n\nRenamed with success: " + renamed + " Files.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BlockEnableFormElements(false);
                    this.ResetProgressBar();
                    this.AggiornaProgresso(".");
                });
            }
        }

        #region DELEGATES 

        public void AggiornaLog(string messaggio)
        {
            if (this.richTextBox_Log.InvokeRequired)
            {
                this.richTextBox_Log.Invoke(new AggiornaLogCallBack(this.AggiornaLog), new object[] { messaggio });
                return;
            }

            this.richTextBox_Log.AppendText(Environment.NewLine + string.Format("{0}: {1}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), messaggio));
            this.richTextBox_Log.Refresh();
            this.richTextBox_Log.SelectionStart = this.richTextBox_Log.Text.Length;
            this.richTextBox_Log.ScrollToCaret();
        }

        public void AggiornaProgresso(string messaggio)
        {
            if (this.label_Progresso.InvokeRequired)
            {
                this.label_Progresso.Invoke(new AggiornaProgressoCallBack(this.AggiornaProgresso), new object[] { messaggio });
                return;
            }

            this.label_Progresso.Text = messaggio;
            this.label_Progresso.Refresh();
        }

        public void ShowMessageBox(string text, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ShowMessageBoxCallBack(this.ShowMessageBox), new object[] { text, title, buttons, icon });
                return;
            }

            MessageBox.Show(text, title, buttons, icon);
            this.Refresh();
        }

        public void IncrementProgressbar()
        {
            if (this.progressBar_progresso.InvokeRequired)
            {
                this.progressBar_progresso.Invoke(new IncrementProgressbarCallBack(this.IncrementProgressbar));
                return;
            }

            this.progressBar_progresso.Value += 1;
            this.progressBar_progresso.Refresh();
        }

        public void SetMaximumProgressBar(int maximum)
        {
            if (this.progressBar_progresso.InvokeRequired)
            {
                this.progressBar_progresso.Invoke(new SetMaximumProgressBarCallBack(this.SetMaximumProgressBar), new object[] { maximum });
                return;
            }

            this.progressBar_progresso.Maximum = maximum;
            this.progressBar_progresso.Refresh();
        }

        public void ResetProgressBar()
        {
            if (this.progressBar_progresso.InvokeRequired)
            {
                this.progressBar_progresso.Invoke(new ResetProgressBarCallBack(this.ResetProgressBar));
                return;
            }

            this.progressBar_progresso.Maximum = 100;
            this.progressBar_progresso.Value = 0;
            this.progressBar_progresso.Refresh();
        }

        public void BlockEnableFormElements(bool block = true)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new BlockEnableFormElements_D(this.BlockEnableFormElements), new object[] { block });
                return;
            }

            this.button_Reset.Enabled = !block;
            this.button_Rename.Enabled = !block;
            this.textBox_txtToRemove.Enabled = !block;
            this.Refresh();
        }

        private delegate void ResetProgressBarCallBack();
        private delegate void BlockEnableFormElements_D(bool block);
        private delegate void IncrementProgressbarCallBack();
        private delegate void AggiornaLogCallBack(string messaggio);
        private delegate void SetMaximumProgressBarCallBack(int maximum);
        private delegate void AggiornaProgressoCallBack(string messaggio);
        private delegate void ShowMessageBoxCallBack(string text, string title, MessageBoxButtons buttons, MessageBoxIcon icon);


        #endregion
    }
}
