using System;
using System.Windows.Forms;
using System.Collections.Generic;
using TholdiContainer.Tables;
using System.Diagnostics;

namespace TholdiContainer
{
    public partial class FormAjouterDeclaration : Form
    {
        public FormAjouterDeclaration()
        {
            InitializeComponent();
        }

        private void FormAjouterDeclaration_Load(object sender, EventArgs e)
        {
            listesDesDeclaration.DataSource = Conteneur.FetchAll();
            listesDesDockers.DataSource = Docker.FetchAll();
            listesDesProblemes.DataSource = Probleme.FetchAll();
            comboBoxTypeProbleme.DataSource = Probleme.FetchTypeProbleme();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Declaration nouvelleDeclaration = new Declaration
            {
                CommentaireDeclaration = richTextBoxCommentaire.Text,
                DateDeclaration = DateTime.Now,
                Traite = radioButtonIsTraite.Checked,
                Urgence = radioButtonIsUrgent.Checked,
                UnContainer = dataGridViewConteneur.CurrentRow.DataBoundItem as Conteneur,
                UnDocker = dataGridViewDockers.CurrentRow.DataBoundItem as Docker,
                UnProbleme = Probleme.FetchBy("LIBELLEPROBLEME", comboBoxTypeProbleme.SelectedIndex.ToString())[0],
            };

            nouvelleDeclaration.Save();
        }
    }
}
