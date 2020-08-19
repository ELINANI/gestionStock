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
    public partial class Fcommende : Form
    {
        public Fcommende()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Fpersonne().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Fproduit().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Fpaiement().Show();
        }
        public void liste_commende()
        {
            Form1.con.list_deconnecter("select * from vue_commende");
            liste.DataSource = Form1.con.t;
        }
        public void vider()
        {
            toperation.Text = "";
            cclient.Text = "";
            cproduit.Text = "";
            cpaiement.Text = "";
            tqte.Text = "";
            ttotal.Text = "";

        }
        public void liste_paiement()
        {
            Form1.con.list_deconnecter("select id_paiement from Paiement");
            for (int k = 0; k < Form1.con.t.Rows.Count; k++)
            {
                cpaiement.Items.Add(Form1.con.t.Rows[k][0].ToString());
            }
        }
        public void liste_produit()
        {
            Form1.con.list_deconnecter("select id_produit from Produit ");
            for (int k = 0; k < Form1.con.t.Rows.Count; k++)
            {
                cproduit.Items.Add(Form1.con.t.Rows[k][0].ToString());
            }
        }
        public void liste_client()
        {
            Form1.con.list_deconnecter("select id_personne from Personne where type_personne = 'client'");
            for (int k = 0; k < Form1.con.t.Rows.Count; k++)
            {
                cclient.Items.Add(Form1.con.t.Rows[k][0].ToString());
            }
        }
        private void Fcommende_Load(object sender, EventArgs e)
        {
            liste_commende();
            liste_produit();
            liste_client();
            liste_paiement();
            tdate.Text = DateTime.Today.Date.ToShortDateString();
        }

        private void cclient_Leave(object sender, EventArgs e)
        {
            if (cclient.Text != "")
            {
                Form1.con.list_deconnecter("select nom,prenom from Personne where id_personne ='" + cclient.Text + "'");
                tnom.Text = Form1.con.t.Rows[0][0].ToString();
                tprenom.Text = Form1.con.t.Rows[0][1].ToString();
            }
        }

        private void cproduit_Leave(object sender, EventArgs e)
        {

            Form1.con.list_deconnecter("select prix_achats,prix_vents,stock from Produit where id_produit ='" + cproduit.Text + "' ");
            tachat.Text = Form1.con.t.Rows[0][0].ToString();
            tvent.Text = Form1.con.t.Rows[0][1].ToString();
            tstock.Text = Form1.con.t.Rows[0][2].ToString();
        }

        private void cpaiement_Leave(object sender, EventArgs e)
        {
            if (cpaiement.Text != "")
            {
                Form1.con.list_deconnecter("select type_paiement from Paiement where id_paiement='" + cpaiement.Text + "'");
                ttype_paiement.Text = Form1.con.t.Rows[0][0].ToString();
            }
        }

        private void tqte_Leave(object sender, EventArgs e)
        {
            double x = 0;
            try
            {

                x = Convert.ToDouble(tqte.Text) * Convert.ToDouble(tvent.Text);

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            ttotal.Text = x.ToString();
        }

        private void bajout_Click(object sender, EventArgs e)
        {
            if (toperation.Text == "" || tdate.Text == "" || cclient.Text == "" || cproduit.Text == "" || cpaiement.Text == "" || tqte.Text == "")
            {
                MessageBox.Show("danner non valide ");
                return;
            }
            Form1.con.execut_query("insert into Operation Values('" + toperation.Text + "','" + ttype.Text + "','" + tdate.Text + "','" + cclient.Text + "','" + cpaiement.Text + "')");
            Form1.con.execut_query("insert into Lign_operation values('" + toperation.Text + "','" + cproduit.Text + "','" + tqte.Text + "','" + ttotal.Text + "')");
            liste_commende();
            vider();
            MessageBox.Show("effectuée");
        }

        private void bsupp_Click(object sender, EventArgs e)
        {
            if (toperation.Text == "")
            {
                MessageBox.Show("donner non valide ");
                return;
            }
            if (Form1.con.execute_valeur("select count(*) from Lign_operation where id_operation = '" + toperation.Text + "'") != "0")
            {
                MessageBox.Show(" inpossible  cette operation a des lign_operation");
                return;
            }
            if (MessageBox.Show("supprimer", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("suppression annuler ");
                return;
            }
            Form1.con.execut_query("delete from Operation where id_operation = " + toperation.Text);
            liste_commende();
            vider();
            MessageBox.Show("effectuer");
        }

        private void bmodif_Click(object sender, EventArgs e)
        {
            if (toperation.Text == "" || tdate.Text == "" || cclient.Text == "" || cproduit.Text == "" || cpaiement.Text == "" || tqte.Text == "")
            {
                MessageBox.Show("danner non valide ");
                return;
            }
            Form1.con.execut_query("update Operation set date_operation='" + tdate.Text + "',id_personne='" + cclient.Text + "',id_paiement='" + cpaiement.Text + "' where id_operation = " + toperation.Text);
            Form1.con.execut_query("update Lign_operation set id_produit='" + cproduit.Text + "',qte_operation='" + tqte.Text + "',prix='" + ttotal.Text + "'where id_operation =" + toperation.Text);
            liste_commende();
            vider();
            MessageBox.Show("effectuee");
        }

        private void toperation_Leave(object sender, EventArgs e)
        {
            if (toperation.Text != "")
            {
                if (Form1.con.execute_valeur("select count(*) from vue_vents where id_operation = '" + toperation.Text + "'") == "0")
                {
                    bajout.Enabled = true;
                    bsupp.Enabled = false;
                    bmodif.Enabled = false;
                    bimpri.Enabled = false;
                    tdate.Select();
                }
                else
                {
                    Form1.con.list_deconnecter("select date_operation,id_personne,id_produit,id_paiement,qte_operation,prix from vue_commende where id_operation =" + toperation.Text);
                    tdate.Text = Form1.con.t.Rows[0][0].ToString();
                    cclient.Text = Form1.con.t.Rows[0][1].ToString();
                    cproduit.Text = Form1.con.t.Rows[0][2].ToString();
                    cpaiement.Text = Form1.con.t.Rows[0][3].ToString();
                    tqte.Text = Form1.con.t.Rows[0][4].ToString();
                    ttotal.Text = Form1.con.t.Rows[0][5].ToString();
                    bajout.Enabled = false;
                    bsupp.Enabled = true;
                    bmodif.Enabled = true;
                    bimpri.Enabled = true;

                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bimpri_Click(object sender, EventArgs e)
        {
            new Etat_commende().Show(); 
        }
    }
}
