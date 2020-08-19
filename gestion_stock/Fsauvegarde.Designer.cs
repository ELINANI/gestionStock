namespace gestion_stock
{
    partial class Fsauvegarde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fsauvegarde));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bajou = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cunite = new Bunifu.Framework.UI.BunifuDropdown();
            this.tbase = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel1.Location = new System.Drawing.Point(434, 103);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nouvelle Unitée";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(41, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unitée De Sauvegarde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(41, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Base Donner";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DarkGray;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 32);
            this.panel1.TabIndex = 23;
            // 
            // bajou
            // 
            this.bajou.ActiveBorderThickness = 1;
            this.bajou.ActiveCornerRadius = 20;
            this.bajou.ActiveFillColor = System.Drawing.Color.DarkGray;
            this.bajou.ActiveForecolor = System.Drawing.Color.White;
            this.bajou.ActiveLineColor = System.Drawing.Color.DarkGray;
            this.bajou.BackColor = System.Drawing.SystemColors.Control;
            this.bajou.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bajou.BackgroundImage")));
            this.bajou.ButtonText = "Save";
            this.bajou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bajou.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajou.ForeColor = System.Drawing.Color.DarkGray;
            this.bajou.IdleBorderThickness = 1;
            this.bajou.IdleCornerRadius = 20;
            this.bajou.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bajou.IdleForecolor = System.Drawing.Color.DarkGray;
            this.bajou.IdleLineColor = System.Drawing.Color.DarkGray;
            this.bajou.Location = new System.Drawing.Point(547, 140);
            this.bajou.Margin = new System.Windows.Forms.Padding(4);
            this.bajou.Name = "bajou";
            this.bajou.Size = new System.Drawing.Size(186, 41);
            this.bajou.TabIndex = 36;
            this.bajou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bajou.Click += new System.EventHandler(this.bajou_Click);
            // 
            // cunite
            // 
            this.cunite.BackColor = System.Drawing.Color.DarkGray;
            this.cunite.BorderRadius = 3;
            this.cunite.DisabledColor = System.Drawing.Color.Gray;
            this.cunite.ForeColor = System.Drawing.Color.Snow;
            this.cunite.Items = new string[0];
            this.cunite.Location = new System.Drawing.Point(243, 71);
            this.cunite.Margin = new System.Windows.Forms.Padding(6);
            this.cunite.Name = "cunite";
            this.cunite.NomalColor = System.Drawing.SystemColors.Control;
            this.cunite.onHoverColor = System.Drawing.Color.DarkGray;
            this.cunite.selectedIndex = -1;
            this.cunite.Size = new System.Drawing.Size(264, 25);
            this.cunite.TabIndex = 38;
            // 
            // tbase
            // 
            this.tbase.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.tbase.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.tbase.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.tbase.BorderThickness = 3;
            this.tbase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbase.Enabled = false;
            this.tbase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbase.ForeColor = System.Drawing.Color.Snow;
            this.tbase.isPassword = false;
            this.tbase.Location = new System.Drawing.Point(243, 133);
            this.tbase.Margin = new System.Windows.Forms.Padding(4);
            this.tbase.Name = "tbase";
            this.tbase.Size = new System.Drawing.Size(264, 25);
            this.tbase.TabIndex = 37;
            this.tbase.Text = "gestion_stock";
            this.tbase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Fsauvegarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(768, 194);
            this.Controls.Add(this.cunite);
            this.Controls.Add(this.tbase);
            this.Controls.Add(this.bajou);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fsauvegarde";
            this.Text = "Fsauvegarde";
            this.Load += new System.EventHandler(this.Fsauvegarde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 bajou;
        private Bunifu.Framework.UI.BunifuDropdown cunite;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbase;
    }
}