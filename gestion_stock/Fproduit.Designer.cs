namespace gestion_stock
{
    partial class Fproduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fproduit));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bsupp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bmodif = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bimpri = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bajout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.trech = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tproduit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tdesign = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tachat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tvent = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tstock = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(112, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(112, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(112, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ptix Achats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(112, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prix Vents";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(64, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rechercher par Id_produit";
            // 
            // liste
            // 
            this.liste.AllowUserToAddRows = false;
            this.liste.AllowUserToDeleteRows = false;
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.liste.Location = new System.Drawing.Point(34, 374);
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.Size = new System.Drawing.Size(805, 131);
            this.liste.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_produit";
            this.Column1.HeaderText = "Id_produit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "designation";
            this.Column2.HeaderText = "Designation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "prix_achats";
            this.Column3.HeaderText = "Prix achats";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "prix_vents";
            this.Column4.HeaderText = "Prix vents";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "stock";
            this.Column5.HeaderText = "Stock";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(112, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Stock";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 32);
            this.panel1.TabIndex = 23;
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
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Aqua;
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
            // bsupp
            // 
            this.bsupp.ActiveBorderThickness = 1;
            this.bsupp.ActiveCornerRadius = 20;
            this.bsupp.ActiveFillColor = System.Drawing.Color.Aqua;
            this.bsupp.ActiveForecolor = System.Drawing.Color.White;
            this.bsupp.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bsupp.BackColor = System.Drawing.SystemColors.Control;
            this.bsupp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bsupp.BackgroundImage")));
            this.bsupp.ButtonText = "Supprimer";
            this.bsupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsupp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsupp.ForeColor = System.Drawing.Color.Aqua;
            this.bsupp.IdleBorderThickness = 1;
            this.bsupp.IdleCornerRadius = 20;
            this.bsupp.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bsupp.IdleForecolor = System.Drawing.Color.Aqua;
            this.bsupp.IdleLineColor = System.Drawing.Color.Aqua;
            this.bsupp.Location = new System.Drawing.Point(640, 132);
            this.bsupp.Margin = new System.Windows.Forms.Padding(4);
            this.bsupp.Name = "bsupp";
            this.bsupp.Size = new System.Drawing.Size(186, 41);
            this.bsupp.TabIndex = 44;
            this.bsupp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bsupp.Click += new System.EventHandler(this.bsuppr_Click);
            // 
            // bmodif
            // 
            this.bmodif.ActiveBorderThickness = 1;
            this.bmodif.ActiveCornerRadius = 20;
            this.bmodif.ActiveFillColor = System.Drawing.Color.Aqua;
            this.bmodif.ActiveForecolor = System.Drawing.Color.White;
            this.bmodif.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bmodif.BackColor = System.Drawing.SystemColors.Control;
            this.bmodif.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bmodif.BackgroundImage")));
            this.bmodif.ButtonText = "Modifier";
            this.bmodif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmodif.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodif.ForeColor = System.Drawing.Color.Aqua;
            this.bmodif.IdleBorderThickness = 1;
            this.bmodif.IdleCornerRadius = 20;
            this.bmodif.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bmodif.IdleForecolor = System.Drawing.Color.Aqua;
            this.bmodif.IdleLineColor = System.Drawing.Color.Aqua;
            this.bmodif.Location = new System.Drawing.Point(640, 175);
            this.bmodif.Margin = new System.Windows.Forms.Padding(4);
            this.bmodif.Name = "bmodif";
            this.bmodif.Size = new System.Drawing.Size(186, 41);
            this.bmodif.TabIndex = 43;
            this.bmodif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bmodif.Click += new System.EventHandler(this.bmodifi_Click);
            // 
            // bimpri
            // 
            this.bimpri.ActiveBorderThickness = 1;
            this.bimpri.ActiveCornerRadius = 20;
            this.bimpri.ActiveFillColor = System.Drawing.Color.Aqua;
            this.bimpri.ActiveForecolor = System.Drawing.Color.White;
            this.bimpri.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bimpri.BackColor = System.Drawing.SystemColors.Control;
            this.bimpri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bimpri.BackgroundImage")));
            this.bimpri.ButtonText = "Imprimer";
            this.bimpri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bimpri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bimpri.ForeColor = System.Drawing.Color.Aqua;
            this.bimpri.IdleBorderThickness = 1;
            this.bimpri.IdleCornerRadius = 20;
            this.bimpri.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bimpri.IdleForecolor = System.Drawing.Color.Aqua;
            this.bimpri.IdleLineColor = System.Drawing.Color.Aqua;
            this.bimpri.Location = new System.Drawing.Point(640, 224);
            this.bimpri.Margin = new System.Windows.Forms.Padding(4);
            this.bimpri.Name = "bimpri";
            this.bimpri.Size = new System.Drawing.Size(186, 41);
            this.bimpri.TabIndex = 42;
            this.bimpri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bimpri.Click += new System.EventHandler(this.bimprimer_Click);
            // 
            // bajout
            // 
            this.bajout.ActiveBorderThickness = 1;
            this.bajout.ActiveCornerRadius = 20;
            this.bajout.ActiveFillColor = System.Drawing.Color.Aqua;
            this.bajout.ActiveForecolor = System.Drawing.Color.White;
            this.bajout.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bajout.BackColor = System.Drawing.SystemColors.Control;
            this.bajout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bajout.BackgroundImage")));
            this.bajout.ButtonText = "Ajouter";
            this.bajout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bajout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajout.ForeColor = System.Drawing.Color.Aqua;
            this.bajout.IdleBorderThickness = 1;
            this.bajout.IdleCornerRadius = 20;
            this.bajout.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bajout.IdleForecolor = System.Drawing.Color.Aqua;
            this.bajout.IdleLineColor = System.Drawing.Color.Aqua;
            this.bajout.Location = new System.Drawing.Point(640, 85);
            this.bajout.Margin = new System.Windows.Forms.Padding(4);
            this.bajout.Name = "bajout";
            this.bajout.Size = new System.Drawing.Size(186, 41);
            this.bajout.TabIndex = 41;
            this.bajout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bajout.Click += new System.EventHandler(this.bajou_Click);
            // 
            // trech
            // 
            this.trech.BorderColorFocused = System.Drawing.Color.Aqua;
            this.trech.BorderColorIdle = System.Drawing.Color.Aqua;
            this.trech.BorderColorMouseHover = System.Drawing.Color.Aqua;
            this.trech.BorderThickness = 3;
            this.trech.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trech.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.trech.ForeColor = System.Drawing.Color.Aqua;
            this.trech.isPassword = false;
            this.trech.Location = new System.Drawing.Point(286, 337);
            this.trech.Margin = new System.Windows.Forms.Padding(4);
            this.trech.Name = "trech";
            this.trech.Size = new System.Drawing.Size(264, 25);
            this.trech.TabIndex = 46;
            this.trech.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Rechercher";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Aqua;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton22.Location = new System.Drawing.Point(570, 321);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(186, 41);
            this.bunifuThinButton22.TabIndex = 45;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // tproduit
            // 
            this.tproduit.BorderColorFocused = System.Drawing.Color.Aqua;
            this.tproduit.BorderColorIdle = System.Drawing.Color.Aqua;
            this.tproduit.BorderColorMouseHover = System.Drawing.Color.Aqua;
            this.tproduit.BorderThickness = 3;
            this.tproduit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tproduit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tproduit.ForeColor = System.Drawing.Color.Aqua;
            this.tproduit.isPassword = false;
            this.tproduit.Location = new System.Drawing.Point(224, 83);
            this.tproduit.Margin = new System.Windows.Forms.Padding(4);
            this.tproduit.Name = "tproduit";
            this.tproduit.Size = new System.Drawing.Size(264, 25);
            this.tproduit.TabIndex = 47;
            this.tproduit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tproduit.Leave += new System.EventHandler(this.bunifuMetroTextbox1_Leave);
            // 
            // tdesign
            // 
            this.tdesign.BorderColorFocused = System.Drawing.Color.Aqua;
            this.tdesign.BorderColorIdle = System.Drawing.Color.Aqua;
            this.tdesign.BorderColorMouseHover = System.Drawing.Color.Aqua;
            this.tdesign.BorderThickness = 3;
            this.tdesign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tdesign.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tdesign.ForeColor = System.Drawing.Color.Aqua;
            this.tdesign.isPassword = false;
            this.tdesign.Location = new System.Drawing.Point(224, 116);
            this.tdesign.Margin = new System.Windows.Forms.Padding(4);
            this.tdesign.Name = "tdesign";
            this.tdesign.Size = new System.Drawing.Size(264, 25);
            this.tdesign.TabIndex = 48;
            this.tdesign.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tachat
            // 
            this.tachat.BorderColorFocused = System.Drawing.Color.Aqua;
            this.tachat.BorderColorIdle = System.Drawing.Color.Aqua;
            this.tachat.BorderColorMouseHover = System.Drawing.Color.Aqua;
            this.tachat.BorderThickness = 3;
            this.tachat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tachat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tachat.ForeColor = System.Drawing.Color.Aqua;
            this.tachat.isPassword = false;
            this.tachat.Location = new System.Drawing.Point(224, 149);
            this.tachat.Margin = new System.Windows.Forms.Padding(4);
            this.tachat.Name = "tachat";
            this.tachat.Size = new System.Drawing.Size(264, 25);
            this.tachat.TabIndex = 49;
            this.tachat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tvent
            // 
            this.tvent.BorderColorFocused = System.Drawing.Color.Aqua;
            this.tvent.BorderColorIdle = System.Drawing.Color.Aqua;
            this.tvent.BorderColorMouseHover = System.Drawing.Color.Aqua;
            this.tvent.BorderThickness = 3;
            this.tvent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tvent.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tvent.ForeColor = System.Drawing.Color.Aqua;
            this.tvent.isPassword = false;
            this.tvent.Location = new System.Drawing.Point(224, 182);
            this.tvent.Margin = new System.Windows.Forms.Padding(4);
            this.tvent.Name = "tvent";
            this.tvent.Size = new System.Drawing.Size(264, 25);
            this.tvent.TabIndex = 50;
            this.tvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tstock
            // 
            this.tstock.BorderColorFocused = System.Drawing.Color.Aqua;
            this.tstock.BorderColorIdle = System.Drawing.Color.Aqua;
            this.tstock.BorderColorMouseHover = System.Drawing.Color.Aqua;
            this.tstock.BorderThickness = 3;
            this.tstock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tstock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tstock.ForeColor = System.Drawing.Color.Aqua;
            this.tstock.isPassword = false;
            this.tstock.Location = new System.Drawing.Point(224, 217);
            this.tstock.Margin = new System.Windows.Forms.Padding(4);
            this.tstock.Name = "tstock";
            this.tstock.Size = new System.Drawing.Size(264, 25);
            this.tstock.TabIndex = 51;
            this.tstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Sortir";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Aqua;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Aqua;
            this.bunifuThinButton21.Location = new System.Drawing.Point(640, 526);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(186, 41);
            this.bunifuThinButton21.TabIndex = 52;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Fproduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(851, 570);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.tstock);
            this.Controls.Add(this.tvent);
            this.Controls.Add(this.tachat);
            this.Controls.Add(this.tdesign);
            this.Controls.Add(this.tproduit);
            this.Controls.Add(this.trech);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bsupp);
            this.Controls.Add(this.bmodif);
            this.Controls.Add(this.bimpri);
            this.Controls.Add(this.bajout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fproduit";
            this.Text = "Fproduit";
            this.Load += new System.EventHandler(this.Fproduit_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 bsupp;
        private Bunifu.Framework.UI.BunifuThinButton2 bmodif;
        private Bunifu.Framework.UI.BunifuThinButton2 bimpri;
        private Bunifu.Framework.UI.BunifuThinButton2 bajout;
        private Bunifu.Framework.UI.BunifuMetroTextbox trech;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuMetroTextbox tproduit;
        private Bunifu.Framework.UI.BunifuMetroTextbox tstock;
        private Bunifu.Framework.UI.BunifuMetroTextbox tvent;
        private Bunifu.Framework.UI.BunifuMetroTextbox tachat;
        private Bunifu.Framework.UI.BunifuMetroTextbox tdesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}