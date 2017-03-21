namespace ArrowFRApp.Controls
{
    partial class GestionAccueil
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelGestion = new System.Windows.Forms.Panel();
            this.buttonGestionAdherent = new System.Windows.Forms.Button();
            this.buttonGestionTypeAdhesion = new System.Windows.Forms.Button();
            this.buttonRecapitulatif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.RoyalBlue;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(258, 559);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // panelGestion
            // 
            this.panelGestion.BackColor = System.Drawing.Color.White;
            this.panelGestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestion.Location = new System.Drawing.Point(258, 0);
            this.panelGestion.Name = "panelGestion";
            this.panelGestion.Size = new System.Drawing.Size(663, 559);
            this.panelGestion.TabIndex = 1;
            // 
            // buttonGestionAdherent
            // 
            this.buttonGestionAdherent.Location = new System.Drawing.Point(56, 261);
            this.buttonGestionAdherent.Name = "buttonGestionAdherent";
            this.buttonGestionAdherent.Size = new System.Drawing.Size(139, 59);
            this.buttonGestionAdherent.TabIndex = 2;
            this.buttonGestionAdherent.Text = "Gestion Adherent";
            this.buttonGestionAdherent.UseVisualStyleBackColor = true;
            this.buttonGestionAdherent.Click += new System.EventHandler(this.buttonGestionAdherent_Click);
            // 
            // buttonGestionTypeAdhesion
            // 
            this.buttonGestionTypeAdhesion.Location = new System.Drawing.Point(56, 360);
            this.buttonGestionTypeAdhesion.Name = "buttonGestionTypeAdhesion";
            this.buttonGestionTypeAdhesion.Size = new System.Drawing.Size(139, 59);
            this.buttonGestionTypeAdhesion.TabIndex = 3;
            this.buttonGestionTypeAdhesion.Text = "Gestion Type Adhesion";
            this.buttonGestionTypeAdhesion.UseVisualStyleBackColor = true;
            this.buttonGestionTypeAdhesion.Click += new System.EventHandler(this.buttonGestionTypeAdhesion_Click_1);
            // 
            // buttonRecapitulatif
            // 
            this.buttonRecapitulatif.Location = new System.Drawing.Point(56, 455);
            this.buttonRecapitulatif.Name = "buttonRecapitulatif";
            this.buttonRecapitulatif.Size = new System.Drawing.Size(139, 59);
            this.buttonRecapitulatif.TabIndex = 4;
            this.buttonRecapitulatif.Text = "Récapitulatif";
            this.buttonRecapitulatif.UseVisualStyleBackColor = true;
            // 
            // GestionAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRecapitulatif);
            this.Controls.Add(this.buttonGestionTypeAdhesion);
            this.Controls.Add(this.buttonGestionAdherent);
            this.Controls.Add(this.panelGestion);
            this.Controls.Add(this.splitter1);
            this.Name = "GestionAccueil";
            this.Size = new System.Drawing.Size(921, 559);
            this.Load += new System.EventHandler(this.GestionAccueil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelGestion;
        private System.Windows.Forms.Button buttonGestionAdherent;
        private System.Windows.Forms.Button buttonGestionTypeAdhesion;
        private System.Windows.Forms.Button buttonRecapitulatif;

    }
}
