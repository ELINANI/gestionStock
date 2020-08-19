namespace gestion_stock
{
    partial class Fcommende
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
            this.liste = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tqte = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tstock = new System.Windows.Forms.TextBox();
            this.tvent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tachat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cproduit = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ttype_paiement = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cpaiement = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tprenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tnom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cclient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.bimpri = new System.Windows.Forms.Button();
            this.bmodif = new System.Windows.Forms.Button();
            this.bsupp = new System.Windows.Forms.Button();
            this.bajout = new System.Windows.Forms.Button();
            this.tdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ttype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toperation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.liste.Location = new System.Drawing.Point(22, 575);
            this.liste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.Size = new System.Drawing.Size(927, 162);
            this.liste.TabIndex = 84;
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
            // ttotal
            // 
            this.ttotal.Location = new System.Drawing.Point(668, 546);
            this.ttotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ttotal.Name = "ttotal";
            this.ttotal.Size = new System.Drawing.Size(281, 20);
            this.ttotal.TabIndex = 83;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(573, 553);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 14);
            this.label13.TabIndex = 82;
            this.label13.Text = "Total";
            // 
            // tqte
            // 
            this.tqte.Location = new System.Drawing.Point(258, 492);
            this.tqte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tqte.Name = "tqte";
            this.tqte.Size = new System.Drawing.Size(281, 20);
            this.tqte.TabIndex = 81;
            this.tqte.Leave += new System.EventHandler(this.tqte_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(93, 499);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 14);
            this.label12.TabIndex = 80;
            this.label12.Text = "Qte";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::gestion_stock.Properties.Resources.ajouter;
            this.pictureBox2.Location = new System.Drawing.Point(549, 278);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(681, 340);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 14);
            this.label11.TabIndex = 77;
            this.label11.Text = "Stock";
            // 
            // tstock
            // 
            this.tstock.Enabled = false;
            this.tstock.Location = new System.Drawing.Point(762, 333);
            this.tstock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tstock.Name = "tstock";
            this.tstock.Size = new System.Drawing.Size(129, 20);
            this.tstock.TabIndex = 76;
            // 
            // tvent
            // 
            this.tvent.Enabled = false;
            this.tvent.Location = new System.Drawing.Point(510, 337);
            this.tvent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tvent.Name = "tvent";
            this.tvent.Size = new System.Drawing.Size(129, 20);
            this.tvent.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(413, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 14);
            this.label8.TabIndex = 74;
            this.label8.Text = "Prix_vents";
            // 
            // tachat
            // 
            this.tachat.Enabled = false;
            this.tachat.Location = new System.Drawing.Point(258, 337);
            this.tachat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tachat.Name = "tachat";
            this.tachat.Size = new System.Drawing.Size(129, 20);
            this.tachat.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 14);
            this.label9.TabIndex = 72;
            this.label9.Text = "Prix_achat";
            // 
            // cproduit
            // 
            this.cproduit.FormattingEnabled = true;
            this.cproduit.Location = new System.Drawing.Point(258, 278);
            this.cproduit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cproduit.Name = "cproduit";
            this.cproduit.Size = new System.Drawing.Size(281, 21);
            this.cproduit.TabIndex = 71;
            this.cproduit.Leave += new System.EventHandler(this.cproduit_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::gestion_stock.Properties.Resources.ajouter;
            this.pictureBox3.Location = new System.Drawing.Point(549, 381);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ttype_paiement
            // 
            this.ttype_paiement.Enabled = false;
            this.ttype_paiement.Location = new System.Drawing.Point(258, 436);
            this.ttype_paiement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ttype_paiement.Name = "ttype_paiement";
            this.ttype_paiement.Size = new System.Drawing.Size(171, 20);
            this.ttype_paiement.TabIndex = 88;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(155, 439);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 14);
            this.label15.TabIndex = 87;
            this.label15.Text = "Type";
            // 
            // cpaiement
            // 
            this.cpaiement.FormattingEnabled = true;
            this.cpaiement.Location = new System.Drawing.Point(258, 381);
            this.cpaiement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cpaiement.Name = "cpaiement";
            this.cpaiement.Size = new System.Drawing.Size(281, 21);
            this.cpaiement.TabIndex = 86;
            this.cpaiement.Leave += new System.EventHandler(this.cpaiement_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(93, 384);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 14);
            this.label16.TabIndex = 85;
            this.label16.Text = "Id_paiement";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_stock.Properties.Resources.ajouter;
            this.pictureBox1.Location = new System.Drawing.Point(549, 182);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(93, 281);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 14);
            this.label10.TabIndex = 70;
            this.label10.Text = "Id_produit";
            // 
            // tprenom
            // 
            this.tprenom.Enabled = false;
            this.tprenom.Location = new System.Drawing.Point(542, 237);
            this.tprenom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tprenom.Name = "tprenom";
            this.tprenom.Size = new System.Drawing.Size(171, 20);
            this.tprenom.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(454, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 68;
            this.label7.Text = "Prenom";
            // 
            // tnom
            // 
            this.tnom.Enabled = false;
            this.tnom.Location = new System.Drawing.Point(258, 237);
            this.tnom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tnom.Name = "tnom";
            this.tnom.Size = new System.Drawing.Size(171, 20);
            this.tnom.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 66;
            this.label6.Text = "Nom";
            // 
            // cclient
            // 
            this.cclient.FormattingEnabled = true;
            this.cclient.Location = new System.Drawing.Point(258, 182);
            this.cclient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cclient.Name = "cclient";
            this.cclient.Size = new System.Drawing.Size(281, 21);
            this.cclient.TabIndex = 65;
            this.cclient.Leave += new System.EventHandler(this.cclient_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 64;
            this.label5.Text = "Id_client";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(818, 221);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 29);
            this.button5.TabIndex = 63;
            this.button5.Text = "Fermer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bimpri
            // 
            this.bimpri.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bimpri.Location = new System.Drawing.Point(818, 185);
            this.bimpri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bimpri.Name = "bimpri";
            this.bimpri.Size = new System.Drawing.Size(131, 29);
            this.bimpri.TabIndex = 62;
            this.bimpri.Text = "Imprimer";
            this.bimpri.UseVisualStyleBackColor = true;
            this.bimpri.Click += new System.EventHandler(this.bimpri_Click);
            // 
            // bmodif
            // 
            this.bmodif.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodif.Location = new System.Drawing.Point(818, 150);
            this.bmodif.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bmodif.Name = "bmodif";
            this.bmodif.Size = new System.Drawing.Size(131, 29);
            this.bmodif.TabIndex = 61;
            this.bmodif.Text = "Modifier";
            this.bmodif.UseVisualStyleBackColor = true;
            this.bmodif.Click += new System.EventHandler(this.bmodif_Click);
            // 
            // bsupp
            // 
            this.bsupp.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsupp.Location = new System.Drawing.Point(818, 114);
            this.bsupp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bsupp.Name = "bsupp";
            this.bsupp.Size = new System.Drawing.Size(131, 29);
            this.bsupp.TabIndex = 60;
            this.bsupp.Text = "Supprimer";
            this.bsupp.UseVisualStyleBackColor = true;
            this.bsupp.Click += new System.EventHandler(this.bsupp_Click);
            // 
            // bajout
            // 
            this.bajout.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajout.Location = new System.Drawing.Point(818, 80);
            this.bajout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bajout.Name = "bajout";
            this.bajout.Size = new System.Drawing.Size(131, 29);
            this.bajout.TabIndex = 59;
            this.bajout.Text = "Ajouter";
            this.bajout.UseVisualStyleBackColor = true;
            this.bajout.Click += new System.EventHandler(this.bajout_Click);
            // 
            // tdate
            // 
            this.tdate.Location = new System.Drawing.Point(258, 145);
            this.tdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tdate.Name = "tdate";
            this.tdate.Size = new System.Drawing.Size(281, 20);
            this.tdate.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 57;
            this.label4.Text = "Date ";
            // 
            // ttype
            // 
            this.ttype.Enabled = false;
            this.ttype.Location = new System.Drawing.Point(258, 117);
            this.ttype.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ttype.Name = "ttype";
            this.ttype.Size = new System.Drawing.Size(281, 20);
            this.ttype.TabIndex = 56;
            this.ttype.Text = "commende";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 55;
            this.label3.Text = "Type";
            // 
            // toperation
            // 
            this.toperation.Location = new System.Drawing.Point(258, 87);
            this.toperation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toperation.Name = "toperation";
            this.toperation.Size = new System.Drawing.Size(281, 20);
            this.toperation.TabIndex = 54;
            this.toperation.Leave += new System.EventHandler(this.toperation_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 53;
            this.label2.Text = "Id_operation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Gestion Des Commendes";
            // 
            // Fcommende
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 749);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.ttotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tqte);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tstock);
            this.Controls.Add(this.tvent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tachat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cproduit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ttype_paiement);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cpaiement);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "Fcommende";
            this.Text = "Fcommende";
            this.Load += new System.EventHandler(this.Fcommende_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox ttotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tqte;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tstock;
        private System.Windows.Forms.TextBox tvent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tachat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cproduit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox ttype_paiement;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cpaiement;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tprenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tnom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cclient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bimpri;
        private System.Windows.Forms.Button bmodif;
        private System.Windows.Forms.Button bsupp;
        private System.Windows.Forms.Button bajout;
        private System.Windows.Forms.TextBox tdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}