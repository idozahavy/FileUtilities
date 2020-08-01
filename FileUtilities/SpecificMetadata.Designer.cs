namespace FileUtilities
{
    partial class SpecificMetadata
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
            this.WriteMetadataButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CommentCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifyTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ModifyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel2.TabIndex = 5;
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
            this.AddFolderButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FolderTextBox_KeyDown);
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
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // WriteMetadataButton
            // 
            this.WriteMetadataButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.WriteMetadataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WriteMetadataButton.Location = new System.Drawing.Point(264, 264);
            this.WriteMetadataButton.Name = "WriteMetadataButton";
            this.WriteMetadataButton.Size = new System.Drawing.Size(143, 84);
            this.WriteMetadataButton.TabIndex = 6;
            this.WriteMetadataButton.Text = "Start Rewriting Metadata";
            this.WriteMetadataButton.UseVisualStyleBackColor = false;
            this.WriteMetadataButton.Click += new System.EventHandler(this.WriteMetadataButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CommentCheckBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CommentTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ModifyTimePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ModifyDatePicker);
            this.panel1.Controls.Add(this.CreateTimePicker);
            this.panel1.Controls.Add(this.CreateDatePicker);
            this.panel1.Controls.Add(this.WriteMetadataButton);
            this.panel1.Location = new System.Drawing.Point(519, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 351);
            this.panel1.TabIndex = 7;
            // 
            // CommentCheckBox
            // 
            this.CommentCheckBox.AutoSize = true;
            this.CommentCheckBox.Location = new System.Drawing.Point(100, 160);
            this.CommentCheckBox.Name = "CommentCheckBox";
            this.CommentCheckBox.Size = new System.Drawing.Size(15, 14);
            this.CommentCheckBox.TabIndex = 12;
            this.CommentCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Comment";
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(119, 157);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(259, 20);
            this.CommentTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(37, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modify";
            // 
            // ModifyTimePicker
            // 
            this.ModifyTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ModifyTimePicker.Location = new System.Drawing.Point(299, 115);
            this.ModifyTimePicker.Name = "ModifyTimePicker";
            this.ModifyTimePicker.ShowUpDown = true;
            this.ModifyTimePicker.Size = new System.Drawing.Size(79, 20);
            this.ModifyTimePicker.TabIndex = 8;
            this.ModifyTimePicker.Value = new System.DateTime(2018, 1, 1, 12, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Create";
            // 
            // ModifyDatePicker
            // 
            this.ModifyDatePicker.Location = new System.Drawing.Point(98, 115);
            this.ModifyDatePicker.Name = "ModifyDatePicker";
            this.ModifyDatePicker.ShowCheckBox = true;
            this.ModifyDatePicker.Size = new System.Drawing.Size(195, 20);
            this.ModifyDatePicker.TabIndex = 7;
            this.ModifyDatePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // CreateTimePicker
            // 
            this.CreateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CreateTimePicker.Location = new System.Drawing.Point(299, 70);
            this.CreateTimePicker.Name = "CreateTimePicker";
            this.CreateTimePicker.ShowUpDown = true;
            this.CreateTimePicker.Size = new System.Drawing.Size(79, 20);
            this.CreateTimePicker.TabIndex = 8;
            this.CreateTimePicker.Value = new System.DateTime(2018, 1, 1, 12, 0, 0, 0);
            // 
            // CreateDatePicker
            // 
            this.CreateDatePicker.Location = new System.Drawing.Point(98, 70);
            this.CreateDatePicker.Name = "CreateDatePicker";
            this.CreateDatePicker.ShowCheckBox = true;
            this.CreateDatePicker.Size = new System.Drawing.Size(195, 20);
            this.CreateDatePicker.TabIndex = 7;
            this.CreateDatePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // SpecificMetadata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SpecificMetadata";
            this.Text = "Metadata To Specific";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpecificMetadata_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Button AddFolderButton;
        private System.Windows.Forms.Button OpenLocationButton;
        private System.Windows.Forms.Button SourceRemoveButton;
        private System.Windows.Forms.Button SourceFileAddButton;
        private System.Windows.Forms.ListBox SourceListBox;
        private System.Windows.Forms.Label SourceLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button WriteMetadataButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker CreateDatePicker;
        private System.Windows.Forms.DateTimePicker CreateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ModifyTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ModifyDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.CheckBox CommentCheckBox;
    }
}