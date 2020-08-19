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
    public partial class Menu3 : Form
    {
        public Menu3()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            new Fpersonne().Show();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            new Finventaire().Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            new Fproduit().Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            new Fpaiement().Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            new Fachats().Show();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            new Fvents2().Show();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            new Fcommande2().Show();
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            new Frecette().Show();
        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            new Fsauvegarde().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Fpv().Show();
        }
    }
}
