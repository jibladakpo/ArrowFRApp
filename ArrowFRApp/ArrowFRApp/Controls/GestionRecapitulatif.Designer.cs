namespace ArrowFRApp.Controls
{
    partial class GestionRecapitulatif
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
            this.labelRecapitulatif = new System.Windows.Forms.Label();
            this.labelNombreAdherent = new System.Windows.Forms.Label();
            this.labelMtTotalAdhesion = new System.Windows.Forms.Label();
            this.labelMontantAdhesionParType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRecapitulatif
            // 
            this.labelRecapitulatif.AutoSize = true;
            this.labelRecapitulatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecapitulatif.Location = new System.Drawing.Point(28, 29);
            this.labelRecapitulatif.Name = "labelRecapitulatif";
            this.labelRecapitulatif.Size = new System.Drawing.Size(205, 39);
            this.labelRecapitulatif.TabIndex = 0;
            this.labelRecapitulatif.Text = "Récapitulatif";
            // 
            // labelNombreAdherent
            // 
            this.labelNombreAdherent.AutoSize = true;
            this.labelNombreAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAdherent.Location = new System.Drawing.Point(30, 117);
            this.labelNombreAdherent.Name = "labelNombreAdherent";
            this.labelNombreAdherent.Size = new System.Drawing.Size(232, 29);
            this.labelNombreAdherent.TabIndex = 1;
            this.labelNombreAdherent.Text = "Nombre d\'adhérents";
            // 
            // labelMtTotalAdhesion
            // 
            this.labelMtTotalAdhesion.AutoSize = true;
            this.labelMtTotalAdhesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMtTotalAdhesion.Location = new System.Drawing.Point(30, 168);
            this.labelMtTotalAdhesion.Name = "labelMtTotalAdhesion";
            this.labelMtTotalAdhesion.Size = new System.Drawing.Size(312, 29);
            this.labelMtTotalAdhesion.TabIndex = 2;
            this.labelMtTotalAdhesion.Text = "Montant total des adhésions";
            // 
            // labelMontantAdhesionParType
            // 
            this.labelMontantAdhesionParType.AutoSize = true;
            this.labelMontantAdhesionParType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontantAdhesionParType.Location = new System.Drawing.Point(35, 217);
            this.labelMontantAdhesionParType.Name = "labelMontantAdhesionParType";
            this.labelMontantAdhesionParType.Size = new System.Drawing.Size(297, 29);
            this.labelMontantAdhesionParType.TabIndex = 3;
            this.labelMontantAdhesionParType.Text = "Montant Adhésion par type";
            // 
            // GestionRecapitulatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelMontantAdhesionParType);
            this.Controls.Add(this.labelMtTotalAdhesion);
            this.Controls.Add(this.labelNombreAdherent);
            this.Controls.Add(this.labelRecapitulatif);
            this.Name = "GestionRecapitulatif";
            this.Size = new System.Drawing.Size(811, 542);
            this.Load += new System.EventHandler(this.GestionRecapitulatif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRecapitulatif;
        private System.Windows.Forms.Label labelNombreAdherent;
        private System.Windows.Forms.Label labelMtTotalAdhesion;
        private System.Windows.Forms.Label labelMontantAdhesionParType;
    }
}
