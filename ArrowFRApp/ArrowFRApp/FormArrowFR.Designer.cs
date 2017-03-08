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
            this.buttonEntrer = new System.Windows.Forms.Button();
            this.pictureArrowFR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowFR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEntrer
            // 
            this.buttonEntrer.Location = new System.Drawing.Point(395, 458);
            this.buttonEntrer.Name = "buttonEntrer";
            this.buttonEntrer.Size = new System.Drawing.Size(261, 82);
            this.buttonEntrer.TabIndex = 0;
            this.buttonEntrer.Text = "ENTRER";
            this.buttonEntrer.UseVisualStyleBackColor = true;
            this.buttonEntrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureArrowFR
            // 
            this.pictureArrowFR.Location = new System.Drawing.Point(395, 138);
            this.pictureArrowFR.Name = "pictureArrowFR";
            this.pictureArrowFR.Size = new System.Drawing.Size(261, 219);
            this.pictureArrowFR.TabIndex = 1;
            this.pictureArrowFR.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 689);
            this.Controls.Add(this.pictureArrowFR);
            this.Controls.Add(this.buttonEntrer);
            this.Name = "Accueil";
            this.Text = "ArrowFRApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowFR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrer;
        private System.Windows.Forms.PictureBox pictureArrowFR;
    }
}

