namespace FileUtilities
{
    partial class SaveRestoreMetadata
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
            this.SaveMetadataButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RestoreMetadataButton = new System.Windows.Forms.Button();
            this.SaveInFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveInFolderTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
            this.SourceFileAddButton.Click += new System.EventHandler(this.SourceAddButton_Click);
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
            // SaveMetadataButton
            // 
            this.SaveMetadataButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SaveMetadataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SaveMetadataButton.Location = new System.Drawing.Point(3, 3);
            this.SaveMetadataButton.Name = "SaveMetadataButton";
            this.SaveMetadataButton.Size = new System.Drawing.Size(223, 116);
            this.SaveMetadataButton.TabIndex = 7;
            this.SaveMetadataButton.Text = "Save Metadata";
            this.SaveMetadataButton.UseVisualStyleBackColor = false;
            this.SaveMetadataButton.Click += new System.EventHandler(this.SaveMetadataButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SaveInFolderTextBox);
            this.panel1.Controls.Add(this.SaveInFolderCheckBox);
            this.panel1.Controls.Add(this.RestoreMetadataButton);
            this.panel1.Controls.Add(this.SaveMetadataButton);
            this.panel1.Location = new System.Drawing.Point(519, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 351);
            this.panel1.TabIndex = 6;
            // 
            // RestoreMetadataButton
            // 
            this.RestoreMetadataButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.RestoreMetadataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RestoreMetadataButton.Location = new System.Drawing.Point(3, 232);
            this.RestoreMetadataButton.Name = "RestoreMetadataButton";
            this.RestoreMetadataButton.Size = new System.Drawing.Size(223, 116);
            this.RestoreMetadataButton.TabIndex = 8;
            this.RestoreMetadataButton.Text = "Restore Metadata";
            this.RestoreMetadataButton.UseVisualStyleBackColor = false;
            this.RestoreMetadataButton.Click += new System.EventHandler(this.RestoreMetadataButton_Click);
            // 
            // SaveInFolderCheckBox
            // 
            this.SaveInFolderCheckBox.AutoSize = true;
            this.SaveInFolderCheckBox.Location = new System.Drawing.Point(12, 125);
            this.SaveInFolderCheckBox.Name = "SaveInFolderCheckBox";
            this.SaveInFolderCheckBox.Size = new System.Drawing.Size(136, 17);
            this.SaveInFolderCheckBox.TabIndex = 9;
            this.SaveInFolderCheckBox.Text = "Save In Specific Folder";
            this.SaveInFolderCheckBox.UseVisualStyleBackColor = true;
            this.SaveInFolderCheckBox.CheckedChanged += new System.EventHandler(this.SaveInFolderCheckBox_CheckedChanged);
            // 
            // SaveInFolderTextBox
            // 
            this.SaveInFolderTextBox.Enabled = false;
            this.SaveInFolderTextBox.Location = new System.Drawing.Point(3, 148);
            this.SaveInFolderTextBox.Name = "SaveInFolderTextBox";
            this.SaveInFolderTextBox.Size = new System.Drawing.Size(221, 20);
            this.SaveInFolderTextBox.TabIndex = 10;
            // 
            // SaveRestoreMetadata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SaveRestoreMetadata";
            this.Text = "SaveRestoreMetadata";
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
        private System.Windows.Forms.Button SaveMetadataButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RestoreMetadataButton;
        private System.Windows.Forms.TextBox SaveInFolderTextBox;
        private System.Windows.Forms.CheckBox SaveInFolderCheckBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}