using CapaDatos;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MailKit.Net.Imap;

namespace CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        private readonly Conexion conexion = new Conexion();

        Label lblFechaHora;
        Timer reloj;
        public FormPrincipal()
        {
            InitializeComponent(); // ← suscribirse DESPUÉS del InitializeComponent

            AppSettings.ConfiguracionCambiada += AplicarConfiguracion;

            AplicarConfiguracion(null, EventArgs.Empty);


            // LABEL FECHA Y HORA
            lblFechaHora = new Label();

            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Arial", 9, FontStyle.Regular);
            lblFechaHora.ForeColor = Color.Black;
            lblFechaHora.BackColor = Color.Transparent;

            // POSICION DEBAJO DE USUARIO
            lblFechaHora.Location = new Point(1008, 55);

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




            // Abrir la ventana maximizada (pantalla completa)
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            // Hacer que panelContenido se redimensione con el formulario
            if (panelContenido != null)
            {
                panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }

            // Crear y añadir el gráfico
            CrearGrafico();
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
        private void Reloj_Tick(object sender, EventArgs e)
        {
            MostrarFechaHora();
        }

        private void MostrarFechaHora()
        {
            lblFechaHora.Text =
                "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy") +
                "\nHora: " + DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        // ======= Crear gráfico (misma lógica que FrmDashboard) =======
        private void CrearGrafico()
        {
            var grafico = new Chart
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill
            };

            var area = new ChartArea
            {
                BackColor = Color.White
            };

            area.AxisX.Title = "Años";
            area.AxisY.Title = "Cantidad de Estudiantes";
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            grafico.ChartAreas.Add(area);

            var serie = new Series
            {
                ChartType = SeriesChartType.Column,
                Color = Color.DeepSkyBlue,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                IsValueShownAsLabel = true
            };

            // Ahora consultamos Matricula.Fecha_Ingreso (la columna existe en Matricula)
            const string consulta = @"
SELECT 
    YEAR(Fecha_Ingreso) AS Año,
    COUNT(*) AS Cantidad
FROM Estudiante
WHERE Activo = 1
GROUP BY YEAR(Fecha_Ingreso)
ORDER BY Año;";

            try
            {
                conexion.AbrirConexion();

                using (var cmd = new SqlCommand(consulta, conexion.cn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        serie.Points.AddXY(dr["Año"].ToString(), dr["Cantidad"]);
                    }
                }

                grafico.Series.Add(serie);

                grafico.Titles.Add("Estudiantes Ingresados por Año");
                grafico.Titles[0].Font = new Font("Segoe UI", 16, FontStyle.Bold);

                if (panelContenido != null)
                {
                    panelContenido.Controls.Clear();
                    panelContenido.Controls.Add(grafico);
                    grafico.BringToFront();
                }
                else
                {
                    Controls.Add(grafico);
                    grafico.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear gráfico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
        

        {
            Process.Start("https://mail.google.com/");
        }
            }
        

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 contacto = new Form1();

            contacto.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Cursos Cursos = new Cursos();

            Cursos.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Listado_Maestro maestro = new Listado_Maestro();

            maestro.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormMaterias formMaterias = new FormMaterias();

            formMaterias.Show();    
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormContacto  Contacto = new FormContacto();

            Contacto.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormConfiguracion configuracion = new FormConfiguracion();

            configuracion.Show();
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSeccion_Click(object sender, EventArgs e)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
     
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/?fs=1&tf=cm&to=centroeducacionalbautista80@gmail.com");
        }

        private void FormPrincipal_Load_1(object sender, EventArgs e)
        {
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
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
    }
}