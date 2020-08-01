using Shell32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FileUtilities
{
    public partial class SpecificMetadata : Form
    {
        public SpecificMetadata()
        {
            InitializeComponent();
        }

        #region Source

        private void AddSource(string[] srcs)
        {
            for (int i = 0; i < srcs.Length; i++)
            {
                if (File.Exists(srcs[i]))
                {
                    if (!SourceListBox.Items.Contains("File <" + Path.GetFileName(srcs[i]).ToLower() + ">  |  Path  |  " + srcs[i].ToLower()))
                        SourceListBox.Items.Add("File <" + Path.GetFileName(srcs[i]).ToLower() + ">  |  Path  |  " + srcs[i].ToLower());
                }
                else if (Directory.Exists(srcs[i]))
                    if (!SourceListBox.Items.Contains("Folder | " + srcs[i].ToLower()))
                        SourceListBox.Items.Add("Folder | " + srcs[i].ToLower());
            }
        }

        private void RemoveSelected()
        {
            ListBox.SelectedIndexCollection col1 = SourceListBox.SelectedIndices;
            for (int i = col1.Count - 1; i >= 0; i--)
                SourceListBox.Items.RemoveAt(col1[i]);
        }

        private void AddSourceDialog()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                AddSource(openFileDialog1.FileNames);
        }

        private void SourceRemoveButton_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }

        private void SourceAddButton_Click(object sender, EventArgs e)
        {
            AddSourceDialog();
        }

        private void SourceListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void SourceListBox_DragDrop(object sender, DragEventArgs e)
        {
            AddSource((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void OpenLocationButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection col2 = SourceListBox.SelectedItems;
#pragma warning disable CS0642 // Possible mistaken empty statement
            if (col2.Count > 5 && MessageBox.Show("You tried opening " + col2.Count + " locations, only the first 5 will be opened.\nThis is because opening too many folders at once can make your computer freeze.") == DialogResult.OK) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
            for (int i = 0; i < col2.Count && i < 5; i++)
            {
                //if (File.Exists())
                string[] srcarray = ((string)col2[i]).Split('|');
                if (srcarray.Length == 3 && File.Exists(srcarray[2]))
                    Process.Start("explorer.exe", @"/select, " + srcarray[2]);
                else if (srcarray.Length == 2 && Directory.Exists(srcarray[1]))
                    Process.Start("explorer.exe", srcarray[1]);
            }
        }

        private void SourceFileAddButton_Click(object sender, EventArgs e)
        {
            AddSourceDialog();
        }

        private void FolderTextBox_TextChanged(object sender, EventArgs e)
        {
            FolderTextBox.ForeColor = Color.Black;
            FolderTextBox.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
        }

        private void AddFolderFromTextBox()
        {
            bool flagnotfound = false;
            if (FolderTextBox.Text.Length == 2 && FolderTextBox.Text[1] == ':')
            {
                FolderTextBox.Text += "\\";
                FolderTextBox.SelectionStart = FolderTextBox.Text.Length;
            }

            if (FolderTextBox.Text.Length <= 1 || (FolderTextBox.Text.Length > 1 && FolderTextBox.Text[1] != ':'))
                flagnotfound = true;
            else
            {
                string src = Path.GetFullPath(FolderTextBox.Text).ToLower();
                if (src.LastIndexOf("\\") == src.Length - 1)
                    src = src.Substring(0, src.Length - 1);
                if (Directory.Exists(src))
                {
                    if (!SourceListBox.Items.Contains("Folder | " + src))
                        SourceListBox.Items.Add("Folder | " + src);
                }
                else
                    flagnotfound = true;
            }

            if (flagnotfound)
            {
                FolderTextBox.ForeColor = Color.DarkRed;
                FolderTextBox.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
            }
        }

        private void AddFolderButton_Click(object sender, EventArgs e)
        {
            AddFolderFromTextBox();
        }

        private void SourceListBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                //case Keys.Oemplus:
                case Keys.Oemplus: AddSourceDialog(); break;
                case Keys.OemMinus:
                case Keys.Delete:
                case Keys.Back: RemoveSelected(); break;
            }
            if (e.KeyCode == Keys.A && e.Control)
                for (int i = 0; i < SourceListBox.Items.Count; i++)
                    SourceListBox.SetSelected(i, true);
        }

        private void FolderTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Oemplus)
            {
                AddFolderFromTextBox();
            }
        }





        #endregion  Source

        #region Form

        private void SpecificMetadata_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.FocusMenu();
        }

        #endregion Form

        private List<FileInfo> GetAllFilesFromSources()
        {
            string[] rowtext = { "" };
            List<FileInfo> srcs = new List<FileInfo>();
            for (int i = 0; i < SourceListBox.Items.Count; i++)
            {
                rowtext = ((string)SourceListBox.Items[i]).Split('|');
                if (rowtext.Length == 2 && Directory.Exists(rowtext[1]))
                    srcs.AddRange(new DirectoryInfo(rowtext[1]).GetFiles());
                else if (rowtext.Length == 3 && File.Exists(rowtext[2]))
                    srcs.Add(new FileInfo(rowtext[2]));
            }

            return srcs;
        }

        private void WriteMetadataButton_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = false;

            List<FileInfo> srcs = GetAllFilesFromSources();

            DateTime createdate = CreateDatePicker.Value;
            DateTime createtime = CreateTimePicker.Value;
            createdate = createdate.AddHours(-createdate.Hour + createtime.Hour);
            createdate = createdate.AddMinutes(-createdate.Minute + createtime.Minute);
            createdate = createdate.AddSeconds(-createdate.Second + createtime.Second);

            DateTime modifydate = ModifyDatePicker.Value;
            DateTime modifytime = ModifyTimePicker.Value;
            modifydate = modifydate.AddHours(-modifydate.Hour + modifytime.Hour);
            modifydate = modifydate.AddMinutes(-modifydate.Minute + modifytime.Minute);
            modifydate = modifydate.AddSeconds(-modifydate.Second + modifytime.Second);

            string createdatestr = "";
            string modifydatestr = "";
            string commentstr = "-comment=\""+CommentTextBox.Text+"\"";
            if (!CommentCheckBox.Checked)
                commentstr = "";

            if (CreateDatePicker.Checked)
                createdatestr = string.Format("-filecreatedate=\"{0:D4}:{1:D2}:{2:D2} {3:D2}:{4:D2}:{5:D2}\" -createdate=\"{0:D4}:{1:D2}:{2:D2} {3:D2}:{4:D2}:{5:D2}\" -DateTimeOriginal=\"{0:D4}:{1:D2}:{2:D2} {3:D2}:{4:D2}:{5:D2}\" "
                    , createdate.Year, createdate.Month, createdate.Day, createdate.Hour, createdate.Minute, createdate.Second);
            if (ModifyDatePicker.Checked)
                modifydatestr = string.Format("-filemodifydate=\"{0:D4}:{1:D2}:{2:D2} {3:D2}:{4:D2}:{5:D2}\" -modifydate=\"{0:D4}:{1:D2}:{2:D2} {3:D2}:{4:D2}:{5:D2}\""
                    , modifydate.Year, modifydate.Month, modifydate.Day, modifydate.Hour, modifydate.Minute, modifydate.Second);
            
            Shell32.Shell shell = new Shell32.Shell();
            
            for (int i = 0; i < srcs.Count; i++)
            {
                srcs[i].CreationTime = createdate;
                srcs[i].LastWriteTime = modifydate;
                shell.ShellExecute("exiftool", String.Format("-overwrite_original {0} {1} {2} \"{3}\"", createdatestr, modifydatestr,commentstr, srcs[i].FullName));
                while (Process.GetProcessesByName("exiftool").Length > 4)
                {
                    Thread.Sleep(500);
                    Application.DoEvents();
                }
            }

            panel1.Enabled = true;
            panel2.Enabled = true;
        }
    }
}
