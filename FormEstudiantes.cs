using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Label lblFechaHora;
        Timer reloj;

        private EstudianteBll bll = new EstudianteBll();

        public int idSeleccionado = 0;
        private int idEstudiante = 0;
        public Form1()
        {
            InitializeComponent();
            // LABEL FECHA Y HORA
            lblFechaHora = new Label();
            AppSettings.ConfiguracionCambiada += AplicarConfiguracion;
            AplicarConfiguracion(null, EventArgs.Empty);
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Arial", 9, FontStyle.Regular);
            lblFechaHora.ForeColor = Color.Black;
            lblFechaHora.BackColor = Color.Transparent;

            // POSICION DEBAJO DE USUARIO
            lblFechaHora.Location = new Point(900, 60);

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
        }
        private void AplicarConfiguracion(object sender, EventArgs e)
        {
            if (IsDisposed) return;
            if (InvokeRequired) { Invoke(new Action(() => AplicarConfiguracion(sender, e))); return; }

            lblInstitucion.Text = AppSettings.NombreInstitucion;

            if (AppSettings.LogoInstitucion != null)
                pictureBox1.Image = AppSettings.LogoInstitucion;

            AppSettings.AplicarTema(this);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            AppSettings.ConfiguracionCambiada -= AplicarConfiguracion;
            base.OnFormClosed(e);
        }
        private void FormEstudiante_Load(object sender, EventArgs e)
        {
            cbGenero.Items.Clear(); // Borra cualquier residuo
            cbGenero.Items.Add("Masculino");
            cbGenero.Items.Add("Femenino");
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarEstudiantes();
            CargarCursos();
            CargarGenero();
          
        }

        public void CargarEstudiante(EstudianteDto e)
        {

            txtNombre.Text =
                e.Nombre;

            txtApellido.Text =
                e.Apellido;

            txtDireccion.Text =
                e.Direccion;

            cbGenero.Text =
                e.Genero;

            dtpFechaNacimiento.Value =
                e.FechaNacimiento;

            txtPadre.Text =
                e.NombrePadres;

            txtTelefono.Text =
                e.TelefonoPadre;
        }

        private void CargarGenero()
        {
            cbGenero.Items.Clear();

            cbGenero.Items.Add("Masculino");

            cbGenero.Items.Add("Femenino");

     
            cbGenero.SelectedIndex = 0;
        }
        private void CargarCursos()
        {
            try
            {
                Conexion conexion =
                    new Conexion();

                conexion.AbrirConexion();

                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT Id_Curso, Nombre_Curso FROM Curso",
                        conexion.cn);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                cmbCurso.DataSource = dt;

                cmbCurso.DisplayMember =
                    "Nombre_Curso";

                cmbCurso.ValueMember =
                    "Id_Curso";

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarEstudiantes()
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Cursos cursos = new Cursos();
            cursos.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Listado_Maestro maestro = new Listado_Maestro();
            maestro.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormMaterias materia = new FormMaterias();
            materia.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormContacto contacto = new FormContacto();
            contacto.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormConfiguracion configuracion = new FormConfiguracion();
            configuracion.Show();
        }

        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                reloj.Stop();

                // ABRIR LOGIN
                FormLogin login = new FormLogin();

                login.Show();

                // CERRAR FORM ACTUAL
                this.Hide();
            }
        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
            {
            try
            {
                // VALIDAR SELECCIÓN
                if (idSeleccionado <= 0)
                {
                   
                    // ELIMINAR
                    bool eliminado = bll.Delete(idSeleccionado);
                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Estudiante eliminado correctamente",
                            "Sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        MostrarEstudiantes();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el estudiante",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                EstudianteDto e1 =
                    new EstudianteDto();

                e1.Nombre = txtNombre.Text;

                e1.Apellido = txtApellido.Text;

                e1.Direccion = txtDireccion.Text;

                e1.Genero = cbGenero.Text;

                e1.FechaNacimiento =
                    dtpFechaNacimiento.Value;

                e1.NombrePadres =
                    txtPadre.Text;

                e1.TelefonoPadre =
                    txtTelefono.Text;
                
                e1.FechaIngreso =
                     dtpIngreso.Value;

                bool resultado = bll.Add(e1);

               

                if (resultado)
                {
                    MessageBox.Show(
                        "Estudiante guardado");

                    MostrarEstudiantes();

                 
                    Limpiar();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                // VALIDAR SELECCIÓN
                if (idSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un estudiante para actualizar",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // VALIDAR CAMPOS
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show(
                        "Complete los campos obligatorios",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // CREAR OBJETO
                EstudianteDto estudiante =
                    new EstudianteDto
                    {
                        IdEstudiante = idSeleccionado,
                        Nombre = txtNombre.Text.Trim(),
                        Apellido = txtApellido.Text.Trim(),
                        Direccion = txtDireccion.Text.Trim(),
                        Genero = cbGenero.Text,
                        FechaNacimiento = dtpFechaNacimiento.Value,
                        NombrePadres = txtPadre.Text.Trim(),
                        TelefonoPadre = txtTelefono.Text.Trim(),
                        FechaIngreso = dtpIngreso.Value
                    };

                // ACTUALIZAR
                bool resultado =
                    bll.Update(estudiante);

                if (resultado)
                {
                    MessageBox.Show(
                        "Estudiante actualizado correctamente",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    MostrarEstudiantes();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el estudiante",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();

            txtApellido.Clear();

            txtDireccion.Clear();

            cbGenero.SelectedIndex = -1;

            txtPadre.Clear();

            txtTelefono.Clear();

            idSeleccionado = 0;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Listado_Estudiantes _Estudiantes = new Listado_Estudiantes();
            _Estudiantes.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
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
