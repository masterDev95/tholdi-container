using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TholdiContainer
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void CentreHorizontalControl(Control control)
        {
            control.Location = new Point(this.Width / 2 - control.Width / 2, control.Location.Y);
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            // Centrage horizontal des controls
            CentreHorizontalControl(pbTholdi);
            CentreHorizontalControl(textBoxIdentifiant);
            CentreHorizontalControl(textBoxMotDePasse);
            CentreHorizontalControl(buttonConnexion);
        }
    }
}
