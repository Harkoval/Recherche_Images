
namespace Ex3
{
    partial class Form1
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
            this.lstPhoto = new System.Windows.Forms.ListBox();
            this.btnDossier = new System.Windows.Forms.Button();
            this.btnRotation = new System.Windows.Forms.Button();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPhoto
            // 
            this.lstPhoto.FormattingEnabled = true;
            this.lstPhoto.HorizontalScrollbar = true;
            this.lstPhoto.ItemHeight = 16;
            this.lstPhoto.Location = new System.Drawing.Point(13, 13);
            this.lstPhoto.Name = "lstPhoto";
            this.lstPhoto.Size = new System.Drawing.Size(146, 148);
            this.lstPhoto.TabIndex = 0;
            this.lstPhoto.SelectedIndexChanged += new System.EventHandler(this.lstPhoto_SelectedIndexChanged);
            // 
            // btnDossier
            // 
            this.btnDossier.Image = global::Ex3.Properties.Resources.dossier;
            this.btnDossier.Location = new System.Drawing.Point(93, 181);
            this.btnDossier.Name = "btnDossier";
            this.btnDossier.Size = new System.Drawing.Size(66, 61);
            this.btnDossier.TabIndex = 1;
            this.btnDossier.UseVisualStyleBackColor = true;
            this.btnDossier.Click += new System.EventHandler(this.btnDossier_Click);
            // 
            // btnRotation
            // 
            this.btnRotation.BackgroundImage = global::Ex3.Properties.Resources.pivoter;
            this.btnRotation.Location = new System.Drawing.Point(13, 181);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(74, 72);
            this.btnRotation.TabIndex = 2;
            this.btnRotation.UseVisualStyleBackColor = true;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(166, 13);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(340, 322);
            this.pctPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPhoto.TabIndex = 3;
            this.pctPhoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 347);
            this.Controls.Add(this.pctPhoto);
            this.Controls.Add(this.btnRotation);
            this.Controls.Add(this.btnDossier);
            this.Controls.Add(this.lstPhoto);
            this.Name = "Form1";
            this.Text = "DossierListe";
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPhoto;
        private System.Windows.Forms.Button btnDossier;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.PictureBox pctPhoto;
    }
}

