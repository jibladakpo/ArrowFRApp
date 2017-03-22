namespace ArrowFRApp
{
    partial class GestionAdherent
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
            this.buttonCreerAdherent = new System.Windows.Forms.Button();
            this.buttonModifierAdherent = new System.Windows.Forms.Button();
            this.buttonSupprimerAdherent = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCodePostale = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelDateNaissance = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelCodePostale = new System.Windows.Forms.Label();
            this.labelTypeAdhesion = new System.Windows.Forms.Label();
            this.listViewAdherent = new System.Windows.Forms.ListView();
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateNaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCodePostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeAdhesion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkedListBoxAdhesion = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonCreerAdherent
            // 
            this.buttonCreerAdherent.Location = new System.Drawing.Point(293, 511);
            this.buttonCreerAdherent.Name = "buttonCreerAdherent";
            this.buttonCreerAdherent.Size = new System.Drawing.Size(119, 51);
            this.buttonCreerAdherent.TabIndex = 2;
            this.buttonCreerAdherent.Text = "Créer";
            this.buttonCreerAdherent.UseVisualStyleBackColor = true;
            this.buttonCreerAdherent.Click += new System.EventHandler(this.buttonCreerAdherent_Click);
            // 
            // buttonModifierAdherent
            // 
            this.buttonModifierAdherent.Location = new System.Drawing.Point(418, 511);
            this.buttonModifierAdherent.Name = "buttonModifierAdherent";
            this.buttonModifierAdherent.Size = new System.Drawing.Size(119, 51);
            this.buttonModifierAdherent.TabIndex = 4;
            this.buttonModifierAdherent.Text = "Modifier";
            this.buttonModifierAdherent.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerAdherent
            // 
            this.buttonSupprimerAdherent.Location = new System.Drawing.Point(543, 511);
            this.buttonSupprimerAdherent.Name = "buttonSupprimerAdherent";
            this.buttonSupprimerAdherent.Size = new System.Drawing.Size(119, 51);
            this.buttonSupprimerAdherent.TabIndex = 5;
            this.buttonSupprimerAdherent.Text = "Supprimer";
            this.buttonSupprimerAdherent.UseVisualStyleBackColor = true;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(33, 97);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(206, 22);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxCodePostale
            // 
            this.textBoxCodePostale.Location = new System.Drawing.Point(33, 294);
            this.textBoxCodePostale.Name = "textBoxCodePostale";
            this.textBoxCodePostale.Size = new System.Drawing.Size(206, 22);
            this.textBoxCodePostale.TabIndex = 8;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(33, 248);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(206, 22);
            this.textBoxVille.TabIndex = 9;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(33, 144);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(206, 22);
            this.textBoxPrenom.TabIndex = 11;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(30, 77);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 12;
            this.labelNom.Text = "Nom";
            this.labelNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(30, 124);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(57, 17);
            this.labelPrenom.TabIndex = 13;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Location = new System.Drawing.Point(30, 179);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(126, 17);
            this.labelDateNaissance.TabIndex = 14;
            this.labelDateNaissance.Text = "Date de naissance";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(30, 228);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(34, 17);
            this.labelVille.TabIndex = 15;
            this.labelVille.Text = "Ville";
            // 
            // labelCodePostale
            // 
            this.labelCodePostale.AutoSize = true;
            this.labelCodePostale.Location = new System.Drawing.Point(30, 274);
            this.labelCodePostale.Name = "labelCodePostale";
            this.labelCodePostale.Size = new System.Drawing.Size(92, 17);
            this.labelCodePostale.TabIndex = 16;
            this.labelCodePostale.Text = "Code Postale";
            // 
            // labelTypeAdhesion
            // 
            this.labelTypeAdhesion.AutoSize = true;
            this.labelTypeAdhesion.Location = new System.Drawing.Point(30, 332);
            this.labelTypeAdhesion.Name = "labelTypeAdhesion";
            this.labelTypeAdhesion.Size = new System.Drawing.Size(113, 17);
            this.labelTypeAdhesion.TabIndex = 18;
            this.labelTypeAdhesion.Text = "Type d\'adhésion";
            // 
            // listViewAdherent
            // 
            this.listViewAdherent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNom,
            this.columnPrenom,
            this.columnDateNaissance,
            this.columnVille,
            this.columnCodePostal,
            this.columnTypeAdhesion});
            this.listViewAdherent.FullRowSelect = true;
            this.listViewAdherent.GridLines = true;
            this.listViewAdherent.Location = new System.Drawing.Point(293, 77);
            this.listViewAdherent.Name = "listViewAdherent";
            this.listViewAdherent.Size = new System.Drawing.Size(596, 418);
            this.listViewAdherent.TabIndex = 19;
            this.listViewAdherent.UseCompatibleStateImageBehavior = false;
            this.listViewAdherent.View = System.Windows.Forms.View.Details;
            // 
            // columnNom
            // 
            this.columnNom.Text = "Nom";
            // 
            // columnPrenom
            // 
            this.columnPrenom.Text = "Prénom";
            // 
            // columnDateNaissance
            // 
            this.columnDateNaissance.Text = "DateNaissance";
            // 
            // columnVille
            // 
            this.columnVille.Text = "Ville";
            // 
            // columnCodePostal
            // 
            this.columnCodePostal.Text = "Code Postal";
            // 
            // columnTypeAdhesion
            // 
            this.columnTypeAdhesion.Text = "TypeAdhesion";
            // 
            // checkedListBoxAdhesion
            // 
            this.checkedListBoxAdhesion.FormattingEnabled = true;
            this.checkedListBoxAdhesion.Location = new System.Drawing.Point(36, 361);
            this.checkedListBoxAdhesion.Name = "checkedListBoxAdhesion";
            this.checkedListBoxAdhesion.Size = new System.Drawing.Size(203, 106);
            this.checkedListBoxAdhesion.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // GestionAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkedListBoxAdhesion);
            this.Controls.Add(this.listViewAdherent);
            this.Controls.Add(this.labelTypeAdhesion);
            this.Controls.Add(this.labelCodePostale);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelDateNaissance);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxCodePostale);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonSupprimerAdherent);
            this.Controls.Add(this.buttonModifierAdherent);
            this.Controls.Add(this.buttonCreerAdherent);
            this.Name = "GestionAdherent";
            this.Size = new System.Drawing.Size(991, 610);
            this.Load += new System.EventHandler(this.Adherent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreerAdherent;
        private System.Windows.Forms.Button buttonModifierAdherent;
        private System.Windows.Forms.Button buttonSupprimerAdherent;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCodePostale;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelCodePostale;
        private System.Windows.Forms.Label labelTypeAdhesion;
        private System.Windows.Forms.ListView listViewAdherent;
        private System.Windows.Forms.ColumnHeader columnNom;
        private System.Windows.Forms.ColumnHeader columnPrenom;
        private System.Windows.Forms.ColumnHeader columnDateNaissance;
        private System.Windows.Forms.ColumnHeader columnVille;
        private System.Windows.Forms.ColumnHeader columnCodePostal;
        private System.Windows.Forms.ColumnHeader columnTypeAdhesion;
        private System.Windows.Forms.CheckedListBox checkedListBoxAdhesion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
