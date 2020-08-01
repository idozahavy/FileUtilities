namespace FileUtilities
{
    partial class NameFormulaToMetadata
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.AddFolderButton = new System.Windows.Forms.Button();
            this.OpenLocationButton = new System.Windows.Forms.Button();
            this.SourceRemoveButton = new System.Windows.Forms.Button();
            this.SourceFileAddButton = new System.Windows.Forms.Button();
            this.SourceListBox = new System.Windows.Forms.ListBox();
            this.SourceLabel1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.ModifyCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.FormulaNameExample = new System.Windows.Forms.TextBox();
            this.StartFormulaButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.VarDayLength = new System.Windows.Forms.ComboBox();
            this.VarMonthLength = new System.Windows.Forms.ComboBox();
            this.UnlockVarsCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VarTimeLength = new System.Windows.Forms.ComboBox();
            this.VarYearLength = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VarTimeName = new System.Windows.Forms.TextBox();
            this.VarDayName = new System.Windows.Forms.TextBox();
            this.VarMonthName = new System.Windows.Forms.TextBox();
            this.VarYearPrefix = new System.Windows.Forms.TextBox();
            this.VarYearName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FormulaTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FolderTextBox);
            this.panel2.Controls.Add(this.AddFolderButton);
            this.panel2.Controls.Add(this.OpenLocationButton);
            this.panel2.Controls.Add(this.SourceRemoveButton);
            this.panel2.Controls.Add(this.SourceFileAddButton);
            this.panel2.Controls.Add(this.SourceListBox);
            this.panel2.Controls.Add(this.SourceLabel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 351);
            this.panel2.TabIndex = 4;
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FolderTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FolderTextBox.Location = new System.Drawing.Point(14, 311);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(383, 20);
            this.FolderTextBox.TabIndex = 5;
            this.FolderTextBox.WordWrap = false;
            this.FolderTextBox.TextChanged += new System.EventHandler(this.FolderTextBox_TextChanged);
            this.FolderTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FolderTextBox_KeyDown);
            // 
            // AddFolderButton
            // 
            this.AddFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AddFolderButton.Location = new System.Drawing.Point(403, 310);
            this.AddFolderButton.Name = "AddFolderButton";
            this.AddFolderButton.Size = new System.Drawing.Size(80, 22);
            this.AddFolderButton.TabIndex = 4;
            this.AddFolderButton.Text = "Add Folder";
            this.AddFolderButton.UseVisualStyleBackColor = true;
            this.AddFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // OpenLocationButton
            // 
            this.OpenLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenLocationButton.Location = new System.Drawing.Point(387, 37);
            this.OpenLocationButton.Name = "OpenLocationButton";
            this.OpenLocationButton.Size = new System.Drawing.Size(96, 25);
            this.OpenLocationButton.TabIndex = 3;
            this.OpenLocationButton.Text = "Open Location";
            this.OpenLocationButton.UseVisualStyleBackColor = true;
            this.OpenLocationButton.Click += new System.EventHandler(this.OpenLocationButton_Click);
            // 
            // SourceRemoveButton
            // 
            this.SourceRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SourceRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SourceRemoveButton.Location = new System.Drawing.Point(215, 30);
            this.SourceRemoveButton.Name = "SourceRemoveButton";
            this.SourceRemoveButton.Size = new System.Drawing.Size(70, 32);
            this.SourceRemoveButton.TabIndex = 3;
            this.SourceRemoveButton.Text = "Remove";
            this.SourceRemoveButton.UseVisualStyleBackColor = false;
            this.SourceRemoveButton.Click += new System.EventHandler(this.SourceRemoveButton_Click);
            // 
            // SourceFileAddButton
            // 
            this.SourceFileAddButton.BackColor = System.Drawing.Color.PaleGreen;
            this.SourceFileAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SourceFileAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SourceFileAddButton.Location = new System.Drawing.Point(14, 30);
            this.SourceFileAddButton.Name = "SourceFileAddButton";
            this.SourceFileAddButton.Size = new System.Drawing.Size(80, 32);
            this.SourceFileAddButton.TabIndex = 2;
            this.SourceFileAddButton.Text = "Add Files";
            this.SourceFileAddButton.UseVisualStyleBackColor = false;
            this.SourceFileAddButton.Click += new System.EventHandler(this.SourceFileAddButton_Click);
            // 
            // SourceListBox
            // 
            this.SourceListBox.AllowDrop = true;
            this.SourceListBox.HorizontalScrollbar = true;
            this.SourceListBox.Location = new System.Drawing.Point(14, 68);
            this.SourceListBox.Name = "SourceListBox";
            this.SourceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.SourceListBox.Size = new System.Drawing.Size(469, 238);
            this.SourceListBox.Sorted = true;
            this.SourceListBox.TabIndex = 1;
            this.SourceListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.SourceListBox_DragDrop);
            this.SourceListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.SourceListBox_DragEnter);
            this.SourceListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SourceListBox_KeyDown);
            // 
            // SourceLabel1
            // 
            this.SourceLabel1.AutoSize = true;
            this.SourceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SourceLabel1.Location = new System.Drawing.Point(10, 7);
            this.SourceLabel1.Name = "SourceLabel1";
            this.SourceLabel1.Size = new System.Drawing.Size(123, 20);
            this.SourceLabel1.TabIndex = 0;
            this.SourceLabel1.Text = "Source Settings";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Source.mp4";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.ModifyCheckBox);
            this.panel1.Controls.Add(this.CreateCheckBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.FormulaNameExample);
            this.panel1.Controls.Add(this.StartFormulaButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FormulaTextBox);
            this.panel1.Location = new System.Drawing.Point(519, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 351);
            this.panel1.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(305, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Change These";
            // 
            // ModifyCheckBox
            // 
            this.ModifyCheckBox.AutoSize = true;
            this.ModifyCheckBox.Checked = true;
            this.ModifyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ModifyCheckBox.Location = new System.Drawing.Point(322, 217);
            this.ModifyCheckBox.Name = "ModifyCheckBox";
            this.ModifyCheckBox.Size = new System.Drawing.Size(83, 17);
            this.ModifyCheckBox.TabIndex = 19;
            this.ModifyCheckBox.Text = "Modify Date";
            this.ModifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateCheckBox
            // 
            this.CreateCheckBox.AutoSize = true;
            this.CreateCheckBox.Checked = true;
            this.CreateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreateCheckBox.Location = new System.Drawing.Point(322, 195);
            this.CreateCheckBox.Name = "CreateCheckBox";
            this.CreateCheckBox.Size = new System.Drawing.Size(83, 17);
            this.CreateCheckBox.TabIndex = 18;
            this.CreateCheckBox.Text = "Create Date";
            this.CreateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Name exmaple For current formula";
            // 
            // FormulaNameExample
            // 
            this.FormulaNameExample.Enabled = false;
            this.FormulaNameExample.Location = new System.Drawing.Point(27, 105);
            this.FormulaNameExample.Name = "FormulaNameExample";
            this.FormulaNameExample.Size = new System.Drawing.Size(345, 20);
            this.FormulaNameExample.TabIndex = 15;
            // 
            // StartFormulaButton
            // 
            this.StartFormulaButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.StartFormulaButton.Location = new System.Drawing.Point(319, 276);
            this.StartFormulaButton.Name = "StartFormulaButton";
            this.StartFormulaButton.Size = new System.Drawing.Size(99, 70);
            this.StartFormulaButton.TabIndex = 14;
            this.StartFormulaButton.Text = "Start Formulating";
            this.StartFormulaButton.UseVisualStyleBackColor = false;
            this.StartFormulaButton.Click += new System.EventHandler(this.StartFormulaButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.VarDayLength);
            this.panel3.Controls.Add(this.VarMonthLength);
            this.panel3.Controls.Add(this.UnlockVarsCheckBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.VarTimeLength);
            this.panel3.Controls.Add(this.VarYearLength);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.VarTimeName);
            this.panel3.Controls.Add(this.VarDayName);
            this.panel3.Controls.Add(this.VarMonthName);
            this.panel3.Controls.Add(this.VarYearPrefix);
            this.panel3.Controls.Add(this.VarYearName);
            this.panel3.Location = new System.Drawing.Point(27, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 189);
            this.panel3.TabIndex = 13;
            // 
            // VarDayLength
            // 
            this.VarDayLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VarDayLength.Enabled = false;
            this.VarDayLength.FormattingEnabled = true;
            this.VarDayLength.Items.AddRange(new object[] {
            "2"});
            this.VarDayLength.Location = new System.Drawing.Point(127, 99);
            this.VarDayLength.Name = "VarDayLength";
            this.VarDayLength.Size = new System.Drawing.Size(56, 21);
            this.VarDayLength.TabIndex = 13;
            this.VarDayLength.TabStop = false;
            // 
            // VarMonthLength
            // 
            this.VarMonthLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VarMonthLength.Enabled = false;
            this.VarMonthLength.FormattingEnabled = true;
            this.VarMonthLength.Items.AddRange(new object[] {
            "2"});
            this.VarMonthLength.Location = new System.Drawing.Point(127, 72);
            this.VarMonthLength.Name = "VarMonthLength";
            this.VarMonthLength.Size = new System.Drawing.Size(56, 21);
            this.VarMonthLength.TabIndex = 12;
            // 
            // UnlockVarsCheckBox
            // 
            this.UnlockVarsCheckBox.AutoSize = true;
            this.UnlockVarsCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.UnlockVarsCheckBox.Location = new System.Drawing.Point(3, 163);
            this.UnlockVarsCheckBox.Name = "UnlockVarsCheckBox";
            this.UnlockVarsCheckBox.Size = new System.Drawing.Size(147, 17);
            this.UnlockVarsCheckBox.TabIndex = 8;
            this.UnlockVarsCheckBox.Text = "Unlock Variables Settings";
            this.UnlockVarsCheckBox.UseVisualStyleBackColor = true;
            this.UnlockVarsCheckBox.CheckedChanged += new System.EventHandler(this.UnlockVarsCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Prefix";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Day";
            // 
            // VarTimeLength
            // 
            this.VarTimeLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VarTimeLength.Enabled = false;
            this.VarTimeLength.FormattingEnabled = true;
            this.VarTimeLength.Items.AddRange(new object[] {
            "6",
            "4",
            "2"});
            this.VarTimeLength.Location = new System.Drawing.Point(127, 124);
            this.VarTimeLength.Name = "VarTimeLength";
            this.VarTimeLength.Size = new System.Drawing.Size(56, 21);
            this.VarTimeLength.TabIndex = 6;
            this.VarTimeLength.SelectedIndexChanged += new System.EventHandler(this.VarTimeLength_SelectedIndexChanged);
            // 
            // VarYearLength
            // 
            this.VarYearLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VarYearLength.Enabled = false;
            this.VarYearLength.FormattingEnabled = true;
            this.VarYearLength.Items.AddRange(new object[] {
            "4",
            "2"});
            this.VarYearLength.Location = new System.Drawing.Point(127, 46);
            this.VarYearLength.Name = "VarYearLength";
            this.VarYearLength.Size = new System.Drawing.Size(56, 21);
            this.VarYearLength.TabIndex = 6;
            this.VarYearLength.SelectedIndexChanged += new System.EventHandler(this.VarYearLength_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Variables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year";
            // 
            // VarTimeName
            // 
            this.VarTimeName.Enabled = false;
            this.VarTimeName.Location = new System.Drawing.Point(70, 124);
            this.VarTimeName.Name = "VarTimeName";
            this.VarTimeName.Size = new System.Drawing.Size(51, 20);
            this.VarTimeName.TabIndex = 3;
            this.VarTimeName.Text = "t";
            // 
            // VarDayName
            // 
            this.VarDayName.Enabled = false;
            this.VarDayName.Location = new System.Drawing.Point(70, 98);
            this.VarDayName.Name = "VarDayName";
            this.VarDayName.Size = new System.Drawing.Size(51, 20);
            this.VarDayName.TabIndex = 3;
            this.VarDayName.Text = "d";
            // 
            // VarMonthName
            // 
            this.VarMonthName.Enabled = false;
            this.VarMonthName.Location = new System.Drawing.Point(70, 72);
            this.VarMonthName.Name = "VarMonthName";
            this.VarMonthName.Size = new System.Drawing.Size(51, 20);
            this.VarMonthName.TabIndex = 3;
            this.VarMonthName.Text = "m";
            // 
            // VarYearPrefix
            // 
            this.VarYearPrefix.Location = new System.Drawing.Point(189, 46);
            this.VarYearPrefix.Name = "VarYearPrefix";
            this.VarYearPrefix.Size = new System.Drawing.Size(51, 20);
            this.VarYearPrefix.TabIndex = 3;
            this.VarYearPrefix.Text = "20";
            this.VarYearPrefix.Visible = false;
            // 
            // VarYearName
            // 
            this.VarYearName.Enabled = false;
            this.VarYearName.Location = new System.Drawing.Point(70, 46);
            this.VarYearName.Name = "VarYearName";
            this.VarYearName.Size = new System.Drawing.Size(51, 20);
            this.VarYearName.TabIndex = 3;
            this.VarYearName.Text = "y";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(75, 53);
            this.label2.MaximumSize = new System.Drawing.Size(350, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 0);
            this.label2.TabIndex = 2;
            this.label2.Text = "The program takes the filename of all the sources and edits its metadata to match" +
    " their names.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formula -";
            // 
            // FormulaTextBox
            // 
            this.FormulaTextBox.Location = new System.Drawing.Point(75, 30);
            this.FormulaTextBox.Name = "FormulaTextBox";
            this.FormulaTextBox.Size = new System.Drawing.Size(297, 20);
            this.FormulaTextBox.TabIndex = 0;
            this.FormulaTextBox.TextChanged += new System.EventHandler(this.FormulaTextBox_TextChanged);
            // 
            // NameFormulaToMetadata
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "NameFormulaToMetadata";
            this.Text = "Name Formula To Metadata";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NameFormulaToMetadata_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SourceLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SourceRemoveButton;
        private System.Windows.Forms.Button SourceFileAddButton;
        private System.Windows.Forms.ListBox SourceListBox;
        private System.Windows.Forms.Button OpenLocationButton;
        private System.Windows.Forms.Button AddFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FormulaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VarYearName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox UnlockVarsCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox VarYearLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button StartFormulaButton;
        private System.Windows.Forms.ComboBox VarTimeLength;
        private System.Windows.Forms.TextBox VarTimeName;
        private System.Windows.Forms.TextBox VarDayName;
        private System.Windows.Forms.TextBox VarMonthName;
        private System.Windows.Forms.ComboBox VarDayLength;
        private System.Windows.Forms.ComboBox VarMonthLength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox VarYearPrefix;
        private System.Windows.Forms.TextBox FormulaNameExample;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ModifyCheckBox;
        private System.Windows.Forms.CheckBox CreateCheckBox;
        private System.Windows.Forms.Label label12;
    }
}