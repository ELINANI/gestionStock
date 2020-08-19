namespace gestion_stock
{
    partial class Fachats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fachats));
            this.liste = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toperation = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ttype = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tdate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tachat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cclient = new Bunifu.Framework.UI.BunifuDropdown();
            this.cpaiement = new Bunifu.Framework.UI.BunifuDropdown();
            this.cproduit = new Bunifu.Framework.UI.BunifuDropdown();
            this.tid_paiement = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.tid_fournisseur = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.id_produit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.liste2 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tqte_produit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bsupp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bmodif = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bimpri = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bajout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liste2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.AllowUserToAddRows = false;
            this.liste.AllowUserToDeleteRows = false;
            this.liste.BackgroundColor = System.Drawing.SystemColors.Control;
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.liste.GridColor = System.Drawing.Color.Coral;
            this.liste.Location = new System.Drawing.Point(81, 542);
            this.liste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.Size = new System.Drawing.Size(843, 162);
            this.liste.TabIndex = 84;
            this.liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.liste_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_operation";
            this.Column1.HeaderText = "Id_operation";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "type";
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date_operation";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "id_personne";
            this.Column4.HeaderText = "ID_fournisseur";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id_produit";
            this.Column5.HeaderText = "Id_produit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "id_paiement";
            this.Column6.HeaderText = "Id_paiement";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "qte_operation";
            this.Column7.HeaderText = "Qte";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "prix";
            this.Column8.HeaderText = "Total";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(166, 370);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 14);
            this.label9.TabIndex = 72;
            this.label9.Text = "Prix_achat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Coral;
            this.label15.Location = new System.Drawing.Point(104, 412);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 14);
            this.label15.TabIndex = 87;
            this.label15.Text = "Paiement";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(104, 263);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 14);
            this.label10.TabIndex = 70;
            this.label10.Text = "Produit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(104, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 14);
            this.label5.TabIndex = 64;
            this.label5.Text = "Fournissseur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(104, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 57;
            this.label4.Text = "Date ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(104, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 55;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(104, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 53;
            this.label2.Text = "Id_operation";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 32);
            this.panel1.TabIndex = 90;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Coral;
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // toperation
            // 
            this.toperation.BackColor = System.Drawing.SystemColors.Control;
            this.toperation.BorderColorFocused = System.Drawing.Color.Coral;
            this.toperation.BorderColorIdle = System.Drawing.Color.Coral;
            this.toperation.BorderColorMouseHover = System.Drawing.Color.Coral;
            this.toperation.BorderThickness = 3;
            this.toperation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.toperation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.toperation.ForeColor = System.Drawing.Color.Tomato;
            this.toperation.isPassword = false;
            this.toperation.Location = new System.Drawing.Point(269, 77);
            this.toperation.Margin = new System.Windows.Forms.Padding(4);
            this.toperation.Name = "toperation";
            this.toperation.Size = new System.Drawing.Size(281, 25);
            this.toperation.TabIndex = 95;
            this.toperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toperation.Leave += new System.EventHandler(this.toperation_Leave_1);
            // 
            // ttype
            // 
            this.ttype.BorderColorFocused = System.Drawing.Color.Coral;
            this.ttype.BorderColorIdle = System.Drawing.Color.Coral;
            this.ttype.BorderColorMouseHover = System.Drawing.Color.Coral;
            this.ttype.BorderThickness = 3;
            this.ttype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ttype.Enabled = false;
            this.ttype.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ttype.ForeColor = System.Drawing.Color.Tomato;
            this.ttype.isPassword = false;
            this.ttype.Location = new System.Drawing.Point(269, 110);
            this.ttype.Margin = new System.Windows.Forms.Padding(4);
            this.ttype.Name = "ttype";
            this.ttype.Size = new System.Drawing.Size(281, 25);
            this.ttype.TabIndex = 96;
            this.ttype.Text = "achats";
            this.ttype.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tdate
            // 
            this.tdate.BorderColorFocused = System.Drawing.Color.Coral;
            this.tdate.BorderColorIdle = System.Drawing.Color.Coral;
            this.tdate.BorderColorMouseHover = System.Drawing.Color.Coral;
            this.tdate.BorderThickness = 3;
            this.tdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tdate.ForeColor = System.Drawing.Color.Tomato;
            this.tdate.isPassword = false;
            this.tdate.Location = new System.Drawing.Point(269, 143);
            this.tdate.Margin = new System.Windows.Forms.Padding(4);
            this.tdate.Name = "tdate";
            this.tdate.Size = new System.Drawing.Size(281, 25);
            this.tdate.TabIndex = 97;
            this.tdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tachat
            // 
            this.tachat.BorderColorFocused = System.Drawing.Color.Coral;
            this.tachat.BorderColorIdle = System.Drawing.Color.Coral;
            this.tachat.BorderColorMouseHover = System.Drawing.Color.Coral;
            this.tachat.BorderThickness = 3;
            this.tachat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tachat.Enabled = false;
            this.tachat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tachat.ForeColor = System.Drawing.Color.Tomato;
            this.tachat.isPassword = false;
            this.tachat.Location = new System.Drawing.Point(269, 359);
            this.tachat.Margin = new System.Windows.Forms.Padding(4);
            this.tachat.Name = "tachat";
            this.tachat.Size = new System.Drawing.Size(129, 25);
            this.tachat.TabIndex = 100;
            this.tachat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cclient
            // 
            this.cclient.BackColor = System.Drawing.Color.Coral;
            this.cclient.BorderRadius = 3;
            this.cclient.DisabledColor = System.Drawing.Color.Gray;
            this.cclient.ForeColor = System.Drawing.Color.Tan;
            this.cclient.Items = new string[0];
            this.cclient.Location = new System.Drawing.Point(269, 183);
            this.cclient.Margin = new System.Windows.Forms.Padding(6);
            this.cclient.Name = "cclient";
            this.cclient.NomalColor = System.Drawing.SystemColors.Control;
            this.cclient.onHoverColor = System.Drawing.Color.Coral;
            this.cclient.selectedIndex = -1;
            this.cclient.Size = new System.Drawing.Size(281, 25);
            this.cclient.TabIndex = 103;
            this.cclient.Leave += new System.EventHandler(this.cclient_Leave);
            // 
            // cpaiement
            // 
            this.cpaiement.BackColor = System.Drawing.Color.Coral;
            this.cpaiement.BorderRadius = 3;
            this.cpaiement.DisabledColor = System.Drawing.Color.Gray;
            this.cpaiement.ForeColor = System.Drawing.Color.Snow;
            this.cpaiement.Items = new string[0];
            this.cpaiement.Location = new System.Drawing.Point(269, 401);
            this.cpaiement.Margin = new System.Windows.Forms.Padding(6);
            this.cpaiement.Name = "cpaiement";
            this.cpaiement.NomalColor = System.Drawing.SystemColors.Control;
            this.cpaiement.onHoverColor = System.Drawing.Color.Coral;
            this.cpaiement.selectedIndex = -1;
            this.cpaiement.Size = new System.Drawing.Size(281, 25);
            this.cpaiement.TabIndex = 104;
            this.cpaiement.Leave += new System.EventHandler(this.cpaiement_Leave_1);
            // 
            // cproduit
            // 
            this.cproduit.BackColor = System.Drawing.Color.Coral;
            this.cproduit.BorderRadius = 3;
            this.cproduit.DisabledColor = System.Drawing.Color.Gray;
            this.cproduit.ForeColor = System.Drawing.Color.Snow;
            this.cproduit.Items = new string[0];
            this.cproduit.Location = new System.Drawing.Point(269, 263);
            this.cproduit.Margin = new System.Windows.Forms.Padding(6);
            this.cproduit.Name = "cproduit";
            this.cproduit.NomalColor = System.Drawing.SystemColors.Control;
            this.cproduit.onHoverColor = System.Drawing.Color.Coral;
            this.cproduit.selectedIndex = -1;
            this.cproduit.Size = new System.Drawing.Size(281, 25);
            this.cproduit.TabIndex = 105;
            this.cproduit.Leave += new System.EventHandler(this.cproduit_Leave_1);
            // 
            // tid_paiement
            // 
            this.tid_paiement.BorderColorFocused = System.Drawing.Color.Coral;
            this.tid_paiement.BorderColorIdle = System.Drawing.Color.Coral;
            this.tid_paiement.BorderColorMouseHover = System.Drawing.Color.Coral;
            this.tid_paiement.BorderThickness = 3;
            this.tid_paiement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tid_paiement.Enabled = false;
            this.tid_paiement.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tid_paiement.ForeColor = System.Drawing.Color.Tomato;
            this.tid_paiement.isPassword = false;
            this.tid_paiement.Location = new System.Drawing.Point(269, 445);
            this.tid_paiement.Margin = new System.Windows.Forms.Padding(4);
            this.tid_paiement.Name = "tid_paiement";
            this.tid_paiement.Size = new System.Drawing.Size(129, 25);
            this.tid_paiement.TabIndex = 107;
            this.tid_paiement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(166, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 106;
            this.label1.Text = "Id_paiement";
            // 
            // tid_fournisseur
            // 
            this.tid_fournisseur.BorderColorFocused = System.Drawing.Color.Coral;
            this.tid_fournisseur.BorderColorIdle = System.Drawing.Color.Coral;
            this.tid_fournisseur.BorderColorMouseHover = System.Drawing.Color.Coral;
            this.tid_fournisseur.BorderThickness = 3;
            this.tid_fournisseur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tid_fournisseur.Enabled = false;
            this.tid_fournisseur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tid_fournisseur.ForeColor = System.Drawing.Color.Tomato;
            this.tid_fournisseur.isPassword = false;
            this.tid_fournisseur.Location = new System.Drawing.Point(269, 228);
            this.tid_fournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.tid_fournisseur.Name = "tid_fournisseur";
            this.tid_fournisseur.Size = new System.Drawing.Size(129, 25);
            this.tid_fournisseur.TabIndex = 109;
            this.tid_fournisseur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(147, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 14);
            this.label6.TabIndex = 108;
            this.label6.Text = "Id_fournisseur";
            // 
            // id_produit
            // 
            this.id_produit.BorderColorFocused = System.Drawing.Color.Coral;
            this.id_produit.BorderColorIdle = System.Drawing.Color.Coral;
            this.id_produit.BorderColorMouseHover = System.Drawing.Color.Coral;
            this.id_produit.BorderThickness = 3;
            this.id_produit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_produit.Enabled = false;
            this.id_produit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.id_produit.ForeColor = System.Drawing.Color.Tomato;
            this.id_produit.isPassword = false;
            this.id_produit.Location = new System.Drawing.Point(559, 359);
            this.id_produit.Margin = new System.Windows.Forms.Padding(4);
            this.id_produit.Name = "id_produit";
            this.id_produit.Size = new System.Drawing.Size(129, 25);
            this.id_produit.TabIndex = 111;
            this.id_produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(421, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 110;
            this.label7.Text = "Id_produit";
            // 
            // liste2
            // 
            this.liste2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.liste2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10});
            this.liste2.GridColor = System.Drawing.Color.Coral;
            this.liste2.Location = new System.Drawing.Point(695, 276);
            this.liste2.Name = "liste2";
            this.liste2.Size = new System.Drawing.Size(243, 150);
            this.liste2.TabIndex = 113;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Produit";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "QTE";
            this.Column10.Name = "Column10";
            // 
            // tqte_produit
            // 
            this.tqte_produit.BorderColorFocused = System.Drawing.Color.Coral;
            this.tqte_produit.BorderColorIdle = System.Drawing.Color.Coral;
            this.tqte_produit.BorderColorMouseHover = System.Drawing.Color.Coral;
            this.tqte_produit.BorderThickness = 3;
            this.tqte_produit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tqte_produit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tqte_produit.ForeColor = System.Drawing.Color.Snow;
            this.tqte_produit.isPassword = false;
            this.tqte_produit.Location = new System.Drawing.Point(269, 298);
            this.tqte_produit.Margin = new System.Windows.Forms.Padding(4);
            this.tqte_produit.Name = "tqte_produit";
            this.tqte_produit.Size = new System.Drawing.Size(129, 25);
            this.tqte_produit.TabIndex = 115;
            this.tqte_produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(131, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 14);
            this.label8.TabIndex = 114;
            this.label8.Text = "Qte Produit";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(559, 256);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(54, 32);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 112;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bsupp
            // 
            this.bsupp.ActiveBorderThickness = 1;
            this.bsupp.ActiveCornerRadius = 20;
            this.bsupp.ActiveFillColor = System.Drawing.Color.Coral;
            this.bsupp.ActiveForecolor = System.Drawing.Color.White;
            this.bsupp.ActiveLineColor = System.Drawing.Color.Coral;
            this.bsupp.BackColor = System.Drawing.SystemColors.Control;
            this.bsupp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bsupp.BackgroundImage")));
            this.bsupp.ButtonText = "Supprimer";
            this.bsupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsupp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsupp.ForeColor = System.Drawing.Color.Coral;
            this.bsupp.IdleBorderThickness = 1;
            this.bsupp.IdleCornerRadius = 20;
            this.bsupp.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bsupp.IdleForecolor = System.Drawing.Color.Coral;
            this.bsupp.IdleLineColor = System.Drawing.Color.Coral;
            this.bsupp.Location = new System.Drawing.Point(793, 124);
            this.bsupp.Margin = new System.Windows.Forms.Padding(4);
            this.bsupp.Name = "bsupp";
            this.bsupp.Size = new System.Drawing.Size(186, 41);
            this.bsupp.TabIndex = 94;
            this.bsupp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bsupp.Click += new System.EventHandler(this.bsupp_Click);
            // 
            // bmodif
            // 
            this.bmodif.ActiveBorderThickness = 1;
            this.bmodif.ActiveCornerRadius = 20;
            this.bmodif.ActiveFillColor = System.Drawing.Color.Coral;
            this.bmodif.ActiveForecolor = System.Drawing.Color.White;
            this.bmodif.ActiveLineColor = System.Drawing.Color.Coral;
            this.bmodif.BackColor = System.Drawing.SystemColors.Control;
            this.bmodif.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bmodif.BackgroundImage")));
            this.bmodif.ButtonText = "Modifier";
            this.bmodif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmodif.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodif.ForeColor = System.Drawing.Color.Coral;
            this.bmodif.IdleBorderThickness = 1;
            this.bmodif.IdleCornerRadius = 20;
            this.bmodif.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bmodif.IdleForecolor = System.Drawing.Color.Coral;
            this.bmodif.IdleLineColor = System.Drawing.Color.Coral;
            this.bmodif.Location = new System.Drawing.Point(793, 167);
            this.bmodif.Margin = new System.Windows.Forms.Padding(4);
            this.bmodif.Name = "bmodif";
            this.bmodif.Size = new System.Drawing.Size(186, 41);
            this.bmodif.TabIndex = 93;
            this.bmodif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bmodif.Click += new System.EventHandler(this.bmodif_Click);
            // 
            // bimpri
            // 
            this.bimpri.ActiveBorderThickness = 1;
            this.bimpri.ActiveCornerRadius = 20;
            this.bimpri.ActiveFillColor = System.Drawing.Color.Coral;
            this.bimpri.ActiveForecolor = System.Drawing.Color.White;
            this.bimpri.ActiveLineColor = System.Drawing.Color.Coral;
            this.bimpri.BackColor = System.Drawing.SystemColors.Control;
            this.bimpri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bimpri.BackgroundImage")));
            this.bimpri.ButtonText = "Imprimer";
            this.bimpri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bimpri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bimpri.ForeColor = System.Drawing.Color.Coral;
            this.bimpri.IdleBorderThickness = 1;
            this.bimpri.IdleCornerRadius = 20;
            this.bimpri.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bimpri.IdleForecolor = System.Drawing.Color.Coral;
            this.bimpri.IdleLineColor = System.Drawing.Color.Coral;
            this.bimpri.Location = new System.Drawing.Point(793, 216);
            this.bimpri.Margin = new System.Windows.Forms.Padding(4);
            this.bimpri.Name = "bimpri";
            this.bimpri.Size = new System.Drawing.Size(186, 41);
            this.bimpri.TabIndex = 92;
            this.bimpri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bimpri.Click += new System.EventHandler(this.bimpri_Click);
            // 
            // bajout
            // 
            this.bajout.ActiveBorderThickness = 1;
            this.bajout.ActiveCornerRadius = 20;
            this.bajout.ActiveFillColor = System.Drawing.Color.Coral;
            this.bajout.ActiveForecolor = System.Drawing.Color.White;
            this.bajout.ActiveLineColor = System.Drawing.Color.Coral;
            this.bajout.BackColor = System.Drawing.SystemColors.Control;
            this.bajout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bajout.BackgroundImage")));
            this.bajout.ButtonText = "Ajouter";
            this.bajout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bajout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajout.ForeColor = System.Drawing.Color.Coral;
            this.bajout.IdleBorderThickness = 1;
            this.bajout.IdleCornerRadius = 20;
            this.bajout.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bajout.IdleForecolor = System.Drawing.Color.Coral;
            this.bajout.IdleLineColor = System.Drawing.Color.Coral;
            this.bajout.Location = new System.Drawing.Point(793, 77);
            this.bajout.Margin = new System.Windows.Forms.Padding(4);
            this.bajout.Name = "bajout";
            this.bajout.Size = new System.Drawing.Size(186, 41);
            this.bajout.TabIndex = 91;
            this.bajout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bajout.Click += new System.EventHandler(this.bajout_Click_1);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Coral;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Coral;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Sortir";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Coral;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Coral;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Coral;
            this.bunifuThinButton21.Location = new System.Drawing.Point(752, 711);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(186, 41);
            this.bunifuThinButton21.TabIndex = 116;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // Fachats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(992, 763);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.tqte_produit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.liste2);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.id_produit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tid_fournisseur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tid_paiement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cproduit);
            this.Controls.Add(this.cpaiement);
            this.Controls.Add(this.cclient);
            this.Controls.Add(this.tachat);
            this.Controls.Add(this.tdate);
            this.Controls.Add(this.ttype);
            this.Controls.Add(this.toperation);
            this.Controls.Add(this.bsupp);
            this.Controls.Add(this.bmodif);
            this.Controls.Add(this.bimpri);
            this.Controls.Add(this.bajout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fachats";
            this.Text = "Fachats";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Fachats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liste2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bsupp;
        private Bunifu.Framework.UI.BunifuThinButton2 bmodif;
        private Bunifu.Framework.UI.BunifuThinButton2 bimpri;
        private Bunifu.Framework.UI.BunifuThinButton2 bajout;
        private Bunifu.Framework.UI.BunifuMetroTextbox toperation;
        private Bunifu.Framework.UI.BunifuMetroTextbox ttype;
        private Bunifu.Framework.UI.BunifuMetroTextbox tdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox tachat;
        private Bunifu.Framework.UI.BunifuDropdown cproduit;
        private Bunifu.Framework.UI.BunifuDropdown cpaiement;
        private Bunifu.Framework.UI.BunifuDropdown cclient;
        private Bunifu.Framework.UI.BunifuMetroTextbox tid_fournisseur;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox tid_paiement;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox id_produit;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.DataGridView liste2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private Bunifu.Framework.UI.BunifuMetroTextbox tqte_produit;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}