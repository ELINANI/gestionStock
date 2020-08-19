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
    public partial class Etat_achats : Form
    {
        public Etat_achats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Etat_achats_Load(object sender, EventArgs e)
        {
            liste_achats a = new liste_achats();
            a.DataSourceConnections[0].SetConnection("MOWGLI", "gestion_stock", "sa", "123456");
            liste.ReportSource = a;
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
