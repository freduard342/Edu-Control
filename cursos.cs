using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Cursos : Form
    {
        private Timer reloj;

        private readonly Conexion _conexion =
            new Conexion();

        public Cursos()
        {
            InitializeComponent();

            // ← suscribirse DESPUÉS del InitializeComponent
            AppSettings.ConfiguracionCambiada += AplicarConfiguracion;

            // ← aplicar al final, cuando ya todos los controles existen
            AplicarConfiguracion(null, EventArgs.Empty);
            // =========================
            // FECHA Y HORA
            // =========================

            reloj = new Timer();

            reloj.Interval = 1000;

            reloj.Tick += (s, e) =>
            {
                lblFecha.Text =
                    DateTime.Now.ToString(
                        "dd/MM/yyyy hh:mm:ss tt"
                    );
            };

            reloj.Start();

            // =========================
            // CONFIGURAR DGV
            // =========================

            dgvCursos.AutoGenerateColumns =
                false;

            dgvCursos.SelectionMode =
                DataGridViewSelectionMode
                .FullRowSelect;

            dgvCursos.MultiSelect =
                false;

            dgvCursos.ReadOnly =
                true;

            dgvCursos.AllowUserToAddRows =
                false;

            dgvCursos.AllowUserToDeleteRows =
                false;

            dgvCursos.AllowUserToResizeRows =
                false;

            dgvCursos.RowHeadersVisible =
                false;

            dgvCursos.EnableHeadersVisualStyles =
                false;

            dgvCursos.DefaultCellStyle
                .SelectionBackColor =
                Color.White;

            dgvCursos.DefaultCellStyle
                .SelectionForeColor =
                Color.Black;

            dgvCursos.RowsDefaultCellStyle
                .SelectionBackColor =
                Color.White;

            dgvCursos.RowsDefaultCellStyle
                .SelectionForeColor =
                Color.Black;

            // =========================
            // DATA PROPERTY
            // =========================

            Curso.DataPropertyName =
                "Nombre_Curso";

            Maestro.DataPropertyName =
                "Maestro";

            Estudiantes.DataPropertyName =
                "Estudiantes";

            // =========================
            // EVENTOS
            // =========================

            dgvCursos.CellDoubleClick +=
                DgvCursos_CellDoubleClick;
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

        // ==========================================
        // LOAD
        // ==========================================

        private void Cursos_Load(
            object sender,
            EventArgs e)
        {
            CargarCursos();
        }

        // ==========================================
        // CARGAR CURSOS
        // ==========================================

        private void CargarCursos()
        {
            DataTable dt =
                new DataTable();

            dt.Columns.Add(
                "Id_Curso",
                typeof(int));

            dt.Columns.Add(
                "Nombre_Curso",
                typeof(string));

            dt.Columns.Add(
                "Maestro",
                typeof(string));

            dt.Columns.Add(
                "Estudiantes",
                typeof(int));

            try
            {
                _conexion.AbrirConexion();

                string sql = @"

SELECT 
    c.Id_Curso,
    c.Nombre_Curso,

    ISNULL(m.Nombre,'')
    + ' ' +
    ISNULL(m.Apellido,'')

    AS Maestro,

    (
        SELECT COUNT(*)
        FROM Matricula mat
        WHERE mat.Id_Curso = c.Id_Curso
        AND mat.Activo = 1
    )

    AS Estudiantes

FROM Curso c

LEFT JOIN Maestro m
ON c.Id_Maestro = m.Id_Maestro

WHERE c.Activo = 1

ORDER BY c.Id_Curso";

                using (
                    SqlCommand cmd =
                    new SqlCommand(
                        sql,
                        _conexion.cn
                    )
                )

                using (
                    SqlDataReader reader =
                    cmd.ExecuteReader()
                )
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(

                            Convert.ToInt32(
                                reader["Id_Curso"]
                            ),

                            reader["Nombre_Curso"]
                            .ToString(),

                            reader["Maestro"]
                            .ToString(),

                            Convert.ToInt32(
                                reader["Estudiantes"]
                            )
                        );
                    }
                }

                dgvCursos.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error cargando cursos: "
                    + ex.Message,

                    "Error",

                    MessageBoxButtons.OK,

                    MessageBoxIcon.Error
                );
            }

            finally
            {
                _conexion.CerrarConexion();
            }
        }

        // ==========================================
        // DOBLE CLICK
        // ==========================================

        private void DgvCursos_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataRowView row =
                dgvCursos.Rows[e.RowIndex]
                .DataBoundItem
                as DataRowView;

            if (row == null)
                return;

            int idCurso =
                Convert.ToInt32(
                    row.Row["Id_Curso"]
                );

            El_curso_Tal detalle =
                new El_curso_Tal(idCurso);

            detalle.ShowDialog();

            CargarCursos();
        }

        // ==========================================
        // VOLVER
        // ==========================================

        private void btnVolver_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        // ==========================================
        // BOTONES TANDA
        // ==========================================

        private void btnTandaMatutina_Click(
            object sender,
            EventArgs e)
        {
            labelTitulo.Text =
                "Listado de Cursos - Tanda Matutina";
        }

        private void btnTandaVespertina_Click(
            object sender,
            EventArgs e)
        {
            labelTitulo.Text =
                "Listado de Cursos - Tanda Vespertina";
        }

        // ==========================================
        // MENÚ
        // ==========================================

        private void button9_Click(
            object sender,
            EventArgs e)
        {
            Form1 estudiante =
                new Form1();

            estudiante.Show();
        }

        private void button10_Click(
            object sender,
            EventArgs e)
        {
            Cursos curso =
                new Cursos();

            curso.Show();
        }

        private void button11_Click(
            object sender,
            EventArgs e)
        {
            Listado_Maestro maestro =
                new Listado_Maestro();

            maestro.Show();
        }

        private void button12_Click(
            object sender,
            EventArgs e)
        {
            FormContacto contacto =
                new FormContacto();

            contacto.Show();
        }

        private void button8_Click(
            object sender,
            EventArgs e)
        {
            FormConfiguracion configuracion =
                new FormConfiguracion();

            configuracion.Show();
        }

        private void button13_Click(
            object sender,
            EventArgs e)
        {
            FormMaterias materias =
                new FormMaterias();

            materias.Show();
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

        private void panelCursos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}