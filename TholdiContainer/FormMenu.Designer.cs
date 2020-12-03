namespace TholdiContainer
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonConsulter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.pbTholdi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTholdi)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(95, 115);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(24, 24, 0, 24);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(207, 41);
            this.buttonAjouter.TabIndex = 1;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(95, 180);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(24, 24, 0, 24);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(207, 45);
            this.buttonModifier.TabIndex = 2;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonConsulter
            // 
            this.buttonConsulter.Location = new System.Drawing.Point(95, 249);
            this.buttonConsulter.Margin = new System.Windows.Forms.Padding(24, 0, 0, 24);
            this.buttonConsulter.Name = "buttonConsulter";
            this.buttonConsulter.Size = new System.Drawing.Size(207, 45);
            this.buttonConsulter.TabIndex = 3;
            this.buttonConsulter.Text = "Consulter";
            this.buttonConsulter.UseVisualStyleBackColor = true;
            this.buttonConsulter.Click += new System.EventHandler(this.buttonConsulter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(95, 318);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(24, 0, 24, 24);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(207, 45);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // pbTholdi
            // 
            this.pbTholdi.Image = global::TholdiContainer.Properties.Resources.Tholdi;
            this.pbTholdi.Location = new System.Drawing.Point(113, 28);
            this.pbTholdi.Name = "pbTholdi";
            this.pbTholdi.Size = new System.Drawing.Size(170, 60);
            this.pbTholdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTholdi.TabIndex = 0;
            this.pbTholdi.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 406);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonConsulter);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.pbTholdi);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTholdi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonConsulter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.PictureBox pbTholdi;
    }
}