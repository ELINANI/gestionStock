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
    public partial class Fetat_client : Form
    {
        public Fetat_client()
        {
            InitializeComponent();
        }

        private void Fetat_client_Load(object sender, EventArgs e)
        {
            liste_client l = new liste_client();
            l.DataSourceConnections[0].SetConnection("MOWGLI", "gestion_stock", "sa", "123456");
            etat_client.ReportSource = l;
            etat_client.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
