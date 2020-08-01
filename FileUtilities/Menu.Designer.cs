namespace FileUtilities
{
    partial class Menu
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
            this.NameFormulaToMetadataButton = new System.Windows.Forms.Button();
            this.SpecificMetadataButton = new System.Windows.Forms.Button();
            this.SaveRestoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameFormulaToMetadataButton
            // 
            this.NameFormulaToMetadataButton.Location = new System.Drawing.Point(15, 15);
            this.NameFormulaToMetadataButton.Margin = new System.Windows.Forms.Padding(6);
            this.NameFormulaToMetadataButton.Name = "NameFormulaToMetadataButton";
            this.NameFormulaToMetadataButton.Size = new System.Drawing.Size(100, 80);
            this.NameFormulaToMetadataButton.TabIndex = 0;
            this.NameFormulaToMetadataButton.Text = "Change Metadata By Name Formula";
            this.NameFormulaToMetadataButton.UseVisualStyleBackColor = true;
            this.NameFormulaToMetadataButton.Click += new System.EventHandler(this.NameFormulaToMetadataButton_Click);
            // 
            // SpecificMetadataButton
            // 
            this.SpecificMetadataButton.Location = new System.Drawing.Point(127, 15);
            this.SpecificMetadataButton.Margin = new System.Windows.Forms.Padding(6);
            this.SpecificMetadataButton.Name = "SpecificMetadataButton";
            this.SpecificMetadataButton.Size = new System.Drawing.Size(100, 80);
            this.SpecificMetadataButton.TabIndex = 1;
            this.SpecificMetadataButton.Text = "Change Metadata To Specific";
            this.SpecificMetadataButton.UseVisualStyleBackColor = true;
            this.SpecificMetadataButton.Click += new System.EventHandler(this.SpecificMetadataButton_Click);
            // 
            // SaveRestoreButton
            // 
            this.SaveRestoreButton.Location = new System.Drawing.Point(239, 15);
            this.SaveRestoreButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveRestoreButton.Name = "SaveRestoreButton";
            this.SaveRestoreButton.Size = new System.Drawing.Size(100, 80);
            this.SaveRestoreButton.TabIndex = 2;
            this.SaveRestoreButton.Text = "Save\\Restore Metadata";
            this.SaveRestoreButton.UseVisualStyleBackColor = true;
            this.SaveRestoreButton.Click += new System.EventHandler(this.SaveRestoreButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveRestoreButton);
            this.Controls.Add(this.SpecificMetadataButton);
            this.Controls.Add(this.NameFormulaToMetadataButton);
            this.Name = "Menu";
            this.Text = "File Utilities";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NameFormulaToMetadataButton;
        private System.Windows.Forms.Button SpecificMetadataButton;
        private System.Windows.Forms.Button SaveRestoreButton;
    }
}

