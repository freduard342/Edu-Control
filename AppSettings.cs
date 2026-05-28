using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    /// <summary>
    /// Clase estática que actúa como "cerebro central" de la configuración.
    /// Cualquier form puede leer los valores actuales y suscribirse al evento
    /// ConfiguracionCambiada para recibir notificaciones automáticas.
    /// </summary>
    public static class AppSettings
    {
        // ─── Valores actuales ───────────────────────────────────────────────
        private static string _nombreInstitucion = "Centro Educacional Bautista";
        private static bool _modoOscuro = false;
        private static Image _logoInstitucion = null;  // null = usar imagen por defecto

        // ─── Propiedades públicas ────────────────────────────────────────────
        public static string NombreInstitucion
        {
            get => _nombreInstitucion;
            set
            {
                if (_nombreInstitucion == value) return;
                _nombreInstitucion = value;
                NotificarCambio();
            }
        }

        public static bool ModoOscuro
        {
            get => _modoOscuro;
            set
            {
                if (_modoOscuro == value) return;
                _modoOscuro = value;
                NotificarCambio();
            }
        }

        public static Image LogoInstitucion
        {
            get => _logoInstitucion;
            set
            {
                _logoInstitucion = value;   // null es válido (reset a default)
                NotificarCambio();
            }
        }

        // ─── Evento central ─────────────────────────────────────────────────
        /// <summary>
        /// Se dispara cada vez que cambia cualquier configuración.
        /// Suscríbete en el constructor de cada Form:
        ///     AppSettings.ConfiguracionCambiada += AplicarConfiguracion;
        /// </summary>
        public static event EventHandler ConfiguracionCambiada;

        private static void NotificarCambio()
        {
            ConfiguracionCambiada?.Invoke(null, EventArgs.Empty);
        }

        // ─── Colores según tema ──────────────────────────────────────────────
        public static Color ColorFondo => ModoOscuro ? Color.FromArgb(15, 23, 42) : Color.FromArgb(241, 245, 249);
        public static Color ColorPanel => ModoOscuro ? Color.FromArgb(30, 41, 59) : Color.White;
        public static Color ColorTexto => ModoOscuro ? Color.White : Color.FromArgb(15, 23, 42);
        public static Color ColorTextoGris => ModoOscuro ? Color.LightGray : Color.Gray;
        public static Color ColorAccent => Color.FromArgb(37, 99, 235);

        // ─── Método helper para aplicar tema a cualquier Form ────────────────
        /// <summary>
        /// Aplica el tema actual (claro/oscuro) a un Form de forma recursiva.
        /// Llama a esto dentro de tu handler del evento ConfiguracionCambiada.
        /// </summary>
        public static void AplicarTema(Form form)
        {
            if (form == null || form.IsDisposed) return;

            form.BackColor = ColorFondo;
            AplicarTemaRecursivo(form.Controls);
        }

        private static void AplicarTemaRecursivo(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                // Labels generales
                if (ctrl is Label lbl)
                {
                    // No tocar labels de accent (azul)
                    if (lbl.ForeColor != ColorAccent)
                        lbl.ForeColor = ColorTexto;
                }

                // Panels blancos / de fondo
                if (ctrl.BackColor == Color.White || ctrl.BackColor == Color.FromArgb(241, 245, 249))
                    ctrl.BackColor = ColorPanel;

                // Recurse
                if (ctrl.Controls.Count > 0)
                    AplicarTemaRecursivo(ctrl.Controls);
            }
        }
    }
}