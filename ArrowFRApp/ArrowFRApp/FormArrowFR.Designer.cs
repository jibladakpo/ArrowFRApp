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
            this.buttonEntrer = new System.Windows.Forms.Button();
            this.pictureArrowFR = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panelAccueil = new System.Windows.Forms.Panel();
            this.labelArrowfr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGestion = new System.Windows.Forms.Panel();
            this.buttonRecapitulatif = new System.Windows.Forms.Button();
            this.buttonGestionTypeAdhesion = new System.Windows.Forms.Button();
            this.buttonGestionAdherent = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowFR)).BeginInit();
            this.panelAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEntrer
            // 
            this.buttonEntrer.Location = new System.Drawing.Point(366, 456);
            this.buttonEntrer.Name = "buttonEntrer";
            this.buttonEntrer.Size = new System.Drawing.Size(275, 82);
            this.buttonEntrer.TabIndex = 0;
            this.buttonEntrer.Text = "ENTRER";
            this.buttonEntrer.UseVisualStyleBackColor = true;
            this.buttonEntrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureArrowFR
            // 
            this.pictureArrowFR.Image = ((System.Drawing.Image)(resources.GetObject("pictureArrowFR.Image")));
            this.pictureArrowFR.Location = new System.Drawing.Point(366, 135);
            this.pictureArrowFR.Name = "pictureArrowFR";
            this.pictureArrowFR.Size = new System.Drawing.Size(275, 272);
            this.pictureArrowFR.TabIndex = 1;
            this.pictureArrowFR.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(179, 30);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(606, 69);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "Association ArrowFR";
            this.labelTitre.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelAccueil
            // 
            this.panelAccueil.Controls.Add(this.labelArrowfr);
            this.panelAccueil.Controls.Add(this.pictureBox1);
            this.panelAccueil.Controls.Add(this.panelGestion);
            this.panelAccueil.Controls.Add(this.buttonRecapitulatif);
            this.panelAccueil.Controls.Add(this.buttonGestionTypeAdhesion);
            this.panelAccueil.Controls.Add(this.buttonGestionAdherent);
            this.panelAccueil.Controls.Add(this.splitter1);
            this.panelAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccueil.Location = new System.Drawing.Point(0, 0);
            this.panelAccueil.Name = "panelAccueil";
            this.panelAccueil.Size = new System.Drawing.Size(999, 689);
            this.panelAccueil.TabIndex = 3;
            this.panelAccueil.Visible = false;
            this.panelAccueil.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAccueil_Paint);
            // 
            // labelArrowfr
            // 
            this.labelArrowfr.AutoSize = true;
            this.labelArrowfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrowfr.Location = new System.Drawing.Point(36, 593);
            this.labelArrowfr.Name = "labelArrowfr";
            this.labelArrowfr.Size = new System.Drawing.Size(191, 51);
            this.labelArrowfr.TabIndex = 6;
            this.labelArrowfr.Text = "ArrowFR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelGestion
            // 
            this.panelGestion.BackColor = System.Drawing.SystemColors.Window;
            this.panelGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestion.Location = new System.Drawing.Point(254, 0);
            this.panelGestion.Name = "panelGestion";
            this.panelGestion.Size = new System.Drawing.Size(745, 689);
            this.panelGestion.TabIndex = 4;
            this.panelGestion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGestion_Paint);
            // 
            // buttonRecapitulatif
            // 
            this.buttonRecapitulatif.Location = new System.Drawing.Point(36, 490);
            this.buttonRecapitulatif.Name = "buttonRecapitulatif";
            this.buttonRecapitulatif.Size = new System.Drawing.Size(185, 73);
            this.buttonRecapitulatif.TabIndex = 3;
            this.buttonRecapitulatif.Text = "Récapitulatif";
            this.buttonRecapitulatif.UseVisualStyleBackColor = true;
            this.buttonRecapitulatif.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonGestionTypeAdhesion
            // 
            this.buttonGestionTypeAdhesion.Location = new System.Drawing.Point(36, 376);
            this.buttonGestionTypeAdhesion.Name = "buttonGestionTypeAdhesion";
            this.buttonGestionTypeAdhesion.Size = new System.Drawing.Size(185, 73);
            this.buttonGestionTypeAdhesion.TabIndex = 2;
            this.buttonGestionTypeAdhesion.Text = "Gestion Types Adhésions";
            this.buttonGestionTypeAdhesion.UseVisualStyleBackColor = true;
            this.buttonGestionTypeAdhesion.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonGestionAdherent
            // 
            this.buttonGestionAdherent.Location = new System.Drawing.Point(36, 272);
            this.buttonGestionAdherent.Name = "buttonGestionAdherent";
            this.buttonGestionAdherent.Size = new System.Drawing.Size(185, 73);
            this.buttonGestionAdherent.TabIndex = 1;
            this.buttonGestionAdherent.Text = "Gestion Adhérents";
            this.buttonGestionAdherent.UseVisualStyleBackColor = true;
            this.buttonGestionAdherent.Click += new System.EventHandler(this.buttonGestionAdherent_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(254, 689);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(999, 689);
            this.Controls.Add(this.panelAccueil);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureArrowFR);
            this.Controls.Add(this.buttonEntrer);
            this.Name = "Accueil";
            this.Text = "ArrowFRApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowFR)).EndInit();
            this.panelAccueil.ResumeLayout(false);
            this.panelAccueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrer;
        private System.Windows.Forms.PictureBox pictureArrowFR;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panelAccueil;
        private System.Windows.Forms.Button buttonRecapitulatif;
        private System.Windows.Forms.Button buttonGestionTypeAdhesion;
        private System.Windows.Forms.Button buttonGestionAdherent;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelGestion;
        private System.Windows.Forms.Label labelArrowfr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

