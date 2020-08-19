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
    public partial class Fetat_produit : Form
    {
        public Fetat_produit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fetat_produit_Load(object sender, EventArgs e)
        {
            list_produit f = new list_produit();
            f.DataSourceConnections[0].SetConnection("MOWGLI","gestion_stock", "sa", "123456");
            liste.ReportSource = f;
            liste.RefreshReport();
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
