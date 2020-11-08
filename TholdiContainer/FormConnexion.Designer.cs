namespace TholdiContainer
{
    partial class FormConnexion
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
            this.pbTholdi = new System.Windows.Forms.PictureBox();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelMotDePasse = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTholdi)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTholdi
            // 
            this.pbTholdi.Image = global::TholdiContainer.Properties.Resources.Tholdi;
            this.pbTholdi.Location = new System.Drawing.Point(128, 28);
            this.pbTholdi.Name = "pbTholdi";
            this.pbTholdi.Size = new System.Drawing.Size(170, 59);
            this.pbTholdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTholdi.TabIndex = 0;
            this.pbTholdi.TabStop = false;
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(111, 133);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(201, 20);
            this.textBoxIdentifiant.TabIndex = 1;
            // 
            // textBoxMotDePasse
            // 
            this.textBoxMotDePasse.Location = new System.Drawing.Point(111, 194);
            this.textBoxMotDePasse.Name = "textBoxMotDePasse";
            this.textBoxMotDePasse.PasswordChar = '•';
            this.textBoxMotDePasse.Size = new System.Drawing.Size(201, 20);
            this.textBoxMotDePasse.TabIndex = 2;
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(116, 112);
            this.labelIdentifiant.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.labelIdentifiant.TabIndex = 3;
            this.labelIdentifiant.Text = "Identifiant";
            // 
            // labelMotDePasse
            // 
            this.labelMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMotDePasse.AutoSize = true;
            this.labelMotDePasse.Location = new System.Drawing.Point(116, 173);
            this.labelMotDePasse.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelMotDePasse.Name = "labelMotDePasse";
            this.labelMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.labelMotDePasse.TabIndex = 4;
            this.labelMotDePasse.Text = "Mot de passe";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(164, 240);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(108, 38);
            this.buttonConnexion.TabIndex = 5;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            // 
            // FormConnexion
            // 
            this.AcceptButton = this.buttonConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 309);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.labelMotDePasse);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.textBoxMotDePasse);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.pbTholdi);
            this.Name = "FormConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.FormConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTholdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTholdi;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxMotDePasse;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelMotDePasse;
        private System.Windows.Forms.Button buttonConnexion;
    }
}

