using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CapaPresentacion
{
    partial class FormConfiguracion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private Guna2Panel panelSidebar;
        private Guna2Panel panelTop;
        private Guna2ShadowPanel panelConfiguracion;
        private Guna2ShadowPanel panelInfo;
        private Guna2PictureBox imgUser;
        private Label lblInstitucion;
        private Label lblRol;
        private Label lblUsuario;
        private Label lblFecha;

        private Label lblTitulo;

        private Label lblNombre;
        private Label lblAño;
        private Label lblLogo;
        private Label lblNuevaPass;
        private Label lblConfirmarPass;
        private Label lblModo;

        private Guna2TextBox txtNombre;
        private Guna2TextBox txtAño;
        private Guna2TextBox txtNuevaContraseña;
        private Guna2TextBox txtConfirmarContraseña;

        private Guna2Button btnGuardarCambios;
        private Guna2Button btnSeleccionarLogo;

        private Guna2ToggleSwitch swModoOscuro;

        private Guna2Button btnRegistrar;
        private Guna2Button btnCursos;
        private Guna2Button btnMaestro;
        private Guna2Button btnMaterias;
        private Guna2Button btnContacto;
        private Guna2Button btnConfiguracion;

        private Guna2Button btnCerrarSesion;

        private Label lblInfoTitulo;
        private Label lblInfoTexto;

        private OpenFileDialog ofdLogoNuevo;

        private void InitializeComponent()
        {
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCursos = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaestro = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaterias = new Guna.UI2.WinForms.Guna2Button();
            this.btnContacto = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfiguracion = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.imgUser = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelConfiguracion = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ButtonVer_Usuario = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonGuardar_Contraseña = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtAño = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnSeleccionarLogo = new Guna.UI2.WinForms.Guna2Button();
            this.lblNuevaPass = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirmarPass = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.swModoOscuro = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnGuardarCambios = new Guna.UI2.WinForms.Guna2Button();
            this.panelInfo = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblInfoTitulo = new System.Windows.Forms.Label();
            this.lblInfoTexto = new System.Windows.Forms.Label();
            this.ofdLogoNuevo = new System.Windows.Forms.OpenFileDialog();
            this.guna2btnCompleto = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2BtnAplicar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2btnLogs = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BtnDiferencial = new Guna.UI2.WinForms.Guna2Button();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.panelConfiguracion.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.panelSidebar.Controls.Add(this.label3);
            this.panelSidebar.Controls.Add(this.label2);
            this.panelSidebar.Controls.Add(this.lblSistema);
            this.panelSidebar.Controls.Add(this.btnRegistrar);
            this.panelSidebar.Controls.Add(this.btnCursos);
            this.panelSidebar.Controls.Add(this.btnMaestro);
            this.panelSidebar.Controls.Add(this.btnMaterias);
            this.panelSidebar.Controls.Add(this.btnContacto);
            this.panelSidebar.Controls.Add(this.btnConfiguracion);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(212, 740);
            this.panelSidebar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(46, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 108);
            this.label3.TabIndex = 9;
            this.label3.Text = "🎓";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(66, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sistema de Calificaciones";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(35, 145);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(172, 37);
            this.lblSistema.TabIndex = 1;
            this.lblSistema.Text = "Edu-Control";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BorderRadius = 12;
            this.btnRegistrar.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 232);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(220, 50);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "📝 Registrar Estudiantes";
            this.btnRegistrar.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BorderRadius = 12;
            this.btnCursos.FillColor = System.Drawing.Color.Transparent;
            this.btnCursos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.White;
            this.btnCursos.Location = new System.Drawing.Point(-19, 278);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(220, 50);
            this.btnCursos.TabIndex = 3;
            this.btnCursos.Text = "📚 Listado Cursos";
            this.btnCursos.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnMaestro
            // 
            this.btnMaestro.BorderRadius = 12;
            this.btnMaestro.FillColor = System.Drawing.Color.Transparent;
            this.btnMaestro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaestro.ForeColor = System.Drawing.Color.White;
            this.btnMaestro.Location = new System.Drawing.Point(-39, 322);
            this.btnMaestro.Name = "btnMaestro";
            this.btnMaestro.Size = new System.Drawing.Size(220, 50);
            this.btnMaestro.TabIndex = 4;
            this.btnMaestro.Text = "👨‍🏫 Maestro";
            this.btnMaestro.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.BorderRadius = 12;
            this.btnMaterias.FillColor = System.Drawing.Color.Transparent;
            this.btnMaterias.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.ForeColor = System.Drawing.Color.White;
            this.btnMaterias.Location = new System.Drawing.Point(-39, 370);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(220, 50);
            this.btnMaterias.TabIndex = 5;
            this.btnMaterias.Text = "📖 Materias";
            this.btnMaterias.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnContacto
            // 
            this.btnContacto.BorderRadius = 12;
            this.btnContacto.FillColor = System.Drawing.Color.Transparent;
            this.btnContacto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacto.ForeColor = System.Drawing.Color.White;
            this.btnContacto.Location = new System.Drawing.Point(-39, 417);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(220, 50);
            this.btnContacto.TabIndex = 6;
            this.btnContacto.Text = "📞 Contacto";
            this.btnContacto.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BorderRadius = 12;
            this.btnConfiguracion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Location = new System.Drawing.Point(-19, 473);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(220, 50);
            this.btnConfiguracion.TabIndex = 7;
            this.btnConfiguracion.Text = "⚙ Configuración";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.lblInstitucion);
            this.panelTop.Controls.Add(this.lblRol);
            this.panelTop.Controls.Add(this.imgUser);
            this.panelTop.Controls.Add(this.lblUsuario);
            this.panelTop.Controls.Add(this.btnCerrarSesion);
            this.panelTop.Controls.Add(this.lblFecha);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(212, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1088, 110);
            this.panelTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imagen_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInstitucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblInstitucion.Location = new System.Drawing.Point(71, 20);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(334, 32);
            this.lblInstitucion.TabIndex = 0;
            this.lblInstitucion.Text = "Centro Educacional Bautista";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblRol.Location = new System.Drawing.Point(73, 51);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(87, 20);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol: Admin";
            // 
            // imgUser
            // 
            this.imgUser.Image = global::CapaPresentacion.Properties.Resources.login_imagen;
            this.imgUser.ImageRotate = 0F;
            this.imgUser.Location = new System.Drawing.Point(663, 20);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(55, 55);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 2;
            this.imgUser.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(724, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(140, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario: Leurianny";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BorderRadius = 12;
            this.btnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(901, 26);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(150, 45);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(724, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(141, 19);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "24/05/2026 04:15:46";
            // 
            // panelConfiguracion
            // 
            this.panelConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.panelConfiguracion.Controls.Add(this.guna2ButtonVer_Usuario);
            this.panelConfiguracion.Controls.Add(this.guna2ButtonGuardar_Contraseña);
            this.panelConfiguracion.Controls.Add(this.lblTitulo);
            this.panelConfiguracion.Controls.Add(this.lblNombre);
            this.panelConfiguracion.Controls.Add(this.txtNombre);
            this.panelConfiguracion.Controls.Add(this.lblAño);
            this.panelConfiguracion.Controls.Add(this.txtAño);
            this.panelConfiguracion.Controls.Add(this.lblLogo);
            this.panelConfiguracion.Controls.Add(this.btnSeleccionarLogo);
            this.panelConfiguracion.Controls.Add(this.lblNuevaPass);
            this.panelConfiguracion.Controls.Add(this.txtNuevaContraseña);
            this.panelConfiguracion.Controls.Add(this.lblConfirmarPass);
            this.panelConfiguracion.Controls.Add(this.txtConfirmarContraseña);
            this.panelConfiguracion.Controls.Add(this.lblModo);
            this.panelConfiguracion.Controls.Add(this.swModoOscuro);
            this.panelConfiguracion.Controls.Add(this.btnGuardarCambios);
            this.panelConfiguracion.FillColor = System.Drawing.Color.White;
            this.panelConfiguracion.Location = new System.Drawing.Point(260, 122);
            this.panelConfiguracion.Name = "panelConfiguracion";
            this.panelConfiguracion.Radius = 25;
            this.panelConfiguracion.ShadowColor = System.Drawing.Color.Silver;
            this.panelConfiguracion.ShadowDepth = 60;
            this.panelConfiguracion.Size = new System.Drawing.Size(749, 641);
            this.panelConfiguracion.TabIndex = 0;
            // 
            // guna2ButtonVer_Usuario
            // 
            this.guna2ButtonVer_Usuario.BorderRadius = 18;
            this.guna2ButtonVer_Usuario.FillColor = System.Drawing.Color.Coral;
            this.guna2ButtonVer_Usuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonVer_Usuario.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonVer_Usuario.Location = new System.Drawing.Point(524, 534);
            this.guna2ButtonVer_Usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ButtonVer_Usuario.Name = "guna2ButtonVer_Usuario";
            this.guna2ButtonVer_Usuario.Size = new System.Drawing.Size(134, 50);
            this.guna2ButtonVer_Usuario.TabIndex = 15;
            this.guna2ButtonVer_Usuario.Text = "Ver usuarios";
            this.guna2ButtonVer_Usuario.Click += new System.EventHandler(this.guna2ButtonVer_Usuario_Click);
            // 
            // guna2ButtonGuardar_Contraseña
            // 
            this.guna2ButtonGuardar_Contraseña.BorderRadius = 18;
            this.guna2ButtonGuardar_Contraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.guna2ButtonGuardar_Contraseña.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonGuardar_Contraseña.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonGuardar_Contraseña.Location = new System.Drawing.Point(276, 532);
            this.guna2ButtonGuardar_Contraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ButtonGuardar_Contraseña.Name = "guna2ButtonGuardar_Contraseña";
            this.guna2ButtonGuardar_Contraseña.Size = new System.Drawing.Size(207, 52);
            this.guna2ButtonGuardar_Contraseña.TabIndex = 14;
            this.guna2ButtonGuardar_Contraseña.Text = "💾 Guardar Contraseña";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTitulo.Location = new System.Drawing.Point(35, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(388, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configuración del Sistema";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(38, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(148, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Colegio";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderRadius = 15;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(45, 135);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese el nombre...";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(680, 45);
            this.txtNombre.TabIndex = 2;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAño.Location = new System.Drawing.Point(45, 200);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(91, 20);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año Escolar";
            // 
            // txtAño
            // 
            this.txtAño.BorderRadius = 15;
            this.txtAño.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAño.DefaultText = "";
            this.txtAño.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAño.Location = new System.Drawing.Point(45, 225);
            this.txtAño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAño.Name = "txtAño";
            this.txtAño.PlaceholderText = "Ejemplo: 2025-2026";
            this.txtAño.SelectedText = "";
            this.txtAño.Size = new System.Drawing.Size(680, 45);
            this.txtAño.TabIndex = 4;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLogo.Location = new System.Drawing.Point(45, 278);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(135, 20);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "Logo Institucional";
            // 
            // btnSeleccionarLogo
            // 
            this.btnSeleccionarLogo.BorderRadius = 15;
            this.btnSeleccionarLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnSeleccionarLogo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarLogo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarLogo.Location = new System.Drawing.Point(42, 311);
            this.btnSeleccionarLogo.Name = "btnSeleccionarLogo";
            this.btnSeleccionarLogo.Size = new System.Drawing.Size(250, 45);
            this.btnSeleccionarLogo.TabIndex = 6;
            this.btnSeleccionarLogo.Text = "Seleccionar Logo";
            this.btnSeleccionarLogo.Click += new System.EventHandler(this.btnSeleccionarLogo_Click);
            // 
            // lblNuevaPass
            // 
            this.lblNuevaPass.AutoSize = true;
            this.lblNuevaPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNuevaPass.Location = new System.Drawing.Point(43, 369);
            this.lblNuevaPass.Name = "lblNuevaPass";
            this.lblNuevaPass.Size = new System.Drawing.Size(63, 20);
            this.lblNuevaPass.TabIndex = 7;
            this.lblNuevaPass.Text = "Usuario";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.BorderRadius = 15;
            this.txtNuevaContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuevaContraseña.DefaultText = "";
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNuevaContraseña.Location = new System.Drawing.Point(42, 394);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '●';
            this.txtNuevaContraseña.PlaceholderText = "";
            this.txtNuevaContraseña.SelectedText = "";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(680, 45);
            this.txtNuevaContraseña.TabIndex = 8;
            // 
            // lblConfirmarPass
            // 
            this.lblConfirmarPass.AutoSize = true;
            this.lblConfirmarPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblConfirmarPass.Location = new System.Drawing.Point(41, 454);
            this.lblConfirmarPass.Name = "lblConfirmarPass";
            this.lblConfirmarPass.Size = new System.Drawing.Size(88, 20);
            this.lblConfirmarPass.TabIndex = 9;
            this.lblConfirmarPass.Text = "Contraseña";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.BorderRadius = 15;
            this.txtConfirmarContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmarContraseña.DefaultText = "";
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(42, 479);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '●';
            this.txtConfirmarContraseña.PlaceholderText = "";
            this.txtConfirmarContraseña.SelectedText = "";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(680, 45);
            this.txtConfirmarContraseña.TabIndex = 10;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblModo.Location = new System.Drawing.Point(45, 554);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(103, 20);
            this.lblModo.TabIndex = 11;
            this.lblModo.Text = "Modo Oscuro";
            // 
            // swModoOscuro
            // 
            this.swModoOscuro.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.swModoOscuro.Location = new System.Drawing.Point(183, 554);
            this.swModoOscuro.Name = "swModoOscuro";
            this.swModoOscuro.Size = new System.Drawing.Size(55, 30);
            this.swModoOscuro.TabIndex = 12;
            this.swModoOscuro.CheckedChanged += new System.EventHandler(this.swModoOscuro_CheckedChanged_1);
            this.swModoOscuro.Click += new System.EventHandler(this.swModoOscuro_CheckedChanged);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BorderRadius = 18;
            this.btnGuardarCambios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(425, 306);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(245, 50);
            this.btnGuardarCambios.TabIndex = 13;
            this.btnGuardarCambios.Text = "💾 Guardar Configuración";
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.lblInfoTitulo);
            this.panelInfo.Controls.Add(this.lblInfoTexto);
            this.panelInfo.FillColor = System.Drawing.Color.White;
            this.panelInfo.Location = new System.Drawing.Point(1028, 116);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Radius = 25;
            this.panelInfo.ShadowColor = System.Drawing.Color.Silver;
            this.panelInfo.ShadowDepth = 60;
            this.panelInfo.Size = new System.Drawing.Size(272, 270);
            this.panelInfo.TabIndex = 1;
            // 
            // lblInfoTitulo
            // 
            this.lblInfoTitulo.AutoSize = true;
            this.lblInfoTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblInfoTitulo.Location = new System.Drawing.Point(22, 36);
            this.lblInfoTitulo.Name = "lblInfoTitulo";
            this.lblInfoTitulo.Size = new System.Drawing.Size(243, 37);
            this.lblInfoTitulo.TabIndex = 0;
            this.lblInfoTitulo.Text = "⚙ Configuración";
            // 
            // lblInfoTexto
            // 
            this.lblInfoTexto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInfoTexto.ForeColor = System.Drawing.Color.Gray;
            this.lblInfoTexto.Location = new System.Drawing.Point(35, 120);
            this.lblInfoTexto.Name = "lblInfoTexto";
            this.lblInfoTexto.Size = new System.Drawing.Size(230, 120);
            this.lblInfoTexto.TabIndex = 1;
            this.lblInfoTexto.Text = "Desde este panel puedes modificar los datos institucionales, cambiar la contraseñ" +
    "a del administrador y personalizar el sistema.";
            // 
            // guna2btnCompleto
            // 
            this.guna2btnCompleto.BorderRadius = 18;
            this.guna2btnCompleto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.guna2btnCompleto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2btnCompleto.ForeColor = System.Drawing.Color.White;
            this.guna2btnCompleto.Location = new System.Drawing.Point(21, 88);
            this.guna2btnCompleto.Name = "guna2btnCompleto";
            this.guna2btnCompleto.PressedColor = System.Drawing.Color.Aquamarine;
            this.guna2btnCompleto.Size = new System.Drawing.Size(173, 50);
            this.guna2btnCompleto.TabIndex = 14;
            this.guna2btnCompleto.Text = "BK Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(60, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Backups";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2BtnAplicar);
            this.guna2ShadowPanel1.Controls.Add(this.guna2btnLogs);
            this.guna2ShadowPanel1.Controls.Add(this.guna2BtnDiferencial);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2btnCompleto);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(1028, 387);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 25;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Silver;
            this.guna2ShadowPanel1.ShadowDepth = 60;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(272, 353);
            this.guna2ShadowPanel1.TabIndex = 15;
            // 
            // guna2BtnAplicar
            // 
            this.guna2BtnAplicar.BorderRadius = 18;
            this.guna2BtnAplicar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.guna2BtnAplicar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2BtnAplicar.ForeColor = System.Drawing.Color.White;
            this.guna2BtnAplicar.Location = new System.Drawing.Point(21, 289);
            this.guna2BtnAplicar.Name = "guna2BtnAplicar";
            this.guna2BtnAplicar.PressedColor = System.Drawing.Color.Aquamarine;
            this.guna2BtnAplicar.Size = new System.Drawing.Size(173, 50);
            this.guna2BtnAplicar.TabIndex = 17;
            this.guna2BtnAplicar.Text = "Aplicar BK";
            this.guna2BtnAplicar.Click += new System.EventHandler(this.Guna2BtnAplicar_Click);
            // 
            // guna2btnLogs
            // 
            this.guna2btnLogs.BorderRadius = 18;
            this.guna2btnLogs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.guna2btnLogs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2btnLogs.ForeColor = System.Drawing.Color.White;
            this.guna2btnLogs.Location = new System.Drawing.Point(21, 200);
            this.guna2btnLogs.Name = "guna2btnLogs";
            this.guna2btnLogs.PressedColor = System.Drawing.Color.Aquamarine;
            this.guna2btnLogs.Size = new System.Drawing.Size(173, 50);
            this.guna2btnLogs.TabIndex = 16;
            this.guna2btnLogs.Text = "BK Logs";
            // 
            // guna2BtnDiferencial
            // 
            this.guna2BtnDiferencial.BorderRadius = 18;
            this.guna2BtnDiferencial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.guna2BtnDiferencial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2BtnDiferencial.ForeColor = System.Drawing.Color.White;
            this.guna2BtnDiferencial.Location = new System.Drawing.Point(21, 144);
            this.guna2BtnDiferencial.Name = "guna2BtnDiferencial";
            this.guna2BtnDiferencial.PressedColor = System.Drawing.Color.Aquamarine;
            this.guna2BtnDiferencial.Size = new System.Drawing.Size(173, 50);
            this.guna2BtnDiferencial.TabIndex = 15;
            this.guna2BtnDiferencial.Text = "BK Diferencial";
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panelConfiguracion);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormConfiguracion_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.panelConfiguracion.ResumeLayout(false);
            this.panelConfiguracion.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Button guna2btnCompleto;
        private Label label1;
        private Guna2ShadowPanel guna2ShadowPanel1;
        private Guna2Button guna2btnLogs;
        private Guna2Button guna2BtnDiferencial;
        private Guna2Button guna2BtnAplicar;
        private Label label2;
        private Label lblSistema;
        private Label label3;
        private PictureBox pictureBox1;
        private Guna2Button guna2ButtonGuardar_Contraseña;
        private Guna2Button guna2ButtonVer_Usuario;
    }
}