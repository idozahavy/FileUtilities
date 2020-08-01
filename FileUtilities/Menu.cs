using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileUtilities
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            OpenForms = new List<Form>();
        }

        List<Form> OpenForms;

        private void NameFormulaToMetadataButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OpenForms.Count; i++)
                if (OpenForms[i] != null && OpenForms[i].Name == "NameFormulaToMetadata1")
                {
                    if (OpenForms[i].IsDisposed)
                    {
                        OpenForms.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        OpenForms[i].Focus();
                        return;
                    }
                }

            Form newform = new NameFormulaToMetadata();
            newform.Name = "NameFormulaToMetadata1";
            newform.Show();
            OpenForms.Add(newform);
        }

        private void SpecificMetadataButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OpenForms.Count; i++)
                if (OpenForms[i] != null && OpenForms[i].Name == "SpecificMetadata1")
                {
                    if (OpenForms[i].IsDisposed)
                    {
                        OpenForms.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        OpenForms[i].Focus();
                        return;
                    }
                }

            Form newform = new SpecificMetadata();
            newform.Name = "SpecificMetadata1";
            newform.Show();
            OpenForms.Add(newform);
        }

        private void SaveRestoreButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OpenForms.Count; i++)
                if (OpenForms[i] != null && OpenForms[i].Name == "SaveRestoreMetadata1")
                {
                    if (OpenForms[i].IsDisposed)
                    {
                        OpenForms.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        OpenForms[i].Focus();
                        return;
                    }
                }

            Form newform = new SaveRestoreMetadata();
            newform.Name = "SaveRestoreMetadata1";
            newform.Show();
            OpenForms.Add(newform);
        }
    }
}
