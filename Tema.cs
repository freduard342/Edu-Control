using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public static class Tema
    {
        // Variable global
        public static bool ModoOscuro = false;

        // Método para aplicar tema
        public static void AplicarTema(Form form)
        {
            if (ModoOscuro)
            {
                form.BackColor = Color.FromArgb(25, 25, 25);
                form.ForeColor = Color.White;

                CambiarControles(form.Controls, true);
            }
            else
            {
                form.BackColor = Color.White;
                form.ForeColor = Color.Black;

                CambiarControles(form.Controls, false);
            }
        }

        // Cambiar controles automáticamente
        private static void CambiarControles(Control.ControlCollection controles, bool oscuro)
        {
            foreach (Control c in controles)
            {
                if (oscuro)
                {
                    c.BackColor = Color.FromArgb(35, 35, 35);
                    c.ForeColor = Color.White;
                }
                else
                {
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                }

                // Recorrer controles hijos
                if (c.HasChildren)
                {
                    CambiarControles(c.Controls, oscuro);
                }
            }
        }
    }
}