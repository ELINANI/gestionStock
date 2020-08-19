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
    public partial class Fpaiement : Form
    {
        public Fpaiement()
        {
            InitializeComponent();
        }
        public void liste_paiement()
        {
            Form1.con.list_deconnecter("select * from Paiement");
            liste.DataSource = Form1.con.t;
        }

        private void Fpaiement_Load(object sender, EventArgs e)
        {
            liste_paiement();
        }
        public void vider()
        {
            tpaiement.Text = "";
            ttype.Text = "";
            tpaiement.Select();
        }
        private void tpaiement_Leave(object sender, EventArgs e)
        {
            if (tpaiement.Text != "")
            {
                if (Form1.con.execute_valeur("select count(*) from Paiement where id_paiement ='" + tpaiement.Text + "'") == "0")
                {
                    bajout.Enabled = true;
                    bsupp.Enabled = false;
                    bmodif.Enabled = false;
                    ttype.Select();
                }
                else
                {
                    Form1.con.list_deconnecter("select type_paiement from Paiement where id_paiement =" + tpaiement.Text);
                    ttype.Text = Form1.con.t.Rows[0][0].ToString();
                    bajout.Enabled = false;
                    bsupp.Enabled = true;
                    bmodif.Enabled = true;
                    ttype.Select();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bajout_Click(object sender, EventArgs e)
        {
            if (tpaiement.Text == "" || ttype.Text == "")
            {
                MessageBox.Show("donnee non valide");
                return;
            }
            Form1.con.execut_query("insert into Paiement values('"+tpaiement.Text+"','"+ttype.Text+"')");
            MessageBox.Show("ejout effectuee");
            liste_paiement();
            vider();
        }

        private void bsupp_Click(object sender, EventArgs e)
        {
            if (tpaiement.Text == "")
            {
                MessageBox.Show("donnee non valide");
                return;
            }
            if (Form1.con.execute_valeur("select count(*) from Operation where id_paiement= '"+tpaiement.Text+"'") != "0")
            {
                MessageBox.Show("impssible ce paiment a des operation");
                return;
            }
            if(MessageBox.Show("supprimer !!","suppression",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.No)
            {
                MessageBox.Show("suppression annulée");
                return;
            }
            Form1.con.execut_query("delete from Paiement where id_paiement= "+tpaiement.Text);
            MessageBox.Show("effectuée");
            liste_paiement();
            vider();

        }

        private void bmodif_Click(object sender, EventArgs e)
        {
            if (tpaiement.Text == "" || ttype.Text == "")
            {
                MessageBox.Show("donnee non valide");
                return;
            }
            Form1.con.execut_query("update Paiement set type_paiement= '"+ttype.Text+"' where id_paiement= "+tpaiement.Text);
            MessageBox.Show("effectuee");
            liste_paiement();
            vider();

        }

        private void bajout_Click_1(object sender, EventArgs e)
        {
            if (tpaiement.Text == "" || ttype.Text == "")
            {
                MessageBox.Show("donnee non valide");
                return;
            }
            Form1.con.execut_query("insert into Paiement values('" + tpaiement.Text + "','" + ttype.Text + "')");
            MessageBox.Show("ejout effectuee");
            liste_paiement();
            vider();
        }

        private void bsupp_Click_1(object sender, EventArgs e)
        {
            if (tpaiement.Text == "")
            {
                MessageBox.Show("donnee non valide");
                return;
            }
            if (Form1.con.execute_valeur("select count(*) from Operation where id_paiement= '" + tpaiement.Text + "'") != "0")
            {
                MessageBox.Show("impssible ce paiment a des operation");
                return;
            }
            if (MessageBox.Show("supprimer !!", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("suppression annulée");
                return;
            }
            Form1.con.execut_query("delete from Paiement where id_paiement= " + tpaiement.Text);
            MessageBox.Show("effectuée");
            liste_paiement();
            vider();
        }

        private void bmodif_Click_1(object sender, EventArgs e)
        {
            if (tpaiement.Text == "" || ttype.Text == "")
            {
                MessageBox.Show("donnee non valide");
                return;
            }
            Form1.con.execut_query("update Paiement set type_paiement= '" + ttype.Text + "' where id_paiement= " + tpaiement.Text);
            MessageBox.Show("effectuee");
            liste_paiement();
            vider();
        }

        private void tpaiement_Leave_1(object sender, EventArgs e)
        {

            if (tpaiement.Text != "")
            {
                if (Form1.con.execute_valeur("select count(*) from Paiement where id_paiement ='" + tpaiement.Text + "'") == "0")
                {
                    bajout.Enabled = true;
                    bsupp.Enabled = false;
                    bmodif.Enabled = false;
                    ttype.Select();
                }
                else
                {
                    Form1.con.list_deconnecter("select type_paiement from Paiement where id_paiement =" + tpaiement.Text);
                    ttype.Text = Form1.con.t.Rows[0][0].ToString();
                    bajout.Enabled = false;
                    bsupp.Enabled = true;
                    bmodif.Enabled = true;
                    ttype.Select();

                }
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       

    }
}
