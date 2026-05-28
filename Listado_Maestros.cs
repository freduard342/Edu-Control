using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Listado_Maestro : Form
    {
        Label lblFechaHora;
        Timer reloj;
        private readonly Conexion _conexion = new Conexion();

        public Listado_Maestro()
        {
            InitializeComponent();
            // LABEL FECHA Y HORA
            lblFechaHora = new Label(); 
            // ← suscribirse DESPUÉS del InitializeComponent
            AppSettings.ConfiguracionCambiada += AplicarConfiguracion;

            // ← aplicar al final, cuando ya todos los controles existen
            AplicarConfiguracion(null, EventArgs.Empty);
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Arial", 9, FontStyle.Regular);
            lblFechaHora.ForeColor = Color.Black;
            lblFechaHora.BackColor = Color.Transparent;

            // POSICION DEBAJO DE USUARIO
            lblFechaHora.Location = new Point(920, 55);

            // AGREGAR AL FORM
            this.Controls.Add(lblFechaHora);

            // TRAER AL FRENTE
            lblFechaHora.BringToFront();

            // TIMER
            reloj = new Timer();

            reloj.Interval = 1000;

            reloj.Tick += (s, e) =>
            {
                lblFechaHora.Text =
                    DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss tt");
            };

            reloj.Start();

            // Eventos
            this.Load += Listado_Maestro_Load;
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

        private void Listado_Maestro_Load(object sender, EventArgs e)
        {
            CargarMaestros();
        }

        private void CargarMaestros()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id_Maestro", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Telefono", typeof(string));
            dt.Columns.Add("Direccion", typeof(string));
            dt.Columns.Add("Usuario", typeof(string));

            try
            {
                _conexion.AbrirConexion();

                const string sql = @"
SELECT m.Id_Maestro, m.Nombre, m.Apellido, ISNULL(m.Telefono,'') AS Telefono, ISNULL(m.Direccion,'') AS Direccion,
       ISNULL(u.Nombre_Usuario,'') AS Usuario
FROM Maestro m
LEFT JOIN Usuario u ON m.Id_Usuario = u.Id_Usuario
WHERE m.Activo = 1
ORDER BY m.Nombre, m.Apellido;";

                using (var cmd = new SqlCommand(sql, _conexion.cn))
                {
                    cmd.CommandTimeout = 60;
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            dt.Rows.Add(
                                Convert.ToInt32(rdr["Id_Maestro"]),
                                rdr["Nombre"].ToString(),
                                rdr["Apellido"].ToString(),
                                rdr["Telefono"].ToString(),
                                rdr["Direccion"].ToString(),
                                rdr["Usuario"].ToString()
                            );
                        }
                    }
                }

                // Asignar al grid
                dgvMaestros.AutoGenerateColumns = true;
                dgvMaestros.DataSource = dt;

                // Ocultar Id si aparece como columna
                if (dgvMaestros.Columns["Id_Maestro"] != null)
                {
                    dgvMaestros.Columns["Id_Maestro"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando maestros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormConfiguracion configuracion = new FormConfiguracion();
            configuracion.Show();
        }
        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            Form1 Estudiante = new Form1();

            Estudiante.Show();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            curso.Show();
        }

        private void btnMaestro_Click(object sender, EventArgs e)
        {

        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FormMaterias Materias = new FormMaterias();
            Materias.Show();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            FormContacto contacto = new FormContacto();
            contacto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConfiguracion formConfiguracion = new FormConfiguracion();
            formConfiguracion.Show();
        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn(object sender, EventArgs e)
        {

        }

        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
    "¿Estás seguro de que quieres cerrar sesión?",
    "Cerrar Sesión",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void Listado_Maestro_Load_1(object sender, EventArgs e)
        {
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