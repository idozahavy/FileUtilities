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
    public partial class NameFormulaToMetadata : Form
    {
        public NameFormulaToMetadata()
        {
            InitializeComponent();
            VarYearLength.SelectedIndex = 0;
            VarTimeLength.SelectedIndex = 0;
            VarMonthLength.SelectedIndex = 0;
            VarDayLength.SelectedIndex = 0;
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
            for (int i = col1.Count-1; i >= 0; i--)
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
            for (int i = 0; i < col2.Count && i<5; i++)
            {
                //if (File.Exists())
                string[] srcarray = ((string)col2[i]).Split('|');
                if (srcarray.Length == 3 && File.Exists(srcarray[2]))
                    Process.Start("explorer.exe", @"/select, "+srcarray[2]);
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

        #endregion

        #region Form

        private void NameFormulaToMetadata_FormClosed(object sender, FormClosedEventArgs e)
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

        private void UnlockVarsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool boli = UnlockVarsCheckBox.Checked;
            VarYearName.Enabled = boli;
            VarYearLength.Enabled = boli;
            VarMonthName.Enabled = boli;
            VarDayName.Enabled = boli;
            VarTimeName.Enabled = boli;
            VarTimeLength.Enabled = boli;
            VarYearPrefix.Enabled = boli;
        }

        private void StartFormulaButton_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = false;

            List<FileInfo> srcs = GetAllFilesFromSources();
            string name = "";

            int yearlength = int.Parse(VarYearLength.Text);
            int monthlength = 2;
            int daylength = 2;
            int timelength = int.Parse(VarTimeLength.Text);

            int yearvarlength = VarYearName.Text.Length;
            int monthvarlength = VarMonthName.Text.Length;
            int dayvarlength = VarDayName.Text.Length;
            int timevarlength = VarTimeName.Text.Length;

            string formula = FormulaTextBox.Text;

            string formulaerrors = "";

            int yearvars = formula.Length - formula.Replace(VarYearName.Text, VarYearName.Text.Substring(0, VarYearName.Text.Length - 1)).Length;
            if (yearvars > 1)
                formulaerrors += "Formula has too many Year variables\n";
            else if (yearvars == 0)
                formulaerrors += "No Year variables were found\n";

            int monthvars = formula.Length - formula.Replace(VarMonthName.Text, VarMonthName.Text.Substring(0, VarMonthName.Text.Length - 1)).Length;
            if (monthvars > 1)
                formulaerrors += "Formula has too many Month variables\n";
            else if (monthvars == 0)
                formulaerrors += "No Month variables were found\n";

            int dayvars = formula.Length - formula.Replace(VarDayName.Text, VarDayName.Text.Substring(0, VarDayName.Text.Length - 1)).Length;
            if (dayvars > 1)
                formulaerrors += "Formula has too many Day variables\n";
            else if (dayvars == 0)
                formulaerrors += "No Day variables were found\n";

            int timevars = formula.Length - formula.Replace(VarTimeName.Text, VarTimeName.Text.Substring(0, VarTimeName.Text.Length - 1)).Length;
            if (timevars > 1)
                formulaerrors += "Formula has too many Time variables\n";
            else if (timevars == 0)
                formulaerrors += "No Time variables were found\n";

            if (formulaerrors != "")
            {
                MessageBox.Show(formulaerrors);
                panel1.Enabled = true;
                panel2.Enabled = true;
                return;
            }

            int yearplace = formula.IndexOf(VarYearName.Text);
            int monthplace = formula.IndexOf(VarMonthName.Text);
            int dayplace = formula.IndexOf(VarDayName.Text);
            int timeplace = formula.IndexOf(VarTimeName.Text);

            int yearplacefix = yearplace + (yearplace > monthplace ? monthlength - monthvarlength : 0) + (yearplace > dayplace ? daylength - dayvarlength : 0) + (yearplace > timeplace ? timelength - timevarlength : 0);
            int monthplacefix = monthplace + (monthplace > yearplace ? yearlength - yearvarlength : 0) + (monthplace > dayplace ? daylength - dayvarlength : 0) + (monthplace > timeplace ? timelength - timevarlength : 0);
            int dayplacefix = dayplace + (dayplace > monthplace ? monthlength - monthvarlength : 0) + (dayplace > yearplace ? yearlength - yearvarlength : 0) + (dayplace > timeplace ? timelength - timevarlength : 0);
            int timeplacefix = timeplace + (timeplace > monthplace ? monthlength - monthvarlength : 0) + (timeplace > dayplace ? daylength - dayvarlength : 0) + (timeplace > yearplace ? yearlength - yearvarlength : 0);

            int minfilelength = Math.Max(Math.Max(timeplacefix + timelength, monthplacefix + monthlength),Math.Max(dayplacefix+daylength,yearplacefix+yearlength));

            string stryear = "";
            string strmonth = "";
            string strday = "";
            string strtime = "";

            int year = 0;
            int month = 0;
            int day = 0;
            int time = 0;

            Shell32.Shell shell = new Shell32.Shell();

            for (int i = 0; i < srcs.Count; i++)
            {
                if (Path.GetFileNameWithoutExtension(srcs[i].FullName).Length < minfilelength)
                    continue;

                name = srcs[i].Name;
                
                stryear = name.Substring(yearplacefix, yearlength);
                strmonth = name.Substring(monthplacefix, monthlength);
                strday = name.Substring(dayplacefix, daylength);
                strtime = name.Substring(timeplacefix, timelength);

                if (int.TryParse(stryear, out year) && int.TryParse(strmonth, out month) && int.TryParse(strday, out day) && int.TryParse(strtime, out time))
                {
                    DateTime date = new DateTime(year, month, day);
                    int yearprefix = int.Parse(VarYearPrefix.Text);
                    if (date.Year < yearprefix*100)
                        date.AddYears(yearprefix*100);
                    if (timelength == 6)
                    {
                        date = date.AddSeconds(time % 100);
                        date = date.AddMinutes((time / 100) % 100);
                        date = date.AddHours((time / 10000) % 100);
                    }
                    else if (timelength == 4)
                    {
                        date = date.AddMinutes(time % 100);
                        date = date.AddHours((time / 100) % 100);
                    }
                    else if (timelength == 2)
                        date = date.AddHours(time % 100);
                    srcs[i].CreationTime = date;
                    string fileext = Path.GetExtension(srcs[i].FullName).ToLower();
                    if (Path.GetExtension(srcs[i].FullName).ToLower()==".mp4")
                    {
                        string exifcreatestr = string.Format("-filecreatedate=\"{0}:{1}:{2} {3}:{4}:{5}\" -createdate=\"{0}:{1}:{2} {3}:{4}:{5}\"", year, month, day, date.Hour, date.Minute, date.Second);
                        string exifmodifystr = string.Format("-filemodifydate=\"{0}:{1}:{2} {3}:{4}:{5}\" -modifydate=\"{0}:{1}:{2} {3}:{4}:{5}\"", year, month, day, date.Hour, date.Minute, date.Second);
                        if (!CreateCheckBox.Checked)
                            exifcreatestr = "";
                        if (!ModifyCheckBox.Checked)
                            exifmodifystr = "";
                        shell.ShellExecute("exiftool", String.Format("-overwrite_original {0} {1} \"{2}\"", exifcreatestr, exifmodifystr, srcs[i].FullName));
                        while (Process.GetProcessesByName("exiftool").Length > 4)
                        {
                            Thread.Sleep(500);
                            Application.DoEvents();
                        }
                    }                           
                }
                else
                    formulaerrors += "Operation failed on file <"+name+">\n";
            }
            if (formulaerrors != "")
                MessageBox.Show(formulaerrors);

            panel1.Enabled = true;
            panel2.Enabled = true;
        }

        private void VarYearLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            VarYearPrefix.Visible = VarYearLength.SelectedIndex == 1;
            if (VarYearPrefix.Visible && VarYearName.Text == "yyyy")
                VarYearName.Text = "yy";
            else if (!VarYearPrefix.Visible && VarYearName.Text == "yy")
                VarYearName.Text = "yyyy";

        }

        private void VarTimeLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            string timevar = VarTimeName.Text;
            switch (VarTimeLength.Text)
            {
                case "2": if (timevar == "tttt" || timevar == "tttttt") VarTimeName.Text = "tt"; break;
                case "4": if (timevar == "tt" || timevar == "tttttt") VarTimeName.Text = "tttt"; break;
                case "6":if (timevar == "tt" || timevar == "tttt") VarTimeName.Text = "tttttt";break;
            }
        }

        private void FormulaTextBox_TextChanged(object sender, EventArgs e)
        {
            int yearlength = int.Parse(VarYearLength.Text);
            int timelength = int.Parse(VarTimeLength.Text);

            int yearvarlength = VarYearName.Text.Length;
            int monthvarlength = VarMonthName.Text.Length;
            int dayvarlength = VarDayName.Text.Length;
            int timevarlength = VarTimeName.Text.Length;

            string formula = FormulaTextBox.Text;

            int yearvars = formula.Length - formula.Replace(VarYearName.Text, VarYearName.Text.Substring(0, VarYearName.Text.Length - 1)).Length;
            int monthvars = formula.Length - formula.Replace(VarMonthName.Text, VarMonthName.Text.Substring(0, VarMonthName.Text.Length - 1)).Length;
            int dayvars = formula.Length - formula.Replace(VarDayName.Text, VarDayName.Text.Substring(0, VarDayName.Text.Length - 1)).Length;
            int timevars = formula.Length - formula.Replace(VarTimeName.Text, VarTimeName.Text.Substring(0, VarTimeName.Text.Length - 1)).Length;

            if (!(yearvars == 1 && monthvars == 1 && dayvars == 1 && timevars == 1))
            {
                FormulaError();
                return;
            }

            string name = formula;
            DateTime now = DateTime.Now;

            if (yearlength == 4)
                name = name.Replace(VarYearName.Text, string.Format("{0:D4}", now.Year.ToString()));
            else if (yearlength == 2)
                name = name.Replace(VarYearName.Text, string.Format("{0:D2}", now.Year % 100));
            else
            {
                FormulaError();
                return;
            }

            name = name.Replace(VarMonthName.Text, string.Format("{0:D2}", now.Month));
            name = name.Replace(VarDayName.Text, string.Format("{0:D2}", now.Day));

            switch (timelength)
            {
                case 6: name = name.Replace(VarTimeName.Text, string.Format("{0:D2}{1:D2}{2:D2}", now.Hour, now.Minute, now.Second)); break;
                case 4: name = name.Replace(VarTimeName.Text, string.Format("{0:D2}{1:D2}", now.Hour, now.Minute)); break;
                case 2: name = name.Replace(VarTimeName.Text, string.Format("{0:D2}", now.Hour)); break;
                default: FormulaError(); return;
            }

            FormulaNameExample.Text = name;

            FormulaTextBox.ForeColor = Color.Black;
        }

        private void FormulaError()
        {
            FormulaTextBox.ForeColor = Color.Red;
        }
    }
}
