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
    public partial class Fachats : Form
    {
        public Fachats()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Fproduit().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Fpersonne().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Fpaiement().Show();

        }
        public void liste_fournisseur()
        {
            Form1.con.list_deconnecter("select nom from Personne where type_personne = 'fournisseur'");
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
        public void liste_achats()
        {
            Form1.con.list_deconnecter("select * from vue_achats");
            liste.DataSource = Form1.con.t;
        }
        private void Fachats_Load(object sender, EventArgs e)
        {
            liste2.Rows.Clear();
            liste_achats();
            liste_fournisseur();
            liste_produit();
            liste_paiement();
            tdate.Text = DateTime.Today.Date.ToShortDateString();
        }

       

        private void cproduit_Leave(object sender, EventArgs e)
        {
            

        }

        private void cpaiement_Leave(object sender, EventArgs e)
        {
            
        }

        //private void tqte_Leave(object sender, EventArgs e)
        //{
        //    double x = 0;
        //    try
        //    {

        //        x = Convert.ToDouble(tqte_produit.Text) * Convert.ToDouble(tachat.Text);

        //    }
        //    catch (Exception m)
        //    {
        //        MessageBox.Show(m.Message);
        //    }
        //    ttotal.Text = x.ToString();

        //}

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void vider()
        {
            toperation.Text = "";
            cclient.Text = "";
            cproduit.Text = "";
            cpaiement.Text = "";
            tqte_produit.Text = "";
            

        }
        private void bajout_Click_1(object sender, EventArgs e)
        {
            if (toperation.Text == "" || tdate.Text == "" || cclient.selectedValue == "" || cproduit.selectedValue == "" || cpaiement.selectedValue == "" ||  tqte_produit.Text == "")
            {
                MessageBox.Show("danner non valide ");
                return;
            }
            double prix_prd = 0;
            string qte;
            
            Form1.con.execut_query("insert into Operation Values('" + toperation.Text + "','" + ttype.Text + "','" + tdate.Text + "','" + tid_fournisseur.Text + "','" + tid_paiement.Text + "')");
            for (int K = 0; K < liste2.Rows.Count; K++)
            {
                prix_prd = Convert.ToDouble(tachat.Text) * Convert.ToDouble(liste2.Rows[K].Cells[1].Value);
                qte = liste2.Rows[K].Cells[1].Value.ToString();
                Form1.con.execut_query("insert into Lign_operation values('" + toperation.Text + "','" + id_produit.Text + "','" + qte + "','" + prix_prd.ToString() + "')");
                prix_prd = 0; 
            }
            liste_achats();
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
            liste_achats();
            vider();
            MessageBox.Show("effectuer");
        }

        private void bmodif_Click(object sender, EventArgs e)
        {
            if (toperation.Text == "" || tdate.Text == "" || cclient.Text == "" || cproduit.Text == "" || cpaiement.Text == "" || tqte_produit.Text == "")
            {
                MessageBox.Show("danner non valide ");
                return;
            }
            double totale;
            totale = Convert.ToDouble(tachat.Text) * Convert.ToDouble(tqte_produit.Text);
            Form1.con.execut_query("update Operation set date_operation='" + tdate.Text + "',id_personne='" + tid_fournisseur.Text + "',id_paiement='" + tid_paiement.Text + "' where id_operation = " + toperation.Text);
            Form1.con.execut_query("update Lign_operation set id_produit='" + id_produit.Text + "',qte_operation='" +  tqte_produit.Text + "',prix='" + totale + "'where id_operation =" + toperation.Text);
            liste_achats();
            vider();
            MessageBox.Show("effectuee");
        }

        private void toperation_Leave_1(object sender, EventArgs e)
        {

            if (Form1.con.execute_valeur("select count(*) from vue_achats where id_operation = '" + toperation.Text + "'") == "0")
            {
                bajout.Enabled = true;
                bsupp.Enabled = false;
                bmodif.Enabled = false;
                bimpri.Enabled = false;
                tdate.Select();
            }
            else
            {
                Form1.con.list_deconnecter("select date_operation,id_personne,id_produit,id_paiement,qte_operation,prix from vue_achats where id_operation =" + toperation.Text);
                tdate.Text = Form1.con.t.Rows[0][0].ToString();
                tid_fournisseur.Text = Form1.con.t.Rows[0][1].ToString();
                id_produit.Text = Form1.con.t.Rows[0][2].ToString();
                tid_paiement.Text = Form1.con.t.Rows[0][3].ToString();
                tqte_produit.Text = Form1.con.t.Rows[0][4].ToString();
               
                bajout.Enabled = false;
                bsupp.Enabled = true;
                bmodif.Enabled = true;
                bimpri.Enabled = true;

            }

        }

        private void bimpri_Click(object sender, EventArgs e)
        {
            new Etat_achats().Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (toperation.Text == "" || tdate.Text == "" || cclient.Text == "" || cproduit.Text == "" || cpaiement.Text == "" || tqte_produit.Text == "")
            {
                MessageBox.Show("danner non valide ");
                return;
            }
            Form1.con.execut_query("insert into Operation Values('" + toperation.Text + "','" + ttype.Text + "','" + tdate.Text + "','" + cclient.Text + "','" + cpaiement.Text + "')");
            Form1.con.execut_query("insert into Lign_operation values('" + toperation.Text + "','" + cproduit.Text + "','" + tqte_produit.Text + "','" + tachat.Text + "')");
            liste_achats();
            vider();
            MessageBox.Show("effectuée");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
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
            liste_achats();
            vider();
            MessageBox.Show("effectuer");
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (toperation.Text == "" || tdate.Text == "" || cclient.Text == "" || cproduit.Text == "" || cpaiement.Text == "" || tqte_produit.Text == "")
            {
                MessageBox.Show("danner non valide ");
                return;
            }
            Form1.con.execut_query("update Operation set date_operation='" + tdate.Text + "',id_personne='" + cclient.Text + "',id_paiement='" + cpaiement.Text + "' where id_operation = " + toperation.Text);
            Form1.con.execut_query("update Lign_operation set id_produit='" + cproduit.Text + "',qte_operation='" + tqte_produit.Text + "',prix='" + tachat.Text + "'where id_operation =" + toperation.Text);
            liste_achats();
            vider();
            MessageBox.Show("effectuee");
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            new Etat_achats().Show();
        }

        //private void tproduit_Leave(object sender, EventArgs e)
        //{
        //    if (Form1.con.execute_valeur("select count(*) from vue_achats where id_operation = '" + toperation.Text + "'") == "0")
        //    {
        //        bajout.Enabled = true;
        //        bsupp.Enabled = false;
        //        bmodif.Enabled = false;
        //        bimpri.Enabled = false;
        //        tdate.Select();
        //    }
        //    else
        //    {
        //        Form1.con.list_deconnecter("select date_operation,id_personne,id_produit,id_paiement,qte_operation,prix from vue_achats where id_operation =" + toperation.Text);
        //        tdate.Text = Form1.con.t.Rows[0][0].ToString();
        //        cclient.Text = Form1.con.t.Rows[0][1].ToString();
        //        cproduit.Text = Form1.con.t.Rows[0][2].ToString();
        //        cpaiement.Text = Form1.con.t.Rows[0][3].ToString();
        //        tqte.Text = Form1.con.t.Rows[0][4].ToString();
        //        ttotal.Text = Form1.con.t.Rows[0][5].ToString();
        //        bajout.Enabled = false;
        //        bsupp.Enabled = true;
        //        bmodif.Enabled = true;
        //        bimpri.Enabled = true;
        //    }
        //}

        private void cproduit_Leave_1(object sender, EventArgs e)
        {
            Form1.con.list_deconnecter("select id_produit,prix_achats from Produit where designation = '"+cproduit.selectedValue+"'");
            tachat.Text = Form1.con.t.Rows[0][1].ToString();
            id_produit.Text = Form1.con.t.Rows[0][0].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cpaiement_Leave_1(object sender, EventArgs e)
        {
            Form1.con.list_deconnecter("select id_paiement from Paiement where type_paiement = '"+cpaiement.selectedValue+"'");
            tid_paiement.Text = Form1.con.t.Rows[0][0].ToString();
        }

        private void cclient_Leave(object sender, EventArgs e)
        {
            Form1.con.list_deconnecter("select id_personne from Personne where nom = '" + cclient.selectedValue + "'");
            tid_fournisseur.Text = Form1.con.t.Rows[0][0].ToString();
        }

        private void liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            liste2.Rows.Add(cproduit.selectedValue , tqte_produit.Text);
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
        

       
       

       

    }
}

