using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormRecuperar : Form
    {
        // Variable para guardar el código enviado
        private string codigoGenerado = "";

        // Conexión a SQL Server
        private string cadenaConexion = @"Data Source=DESKTOP-S35R0HB\SQLEXPRESS; Initial Catalog=Sistema_Gestion_Calificaciones; Integrated Security=True; TrustServerCertificate=True;";

        public FormRecuperar()
        {
            InitializeComponent();
        }

        // ============================================
        // BOTÓN ENVIAR CÓDIGO
        // ============================================
        private void BtnSendCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show(
                    "Por favor, ingrese su correo electrónico.",
                    "Correo Requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // Generar código aleatorio
                Random rand = new Random();
                codigoGenerado = rand.Next(100000, 999999).ToString();

                // Datos del correo
                string correoEmisor = "centroeducacionalbautista80@gmail.com";

                // CONTRASEÑA DE APLICACIÓN DE GMAIL
                string contrasenaEmisor = "agze dmhq ediq pljn";

                string correoReceptor = txtUsername.Text.Trim();

                // Crear correo
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(correoEmisor);
                mail.To.Add(correoReceptor);

                mail.Subject = "Código de Recuperación";

                mail.Body =
                    "Hola.\n\n" +
                    "Tu código de verificación es: " +
                    codigoGenerado +
                    "\n\nIntroduce este código en el sistema.";

                mail.IsBodyHtml = false;

                // Configuración SMTP Gmail
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                smtp.Port = 587;

                smtp.Credentials =
                    new NetworkCredential(
                        correoEmisor,
                        contrasenaEmisor);

                smtp.EnableSsl = true;

                Cursor = Cursors.WaitCursor;

                smtp.Send(mail);

                Cursor = Cursors.Default;

                MessageBox.Show(
                    "Código enviado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;

                MessageBox.Show(
                    "Error al enviar correo: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================
        // BOTÓN ACTUALIZAR CONTRASEÑA
        // ============================================
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos.",
                    "Campos Vacíos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validar si se envió código
            if (string.IsNullOrEmpty(codigoGenerado))
            {
                MessageBox.Show(
                    "Primero debe enviar el código.",
                    "Código Requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validar código
            if (txtCode.Text.Trim() != codigoGenerado)
            {
                MessageBox.Show(
                    "El código es incorrecto.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Validar contraseñas
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // ============================================
            // ACTUALIZAR CONTRASEÑA EN SQL SERVER
            // ============================================

            try
            {
                using (SqlConnection conexion =
                    new SqlConnection(cadenaConexion))
                {
                    string query =
                        "UPDATE Usuario " +
                        "SET Contraseña = @NuevaPass " +
                        "WHERE Correo = @Correo";

                    SqlCommand cmd =
                        new SqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue(
                        "@NuevaPass",
                        txtNewPassword.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Correo",
                        txtUsername.Text.Trim());

                    conexion.Open();

                    int filas = cmd.ExecuteNonQuery();

                    conexion.Close();

                    if (filas > 0)
                    {
                        MessageBox.Show(
                            "¡Contraseña actualizada correctamente!",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se encontró ningún usuario con ese correo.",
                            "Usuario No Encontrado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar contraseña: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================
        // BOTÓN CANCELAR
        // ============================================
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRecuperar_Load(object sender, EventArgs e)
        {

        }
    }
}