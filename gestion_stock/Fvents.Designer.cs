namespace gestion_stock
{
    partial class Fvents
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toperation = new System.Windows.Forms.TextBox();
            this.ttype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.bimpri = new System.Windows.Forms.Button();
            this.bmodif = new System.Windows.Forms.Button();
            this.bsupp = new System.Windows.Forms.Button();
            this.bajout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cclient = new System.Windows.Forms.ComboBox();
            this.tnom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tprenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tachat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cproduit = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tvent = new System.Windows.Forms.TextBox();
            this.tstock = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tqte = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ttotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttype_paiement = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cpaiement = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Des Vents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_operation";
            // 
            // toperation
            // 
            this.toperation.Location = new System.Drawing.Point(272, 101);
            this.toperation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toperation.Name = "toperation";
            this.toperation.Size = new System.Drawing.Size(281, 23);
            this.toperation.TabIndex = 2;
            this.toperation.Leave += new System.EventHandler(this.toperation_Leave);
            // 
            // ttype
            // 
            this.ttype.Enabled = false;
            this.ttype.Location = new System.Drawing.Point(272, 131);
            this.ttype.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ttype.Name = "ttype";
            this.ttype.Size = new System.Drawing.Size(281, 23);
            this.ttype.TabIndex = 4;
            this.ttype.Text = "vents";
            this.ttype.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // tdate
            // 
            this.tdate.Location = new System.Drawing.Point(272, 159);
            this.tdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tdate.Name = "tdate";
            this.tdate.Size = new System.Drawing.Size(281, 23);
            this.tdate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date ";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(832, 235);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 29);
            this.button5.TabIndex = 22;
            this.button5.Text = "Fermer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bimpri
            // 
            this.bimpri.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bimpri.Location = new System.Drawing.Point(832, 199);
            this.bimpri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bimpri.Name = "bimpri";
            this.bimpri.Size = new System.Drawing.Size(131, 29);
            this.bimpri.TabIndex = 21;
            this.bimpri.Text = "Imprimer";
            this.bimpri.UseVisualStyleBackColor = true;
            this.bimpri.Click += new System.EventHandler(this.bimpri_Click);
            // 
            // bmodif
            // 
            this.bmodif.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodif.Location = new System.Drawing.Point(832, 164);
            this.bmodif.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bmodif.Name = "bmodif";
            this.bmodif.Size = new System.Drawing.Size(131, 29);
            this.bmodif.TabIndex = 20;
            this.bmodif.Text = "Modifier";
            this.bmodif.UseVisualStyleBackColor = true;
            this.bmodif.Click += new System.EventHandler(this.bmodif_Click);
            // 
            // bsupp
            // 
            this.bsupp.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsupp.Location = new System.Drawing.Point(832, 128);
            this.bsupp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bsupp.Name = "bsupp";
            this.bsupp.Size = new System.Drawing.Size(131, 29);
            this.bsupp.TabIndex = 19;
            this.bsupp.Text = "Supprimer";
            this.bsupp.UseVisualStyleBackColor = true;
            this.bsupp.Click += new System.EventHandler(this.bsupp_Click);
            // 
            // bajout
            // 
            this.bajout.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajout.Location = new System.Drawing.Point(832, 94);
            this.bajout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bajout.Name = "bajout";
            this.bajout.Size = new System.Drawing.Size(131, 29);
            this.bajout.TabIndex = 18;
            this.bajout.Text = "Ajouter";
            this.bajout.UseVisualStyleBackColor = true;
            this.bajout.Click += new System.EventHandler(this.bajout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Id_client";
            // 
            // cclient
            // 
            this.cclient.FormattingEnabled = true;
            this.cclient.Location = new System.Drawing.Point(272, 196);
            this.cclient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cclient.Name = "cclient";
            this.cclient.Size = new System.Drawing.Size(281, 22);
            this.cclient.TabIndex = 24;
            this.cclient.Leave += new System.EventHandler(this.cclient_Leave);
            // 
            // tnom
            // 
            this.tnom.Enabled = false;
            this.tnom.Location = new System.Drawing.Point(272, 251);
            this.tnom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tnom.Name = "tnom";
            this.tnom.Size = new System.Drawing.Size(171, 23);
            this.tnom.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nom";
            // 
            // tprenom
            // 
            this.tprenom.Enabled = false;
            this.tprenom.Location = new System.Drawing.Point(556, 251);
            this.tprenom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tprenom.Name = "tprenom";
            this.tprenom.Size = new System.Drawing.Size(171, 23);
            this.tprenom.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Prenom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 360);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 14);
            this.label8.TabIndex = 33;
            this.label8.Text = "Prix_vents";
            // 
            // tachat
            // 
            this.tachat.Enabled = false;
            this.tachat.Location = new System.Drawing.Point(272, 351);
            this.tachat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tachat.Name = "tachat";
            this.tachat.Size = new System.Drawing.Size(129, 23);
            this.tachat.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 360);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 14);
            this.label9.TabIndex = 31;
            this.label9.Text = "Prix_achat";
            // 
            // cproduit
            // 
            this.cproduit.FormattingEnabled = true;
            this.cproduit.Location = new System.Drawing.Point(272, 292);
            this.cproduit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cproduit.Name = "cproduit";
            this.cproduit.Size = new System.Drawing.Size(281, 22);
            this.cproduit.TabIndex = 30;
            this.cproduit.Leave += new System.EventHandler(this.cproduit_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(107, 295);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 14);
            this.label10.TabIndex = 29;
            this.label10.Text = "Id_produit";
            // 
            // tvent
            // 
            this.tvent.Enabled = false;
            this.tvent.Location = new System.Drawing.Point(524, 351);
            this.tvent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tvent.Name = "tvent";
            this.tvent.Size = new System.Drawing.Size(129, 23);
            this.tvent.TabIndex = 35;
            // 
            // tstock
            // 
            this.tstock.Enabled = false;
            this.tstock.Location = new System.Drawing.Point(776, 347);
            this.tstock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tstock.Name = "tstock";
            this.tstock.Size = new System.Drawing.Size(129, 23);
            this.tstock.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(695, 354);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 14);
            this.label11.TabIndex = 37;
            this.label11.Text = "Stock";
            // 
            // tqte
            // 
            this.tqte.Location = new System.Drawing.Point(272, 506);
            this.tqte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tqte.Name = "tqte";
            this.tqte.Size = new System.Drawing.Size(281, 23);
            this.tqte.TabIndex = 41;
            this.tqte.Leave += new System.EventHandler(this.tqte_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(107, 513);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 14);
            this.label12.TabIndex = 40;
            this.label12.Text = "Qte";
            // 
            // ttotal
            // 
            this.ttotal.Location = new System.Drawing.Point(682, 560);
            this.ttotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ttotal.Name = "ttotal";
            this.ttotal.Size = new System.Drawing.Size(281, 23);
            this.ttotal.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(587, 567);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 14);
            this.label13.TabIndex = 42;
            this.label13.Text = "Total";
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
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.liste.Location = new System.Drawing.Point(36, 589);
            this.liste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.Size = new System.Drawing.Size(927, 162);
            this.liste.TabIndex = 44;
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
            this.Column4.HeaderText = "ID_client";
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
            // ttype_paiement
            // 
            this.ttype_paiement.Enabled = false;
            this.ttype_paiement.Location = new System.Drawing.Point(272, 450);
            this.ttype_paiement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ttype_paiement.Name = "ttype_paiement";
            this.ttype_paiement.Size = new System.Drawing.Size(171, 23);
            this.ttype_paiement.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(169, 453);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 14);
            this.label15.TabIndex = 47;
            this.label15.Text = "Type";
            // 
            // cpaiement
            // 
            this.cpaiement.FormattingEnabled = true;
            this.cpaiement.Location = new System.Drawing.Point(272, 395);
            this.cpaiement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cpaiement.Name = "cpaiement";
            this.cpaiement.Size = new System.Drawing.Size(281, 22);
            this.cpaiement.TabIndex = 46;
            this.cpaiement.Leave += new System.EventHandler(this.cpaiement_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(107, 398);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 14);
            this.label16.TabIndex = 45;
            this.label16.Text = "Id_paiement";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::gestion_stock.Properties.Resources.ajouter;
            this.pictureBox3.Location = new System.Drawing.Point(563, 395);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::gestion_stock.Properties.Resources.ajouter;
            this.pictureBox2.Location = new System.Drawing.Point(563, 292);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_stock.Properties.Resources.ajouter;
            this.pictureBox1.Location = new System.Drawing.Point(563, 196);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Fvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 749);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ttype_paiement);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cpaiement);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.ttotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tqte);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tstock);
            this.Controls.Add(this.tvent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tachat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cproduit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tprenom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tnom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cclient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bimpri);
            this.Controls.Add(this.bmodif);
            this.Controls.Add(this.bsupp);
            this.Controls.Add(this.bajout);
            this.Controls.Add(this.tdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ttype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Fvents";
            this.Text = "Fvents";
            this.Load += new System.EventHandler(this.Fvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toperation;
        private System.Windows.Forms.TextBox ttype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bimpri;
        private System.Windows.Forms.Button bmodif;
        private System.Windows.Forms.Button bsupp;
        private System.Windows.Forms.Button bajout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cclient;
        private System.Windows.Forms.TextBox tnom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tprenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tachat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cproduit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tvent;
        private System.Windows.Forms.TextBox tstock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tqte;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ttotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox ttype_paiement;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cpaiement;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}