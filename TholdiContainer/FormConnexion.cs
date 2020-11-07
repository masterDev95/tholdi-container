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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            // Centrage horizontal des controls
            this.CentrerHorizontalement(pbTholdi);
            this.CentrerHorizontalement(textBoxIdentifiant);
            this.CentrerHorizontalement(textBoxMotDePasse);
            this.CentrerHorizontalement(buttonConnexion);
        }
    }
}
