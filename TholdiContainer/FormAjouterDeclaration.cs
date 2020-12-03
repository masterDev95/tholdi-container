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
    }
}
