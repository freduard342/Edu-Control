using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormContacto : Form
    {
        Timer reloj = new Timer();
        private void FormContacto_Load(object sender, EventArgs e)
        {
            Tema.AplicarTema(this);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form1 estudiante = new Form1();
            estudiante.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            curso.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Listado_Maestro maestro = new Listado_Maestro();
            maestro.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            FormConfiguracion configuracion = new FormConfiguracion();
            configuracion.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormMaterias materias = new FormMaterias();
            materias.Show();
        }
        public FormContacto()
        {
            InitializeComponent();

            // ← suscribirse DESPUÉS del InitializeComponent
            AppSettings.ConfiguracionCambiada += AplicarConfiguracion;

            // ← aplicar al final, cuando ya todos los controles existen
            AplicarConfiguracion(null, EventArgs.Empty);

            reloj.Interval = 1000;

            reloj.Tick += (s, e) =>
            {
                lblFecha.Text =
                    DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            };

            reloj.Start();

            // DATOS DEMO
            cmbEstudiante.Items.Add("Juan Pérez");
            cmbEstudiante.Items.Add("María López");
            cmbEstudiante.Items.Add("Carlos Sánchez");

            cmbCurso.Items.Add("6to Primaria");
            cmbCurso.Items.Add("1ro Secundaria");
            cmbCurso.Items.Add("5to Secundaria");
        }
        private void AplicarConfiguracion(object sender, EventArgs e)
        {
            if (IsDisposed) return;
            if (InvokeRequired) { Invoke(new Action(() => AplicarConfiguracion(sender, e))); return; }

            // null check antes de cada asignación
            if (lblInstitucion != null)
                lblInstitucion.Text = AppSettings.NombreInstitucion;

            if (pictureBox1 != null && AppSettings.LogoInstitucion != null)
                pictureBox1.Image = AppSettings.LogoInstitucion;

            AppSettings.AplicarTema(this);
            // restaurar sidebar que siempre es oscuro
            if (panelSidebar != null)
                panelSidebar.BackColor = Color.FromArgb(7, 26, 66);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            AppSettings.ConfiguracionCambiada -= AplicarConfiguracion;
            base.OnFormClosed(e);
        }
        // =====================================================
        // BOTON ENVIAR
        // =====================================================

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Mensaje enviado correctamente.",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =====================================================
        // BOTON LIMPIAR
        // =====================================================

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbEstudiante.SelectedIndex = -1;
            cmbCurso.SelectedIndex = -1;

            txtTelefono.Clear();
            txtEmail.Clear();
            txtMensaje.Clear();
        }

        // =====================================================
        // BOTON ELIMINAR
        // =====================================================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtMensaje.Clear();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
   "¿Estás seguro de que quieres cerrar sesión?",
   "Cerrar Sesión",
   MessageBoxButtons.YesNo,
   MessageBoxIcon.Question
);

            if (resultado == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSoporte Soporte = new FormSoporte();
            Soporte.Show();
        }

        private void lblSistema_Click(object sender, EventArgs e)
        {
            FormPrincipal Principal = new FormPrincipal();
            Principal.Show();
        }
    }
}