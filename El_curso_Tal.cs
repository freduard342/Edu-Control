using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class El_curso_Tal : Form
    {
        private readonly int _idCurso;
        private readonly Conexion _conexion = new Conexion();

        // Labels dinámicos para mostrar información del curso/maestro si no existen en el diseñador
        private Label lblCursoInfo;
        private Label lblMaestroInfo;

        public El_curso_Tal(int idCurso)
        {
            _idCurso = idCurso;
            InitializeComponent();

            // Preparar controles dinámicos si no existen en el diseñador
            if (this.Controls["lblCursoInfo"] == null)
            {
                lblCursoInfo = new Label
                {
                    Name = "lblCursoInfo",
                    AutoSize = true,
                    Font = new Font("Arial Narrow", 14F, FontStyle.Bold),
                    Location = new Point(16, 16)
                };
                this.Controls.Add(lblCursoInfo);
            }
            else
            {
                lblCursoInfo = (Label)this.Controls["lblCursoInfo"];
            }

            if (this.Controls["lblMaestroInfo"] == null)
            {
                lblMaestroInfo = new Label
                {
                    Name = "lblMaestroInfo",
                    AutoSize = true,
                    Font = new Font("Arial", 10F, FontStyle.Regular),
                    Location = new Point(16, 46)
                };
                this.Controls.Add(lblMaestroInfo);
            }
            else
            {
                lblMaestroInfo = (Label)this.Controls["lblMaestroInfo"];
            }

            // Asegurar que dgvEstudiantes exista y esté listo
            dgvEstudiantes.AutoGenerateColumns = false;
            dgvEstudiantes.Columns.Clear();
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.MultiSelect = false;
            dgvEstudiantes.ReadOnly = true;

            // Columnas: Número (secuencia), Nombre, Apellido, Fecha Nac.
            dgvEstudiantes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Numero", HeaderText = "N.º", Width = 60, DataPropertyName = "Numero" });
            dgvEstudiantes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, DataPropertyName = "Nombre" });
            dgvEstudiantes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Apellido", HeaderText = "Apellido", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, DataPropertyName = "Apellido" });
            dgvEstudiantes.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaNac", HeaderText = "Fecha Nacimiento", Width = 140, DataPropertyName = "FechaNac" });

            this.Load += El_curso_Tal_Load;
        }

        private void El_curso_Tal_Load(object sender, EventArgs e)
        {
            CargarDetalleCurso();
            CargarEstudiantes();
            AplicarEstiloFilasAlternas();
        }

        private void CargarDetalleCurso()
        {
            try
            {
                _conexion.AbrirConexion();
                const string sql = @"
SELECT c.Nombre_Curso, c.Nivel, c.Tanda, m.Id_Maestro, ISNULL(m.Nombre,'') AS MaestroNombre, ISNULL(m.Apellido,'') AS MaestroApellido, ISNULL(m.Telefono,'') AS MaestroTelefono
FROM Curso c
LEFT JOIN Maestro m ON c.Id_Maestro = m.Id_Maestro
WHERE c.Id_Curso = @IdCurso;";

                using (var cmd = new SqlCommand(sql, _conexion.cn))
                {
                    cmd.Parameters.AddWithValue("@IdCurso", _idCurso);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            string nombreCurso = rdr["Nombre_Curso"].ToString();
                            string nivel = rdr["Nivel"].ToString();
                            string tanda = rdr["Tanda"].ToString();
                            string maestroNombre = rdr["MaestroNombre"].ToString();
                            string maestroApellido = rdr["MaestroApellido"].ToString();
                            string maestroTelefono = rdr["MaestroTelefono"].ToString();

                            lblCursoInfo.Text = $"{nombreCurso} — {nivel} ({tanda})";
                            lblMaestroInfo.Text = $"Maestro: {maestroNombre} {maestroApellido}  |  Tel: {maestroTelefono}";
                        }
                        else
                        {
                            lblCursoInfo.Text = "Curso no encontrado.";
                            lblMaestroInfo.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalle del curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }

        private void CargarEstudiantes()
        {
            var dt = new DataTable();
            dt.Columns.Add("Numero", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("FechaNac", typeof(string));

            try
            {
                _conexion.AbrirConexion();
                const string sql = @"
SELECT e.Id_Estudiante, e.Nombre, e.Apellido, e.Fecha_Nacimiento
FROM Matricula mat
JOIN Estudiante e ON mat.Id_Estudiante = e.Id_Estudiante
WHERE mat.Id_Curso = @IdCurso AND mat.Activo = 1 AND e.Activo = 1
ORDER BY e.Nombre, e.Apellido;";

                using (var cmd = new SqlCommand(sql, _conexion.cn))
                {
                    cmd.Parameters.AddWithValue("@IdCurso", _idCurso);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        int seq = 1;
                        while (rdr.Read())
                        {
                            var fecha = DBNull.Value.Equals(rdr["Fecha_Nacimiento"]) ? "" : Convert.ToDateTime(rdr["Fecha_Nacimiento"]).ToString("yyyy-MM-dd");
                            dt.Rows.Add(seq++, rdr["Nombre"].ToString(), rdr["Apellido"].ToString(), fecha);
                        }
                    }
                }

                dgvEstudiantes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }

        private void AplicarEstiloFilasAlternas()
        {
            dgvEstudiantes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvEstudiantes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
        }
    }
}