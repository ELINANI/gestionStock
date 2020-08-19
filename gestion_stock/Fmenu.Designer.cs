namespace gestion_stock
{
    partial class Fmenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmenu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clientFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paiementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvgarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientFournisseurToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.achatsToolStripMenuItem,
            this.ventsToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.paiementToolStripMenuItem,
            this.sauvgarderToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(860, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // clientFournisseurToolStripMenuItem
            // 
            this.clientFournisseurToolStripMenuItem.Name = "clientFournisseurToolStripMenuItem";
            this.clientFournisseurToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.clientFournisseurToolStripMenuItem.Text = "Client/Fournisseur";
            this.clientFournisseurToolStripMenuItem.Click += new System.EventHandler(this.clientFournisseurToolStripMenuItem_Click);
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.produitToolStripMenuItem.Text = "Produit";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // achatsToolStripMenuItem
            // 
            this.achatsToolStripMenuItem.Name = "achatsToolStripMenuItem";
            this.achatsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.achatsToolStripMenuItem.Text = "Achats";
            this.achatsToolStripMenuItem.Click += new System.EventHandler(this.achatsToolStripMenuItem_Click);
            // 
            // ventsToolStripMenuItem
            // 
            this.ventsToolStripMenuItem.Name = "ventsToolStripMenuItem";
            this.ventsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ventsToolStripMenuItem.Text = "Vents";
            this.ventsToolStripMenuItem.Click += new System.EventHandler(this.ventsToolStripMenuItem_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.commandeToolStripMenuItem.Text = "Commande";
            this.commandeToolStripMenuItem.Click += new System.EventHandler(this.commandeToolStripMenuItem_Click);
            // 
            // paiementToolStripMenuItem
            // 
            this.paiementToolStripMenuItem.Name = "paiementToolStripMenuItem";
            this.paiementToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.paiementToolStripMenuItem.Text = "Paiement";
            this.paiementToolStripMenuItem.Click += new System.EventHandler(this.paiementToolStripMenuItem_Click);
            // 
            // sauvgarderToolStripMenuItem
            // 
            this.sauvgarderToolStripMenuItem.Name = "sauvgarderToolStripMenuItem";
            this.sauvgarderToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.sauvgarderToolStripMenuItem.Text = "Sauvgarder";
            this.sauvgarderToolStripMenuItem.Click += new System.EventHandler(this.sauvgarderToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // Fmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 605);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Fmenu";
            this.Text = "Fmenu";
            this.Load += new System.EventHandler(this.Fmenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem clientFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem achatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paiementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvgarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
    }
}



