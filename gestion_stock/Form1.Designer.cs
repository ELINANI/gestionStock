namespace gestion_stock
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tnom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // tnom
            // 
            this.tnom.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.tnom.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.tnom.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.tnom.BorderThickness = 3;
            this.tnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tnom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.tnom.isPassword = false;
            this.tnom.Location = new System.Drawing.Point(214, 91);
            this.tnom.Margin = new System.Windows.Forms.Padding(4);
            this.tnom.Name = "tnom";
            this.tnom.Size = new System.Drawing.Size(370, 44);
            this.tnom.TabIndex = 18;
            this.tnom.Text = "Username";
            this.tnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tnom.Click += new System.EventHandler(this.tnom_Click_1);
            // 
            // tpass
            // 
            this.tpass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.tpass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.tpass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.tpass.BorderThickness = 3;
            this.tpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.tpass.isPassword = false;
            this.tpass.Location = new System.Drawing.Point(214, 152);
            this.tpass.Margin = new System.Windows.Forms.Padding(4);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(370, 44);
            this.tpass.TabIndex = 19;
            this.tpass.Text = "Password";
            this.tpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tpass.OnValueChanged += new System.EventHandler(this.tpass_OnValueChanged);
            this.tpass.Click += new System.EventHandler(this.tpass_Click_2);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Login";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(160, 243);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(189, 41);
            this.bunifuThinButton22.TabIndex = 21;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Exit";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(403, 243);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 22;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(103, 120);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(36, 15);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "Nom";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(103, 181);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 15);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(160, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(61, 60);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 25;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(0, 39);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(137, 15);
            this.bunifuCustomLabel3.TabIndex = 26;
            this.bunifuCustomLabel3.Text = "Gestion De Stock";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(713, 323);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.tnom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox tnom;
        private Bunifu.Framework.UI.BunifuMetroTextbox tpass;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}

