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
    public partial class Finventair_achat : Form
    {
        public Finventair_achat()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bajout_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Form1.con.list_deconnecter("select * from vue_achats where date_operation between convert(smalldatetime,'" + td1.Text + "') and convert(smalldatetime,'" + td2.Text + "')");
                liste.DataSource = Form1.con.t;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    Form1.con.list_deconnecter("select * from vues_achats_date where date_operation = convert(smalldatetime,'" + tmois.Text + "')");
                    liste.DataSource = Form1.con.t;
                }
                else
                {
                    Form1.con.list_deconnecter("select * from vues_achats_date where date_operation = convert(smalldatetime,'" + tannée.Text + "')");
                    liste.DataSource = Form1.con.t;
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
