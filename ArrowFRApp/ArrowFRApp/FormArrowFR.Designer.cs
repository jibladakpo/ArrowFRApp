namespace ArrowFRApp
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.pictureArrowFR = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panelAccueil = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textMdp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowFR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnexion.Location = new System.Drawing.Point(649, 574);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(275, 82);
            this.buttonConnexion.TabIndex = 0;
            this.buttonConnexion.Text = "Se Connecter";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureArrowFR
            // 
            this.pictureArrowFR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureArrowFR.Image = ((System.Drawing.Image)(resources.GetObject("pictureArrowFR.Image")));
            this.pictureArrowFR.Location = new System.Drawing.Point(649, 101);
            this.pictureArrowFR.Name = "pictureArrowFR";
            this.pictureArrowFR.Size = new System.Drawing.Size(275, 272);
            this.pictureArrowFR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArrowFR.TabIndex = 1;
            this.pictureArrowFR.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(483, 9);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(606, 69);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "Association ArrowFR";
            // 
            // panelAccueil
            // 
            this.panelAccueil.BackColor = System.Drawing.SystemColors.Window;
            this.panelAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccueil.Location = new System.Drawing.Point(0, 0);
            this.panelAccueil.Name = "panelAccueil";
            this.panelAccueil.Size = new System.Drawing.Size(1580, 689);
            this.panelAccueil.TabIndex = 5;
            this.panelAccueil.Visible = false;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(647, 390);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(91, 32);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login";
            // 
            // labelMdp
            // 
            this.labelMdp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMdp.AutoSize = true;
            this.labelMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMdp.Location = new System.Drawing.Point(647, 476);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(196, 32);
            this.labelMdp.TabIndex = 0;
            this.labelMdp.Text = "Mot de passe";
            // 
            // textLogin
            // 
            this.textLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogin.Location = new System.Drawing.Point(649, 435);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(275, 38);
            this.textLogin.TabIndex = 0;
            // 
            // textMdp
            // 
            this.textMdp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMdp.Location = new System.Drawing.Point(649, 508);
            this.textMdp.Name = "textMdp";
            this.textMdp.PasswordChar = '*';
            this.textMdp.Size = new System.Drawing.Size(275, 38);
            this.textMdp.TabIndex = 0;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1580, 689);
            this.Controls.Add(this.panelAccueil);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureArrowFR);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.textMdp);
            this.Controls.Add(this.textLogin);
            this.Name = "Accueil";
            this.Text = "ArrowFRApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowFR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.PictureBox pictureArrowFR;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panelAccueil;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textMdp;
    }
}

