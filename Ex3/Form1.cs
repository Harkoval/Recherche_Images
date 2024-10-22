using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dossier;

        private void btnDossier_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog rechercheDossier;
            rechercheDossier = new System.Windows.Forms.FolderBrowserDialog();
            DialogResult choix = rechercheDossier.ShowDialog();

            if (choix == DialogResult.OK)
            {
                dossier = rechercheDossier.SelectedPath;
            }
            lstPhoto.Items.Clear();
            foreach (string fichier in System.IO.Directory.GetFiles(dossier))
            {
                string nom = System.IO.Path.GetFileName(fichier);
                lstPhoto.Items.Add(nom);
            }
            if (lstPhoto.Items.Count != 0)
            {
                lstPhoto.SelectedIndex = 0;
            }
        }

        private void lstPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string fichier = dossier + "\\" + lstPhoto.SelectedItem;
                pctPhoto.Image =Image.FromFile(fichier);
            }
            catch (Exception)
            {
                pctPhoto.Image = null;
            }
        }

        private void btnRotation_Click(object sender, EventArgs e)
        {
            if (pctPhoto.Image != null)
            {
                pctPhoto.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pctPhoto.Refresh();
            }

        }
    }
}
