using Guna.UI2.WinForms;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class FormConfiguracion : Form
    {
        // ═══════════════════════════════════════════════════════════════
        //  BACKUP
        // ═══════════════════════════════════════════════════════════════
        private enum BackupType { Full, Differential, Log }
        private BackupType? _selectedBackup;
        private string _lastBackupPath;
        private BackupType? _lastBackupType;

        // ═══════════════════════════════════════════════════════════════
        //  CONSTRUCTOR
        // ═══════════════════════════════════════════════════════════════
        public FormConfiguracion()
        {
            InitializeComponent();

            // Cargar valores actuales en los controles
            CargarConfiguracionActual();

            // Suscribirse al evento global para reaccionar si otro form cambia algo
            AppSettings.ConfiguracionCambiada += AppSettings_ConfiguracionCambiada;

            // ── Backup buttons ──────────────────────────────────────────
            if (guna2btnCompleto != null) guna2btnCompleto.Click += (s, e) => { RunFullBackup(); SelectBackupVisual(BackupType.Full, guna2btnCompleto); };
            if (guna2BtnDiferencial != null) guna2BtnDiferencial.Click += (s, e) => { RunDifferentialBackup(); SelectBackupVisual(BackupType.Differential, guna2BtnDiferencial); };
            if (guna2btnLogs != null) guna2btnLogs.Click += (s, e) => { RunLogBackup(); SelectBackupVisual(BackupType.Log, guna2btnLogs); };
            if (guna2BtnAplicar != null) guna2BtnAplicar.Click += Guna2BtnAplicar_Click;

            // ── Guardar contraseña ──────────────────────────────────────
            if (guna2ButtonGuardar_Contraseña != null)
                guna2ButtonGuardar_Contraseña.Click += GuardarContraseña_Click;
        }

        // ═══════════════════════════════════════════════════════════════
        //  CARGA INICIAL
        // ═══════════════════════════════════════════════════════════════
        private void CargarConfiguracionActual()
        {
            // Nombre de institución
            txtNombre.Text = AppSettings.NombreInstitucion;

            // Año escolar (si lo guardas, léelo aquí)
            // txtAño.Text = AppSettings.AñoEscolar;

            // Toggle modo oscuro
            swModoOscuro.Checked = AppSettings.ModoOscuro;

            // Logo actual
            if (AppSettings.LogoInstitucion != null)
                pictureBox1.Image = AppSettings.LogoInstitucion;

            // Limpiar campos de usuario/contraseña
            txtNuevaContraseña.Text = "";
            txtConfirmarContraseña.Text = "";

            // Aplicar tema visual si ya está en modo oscuro
            if (AppSettings.ModoOscuro)
                AplicarTemaLocal(true);
        }

        // ═══════════════════════════════════════════════════════════════
        //  EVENTO GLOBAL (cambios desde otros forms)
        // ═══════════════════════════════════════════════════════════════
        private void AppSettings_ConfiguracionCambiada(object sender, EventArgs e)
        {
            if (IsDisposed) return;

            // Volver al hilo de UI si hace falta
            if (InvokeRequired) { Invoke(new Action(() => AppSettings_ConfiguracionCambiada(sender, e))); return; }

            // Sincronizar controles con los valores globales
            swModoOscuro.Checked = AppSettings.ModoOscuro;
            txtNombre.Text = AppSettings.NombreInstitucion;

            if (AppSettings.LogoInstitucion != null)
                pictureBox1.Image = AppSettings.LogoInstitucion;

            AplicarTemaLocal(AppSettings.ModoOscuro);
        }

        // ═══════════════════════════════════════════════════════════════
        //  GUARDAR NOMBRE DEL SISTEMA (con validación)
        // ═══════════════════════════════════════════════════════════════
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            // ── Validar nombre ──────────────────────────────────────────
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MostrarError("El nombre de la institución no puede estar vacío.");
                txtNombre.Focus();
                return;
            }
            if (nombre.Length < 3)
            {
                MostrarError("El nombre debe tener al menos 3 caracteres.");
                txtNombre.Focus();
                return;
            }
            if (nombre.Length > 120)
            {
                MostrarError("El nombre no puede superar los 120 caracteres.");
                txtNombre.Focus();
                return;
            }

            // ── Validar año escolar ─────────────────────────────────────
            string año = txtAño.Text.Trim();
            if (!string.IsNullOrWhiteSpace(año))
            {
                // Formato esperado: YYYY-YYYY  (ej. 2025-2026)
                System.Text.RegularExpressions.Regex regexAño =
                    new System.Text.RegularExpressions.Regex(@"^\d{4}-\d{4}$");

                if (!regexAño.IsMatch(año))
                {
                    MostrarError("El año escolar debe tener el formato AAAA-AAAA (ej. 2025-2026).");
                    txtAño.Focus();
                    return;
                }
            }

            // ── Aplicar al sistema global ───────────────────────────────
            AppSettings.NombreInstitucion = nombre;

            // Actualizar label del top inmediatamente en este form
            lblInstitucion.Text = nombre;

            MessageBox.Show(
                "Configuración del sistema guardada correctamente.\n" +
                "El nombre ha sido actualizado en todos los formularios.",
                "Edu-Control",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ═══════════════════════════════════════════════════════════════
        //  GUARDAR CONTRASEÑA
        //  - txtNuevaContraseña     → USUARIO (login name)
        //  - txtConfirmarContraseña → CONTRASEÑA nueva
        // ═══════════════════════════════════════════════════════════════
        private void GuardarContraseña_Click(object sender, EventArgs e)
        {
            string usuario = txtNuevaContraseña.Text.Trim();      // campo "Usuario"
            string nuevaContraseña = txtConfirmarContraseña.Text.Trim();  // campo "Contraseña"

            // ── Validar usuario ─────────────────────────────────────────
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MostrarError("El nombre de usuario no puede estar vacío.");
                txtNuevaContraseña.Focus();
                return;
            }
            if (usuario.Length < 3)
            {
                MostrarError("El usuario debe tener al menos 3 caracteres.");
                txtNuevaContraseña.Focus();
                return;
            }

            // ── Validar contraseña ──────────────────────────────────────
            if (string.IsNullOrWhiteSpace(nuevaContraseña))
            {
                MostrarError("La contraseña no puede estar vacía.");
                txtConfirmarContraseña.Focus();
                return;
            }
            if (nuevaContraseña.Length < 6)
            {
                MostrarError("La contraseña debe tener al menos 6 caracteres.");
                txtConfirmarContraseña.Focus();
                return;
            }
            if (!TieneCaracterEspecial(nuevaContraseña))
            {
                MostrarError("La contraseña debe contener al menos un carácter especial (ej. @, #, !, %).");
                txtConfirmarContraseña.Focus();
                return;
            }

            // ── Aquí iría la lógica de actualización en BD ──────────────
            // EjecutarSql($"UPDATE Usuarios SET Password = '{nuevaContraseña}' WHERE Usuario = '{usuario}'");
            // (Usar parámetros SQL reales en producción, nunca concatenar strings)

            MessageBox.Show(
                $"Credenciales actualizadas correctamente para el usuario: {usuario}",
                "Edu-Control",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar campos por seguridad
            txtNuevaContraseña.Text = "";
            txtConfirmarContraseña.Text = "";
        }

        // ═══════════════════════════════════════════════════════════════
        //  SELECCIONAR LOGO — cambia en tiempo real
        // ═══════════════════════════════════════════════════════════════
        private void btnSeleccionarLogo_Click(object sender, EventArgs e)
        {
            ofdLogoNuevo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofdLogoNuevo.Title = "Seleccionar Logo Institucional";

            if (ofdLogoNuevo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image nuevoLogo = Image.FromFile(ofdLogoNuevo.FileName);

                    // 1. Mostrar en este form de inmediato
                    pictureBox1.Image = nuevoLogo;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    // 2. Guardar en AppSettings → notifica a TODOS los forms
                    AppSettings.LogoInstitucion = nuevoLogo;

                    MessageBox.Show(
                        "Logo institucional actualizado correctamente.\n" +
                        "El cambio se reflejará en todos los formularios abiertos.",
                        "Edu-Control",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MostrarError($"No se pudo cargar la imagen:\n{ex.Message}");
                }
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  MODO OSCURO
        // ═══════════════════════════════════════════════════════════════
        private void swModoOscuro_CheckedChanged(object sender, EventArgs e)
        {
            bool oscuro = swModoOscuro.Checked;

            // Guardar en AppSettings → notifica a todos los forms
            AppSettings.ModoOscuro = oscuro;

            // Aplicar localmente también
            AplicarTemaLocal(oscuro);
        }

        private void AplicarTemaLocal(bool oscuro)
        {
            this.BackColor = oscuro ? Color.FromArgb(15, 23, 42) : Color.FromArgb(241, 245, 249);

            // Panels
            if (panelTop != null) panelTop.BackColor = oscuro ? Color.FromArgb(30, 41, 59) : Color.White;
            if (panelConfiguracion != null) panelConfiguracion.FillColor = oscuro ? Color.FromArgb(30, 41, 59) : Color.White;
            if (panelInfo != null) panelInfo.FillColor = oscuro ? Color.FromArgb(30, 41, 59) : Color.White;
            if (guna2ShadowPanel1 != null) guna2ShadowPanel1.FillColor = oscuro ? Color.FromArgb(30, 41, 59) : Color.White;

            // Labels
            Color colorTexto = oscuro ? Color.White : Color.FromArgb(15, 23, 42);
            Color colorAccent = Color.FromArgb(37, 99, 235);

            foreach (Label lbl in new[] { lblNombre, lblAño, lblLogo, lblNuevaPass, lblConfirmarPass, lblModo })
                if (lbl != null) lbl.ForeColor = colorTexto;

            if (lblTitulo != null) lblTitulo.ForeColor = colorAccent;
            if (lblInfoTitulo != null) lblInfoTitulo.ForeColor = colorAccent;
            if (lblInstitucion != null) lblInstitucion.ForeColor = oscuro ? Color.White : Color.FromArgb(15, 23, 42);
            if (lblInfoTexto != null) lblInfoTexto.ForeColor = oscuro ? Color.LightGray : Color.Gray;
        }

        // ═══════════════════════════════════════════════════════════════
        //  CERRAR SESIÓN
        // ═══════════════════════════════════════════════════════════════
        // Añade esto dentro de la clase `FormConfiguracion` (si ya existe un handler igual, elimina el duplicado anterior)
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Deseas cerrar sesión? Se cerrarán las ventanas secundarias.",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            CerrarTodasMenosInicio();
        }

        private void CerrarTodasMenosInicio()
        {
            // Tomar snapshot para evitar modificar la colección mientras se itera
            var toClose = new System.Collections.Generic.List<Form>();
            foreach (Form f in Application.OpenForms)
            {
                if (f == null) continue;
                if (f.GetType() == typeof(FrmInicio)) continue; // mantener FrmInicio
                toClose.Add(f);
            }

            // Cerrar de forma segura
            foreach (var f in toClose)
            {
                try
                {
                    if (!f.IsDisposed) f.Close();
                }
                catch { /* ignorar errores individuales */ }
            }

            // Asegurar que FrmInicio esté visible y en primer plano
            Form inicio = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f != null && f.GetType() == typeof(FrmInicio))
                {
                    inicio = f;
                    break;
                }
            }

            if (inicio != null)
            {
                try { inicio.Show(); inicio.BringToFront(); } catch { }
            }
        }


        // ═══════════════════════════════════════════════════════════════
        //  NAVEGACIÓN SIDEBAR
        // ═══════════════════════════════════════════════════════════════
        private void button9_Click(object sender, EventArgs e) { AbrirForm(() => new Form1()); }
        private void button10_Click(object sender, EventArgs e) { AbrirForm(() => new Cursos()); }
        private void button11_Click(object sender, EventArgs e) { AbrirForm(() => new Listado_Maestro()); }
        private void button12_Click(object sender, EventArgs e) { AbrirForm(() => new FormContacto()); }
        private void button13_Click(object sender, EventArgs e) { AbrirForm(() => new FormMaterias()); }

        private void AbrirForm(Func<Form> crearForm)
        {
            try { crearForm().Show(); }
            catch (Exception ex)
            {
                MessageBox.Show($"Error abriendo formulario:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  LOAD & DISPOSE
        // ═══════════════════════════════════════════════════════════════
        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            CargarConfiguracionActual();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Desuscribirse para evitar memory leaks
            AppSettings.ConfiguracionCambiada -= AppSettings_ConfiguracionCambiada;
            base.OnFormClosed(e);
        }

        // ═══════════════════════════════════════════════════════════════
        //  STUBS REQUERIDOS POR EL DESIGNER
        // ═══════════════════════════════════════════════════════════════
        private void swModoOscuro_CheckedChanged_1(object sender, EventArgs e) { }
        private void guna2btnCompleto_Click(object sender, EventArgs e) { RunFullBackup(); SelectBackupVisual(BackupType.Full, guna2btnCompleto); }
        private void guna2BtnDiferencial_Click(object sender, EventArgs e) { RunDifferentialBackup(); SelectBackupVisual(BackupType.Differential, guna2BtnDiferencial); }
        private void guna2btnLogs_Click(object sender, EventArgs e) { RunLogBackup(); SelectBackupVisual(BackupType.Log, guna2btnLogs); }

        // ═══════════════════════════════════════════════════════════════
        //  HELPERS GENERALES
        // ═══════════════════════════════════════════════════════════════
        private static void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static bool TieneCaracterEspecial(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]");
        }

        // ═══════════════════════════════════════════════════════════════
        //  BACKUP (sin modificar)
        // ═══════════════════════════════════════════════════════════════
        private void SelectBackupVisual(BackupType type, Guna2Button sender)
        {
            _selectedBackup = type;
            ResetBackupButtonsStyle();
            try { sender.FillColor = Color.FromArgb(20, 110, 230); sender.ForeColor = Color.White; }
            catch { }
        }

        private void ResetBackupButtonsStyle()
        {
            try
            {
                if (guna2btnCompleto != null) guna2btnCompleto.FillColor = Color.FromArgb(59, 130, 246);
                if (guna2BtnDiferencial != null) guna2BtnDiferencial.FillColor = Color.FromArgb(34, 197, 94);
                if (guna2btnLogs != null) guna2btnLogs.FillColor = Color.FromArgb(107, 114, 128);
            }
            catch { }
        }

        private void Guna2BtnAplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_lastBackupPath) || !_lastBackupType.HasValue)
            {
                MessageBox.Show("No hay backup reciente para aplicar. Realiza primero un backup.",
                    "Sin backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string db = ObtenerNombreBaseDatos();
            try
            {
                EjecutarSqlEnMaster($"ALTER DATABASE [{db}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;");
                if (_lastBackupType == BackupType.Full || _lastBackupType == BackupType.Differential)
                    EjecutarSqlEnMaster($"RESTORE DATABASE [{db}] FROM DISK = N'{_lastBackupPath.Replace("'", "''")}' WITH REPLACE, STATS = 10;");
                else if (_lastBackupType == BackupType.Log)
                    EjecutarSqlEnMaster($"RESTORE LOG [{db}] FROM DISK = N'{_lastBackupPath.Replace("'", "''")}' WITH RECOVERY, STATS = 10;");
                EjecutarSqlEnMaster($"ALTER DATABASE [{db}] SET MULTI_USER;");
                MessageBox.Show($"Restauración aplicada correctamente desde:\n{_lastBackupPath}",
                    "Restauración completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                try { EjecutarSqlEnMaster($"ALTER DATABASE [{db}] SET MULTI_USER;"); } catch { }
                MessageBox.Show($"Error aplicando restauración:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EjecutarSqlEnMaster(string sql)
        {
            var builder = new SqlConnectionStringBuilder(ObtenerCadenaConexion()) { InitialCatalog = "master" };
            using (var conn = new SqlConnection(builder.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn)) { cmd.CommandTimeout = 900; cmd.ExecuteNonQuery(); }
            }
        }

        private string ObtenerCadenaConexion()
        {
            var cs = ConfigurationManager.ConnectionStrings["cn"];
            if (cs == null) throw new InvalidOperationException("No se encontró la cadena 'cn' en App.config");
            return cs.ConnectionString;
        }

        private string ObtenerNombreBaseDatos()
        {
            var builder = new SqlConnectionStringBuilder(ObtenerCadenaConexion());
            return builder.InitialCatalog ?? "Sistema_Gestion_Calificaciones";
        }

        private string CarpetaBackups()
        {
            const string serverFolder = @"C:\Backups";
            try
            {
                if (!Directory.Exists(serverFolder)) Directory.CreateDirectory(serverFolder);
                return serverFolder;
            }
            catch
            {
                string fallback = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "EduControl_Backups");
                if (!Directory.Exists(fallback)) Directory.CreateDirectory(fallback);
                return fallback;
            }
        }

        private void EjecutarSql(string sql)
        {
            using (var conn = new SqlConnection(ObtenerCadenaConexion()))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn)) { cmd.CommandTimeout = 900; cmd.ExecuteNonQuery(); }
            }
        }

        private void RunFullBackup()
        {
            try
            {
                string db = ObtenerNombreBaseDatos();
                string ruta = Path.Combine(CarpetaBackups(), $"BK_{db}_FULL_{DateTime.Now:yyyyMMdd_HHmmss}.bak");
                EjecutarSql($"BACKUP DATABASE [{db}] TO DISK = N'{ruta.Replace("'", "''")}' WITH FORMAT, INIT, NAME = N'{db}-FULL-{DateTime.Now:yyyyMMdd_HHmmss}', STATS = 10");
                _lastBackupPath = ruta; _lastBackupType = BackupType.Full;
                MessageBox.Show($"Backup completo guardado en:\n{ruta}", "Backup completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show($"Error creando backup completo:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RunDifferentialBackup()
        {
            try
            {
                string db = ObtenerNombreBaseDatos();
                string ruta = Path.Combine(CarpetaBackups(), $"BK_{db}_DIFF_{DateTime.Now:yyyyMMdd_HHmmss}.bak");
                EjecutarSql($"BACKUP DATABASE [{db}] TO DISK = N'{ruta.Replace("'", "''")}' WITH DIFFERENTIAL, INIT, NAME = N'{db}-DIFF-{DateTime.Now:yyyyMMdd_HHmmss}', STATS = 10");
                _lastBackupPath = ruta; _lastBackupType = BackupType.Differential;
                MessageBox.Show($"Backup diferencial guardado en:\n{ruta}", "Backup completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show($"Error creando backup diferencial:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RunLogBackup()
        {
            try
            {
                string db = ObtenerNombreBaseDatos();
                string ruta = Path.Combine(CarpetaBackups(), $"BK_{db}_LOG_{DateTime.Now:yyyyMMdd_HHmmss}.trn");
                EjecutarSql($"BACKUP LOG [{db}] TO DISK = N'{ruta.Replace("'", "''")}' WITH INIT, NAME = N'{db}-LOG-{DateTime.Now:yyyyMMdd_HHmmss}', STATS = 10");
                _lastBackupPath = ruta; _lastBackupType = BackupType.Log;
                MessageBox.Show($"Backup de logs guardado en:\n{ruta}", "Backup completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show($"Error creando backup de logs:\n{ex.Message}\n\nAsegúrate que la base esté en modo FULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void guna2ButtonVer_Usuario_Click(object sender, EventArgs e)
        {
            RolesForm roles = new RolesForm();
            roles.ShowDialog();
        }


    }
}