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
    public partial class Fsauvegarde : Form
    {
        public Fsauvegarde()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void lise_unite()
        {
            Form1.con.list_deconnecter(" use master select name from sysdevices");
            for (int k=0;k<Form1.con.t.Rows.Count;k++)
            {
                cunite.AddItem(Form1.con.t.Rows[k][0].ToString());
            }
        }

        private void Fsauvegarde_Load(object sender, EventArgs e)
        {
            lise_unite();
        }

        private void tbase_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.con.execut_query(" use master backup database "+tbase.Text+" to "+cunite.Text);
            MessageBox.Show("sauvegarde bien fait");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Funite().Show();
            
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bajou_Click(object sender, EventArgs e)
        {
            Form1.con.execut_query(" use master backup database  " +  tbase.Text + "   to   " +  cunite.Text );
            MessageBox.Show("sauvegarde bien fait");
        }
    }
}
