namespace gestion_stock
{
    partial class Fpaiement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fpaiement));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bsupp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bmodif = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bajout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tpaiement = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ttype = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(68, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_paiement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(85, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // liste
            // 
            this.liste.AllowUserToAddRows = false;
            this.liste.AllowUserToDeleteRows = false;
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.liste.GridColor = System.Drawing.Color.Magenta;
            this.liste.Location = new System.Drawing.Point(125, 261);
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.Size = new System.Drawing.Size(643, 101);
            this.liste.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_paiement";
            this.Column1.HeaderText = "Id_paiement";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "type_paiement";
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bsupp
            // 
            this.bsupp.ActiveBorderThickness = 1;
            this.bsupp.ActiveCornerRadius = 20;
            this.bsupp.ActiveFillColor = System.Drawing.Color.Magenta;
            this.bsupp.ActiveForecolor = System.Drawing.Color.White;
            this.bsupp.ActiveLineColor = System.Drawing.Color.Magenta;
            this.bsupp.BackColor = System.Drawing.SystemColors.Control;
            this.bsupp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bsupp.BackgroundImage")));
            this.bsupp.ButtonText = "Supprimer";
            this.bsupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsupp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsupp.ForeColor = System.Drawing.Color.Magenta;
            this.bsupp.IdleBorderThickness = 1;
            this.bsupp.IdleCornerRadius = 20;
            this.bsupp.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bsupp.IdleForecolor = System.Drawing.Color.Magenta;
            this.bsupp.IdleLineColor = System.Drawing.Color.Magenta;
            this.bsupp.Location = new System.Drawing.Point(634, 131);
            this.bsupp.Margin = new System.Windows.Forms.Padding(4);
            this.bsupp.Name = "bsupp";
            this.bsupp.Size = new System.Drawing.Size(186, 41);
            this.bsupp.TabIndex = 44;
            this.bsupp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bsupp.Click += new System.EventHandler(this.bsupp_Click_1);
            // 
            // bmodif
            // 
            this.bmodif.ActiveBorderThickness = 1;
            this.bmodif.ActiveCornerRadius = 20;
            this.bmodif.ActiveFillColor = System.Drawing.Color.Magenta;
            this.bmodif.ActiveForecolor = System.Drawing.Color.White;
            this.bmodif.ActiveLineColor = System.Drawing.Color.Magenta;
            this.bmodif.BackColor = System.Drawing.SystemColors.Control;
            this.bmodif.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bmodif.BackgroundImage")));
            this.bmodif.ButtonText = "Modifier";
            this.bmodif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmodif.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodif.ForeColor = System.Drawing.Color.Magenta;
            this.bmodif.IdleBorderThickness = 1;
            this.bmodif.IdleCornerRadius = 20;
            this.bmodif.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bmodif.IdleForecolor = System.Drawing.Color.Magenta;
            this.bmodif.IdleLineColor = System.Drawing.Color.Magenta;
            this.bmodif.Location = new System.Drawing.Point(634, 174);
            this.bmodif.Margin = new System.Windows.Forms.Padding(4);
            this.bmodif.Name = "bmodif";
            this.bmodif.Size = new System.Drawing.Size(186, 41);
            this.bmodif.TabIndex = 43;
            this.bmodif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bmodif.Click += new System.EventHandler(this.bmodif_Click_1);
            // 
            // bajout
            // 
            this.bajout.ActiveBorderThickness = 1;
            this.bajout.ActiveCornerRadius = 20;
            this.bajout.ActiveFillColor = System.Drawing.Color.Magenta;
            this.bajout.ActiveForecolor = System.Drawing.Color.White;
            this.bajout.ActiveLineColor = System.Drawing.Color.Magenta;
            this.bajout.BackColor = System.Drawing.SystemColors.Control;
            this.bajout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bajout.BackgroundImage")));
            this.bajout.ButtonText = "Ajouter";
            this.bajout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bajout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajout.ForeColor = System.Drawing.Color.Magenta;
            this.bajout.IdleBorderThickness = 1;
            this.bajout.IdleCornerRadius = 20;
            this.bajout.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bajout.IdleForecolor = System.Drawing.Color.Magenta;
            this.bajout.IdleLineColor = System.Drawing.Color.Magenta;
            this.bajout.Location = new System.Drawing.Point(634, 95);
            this.bajout.Margin = new System.Windows.Forms.Padding(4);
            this.bajout.Name = "bajout";
            this.bajout.Size = new System.Drawing.Size(186, 41);
            this.bajout.TabIndex = 41;
            this.bajout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bajout.Click += new System.EventHandler(this.bajout_Click_1);
            // 
            // tpaiement
            // 
            this.tpaiement.BorderColorFocused = System.Drawing.Color.Magenta;
            this.tpaiement.BorderColorIdle = System.Drawing.Color.Magenta;
            this.tpaiement.BorderColorMouseHover = System.Drawing.Color.Magenta;
            this.tpaiement.BorderThickness = 3;
            this.tpaiement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tpaiement.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tpaiement.ForeColor = System.Drawing.Color.Magenta;
            this.tpaiement.isPassword = false;
            this.tpaiement.Location = new System.Drawing.Point(199, 117);
            this.tpaiement.Margin = new System.Windows.Forms.Padding(4);
            this.tpaiement.Name = "tpaiement";
            this.tpaiement.Size = new System.Drawing.Size(264, 25);
            this.tpaiement.TabIndex = 45;
            this.tpaiement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tpaiement.Leave += new System.EventHandler(this.tpaiement_Leave_1);
            // 
            // ttype
            // 
            this.ttype.BorderColorFocused = System.Drawing.Color.Magenta;
            this.ttype.BorderColorIdle = System.Drawing.Color.Magenta;
            this.ttype.BorderColorMouseHover = System.Drawing.Color.Magenta;
            this.ttype.BorderThickness = 3;
            this.ttype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ttype.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ttype.ForeColor = System.Drawing.Color.Magenta;
            this.ttype.isPassword = false;
            this.ttype.Location = new System.Drawing.Point(199, 178);
            this.ttype.Margin = new System.Windows.Forms.Padding(4);
            this.ttype.Name = "ttype";
            this.ttype.Size = new System.Drawing.Size(264, 25);
            this.ttype.TabIndex = 46;
            this.ttype.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Magenta;
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 32);
            this.panel1.TabIndex = 48;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 13);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(137, 15);
            this.bunifuCustomLabel3.TabIndex = 28;
            this.bunifuCustomLabel3.Text = "Gestion De Stock";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Magenta;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(164, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(61, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 27;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // Fpaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ttype);
            this.Controls.Add(this.tpaiement);
            this.Controls.Add(this.bsupp);
            this.Controls.Add(this.bmodif);
            this.Controls.Add(this.bajout);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fpaiement";
            this.Text = "Fpaiement";
            this.Load += new System.EventHandler(this.Fpaiement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bsupp;
        private Bunifu.Framework.UI.BunifuThinButton2 bmodif;
        private Bunifu.Framework.UI.BunifuThinButton2 bajout;
        private Bunifu.Framework.UI.BunifuMetroTextbox ttype;
        private Bunifu.Framework.UI.BunifuMetroTextbox tpaiement;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}