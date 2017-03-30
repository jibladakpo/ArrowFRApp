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
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowFR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEntrer
            // 
            this.buttonEntrer.Location = new System.Drawing.Point(649, 443);
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
            this.pictureArrowFR.Location = new System.Drawing.Point(649, 135);
            this.pictureArrowFR.Name = "pictureArrowFR";
            this.pictureArrowFR.Size = new System.Drawing.Size(275, 272);
            this.pictureArrowFR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArrowFR.TabIndex = 1;
            this.pictureArrowFR.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(487, 28);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(606, 69);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "Association ArrowFR";
            this.labelTitre.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelAccueil
            // 
            this.panelAccueil.BackColor = System.Drawing.SystemColors.Window;
            this.panelAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccueil.Location = new System.Drawing.Point(0, 0);
            this.panelAccueil.Name = "panelAccueil";
            this.panelAccueil.Size = new System.Drawing.Size(1474, 689);
            this.panelAccueil.TabIndex = 3;
            this.panelAccueil.Visible = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1474, 689);
            this.Controls.Add(this.panelAccueil);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureArrowFR);
            this.Controls.Add(this.buttonEntrer);
            this.Name = "Accueil";
            this.Text = "ArrowFRApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowFR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrer;
        private System.Windows.Forms.PictureBox pictureArrowFR;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panelAccueil;
    }
}

