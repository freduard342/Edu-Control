using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class FrmDashboard : Form
    {
        Conexion conexion = new Conexion();

        public FrmDashboard()
        {
            InitializeComponent();

            dgvDatos.Visible = false;

            CargarTotales();
            CrearGrafico();
        }

        // ==============================
        // CARGAR TOTALES
        // ==============================
        private void CargarTotales()
        {
            try
            {
                conexion.AbrirConexion();

                SqlCommand cmdEst = new SqlCommand(
                    "SELECT COUNT(*) FROM Estudiante WHERE Activo = 1",
                    conexion.cn);

                lblNumEstudiantes.Text =
                    cmdEst.ExecuteScalar().ToString();

                SqlCommand cmdCurso = new SqlCommand(
                    "SELECT COUNT(*) FROM Curso WHERE Activo = 1",
                    conexion.cn);

                lblNumCursos.Text =
                    cmdCurso.ExecuteScalar().ToString();

                // Mensajes fijos
                lblNumMensajes.Text = "8";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // ==============================
        // MOSTRAR ESTUDIANTES
        // ==============================
        private void MostrarEstudiantes()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT 
                        Nombre,
                        Apellido,
                        Direccion,
                        Genero,
                        Fecha_Nacimiento,
                        Nombre_Padres,
                        Telefono_Padre
                      FROM Estudiante
                      WHERE Activo = 1",
                    conexion.cn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvDatos.DataSource = dt;

                dgvDatos.Columns["Fecha_Nacimiento"].HeaderText = "Fecha";
                dgvDatos.Columns["Nombre_Padres"].HeaderText = "Padres";
                dgvDatos.Columns["Telefono_Padre"].HeaderText = "Teléfono";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==============================
        // CREAR GRAFICO
        // ==============================
        private void CrearGrafico()
        {
            Chart grafico = new Chart();

            grafico.Size = new System.Drawing.Size(750, 350);

            grafico.Location = new System.Drawing.Point(80, 170);

            grafico.BackColor = Color.White;

            // AREA DEL GRAFICO
            ChartArea area = new ChartArea();

            area.BackColor = Color.White;

            area.AxisX.Title = "Años";

            area.AxisY.Title = "Cantidad de Estudiantes";

            area.AxisX.MajorGrid.Enabled = false;

            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            grafico.ChartAreas.Add(area);

            // SERIE
            Series serie = new Series();

            serie.ChartType = SeriesChartType.Column;

            serie.Color = Color.DeepSkyBlue;

            serie.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            serie.IsValueShownAsLabel = true;

            // CONSULTA SQL
            string consulta = @"
    SELECT 
        YEAR(Fecha_Ingreso) AS Año,
        COUNT(*) AS Cantidad
    FROM Matricula
    WHERE Activo = 1
    GROUP BY YEAR(Fecha_Ingreso)
    ORDER BY Año";

            try
            {
                conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand(consulta, conexion.cn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    serie.Points.AddXY(
                        dr["Año"].ToString(),
                        dr["Cantidad"]);
                }

                dr.Close();

                grafico.Series.Add(serie);

                // TITULO
                grafico.Titles.Add("Estudiantes Ingresados por Año");

                grafico.Titles[0].Font =
                    new Font("Segoe UI", 16, FontStyle.Bold);

                panelContenido.Controls.Add(grafico);

                grafico.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}