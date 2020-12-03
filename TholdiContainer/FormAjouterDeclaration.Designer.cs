
namespace TholdiContainer
{
    partial class FormAjouterDeclaration
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewConteneur = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypeProbleme = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonIsUrgent = new System.Windows.Forms.RadioButton();
            this.radioButtonisNotUrgent = new System.Windows.Forms.RadioButton();
            this.panelRadioUrgent = new System.Windows.Forms.Panel();
            this.codeDockerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDockerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDockerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listesDesDockers = new System.Windows.Forms.BindingSource(this.components);
            this.numContainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAchatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeContainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDerniereInspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listesDesDeclaration = new System.Windows.Forms.BindingSource(this.components);
            this.listesDesProblemes = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConteneur)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelRadioUrgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listesDesDockers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listesDesDeclaration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listesDesProblemes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConteneur
            // 
            this.dataGridViewConteneur.AllowUserToAddRows = false;
            this.dataGridViewConteneur.AllowUserToDeleteRows = false;
            this.dataGridViewConteneur.AllowUserToResizeColumns = false;
            this.dataGridViewConteneur.AllowUserToResizeRows = false;
            this.dataGridViewConteneur.AutoGenerateColumns = false;
            this.dataGridViewConteneur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewConteneur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numContainerDataGridViewTextBoxColumn,
            this.dateAchatDataGridViewTextBoxColumn,
            this.typeContainerDataGridViewTextBoxColumn,
            this.dateDerniereInspDataGridViewTextBoxColumn});
            this.dataGridViewConteneur.DataSource = this.listesDesDeclaration;
            this.dataGridViewConteneur.Location = new System.Drawing.Point(23, 30);
            this.dataGridViewConteneur.MultiSelect = false;
            this.dataGridViewConteneur.Name = "dataGridViewConteneur";
            this.dataGridViewConteneur.ReadOnly = true;
            this.dataGridViewConteneur.Size = new System.Drawing.Size(610, 136);
            this.dataGridViewConteneur.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewConteneur);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Containers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(25, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dockers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDockerDataGridViewTextBoxColumn,
            this.nomDockerDataGridViewTextBoxColumn,
            this.prenomDockerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listesDesDockers;
            this.dataGridView1.Location = new System.Drawing.Point(23, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(610, 136);
            this.dataGridView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(235, 84);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panelRadioUrgent);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(714, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 225);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Commentaire:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBoxTypeProbleme);
            this.groupBox3.Location = new System.Drawing.Point(714, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Problème";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type de problème";
            // 
            // comboBoxTypeProbleme
            // 
            this.comboBoxTypeProbleme.FormattingEnabled = true;
            this.comboBoxTypeProbleme.Location = new System.Drawing.Point(27, 55);
            this.comboBoxTypeProbleme.Name = "comboBoxTypeProbleme";
            this.comboBoxTypeProbleme.Size = new System.Drawing.Size(168, 21);
            this.comboBoxTypeProbleme.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Urgent:";
            // 
            // radioButtonIsUrgent
            // 
            this.radioButtonIsUrgent.AutoSize = true;
            this.radioButtonIsUrgent.Location = new System.Drawing.Point(3, 3);
            this.radioButtonIsUrgent.Name = "radioButtonIsUrgent";
            this.radioButtonIsUrgent.Size = new System.Drawing.Size(41, 17);
            this.radioButtonIsUrgent.TabIndex = 5;
            this.radioButtonIsUrgent.TabStop = true;
            this.radioButtonIsUrgent.Text = "Oui";
            this.radioButtonIsUrgent.UseVisualStyleBackColor = true;
            // 
            // radioButtonisNotUrgent
            // 
            this.radioButtonisNotUrgent.AutoSize = true;
            this.radioButtonisNotUrgent.Location = new System.Drawing.Point(50, 3);
            this.radioButtonisNotUrgent.Name = "radioButtonisNotUrgent";
            this.radioButtonisNotUrgent.Size = new System.Drawing.Size(45, 17);
            this.radioButtonisNotUrgent.TabIndex = 6;
            this.radioButtonisNotUrgent.TabStop = true;
            this.radioButtonisNotUrgent.Text = "Non";
            this.radioButtonisNotUrgent.UseVisualStyleBackColor = true;
            // 
            // panelRadioUrgent
            // 
            this.panelRadioUrgent.Controls.Add(this.radioButtonIsUrgent);
            this.panelRadioUrgent.Controls.Add(this.radioButtonisNotUrgent);
            this.panelRadioUrgent.Location = new System.Drawing.Point(27, 179);
            this.panelRadioUrgent.Name = "panelRadioUrgent";
            this.panelRadioUrgent.Size = new System.Drawing.Size(97, 23);
            this.panelRadioUrgent.TabIndex = 7;
            // 
            // codeDockerDataGridViewTextBoxColumn
            // 
            this.codeDockerDataGridViewTextBoxColumn.DataPropertyName = "CodeDocker";
            this.codeDockerDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDockerDataGridViewTextBoxColumn.Name = "codeDockerDataGridViewTextBoxColumn";
            this.codeDockerDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDockerDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomDockerDataGridViewTextBoxColumn
            // 
            this.nomDockerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomDockerDataGridViewTextBoxColumn.DataPropertyName = "NomDocker";
            this.nomDockerDataGridViewTextBoxColumn.HeaderText = "Nom Docker";
            this.nomDockerDataGridViewTextBoxColumn.Name = "nomDockerDataGridViewTextBoxColumn";
            this.nomDockerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDockerDataGridViewTextBoxColumn
            // 
            this.prenomDockerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenomDockerDataGridViewTextBoxColumn.DataPropertyName = "PrenomDocker";
            this.prenomDockerDataGridViewTextBoxColumn.HeaderText = "Prenom Docker";
            this.prenomDockerDataGridViewTextBoxColumn.Name = "prenomDockerDataGridViewTextBoxColumn";
            this.prenomDockerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listesDesDockers
            // 
            this.listesDesDockers.DataSource = typeof(TholdiContainer.Tables.Docker);
            // 
            // numContainerDataGridViewTextBoxColumn
            // 
            this.numContainerDataGridViewTextBoxColumn.DataPropertyName = "NumContainer";
            this.numContainerDataGridViewTextBoxColumn.HeaderText = "N° Container";
            this.numContainerDataGridViewTextBoxColumn.Name = "numContainerDataGridViewTextBoxColumn";
            this.numContainerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAchatDataGridViewTextBoxColumn
            // 
            this.dateAchatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateAchatDataGridViewTextBoxColumn.DataPropertyName = "DateAchat";
            this.dateAchatDataGridViewTextBoxColumn.HeaderText = "Date Achat";
            this.dateAchatDataGridViewTextBoxColumn.Name = "dateAchatDataGridViewTextBoxColumn";
            this.dateAchatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeContainerDataGridViewTextBoxColumn
            // 
            this.typeContainerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeContainerDataGridViewTextBoxColumn.DataPropertyName = "TypeContainer";
            this.typeContainerDataGridViewTextBoxColumn.HeaderText = "Type Container";
            this.typeContainerDataGridViewTextBoxColumn.Name = "typeContainerDataGridViewTextBoxColumn";
            this.typeContainerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDerniereInspDataGridViewTextBoxColumn
            // 
            this.dateDerniereInspDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDerniereInspDataGridViewTextBoxColumn.DataPropertyName = "DateDerniereInsp";
            this.dateDerniereInspDataGridViewTextBoxColumn.HeaderText = "Date Derniere Insp.";
            this.dateDerniereInspDataGridViewTextBoxColumn.Name = "dateDerniereInspDataGridViewTextBoxColumn";
            this.dateDerniereInspDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listesDesDeclaration
            // 
            this.listesDesDeclaration.DataSource = typeof(TholdiContainer.Tables.Conteneur);
            // 
            // listesDesProblemes
            // 
            this.listesDesProblemes.DataSource = typeof(TholdiContainer.Tables.Probleme);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(912, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAjouterDeclaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAjouterDeclaration";
            this.Text = "Ajouter une déclaration";
            this.Load += new System.EventHandler(this.FormAjouterDeclaration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConteneur)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelRadioUrgent.ResumeLayout(false);
            this.panelRadioUrgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listesDesDockers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listesDesDeclaration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listesDesProblemes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConteneur;
        private System.Windows.Forms.DataGridViewTextBoxColumn numContainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAchatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeContainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDerniereInspDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listesDesDeclaration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource listesDesDockers;
        private System.Windows.Forms.BindingSource listesDesProblemes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDockerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDockerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDockerDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTypeProbleme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonisNotUrgent;
        private System.Windows.Forms.RadioButton radioButtonIsUrgent;
        private System.Windows.Forms.Panel panelRadioUrgent;
        private System.Windows.Forms.Button button1;
    }
}