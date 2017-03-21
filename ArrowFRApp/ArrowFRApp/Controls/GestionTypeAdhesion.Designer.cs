namespace ArrowFRApp
{
    partial class GestionTypeAdhesion
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
            this.labelTarif = new System.Windows.Forms.Label();
            this.labelLibellé = new System.Windows.Forms.Label();
            this.textBoxTarif = new System.Windows.Forms.TextBox();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.buttonSupprimerTypeAdhesion = new System.Windows.Forms.Button();
            this.buttonModifierTypeAdhesion = new System.Windows.Forms.Button();
            this.buttonCreerTypeAdhesion = new System.Windows.Forms.Button();
            this.listViewTypeAdhesion = new System.Windows.Forms.ListView();
            this.columnLibelle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTarif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelTarif
            // 
            this.labelTarif.AutoSize = true;
            this.labelTarif.Location = new System.Drawing.Point(30, 122);
            this.labelTarif.Name = "labelTarif";
            this.labelTarif.Size = new System.Drawing.Size(37, 17);
            this.labelTarif.TabIndex = 29;
            this.labelTarif.Text = "Tarif";
            // 
            // labelLibellé
            // 
            this.labelLibellé.AutoSize = true;
            this.labelLibellé.Location = new System.Drawing.Point(30, 77);
            this.labelLibellé.Name = "labelLibellé";
            this.labelLibellé.Size = new System.Drawing.Size(49, 17);
            this.labelLibellé.TabIndex = 28;
            this.labelLibellé.Text = "Libellé";
            // 
            // textBoxTarif
            // 
            this.textBoxTarif.Location = new System.Drawing.Point(33, 143);
            this.textBoxTarif.Name = "textBoxTarif";
            this.textBoxTarif.Size = new System.Drawing.Size(206, 22);
            this.textBoxTarif.TabIndex = 27;
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Location = new System.Drawing.Point(33, 97);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.Size = new System.Drawing.Size(206, 22);
            this.textBoxLibelle.TabIndex = 23;
            // 
            // buttonSupprimerTypeAdhesion
            // 
            this.buttonSupprimerTypeAdhesion.Location = new System.Drawing.Point(543, 511);
            this.buttonSupprimerTypeAdhesion.Name = "buttonSupprimerTypeAdhesion";
            this.buttonSupprimerTypeAdhesion.Size = new System.Drawing.Size(119, 51);
            this.buttonSupprimerTypeAdhesion.TabIndex = 22;
            this.buttonSupprimerTypeAdhesion.Text = "Supprimer";
            this.buttonSupprimerTypeAdhesion.UseVisualStyleBackColor = true;
            // 
            // buttonModifierTypeAdhesion
            // 
            this.buttonModifierTypeAdhesion.Location = new System.Drawing.Point(418, 511);
            this.buttonModifierTypeAdhesion.Name = "buttonModifierTypeAdhesion";
            this.buttonModifierTypeAdhesion.Size = new System.Drawing.Size(119, 51);
            this.buttonModifierTypeAdhesion.TabIndex = 21;
            this.buttonModifierTypeAdhesion.Text = "Modifier";
            this.buttonModifierTypeAdhesion.UseVisualStyleBackColor = true;
            // 
            // buttonCreerTypeAdhesion
            // 
            this.buttonCreerTypeAdhesion.Location = new System.Drawing.Point(293, 511);
            this.buttonCreerTypeAdhesion.Name = "buttonCreerTypeAdhesion";
            this.buttonCreerTypeAdhesion.Size = new System.Drawing.Size(119, 51);
            this.buttonCreerTypeAdhesion.TabIndex = 20;
            this.buttonCreerTypeAdhesion.Text = "Créer";
            this.buttonCreerTypeAdhesion.UseVisualStyleBackColor = true;
            // 
            // listViewTypeAdhesion
            // 
            this.listViewTypeAdhesion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnLibelle,
            this.columnTarif});
            this.listViewTypeAdhesion.Location = new System.Drawing.Point(293, 97);
            this.listViewTypeAdhesion.Name = "listViewTypeAdhesion";
            this.listViewTypeAdhesion.Size = new System.Drawing.Size(369, 408);
            this.listViewTypeAdhesion.TabIndex = 30;
            this.listViewTypeAdhesion.UseCompatibleStateImageBehavior = false;
            this.listViewTypeAdhesion.View = System.Windows.Forms.View.Details;
            // 
            // columnLibelle
            // 
            this.columnLibelle.Text = "Libelle";
            // 
            // columnTarif
            // 
            this.columnTarif.Text = "Tarif";
            // 
            // GestionTypeAdhesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.listViewTypeAdhesion);
            this.Controls.Add(this.labelTarif);
            this.Controls.Add(this.labelLibellé);
            this.Controls.Add(this.textBoxTarif);
            this.Controls.Add(this.textBoxLibelle);
            this.Controls.Add(this.buttonSupprimerTypeAdhesion);
            this.Controls.Add(this.buttonModifierTypeAdhesion);
            this.Controls.Add(this.buttonCreerTypeAdhesion);
            this.Name = "GestionTypeAdhesion";
            this.Size = new System.Drawing.Size(730, 611);
            this.Load += new System.EventHandler(this.TypeAdhesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTarif;
        private System.Windows.Forms.Label labelLibellé;
        private System.Windows.Forms.TextBox textBoxTarif;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.Button buttonSupprimerTypeAdhesion;
        private System.Windows.Forms.Button buttonModifierTypeAdhesion;
        private System.Windows.Forms.Button buttonCreerTypeAdhesion;
        private System.Windows.Forms.ListView listViewTypeAdhesion;
        private System.Windows.Forms.ColumnHeader columnLibelle;
        private System.Windows.Forms.ColumnHeader columnTarif;
    }
}
