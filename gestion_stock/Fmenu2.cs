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
    public partial class Fmenu2 : Form
    {
        public Fmenu2()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            new Fvents2().Show();
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           new Fpersonne().Show();
                 
           
            

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            new Fpaiement().Show();
            
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            new Fsauvegarde().Show();
          
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            new Fproduit().Show();
           
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            new Fachats().Show();
            
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            new Fcommande2().Show();
         
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            new Finventaire().Show();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            new Frecette().Show();
        }

        private void Fmenu2_Load(object sender, EventArgs e)
        {

        }
    }
}
