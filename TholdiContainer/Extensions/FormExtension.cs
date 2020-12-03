using System.Drawing;
using System.Windows.Forms;

namespace TholdiContainer.Extensions
{
    public static class FormExtension
    {
        /// <summary>
        /// Aligne de façon centrale horizontalement un Control transmit en paramètre.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="control"></param>
        public static void CentrerHorizontalement(this Form form, Control control)
        {
            control.Location = new Point(form.ClientSize.Width / 2 - control.Width / 2, control.Location.Y);
        }

        /// <summary>
        /// Ferme la fenêtre courante pour en afficher une autre.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="fenetreSuivante">La fenêtre à afficher</param>
        public static void ChangerFenetre(this Form form, Form fenetreSuivante)
        {
            form.Hide();
            fenetreSuivante.ShowDialog();
            form.Close();
        }
    }
}
