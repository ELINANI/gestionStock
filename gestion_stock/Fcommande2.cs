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
    public partial class Fcommande2 : Form
    {
        public Fcommande2()
        {
            InitializeComponent();
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
            tqte_produit.Text = "";
            

        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(tqte_produit.Text == "" )
            {
                MessageBox.Show("qte non valide");
                return;
            }
            liste2.Rows.Add(cproduit.selectedValue, tqte_produit.Text);
        }

        private void cclient_Leave(object sender, EventArgs e)
        {
            Form1.con.list_deconnecter("select id_personne from Personne where nom = '" + cclient.selectedValue + "'");
            tid_clients.Text = Form1.con.t.Rows[0][0].ToString();
        }

        private void cproduit_Leave(object sender, EventArgs e)
        {

            Form1.con.list_deconnecter("select id_produit,prix_achats,prix_vents,stock from Produit where designation = '" + cproduit.selectedValue + "'");
            id_produit.Text = Form1.con.t.Rows[0][0].ToString();
            tachat.Text = Form1.con.t.Rows[0][1].ToString();
            tvents.Text = Form1.con.t.Rows[0][2].ToString();
            tstock.Text = Form1.con.t.Rows[0][3].ToString();
        }

        private void cpaiement_Leave(object sender, EventArgs e)
        {

            Form1.con.list_deconnecter("select id_paiement from Paiement where type_paiement= '" + cpaiement.selectedValue + "' ");
            tid_paiement.Text = Form1.con.t.Rows[0][0].ToString();
        }

        private void bmodif_Click(object sender, EventArgs e)
        {
            if (toperation.Text == "" || tdate.Text == "" || cclient.Text == "" || cproduit.Text == "" || cpaiement.Text == "" || tqte_produit.Text == "")
            {
                MessageBox.Show("danner non valide ");
                return;
            }
            double totale;
            totale = Convert.ToDouble(tvents.Text) * Convert.ToDouble(tqte_produit.Text);
            Form1.con.execut_query("update Operation set date_operation='" + tdate.Text + "',id_personne='" + cclient.Text + "',id_paiement='" + cpaiement.Text + "' where id_operation = " + toperation.Text);
            Form1.con.execut_query("update Lign_operation set id_produit='" + cproduit.Text + "',qte_operation='" + tqte_produit.Text + "',prix='" + totale + "'where id_operation =" + toperation.Text);
            liste_commende();
            vider();
            MessageBox.Show("effectuee");
        }
        public void liste_client()
        {
            Form1.con.list_deconnecter("select nom from Personne where type_personne = 'client'");
            for (int k = 0; k < Form1.con.t.Rows.Count; k++)
            {
                cclient.AddItem(Form1.con.t.Rows[k][0].ToString());
            }
        }
        public void liste_produit()
        {
            Form1.con.list_deconnecter("select designation from Produit ");
            for (int k = 0; k < Form1.con.t.Rows.Count; k++)
            {
                cproduit.AddItem(Form1.con.t.Rows[k][0].ToString());
            }
        }
        public void liste_paiement()
        {
            Form1.con.list_deconnecter("select type_paiement from Paiement");
            for (int k = 0; k < Form1.con.t.Rows.Count; k++)
            {
                cpaiement.AddItem(Form1.con.t.Rows[k][0].ToString());
            }
        }
        private void Fcommande2_Load(object sender, EventArgs e)
        {
            liste2.Rows.Clear();
            liste_commende();
            liste_client();
            liste_produit();
            liste_paiement();
            tdate.Text = DateTime.Today.Date.ToShortDateString();
        }

        private void toperation_Leave(object sender, EventArgs e)
        {
            if (toperation.Text != "")
            {
                if (Form1.con.execute_valeur("select count(*) from vue_commende where id_operation = '" + toperation.Text + "'") == "0")
                {
                    bajout.Enabled = true;
                    bsupp.Enabled = false;
                    bmodif.Enabled = false;
                    bimpri.Enabled = false;
                    tdate.Select();
                }
                else
                {
                    Form1.con.list_deconnecter("select date_operation,id_personne,id_produit,id_paiement,qte_operation,prix from vue_commende  where id_operation =" + toperation.Text);
                    tdate.Text = Form1.con.t.Rows[0][0].ToString();
                    cclient.Text = Form1.con.t.Rows[0][1].ToString();
                    cproduit.Text = Form1.con.t.Rows[0][2].ToString();
                    cpaiement.Text = Form1.con.t.Rows[0][3].ToString();
                    tqte_produit.Text = Form1.con.t.Rows[0][4].ToString();
                    bajout.Enabled = false;
                    bsupp.Enabled = true;
                    bmodif.Enabled = true;
                    bimpri.Enabled = true;

                }

            }
        }

        private void bimpri_Click(object sender, EventArgs e)
        {
            new Etat_commende().Show();
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

        private void bajout_Click(object sender, EventArgs e)
        {

            if (toperation.Text == "" || tdate.Text == "" || cclient.selectedValue == "" || cproduit.selectedValue == "" || cpaiement.selectedValue == "" || tqte_produit.Text == "")
            {
                MessageBox.Show("danner non valide ");
                return;
            }
            double prix_prd = 0;
            string qte;

            Form1.con.execut_query("insert into Operation Values('" + toperation.Text + "','" + ttype.Text + "','" + tdate.Text + "','" + tid_clients.Text + "','" + tid_paiement.Text + "')");
            for (int K = 0; K < liste2.Rows.Count; K++)
            {
                prix_prd = Convert.ToDouble(tvents.Text) * Convert.ToDouble(liste2.Rows[K].Cells[1].Value);
                qte = liste2.Rows[K].Cells[1].Value.ToString();
                Form1.con.execut_query("insert into Lign_operation values('" + toperation.Text + "','" + id_produit.Text + "','" + qte + "','" + prix_prd.ToString() + "')");
                prix_prd = 0;
            }
            liste_commende();
            vider();
            MessageBox.Show("effectuée");
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
