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
    public partial class Fpersonne : Form
    {
        public Fpersonne()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void liste_personne()
        {
            Form1.con.list_deconnecter("select * from Personne");
            liste.DataSource = Form1.con.t;
        }
        private void Fpersonne_Load(object sender, EventArgs e)
        {
            ctype.AddItem("client");
            ctype.AddItem("fournisseur");
            liste_personne();
            

        }
        public void vider()
        {
            tid.Text = "";
            ctype.Text = "";
            tcin.Text = "";
            tnom.Text = "";
            tprenom.Text = "";
            tadresse.Text = "";
            tid.Select();
        }
        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text != "")
            {
                if (Form1.con.execute_valeur("select count(*) from Personne where id_personne= "+tid.Text+"") == "0")
                 {
                    bajou.Enabled = true;
                    bsuppr.Enabled = false;
                    bmodifi.Enabled = false;
                    bimprimer.Enabled = false;
                    ctype.Select();
                 }
                else
                    {
                        Form1.con.list_deconnecter("select * from Personne where id_personne= "+tid.Text+"");
                        bajou.Enabled = false;
                        bsuppr.Enabled = true;
                        bmodifi.Enabled = true;
                        bimprimer.Enabled = true;
                        ctype.Text = Form1.con.t.Rows[0][1].ToString();
                        tcin.Text =Form1.con.t.Rows[0][2].ToString ();
                        tnom.Text =Form1.con.t.Rows[0][3].ToString();
                        tprenom.Text =Form1.con.t.Rows[0][4].ToString();
                        tadresse.Text = Form1.con.t.Rows[0][5].ToString(); 
                    }
            }
        }

        private void bajout_Click(object sender, EventArgs e)
        {
            if (tid.Text == "" || ctype.Text == "" || tcin.Text == "" || tnom.Text == "" || tprenom.Text == "" || tadresse.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.execut_query("insert into Personne values('" + tid.Text + "','" + ctype.Text + "','" + tcin.Text + "','" + tnom.Text + "','" + tprenom.Text + "','" + tadresse.Text + "')");
            liste_personne();
            MessageBox.Show("ajout effectuer");
            vider();

        }

        private void bsuppr_Click(object sender, EventArgs e)
        {
            if (tid.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            if (Form1.con.execute_valeur("select count(*)  from Operation where id_personne= '" + tid.Text + "'") != "0") 
            {
                MessageBox.Show("impossible ce personne a des Operation");
                return;
            }
           
               if( MessageBox.Show("supprimer !!!","seppression",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
               {
                   MessageBox.Show("suppression annulée");
                   return;
               }
                Form1.con.execut_query("delete from Personne where id_personne= "+tid.Text);
                MessageBox.Show("effectué");
                liste_personne();
                vider();
            }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (trech.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.list_deconnecter("select * from Personne where id_personne= " + trech.Text);
            liste.DataSource = Form1.con.t;
        }

        private void bmodifi_Click(object sender, EventArgs e)
        {
            if (tid.Text == "" || ctype.Text == "" || tcin.Text == "" || tnom.Text == "" || tprenom.Text == "" || tadresse.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.execut_query("update Personne set type_personne= '" + ctype.Text + "',cin= '" + tcin.Text + "',nom= '" + tnom.Text + "',prenom= '" + tprenom.Text + "',adresse= '" + tadresse.Text + "' where id_personne= " + tid.Text);
            MessageBox.Show("modification effectuee");
            liste_personne();
            vider();
        }

        private void bimprimer_Click(object sender, EventArgs e)
        {
            Fetat f = new Fetat();
           
            f.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (tid.Text == "" || ctype.Text == "" || tcin.Text == "" || tnom.Text == "" || tprenom.Text == "" || tadresse.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.execut_query("insert into Personne values('" + tid.Text + "','" + ctype.Text + "','" + tcin.Text + "','" + tnom.Text + "','" + tprenom.Text + "','" + tadresse.Text + "')");
            liste_personne();
            MessageBox.Show("ajout effectuer");
            vider();
        }

        private void bsuppr_Click_1(object sender, EventArgs e)
        {
            if (tid.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            if (Form1.con.execute_valeur("select count(*)  from Operation where id_personne= '" + tid.Text + "'") != "0") 
            {
                MessageBox.Show("impossible ce personne a des Operation");
                return;
            }
           
               if( MessageBox.Show("supprimer !!!","seppression",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
               {
                   MessageBox.Show("suppression annulée");
                   return;
               }
                Form1.con.execut_query("delete from Personne where id_personne= "+tid.Text);
                MessageBox.Show("effectué");
                liste_personne();
                vider();
            }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (trech.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.list_deconnecter("select * from Personne where id_personne= " + trech.Text);
            liste.DataSource = Form1.con.t;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bmodifi_Click_1(object sender, EventArgs e)
        {
            if (tid.Text == "" || ctype.Text == "" || tcin.Text == "" || tnom.Text == "" || tprenom.Text == "" || tadresse.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.execut_query("update Personne set type_personne= '" + ctype.Text + "',cin= '" + tcin.Text + "',nom= '" + tnom.Text + "',prenom= '" + tprenom.Text + "',adresse= '" + tadresse.Text + "' where id_personne= " + tid.Text);
            MessageBox.Show("modification effectuee");
            liste_personne();
            vider();
        }

        private void bimprimer_Click_1(object sender, EventArgs e)
        {
            Fetat f = new Fetat();

            f.Show();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            if (trech.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.list_deconnecter("select * from Personne where id_personne= " + trech.Text);
            liste.DataSource = Form1.con.t;
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            if (tid.Text != "")
            {
                if (Form1.con.execute_valeur("select count(*) from Personne where id_personne= " + tid.Text + "") == "0")
                {
                    bajou.Enabled = true;
                    bsuppr.Enabled = false;
                    bmodifi.Enabled = false;
                    bimprimer.Enabled = false;
                    ctype.Select();
                }
                else
                {
                    Form1.con.list_deconnecter("select * from Personne where id_personne= " + tid.Text + "");
                    bajou.Enabled = false;
                    bsuppr.Enabled = true;
                    bmodifi.Enabled = true;
                    bimprimer.Enabled = true;
                    ctype.Text = Form1.con.t.Rows[0][1].ToString();
                    tcin.Text = Form1.con.t.Rows[0][2].ToString();
                    tnom.Text = Form1.con.t.Rows[0][3].ToString();
                    tprenom.Text = Form1.con.t.Rows[0][4].ToString();
                    tadresse.Text = Form1.con.t.Rows[0][5].ToString();
                }
            }
        }

        private void ctype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ctype_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bajou_Click(object sender, EventArgs e)
        {
            if (tid.Text == ""  || tcin.Text == "" || tnom.Text == "" || tprenom.Text == "" || tadresse.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.execut_query("insert into Personne values('" + tid.Text + "','" + ctype.selectedValue + "','" + tcin.Text + "','" + tnom.Text + "','" + tprenom.Text + "','" + tadresse.Text + "')");
            liste_personne();
            MessageBox.Show("ajout effectuer");
            vider();
        }

        private void bsuppr_Click_2(object sender, EventArgs e)
        {
            if (tid.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            if (Form1.con.execute_valeur("select count(*)  from Operation where id_personne= '" + tid.Text + "'") != "0")
            {
                MessageBox.Show("impossible ce personne a des Operation");
                return;
            }

            if (MessageBox.Show("supprimer !!!", "seppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("suppression annulée");
                return;
            }
            Form1.con.execut_query("delete from Personne where id_personne= " + tid.Text);
            MessageBox.Show("effectué");
            liste_personne();
            vider();
        }

        private void bmodifi_Click_2(object sender, EventArgs e)
        {

            if (tid.Text == "" || tcin.Text == "" || tnom.Text == "" || tprenom.Text == "" || tadresse.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.execut_query("update Personne set type_personne= '" + ctype.selectedValue + "',cin= '" + tcin.Text + "',nom= '" + tnom.Text + "',prenom= '" + tprenom.Text + "',adresse= '" + tadresse.Text + "' where id_personne= " + tid.Text);
            MessageBox.Show("modification effectuee");
            liste_personne();
            vider();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Fetat f = new Fetat();

            f.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (trech.Text == "")
            {
                MessageBox.Show("donner non valide");
                return;
            }
            Form1.con.list_deconnecter("select * from Personne where id_personne= " + trech.Text);
            liste.DataSource = Form1.con.t;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        }
    }

