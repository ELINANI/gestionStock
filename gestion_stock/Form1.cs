using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace gestion_stock
{
    public partial class Form1 : Form
    {
        public static Connexion con;
        public static SqlConnection fcon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void tnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tnom_Click(object sender, EventArgs e)
        {
            tnom.Text = "";
            
        }

        private void tpass_Click(object sender, EventArgs e)
        {
            
        }

        private void tpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpass_Click_1(object sender, EventArgs e)
        {
            tpass.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tnom.Text == "" || tpass.Text == "")
            {
                MessageBox.Show("erruere donner non valide");
                return;
            }
            con = new Connexion(tnom.Text, tpass.Text);
            if (con.connecter() == true)
            {
                new Fmenu().Show();

            }
            else
            {
                MessageBox.Show("erreur de connecter");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tnom_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (tnom.Text == "" || tpass.Text == "")
            {
                MessageBox.Show("erruere donner non valide");
                return;
            }
            con = new Connexion(tnom.Text, tpass.Text);
            if (con.connecter() == true)
            {
                new Menu3().Show();

            }
            else
            {
                MessageBox.Show("erreur de connecter");
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous quitter l'appmication ?? ","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void tnom_Click_1(object sender, EventArgs e)
        {
            tnom.Text = "";
        }

        private void tpass_Click_2(object sender, EventArgs e)
        {
            tpass.Text = "";
            tpass.isPassword = true; 
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tpass_OnValueChanged(object sender, EventArgs e)
        {

        }

      
    }
}
