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
    public partial class Fproduit : Form
    {
        public Fproduit()
        {
            InitializeComponent();
        }

        private void Fproduit_Load(object sender, EventArgs e)
        {
            list_produit();
        }
        public void vider()
        {
            tproduit.Text = "";
            tdesign.Text = "";
            tachat.Text = "";
            tvent.Text = "";
           tstock.Text = "";
            tproduit.Select();
            
        }
        public void list_produit()
        {
            Form1.con.list_deconnecter("select * from Produit");
            liste.DataSource = Form1.con.t;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tproduit_Leave(object sender, EventArgs e)
        {
            if (tproduit.Text != "")
            {
                if (Form1.con.execute_valeur("select count(*) from Produit where id_produit= '" + tproduit.Text + "'") == "0")
                {
                    bajout.Enabled = true;
                    bsupp.Enabled = false;
                    bmodif.Enabled = false;
                    bimpri.Enabled = false;
                    tdesign.Select();

                }
                else 
                {
                    
                    Form1.con.list_deconnecter("select designation,prix_achats,prix_vents,stock from Produit where id_produit=" + tproduit.Text);
                    {
                     tdesign.Text = Form1.con.t.Rows[0][0].ToString();
                     tachat.Text =  Form1.con.t.Rows[0][1].ToString();;
                     tvent.Text =  Form1.con.t.Rows[0][2].ToString();;
                     tstock.Text =  Form1.con.t.Rows[0][3].ToString();
                      bajout.Enabled = false;
                     bsupp.Enabled = true;
                     bmodif.Enabled = true;
                     bimpri.Enabled = true;
                    }
                }
            }
        }

        private void bajout_Click(object sender, EventArgs e)
        {
            if (tproduit.Text == "" || tdesign.Text == "" || tachat.Text == "" || tvent.Text == "" || tstock.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.execut_query("insert into Produit values('" + tproduit.Text + "','" + tdesign.Text + "','" + tachat.Text + "','" + tvent.Text + "','" + tstock.Text + "')");
            MessageBox.Show("ajout effectuee");
            list_produit();
            vider();
        }

        private void bsupp_Click(object sender, EventArgs e)
        {
            if (tproduit.Text == "")
            {
                MessageBox.Show("donnee non valide");
                return;
            }
            if (Form1.con.execute_valeur("select count(*) from Lign_operation where id_produit ='" + tproduit.Text + "'") != "0")
            {
                MessageBox.Show("ce produit a des operation ");
                return;

            }
            if (MessageBox.Show("supprimer !!!", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("suppression annuler ");
                return;
            }
            Form1.con.execut_query("delete from Produit where id_produit =" + tproduit.Text);
            MessageBox.Show("effectuee");
            list_produit();
            vider();
        }

        private void bmodif_Click(object sender, EventArgs e)
        {
            if (tproduit.Text == "" || tdesign.Text == "" || tachat.Text == "" || tvent.Text == "" || tstock.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.execut_query("update Produit set designation= '" + tdesign.Text + "',prix_achats= '" + tachat.Text + "',prix_vents= '" + tvent.Text + "',stock= '" + tstock.Text + "' where id_produit = "+tproduit.Text);
            MessageBox.Show("effectuee");
            list_produit();
            vider();
            
        }

        private void bimpri_Click(object sender, EventArgs e)
        {
            new Fetat_produit().Show(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (trech.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.list_deconnecter("select * from Produit where id_produit=" + trech.Text);
            liste.DataSource = Form1.con.t;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (trech.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.list_deconnecter("select * from Produit where id_produit=" + trech.Text);
            liste.DataSource = Form1.con.t;
        }

        private void bajou_Click(object sender, EventArgs e)
        {
            if (tproduit.Text == "" || tdesign.Text == "" || tachat.Text == "" || tvent.Text == "" || tstock.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.execut_query("insert into Produit values('" + tproduit.Text + "','" + tdesign.Text + "','" + tachat.Text + "','" + tvent.Text + "','" + tstock.Text + "')");
            MessageBox.Show("ajout effectuee");
            list_produit();
            vider();
        }

        private void bsuppr_Click(object sender, EventArgs e)
        {
            if (tproduit.Text == "")
            {
                MessageBox.Show("donnee non valide");
                return;
            }
            if (Form1.con.execute_valeur("select count(*) from Lign_operation where id_produit ='" + tproduit.Text + "'") != "0")
            {
                MessageBox.Show("ce produit a des operation ");
                return;

            }
            if (MessageBox.Show("supprimer !!!", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("suppression annuler ");
                return;
            }
            Form1.con.execut_query("delete from Produit where id_produit =" + tproduit.Text);
            MessageBox.Show("effectuee");
            list_produit();
            vider();
        }

        private void bmodifi_Click(object sender, EventArgs e)
        {
            if (tproduit.Text == "" || tdesign.Text == "" || tachat.Text == "" || tvent.Text == "" || tstock.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.execut_query("update Produit set designation= '" + tdesign.Text + "',prix_achats= '" + tachat.Text + "',prix_vents= '" + tvent.Text + "',stock= '" + tstock.Text + "' where id_produit = " + tproduit.Text);
            MessageBox.Show("effectuee");
            list_produit();
            vider();
        }

        private void bimprimer_Click(object sender, EventArgs e)
        {
            new Fetat_produit().Show(); 
        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            if (tproduit.Text != "")
            {
                if (Form1.con.execute_valeur("select count(*) from Produit where id_produit= '" + tproduit.Text + "'") == "0")
                {
                    bajout.Enabled = true;
                    bsupp.Enabled = false;
                    bmodif.Enabled = false;
                    bimpri.Enabled = false;
                    tdesign.Select();

                }
                else
                {

                    Form1.con.list_deconnecter("select designation,prix_achats,prix_vents,stock from Produit where id_produit=" + tproduit.Text);
                    {
                        tdesign.Text = Form1.con.t.Rows[0][0].ToString();
                        tachat.Text = Form1.con.t.Rows[0][1].ToString(); ;
                        tvent.Text = Form1.con.t.Rows[0][2].ToString(); ;
                        tstock.Text = Form1.con.t.Rows[0][3].ToString();
                        bajout.Enabled = false;
                        bsupp.Enabled = true;
                        bmodif.Enabled = true;
                        bimpri.Enabled = true;
                    }
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
