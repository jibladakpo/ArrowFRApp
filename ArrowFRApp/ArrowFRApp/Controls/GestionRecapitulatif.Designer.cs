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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombreAdherent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Récapitulatif";
            // 
            // labelNombreAdherent
            // 
            this.labelNombreAdherent.AutoSize = true;
            this.labelNombreAdherent.Location = new System.Drawing.Point(32, 106);
            this.labelNombreAdherent.Name = "labelNombreAdherent";
            this.labelNombreAdherent.Size = new System.Drawing.Size(137, 17);
            this.labelNombreAdherent.TabIndex = 1;
            this.labelNombreAdherent.Text = "Nombre d\'adhérents";
            // 
            // GestionRecapitulatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelNombreAdherent);
            this.Controls.Add(this.label1);
            this.Name = "GestionRecapitulatif";
            this.Size = new System.Drawing.Size(811, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreAdherent;
    }
}
