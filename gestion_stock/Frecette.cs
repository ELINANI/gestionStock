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
    public partial class Frecette : Form
    {
        public Frecette()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tjour_Leave(object sender, EventArgs e)
        {
            if(tjour.Text  == "")

            {
                MessageBox.Show("donner non valide");
                return;
            }
            double totale = 0;
            Form1.con.list_deconnecter("select prix from vue_vents where date_operation = convert(smalldatetime,'"+ tjour.Text +"')");
            for (int k = 0; k < Form1.con.t.Rows.Count;k++ )
            {
                totale += Convert.ToDouble(Form1.con.t.Rows[k][0]);
            }
            ttotal.Text = totale.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
