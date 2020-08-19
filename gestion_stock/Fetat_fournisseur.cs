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
    public partial class Fetat_fournisseur : Form
    {
        public Fetat_fournisseur()
        {
            InitializeComponent();
        }

        private void Fetat_fournisseur_Load(object sender, EventArgs e)
        {
            list_fournisseur f = new list_fournisseur();
            f.DataSourceConnections[0].SetConnection("MOWGLI","gestion_stock","sa","123456");
            liste.ReportSource = f;
            liste.RefreshReport(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
