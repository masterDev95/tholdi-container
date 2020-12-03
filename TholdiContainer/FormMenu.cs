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

        private Form _mdiChild;
        private Form MdiChild
        {
            get { return _mdiChild; }
            set
            {
                if (_mdiChild != null)
                {
                    _mdiChild.Dispose();
                }
                _mdiChild = value;
                _mdiChild.MdiParent = this;
                _mdiChild.MaximumSize = _mdiChild.Size;
                _mdiChild.MinimumSize = _mdiChild.Size;
                _mdiChild.Show();

            }
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
            MdiChild = new FormAjouterDeclaration();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            MdiChild = new FormModifierDeclaration();
        }

        private void buttonConsulter_Click(object sender, EventArgs e)
        {
            MdiChild = new FormConsulterDeclaration();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            MdiChild = new FormSupprimerDeclaration();
        }
    }
}
