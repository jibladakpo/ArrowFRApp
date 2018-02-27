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
            this.labelAdhesionType = new System.Windows.Forms.Label();
            this.listViewAdhesionType = new System.Windows.Forms.ListView();
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNbAdherent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMontant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTarif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelRecapitulatif
            // 
            this.labelRecapitulatif.AutoSize = true;
            this.labelRecapitulatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecapitulatif.Location = new System.Drawing.Point(28, 29);
            this.labelRecapitulatif.Name = "labelRecapitulatif";
            this.labelRecapitulatif.Size = new System.Drawing.Size(196, 38);
            this.labelRecapitulatif.TabIndex = 0;
            this.labelRecapitulatif.Text = "Récapitulatif";
            // 
            // labelNombreAdherent
            // 
            this.labelNombreAdherent.AutoSize = true;
            this.labelNombreAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAdherent.Location = new System.Drawing.Point(30, 107);
            this.labelNombreAdherent.Name = "labelNombreAdherent";
            this.labelNombreAdherent.Size = new System.Drawing.Size(232, 29);
            this.labelNombreAdherent.TabIndex = 1;
            this.labelNombreAdherent.Text = "Nombre d\'adhérents";
            // 
            // labelMtTotalAdhesion
            // 
            this.labelMtTotalAdhesion.AutoSize = true;
            this.labelMtTotalAdhesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMtTotalAdhesion.Location = new System.Drawing.Point(30, 159);
            this.labelMtTotalAdhesion.Name = "labelMtTotalAdhesion";
            this.labelMtTotalAdhesion.Size = new System.Drawing.Size(312, 29);
            this.labelMtTotalAdhesion.TabIndex = 2;
            this.labelMtTotalAdhesion.Text = "Montant total des adhésions";
            // 
            // labelAdhesionType
            // 
            this.labelAdhesionType.AutoSize = true;
            this.labelAdhesionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdhesionType.Location = new System.Drawing.Point(32, 215);
            this.labelAdhesionType.Name = "labelAdhesionType";
            this.labelAdhesionType.Size = new System.Drawing.Size(206, 29);
            this.labelAdhesionType.TabIndex = 4;
            this.labelAdhesionType.Text = "Adhésion par type";
            // 
            // listViewAdhesionType
            // 
            this.listViewAdhesionType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnType,
            this.columnNbAdherent,
            this.columnTarif,
            this.columnMontant});
            this.listViewAdhesionType.FullRowSelect = true;
            this.listViewAdhesionType.GridLines = true;
            this.listViewAdhesionType.Location = new System.Drawing.Point(26, 271);
            this.listViewAdhesionType.Name = "listViewAdhesionType";
            this.listViewAdhesionType.Size = new System.Drawing.Size(749, 179);
            this.listViewAdhesionType.TabIndex = 5;
            this.listViewAdhesionType.UseCompatibleStateImageBehavior = false;
            this.listViewAdhesionType.View = System.Windows.Forms.View.Details;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 110;
            // 
            // columnNbAdherent
            // 
            this.columnNbAdherent.DisplayIndex = 1;
            this.columnNbAdherent.Text = "Nombre d\'Adhérent";
            this.columnNbAdherent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNbAdherent.Width = 110;
            // 
            // columnMontant
            // 
            this.columnMontant.DisplayIndex = 2;
            this.columnMontant.Text = "Montant Total";
            this.columnMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMontant.Width = 110;
            // 
            // columnTarif
            // 
            this.columnTarif.Text = "Tarif";
            this.columnTarif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTarif.Width = 110;
            // 
            // GestionRecapitulatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listViewAdhesionType);
            this.Controls.Add(this.labelAdhesionType);
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
        private System.Windows.Forms.Label labelAdhesionType;
        private System.Windows.Forms.ListView listViewAdhesionType;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnNbAdherent;
        private System.Windows.Forms.ColumnHeader columnMontant;
        private System.Windows.Forms.ColumnHeader columnTarif;
    }
}
