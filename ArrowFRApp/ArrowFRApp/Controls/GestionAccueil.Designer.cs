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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionAccueil));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelGestion = new System.Windows.Forms.Panel();
            this.buttonGestionAdherent = new System.Windows.Forms.Button();
            this.buttonGestionTypeAdhesion = new System.Windows.Forms.Button();
            this.buttonRecapitulatif = new System.Windows.Forms.Button();
            this.pictureBoxArrowFr = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowFr)).BeginInit();
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
            this.buttonGestionAdherent.Location = new System.Drawing.Point(33, 261);
            this.buttonGestionAdherent.Name = "buttonGestionAdherent";
            this.buttonGestionAdherent.Size = new System.Drawing.Size(188, 79);
            this.buttonGestionAdherent.TabIndex = 2;
            this.buttonGestionAdherent.Text = "Gestion Adherent";
            this.buttonGestionAdherent.UseVisualStyleBackColor = true;
            this.buttonGestionAdherent.Click += new System.EventHandler(this.buttonGestionAdherent_Click);
            // 
            // buttonGestionTypeAdhesion
            // 
            this.buttonGestionTypeAdhesion.Location = new System.Drawing.Point(33, 356);
            this.buttonGestionTypeAdhesion.Name = "buttonGestionTypeAdhesion";
            this.buttonGestionTypeAdhesion.Size = new System.Drawing.Size(188, 79);
            this.buttonGestionTypeAdhesion.TabIndex = 3;
            this.buttonGestionTypeAdhesion.Text = "Gestion Type Adhesion";
            this.buttonGestionTypeAdhesion.UseVisualStyleBackColor = true;
            this.buttonGestionTypeAdhesion.Click += new System.EventHandler(this.buttonGestionTypeAdhesion_Click_1);
            // 
            // buttonRecapitulatif
            // 
            this.buttonRecapitulatif.Location = new System.Drawing.Point(33, 450);
            this.buttonRecapitulatif.Name = "buttonRecapitulatif";
            this.buttonRecapitulatif.Size = new System.Drawing.Size(188, 82);
            this.buttonRecapitulatif.TabIndex = 4;
            this.buttonRecapitulatif.Text = "Récapitulatif";
            this.buttonRecapitulatif.UseVisualStyleBackColor = true;
            this.buttonRecapitulatif.Click += new System.EventHandler(this.buttonRecapitulatif_Click);
            // 
            // pictureBoxArrowFr
            // 
            this.pictureBoxArrowFr.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrowFr.Image")));
            this.pictureBoxArrowFr.Location = new System.Drawing.Point(56, 64);
            this.pictureBoxArrowFr.Name = "pictureBoxArrowFr";
            this.pictureBoxArrowFr.Size = new System.Drawing.Size(147, 136);
            this.pictureBoxArrowFr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrowFr.TabIndex = 5;
            this.pictureBoxArrowFr.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "ArrowFr";
            // 
            // GestionAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxArrowFr);
            this.Controls.Add(this.buttonRecapitulatif);
            this.Controls.Add(this.buttonGestionTypeAdhesion);
            this.Controls.Add(this.buttonGestionAdherent);
            this.Controls.Add(this.panelGestion);
            this.Controls.Add(this.splitter1);
            this.Name = "GestionAccueil";
            this.Size = new System.Drawing.Size(921, 559);
            this.Load += new System.EventHandler(this.GestionAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowFr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelGestion;
        private System.Windows.Forms.Button buttonGestionAdherent;
        private System.Windows.Forms.Button buttonGestionTypeAdhesion;
        private System.Windows.Forms.Button buttonRecapitulatif;
        private System.Windows.Forms.PictureBox pictureBoxArrowFr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}
