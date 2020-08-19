using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_stock
{
    public partial class Fmenu : Form
    {
        private int childFormNumber = 0;

        public Fmenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void sauvgardeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fpersonne f = new Fpersonne();
            f.MdiParent = this;
            f.Show();
        }

        private void Fmenu_Load(object sender, EventArgs e)
        {

        }

        private void paiementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fpaiement f = new Fpaiement();
            f.MdiParent = this;
            f.Show();
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fproduit f = new Fproduit();
            f.MdiParent = this;
            f.Show();
        }

        private void sauvgarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fsauvegarde f = new Fsauvegarde();
            f.MdiParent = this;
            f.Show();
        }

        private void ventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fvents f = new Fvents();
            f.MdiParent = this;
            f.Show();
        }

        private void achatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fachats f = new Fachats();
            f.MdiParent = this;
            f.Show();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fcommende f = new Fcommende();
            f.MdiParent = this;
            f.Show();
        }
    }
}
