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
    public partial class Etat_commende : Form
    {
        public Etat_commende()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Etat_commende_Load(object sender, EventArgs e)
        {
            liste_commende c = new liste_commende();
            c.DataSourceConnections[0].SetConnection("MOWGLI","gestion_stock","sa","123456");
            liste.ReportSource = c;
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
