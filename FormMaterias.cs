using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMaterias : Form
    {
        private readonly Conexion _conexion = new Conexion();

        public FormMaterias()
        {
            InitializeComponent();
            this.Load += FormMaterias_Load;
            // ← suscribirse DESPUÉS del InitializeComponent
            AppSettings.ConfiguracionCambiada += AplicarConfiguracion;

            // ← aplicar al final, cuando ya todos los controles existen
            AplicarConfiguracion(null, EventArgs.Empty);
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
        private void FormMaterias_Load(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void CargarMaterias()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id_Asignatura", typeof(int));
            dt.Columns.Add("Nombre_Asignatura", typeof(string));

            try
            {
                _conexion.AbrirConexion();

                const string sql = @"
SELECT Id_Asignatura, Nombre_Asignatura
FROM Asignatura
WHERE Activo = 1
ORDER BY Nombre_Asignatura;";

                using (var cmd = new SqlCommand(sql, _conexion.cn))
                {
                    cmd.CommandTimeout = 60;
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            dt.Rows.Add(
                                Convert.ToInt32(rdr["Id_Asignatura"]),
                                rdr["Nombre_Asignatura"].ToString()
                            );
                        }
                    }
                }

                dgvMaterias.AutoGenerateColumns = true;
                dgvMaterias.DataSource = dt;

                if (dgvMaterias.Columns["Id_Asignatura"] != null)
                    dgvMaterias.Columns["Id_Asignatura"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando materias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormConfiguracion formConfiguracion = new FormConfiguracion();
            formConfiguracion.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 Estudiante = new Form1();
            Estudiante.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            curso.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormMaestro formMaestro = new FormMaestro();
            formMaestro.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormContacto contacto = new FormContacto();
            contacto.Show();
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

        private void FormMaterias_Load_1(object sender, EventArgs e)
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