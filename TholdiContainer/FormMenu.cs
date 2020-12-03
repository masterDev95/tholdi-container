using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TholdiContainer.Extensions;

namespace TholdiContainer
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.CentrerHorizontalement(pbTholdi);
            this.CentrerHorizontalement(buttonAjouter);
            this.CentrerHorizontalement(buttonConsulter);
            this.CentrerHorizontalement(buttonModifier);
            this.CentrerHorizontalement(buttonSupprimer);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.ChangerFenetre(new FormAjouterDeclaration());
        }

        private void buttonConsulter_Click(object sender, EventArgs e)
        {
            this.ChangerFenetre(new FormConsulterDeclaration());
        }
    }
}
