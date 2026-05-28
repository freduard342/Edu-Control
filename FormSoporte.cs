using System;
using System.Net;
using System.Net.Mail;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CapaPresentacion
{
    public partial class FormSoporte : Form
    {
        // 1. PEGA AQUÍ TU API KEY DE GOOGLE AI STUDIO (Debe empezar con AIzaSy...)
        private static readonly string apiKey = "AIzaSyBHjZc4j05e9IX1qNeQWaKD9k_FfSykAFM";
        private static readonly HttpClient client = new HttpClient();

        public FormSoporte()
        {
            InitializeComponent();
        }

        // ===================================================
        // BOTÓN 1: PREGUNTAR A LA IA (GRATIS)
        // ===================================================
        private async void btnPreguntarIA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMensaje.Text))
            {
                MessageBox.Show("Por favor, escribe tu duda o problema en el cuadro de texto antes de consultar a la IA.",
                                "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnPreguntarIA.Enabled = false;
                btnPreguntarIA.Text = "Pensando... 🧠";
                txtRespuestaIA.Text = "El Asistente de Google Gemini está analizando tu duda...";
                this.Cursor = Cursors.WaitCursor;

                // Llamamos a Gemini
                string respuesta = await LlamarAI(txtMensaje.Text);

                txtRespuestaIA.Text = respuesta;
            }
            catch (Exception ex)
            {
                txtRespuestaIA.Text = "No se pudo obtener respuesta en este momento.";
                MessageBox.Show("Error al conectar con la IA: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnPreguntarIA.Enabled = true;
                btnPreguntarIA.Text = "✨ Preguntar a la IA";
                this.Cursor = Cursors.Default;
            }
        }

        // Método que conecta con la API Gratuita de Google Gemini
        private async Task<string> LlamarAI(string preguntaUsuario)
        {
            if (apiKey == "" || string.IsNullOrWhiteSpace(apiKey))
            {
                return "Configuración incompleta: Por favor, introduce tu clave secreta de Google AI Studio (apiKey) en la parte superior del código de FormSoporte.cs.";
            }

            // URL CORREGIDA: Apuntamos a la versión v1 con el modelo gemini-2.5-flash
            string url = $"https://generativelanguage.googleapis.com/v1/models/gemini-2.5-flash:generateContent?key={apiKey}";

            // Estructura JSON requerida por la API de Google
            var datosPost = new
            {
                contents = new[]
                {
                    new {
                        parts = new[]
                        {
                            new { text = "Actúa como un asistente de soporte técnico inteligente integrado en el sistema escolar Edu-Control. Responde a la siguiente duda de forma muy breve (máximo un párrafo corto), clara y amigable en español: " + preguntaUsuario }
                        }
                    }
                }
            };

            string jsonContenido = JsonConvert.SerializeObject(datosPost);
            var contenido = new StringContent(jsonContenido, Encoding.UTF8, "application/json");

            HttpResponseMessage respuesta = await client.PostAsync(url, contenido);
            string jsonRespuesta = await respuesta.Content.ReadAsStringAsync();

            if (respuesta.IsSuccessStatusCode)
            {
                // Desglosamos el JSON que devuelve Google
                dynamic resultado = JsonConvert.DeserializeObject(jsonRespuesta);
                string textoIA = resultado.candidates[0].content.parts[0].text.ToString();
                return textoIA.Trim();
            }
            else
            {
                // Muestra el error detallado si algo más falla (por ejemplo, la API key)
                return $"Error de Google Gemini: Código de estado {respuesta.StatusCode}. Detalles: {jsonRespuesta}";
            }
        }

        // ==========================================
        // BOTÓN 2: ENVIAR REPORTE POR CORREO
        // ==========================================
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAsunto.Text) || string.IsNullOrWhiteSpace(txtMensaje.Text))
            {
                MessageBox.Show("Por favor, llena el asunto y la descripción antes de enviar el correo.",
                                "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string correoEmisor = "centroeducacionalbautista80@gmail.com";
            string contraseñaToken = "agze dmhq ediq pljn";
            string correoDestino = "centroeducacionalbautista80@gmail.com";

            try
            {
                btnEnviar.Enabled = false;
                btnEnviar.Text = "Enviando... ✉️";
                this.Cursor = Cursors.WaitCursor;

                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(correoEmisor, "Soporte Edu-Control");
                correo.To.Add(correoDestino);
                correo.Subject = "🚨 REPORTE: " + txtAsunto.Text;

                correo.Body = $"Nuevo problema reportado por el usuario:\n\n" +
                              $"Fecha/Hora: {DateTime.Now}\n" +
                              $"Equipo Windows: {Environment.MachineName}\n" +
                              $"Usuario Windows: {Environment.UserName}\n\n" +
                              $"Detalles del error:\n{txtMensaje.Text}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(correoEmisor, contraseñaToken),
                    EnableSsl = true
                };

                smtp.Send(correo);

                this.Cursor = Cursors.Default;
                MessageBox.Show("El reporte ha sido enviado con éxito a tu correo.", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                btnEnviar.Enabled = true;
                btnEnviar.Text = "✉️ Enviar por Correo";
                MessageBox.Show("Error al mandar el correo: " + ex.Message, "Error de envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}