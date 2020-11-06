using System.Drawing;
using System.Windows.Forms;

namespace TholdiContainer.Extensions
{
    public static class FormExtension
    {
        public static void CentreHorizontalControl(this Form form, Control control)
        {
            control.Location = new Point(form.Width / 2 - control.Width / 2, control.Location.Y);
        }
    }
}
