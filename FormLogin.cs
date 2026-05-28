using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // OBLIGATORIO para conectar con SQL Server
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        // Cambiamos 'EduControlDB' por 'Sistema_Gestion_Calificaciones'
        // Usamos tu servidor exacto: DESKTOP-S35R0HB\SQLEXPRESS
        private string cadenaConexion = @"Data Source=DESKTOP-DKPVNB9; Initial Catalog=Sistema_Gestion_Calificaciones; Integrated Security=True; TrustServerCertificate=True;";
        // ⬇️ AQUÍ AGREGA ESTAS DOS LÍNEAS ⬇️
        private int intentosFallidos = 0;
        private const int MAX_INTENTOS = 5;
        public FormLogin()
        {

            InitializeComponent();
            // Forzamos al formulario a cargar los roles al inicializarse
            FormLogin_Load(this, null);
        }

        // Evento que se ejecuta al hacer clic en el Botón de Ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 2. Validar que no dejen los campos vacíos ni el combo sin seleccionar
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, introduzca su usuario y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione su rol antes de ingresar.", "Rol Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuarioInput = txtUsuario.Text.Trim();
            string contrasenaInput = txtPassword.Text.Trim();

            // 3. Convertir el Rol seleccionado en el ComboBox a su ID de la base de datos
            int rolSeleccionadoId = 0;
            if (cmbRol.SelectedItem.ToString() == "Administrador") rolSeleccionadoId = 1;
            else if (cmbRol.SelectedItem.ToString() == "Maestro") rolSeleccionadoId = 2;
            else if (cmbRol.SelectedItem.ToString() == "Secretaria") rolSeleccionadoId = 3;

            // 4. Validar las TRES credenciales juntas (Usuario, Clave y Rol)
            if (ValidarUsuarioConRol(usuarioInput, contrasenaInput, rolSeleccionadoId))
            {
                MessageBox.Show($"¡Bienvenido al sistema! Acceso concedido como {cmbRol.SelectedItem.ToString()}.", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Aquí abrirías tu formulario principal (FormMenu, FormPrincipal, etc.)
                // FormPrincipal principal = new FormPrincipal();
                // principal.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Los datos no coinciden. Verifique el usuario, contraseña o el rol seleccionado.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        // 5. Función que consulta a SQL Server verificando las 3 condiciones
        private bool ValidarUsuarioConRol(string usuario, string contrasena, int idRol)
        {
            bool usuarioValido = false;

            // CORREGIDO: Ahora dice Nombre_Usuario y la variable del rol coincide con la de abajo (@Id_Rol)
            string query = "SELECT COUNT(1) FROM Usuario WHERE Nombre_Usuario = @usuario AND Contraseña = @contraseña AND Id_Rol = @Id_Rol";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Parámetros de seguridad (Todos coinciden letra por letra con el query de arriba)
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contrasena);
                    cmd.Parameters.AddWithValue("@Id_Rol", idRol); // CORREGIDO: Ahora tiene el guion bajo igual que en el query

                    try
                    {
                        conexion.Open();
                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                        if (resultado > 0)
                        {
                            usuarioValido = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error de conexión a la base de datos: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return usuarioValido;
        }

        // === Tus otros métodos del Formulario ===

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Llenamos el ComboBox automáticamente cuando cargue el Login
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Maestro");
            cmbRol.Items.Add("Secretaria");

            // Dejamos seleccionada la primera opción para que no aparezca vacío
            cmbRol.SelectedIndex = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {
        }

        private void linkRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Creamos la instancia del formulario de recuperación
            FormRecuperar frmRecuperar = new FormRecuperar();

            // 2. Lo mostramos como una ventana de diálogo
            frmRecuperar.ShowDialog();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            // 1. Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, introduzca su usuario y contraseña.", "Campos Vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione su rol antes de ingresar.", "Rol Requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuarioInput = txtUsuario.Text.Trim();
            string contrasenaInput = txtPassword.Text.Trim();

            // 2. Convertir rol a ID
            int rolSeleccionadoId = 0;

            if (cmbRol.SelectedItem.ToString() == "Administrador") rolSeleccionadoId = 1;
            else if (cmbRol.SelectedItem.ToString() == "Maestro") rolSeleccionadoId = 2;
            else if (cmbRol.SelectedItem.ToString() == "Secretaria") rolSeleccionadoId = 3;

            // 3. Validar en base de datos
            if (ValidarUsuarioConRol(usuarioInput, contrasenaInput, rolSeleccionadoId))
            {
                // Si el login es correcto, reiniciamos el contador por seguridad
                intentosFallidos = 0;

                MessageBox.Show("Acceso concedido.", "Bienvenido",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Abrir formulario según rol
                Form formAbierto = null;

                switch (rolSeleccionadoId)
                {
                    case 1:
                        formAbierto = new FormPrincipal();   // Admin
                        break;

                    case 2:
                        formAbierto = new FormMaestro();     // Maestro
                        break;

                    case 3:
                        // Por si entra como secretaria, abre el principal o el que definas luego
                        formAbierto = new FormPrincipal();
                        break;
                }

                if (formAbierto != null)
                {
                    formAbierto.Show();
                    this.Hide();
                }
            }
            else
            {
                // 🔒 LÓGICA DE INTENTOS CONTROLADA AQUÍ
                intentosFallidos++;
                int intentosRestantes = MAX_INTENTOS - intentosFallidos;

                if (intentosFallidos >= MAX_INTENTOS)
                {
                    MessageBox.Show("Has superado el límite de 5 intentos permitidos.\nEl sistema se cerrará por motivos de seguridad.",
                                    "Acceso Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    // Cierra la aplicación por completo
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Los datos no coinciden. Verifique usuario, contraseña o rol.\n\nIntentos restantes: {intentosRestantes}",
                        "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMostrarPassword_Click(object sender, EventArgs e)
        {
            // Primero nos aseguramos de apagar el comportamiento automático del sistema
            txtPassword.UseSystemPasswordChar = false;

            // Si el PasswordChar actual es el asterisco '*', significa que está oculta
            if (txtPassword.PasswordChar == '*')
            {
                // Al ponerle '\0' (carácter nulo), el texto se vuelve completamente visible
                txtPassword.PasswordChar = '\0';
                btnMostrarPassword.Text = "🙈"; // Cambia el icono
            }
            else
            {
                // Si no es un asterisco, volvemos a ponerle el asterisco para ocultarla
                txtPassword.PasswordChar = '*';
                btnMostrarPassword.Text = "👁️"; // Restaura el icono
            }

            // Opcional: Esto evita que el foco se pierda y mantiene el cursor al final del texto
            txtPassword.Focus();
            txtPassword.SelectionStart = txtPassword.Text.Length;
        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}