using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CapaPresentacion
{
    partial class FormPrincipal
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
        private Guna2ShadowPanel panelDashboard;
        private Guna2PictureBox imgUser;

        private Label lblSistema;
        private Label lblInstitucion;
        private Label lblRol;
        private Label lblUsuario;
        private Label lblFecha;
        private Label lblTitulo;

        private Guna2Button btnRegistrar;
        private Guna2Button btnCursos;
        private Guna2Button btnMaestro;
        private Guna2Button btnMaterias;
        private Guna2Button btnContacto;
        private Guna2Button btnConfiguracion;
        private Guna2Button btnCerrarSesion;

        private Guna2GradientPanel cardEstudiantes;
        private Guna2GradientPanel cardCursos;
        private Guna2GradientPanel cardMensajes;

        private Label lblEstudiantesNumero;
        private Label lblCursosNumero;
        private Label lblMensajesNumero;

        private Label lblEstudiantesTexto;
        private Label lblCursosTexto;
        private Label lblMensajesTexto;

        private Label lblIcono1;
        private Label lblIcono2;
        private Label lblIcono3;

        private void InitializeComponent()
        {
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panelDashboard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cardEstudiantes = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblEstudiantesNumero = new System.Windows.Forms.Label();
            this.lblEstudiantesTexto = new System.Windows.Forms.Label();
            this.lblIcono1 = new System.Windows.Forms.Label();
            this.cardCursos = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblCursosNumero = new System.Windows.Forms.Label();
            this.lblCursosTexto = new System.Windows.Forms.Label();
            this.lblIcono2 = new System.Windows.Forms.Label();
            this.cardMensajes = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblMensajesNumero = new System.Windows.Forms.Label();
            this.lblMensajesTexto = new System.Windows.Forms.Label();
            this.lblIcono3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.cardEstudiantes.SuspendLayout();
            this.cardCursos.SuspendLayout();
            this.cardMensajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.panelSidebar.Controls.Add(this.label2);
            this.panelSidebar.Controls.Add(this.label1);
            this.panelSidebar.Controls.Add(this.lblSistema);
            this.panelSidebar.Controls.Add(this.btnRegistrar);
            this.panelSidebar.Controls.Add(this.btnCursos);
            this.panelSidebar.Controls.Add(this.btnMaestro);
            this.panelSidebar.Controls.Add(this.btnMaterias);
            this.panelSidebar.Controls.Add(this.btnContacto);
            this.panelSidebar.Controls.Add(this.btnConfiguracion);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(375, 1106);
            this.panelSidebar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(80, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sistema de Calificaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 163);
            this.label1.TabIndex = 8;
            this.label1.Text = "🎓";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(52, 172);
            this.lblSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(249, 54);
            this.lblSistema.TabIndex = 1;
            this.lblSistema.Text = "Edu-Control";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BorderRadius = 12;
            this.btnRegistrar.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(-10, 322);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(330, 77);
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
            this.btnCursos.Location = new System.Drawing.Point(-45, 385);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(330, 77);
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
            this.btnMaestro.Location = new System.Drawing.Point(-74, 445);
            this.btnMaestro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaestro.Name = "btnMaestro";
            this.btnMaestro.Size = new System.Drawing.Size(330, 77);
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
            this.btnMaterias.Location = new System.Drawing.Point(-74, 508);
            this.btnMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(330, 77);
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
            this.btnContacto.Location = new System.Drawing.Point(-74, 571);
            this.btnContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(330, 77);
            this.btnContacto.TabIndex = 6;
            this.btnContacto.Text = "📞 Contacto";
            this.btnContacto.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BorderRadius = 12;
            this.btnConfiguracion.FillColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Location = new System.Drawing.Point(-45, 637);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(330, 77);
            this.btnConfiguracion.TabIndex = 7;
            this.btnConfiguracion.Text = "⚙ Configuración";
            this.btnConfiguracion.Click += new System.EventHandler(this.button8_Click);
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
            this.panelTop.Location = new System.Drawing.Point(375, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1571, 169);
            this.panelTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imagen_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInstitucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblInstitucion.Location = new System.Drawing.Point(123, 37);
            this.lblInstitucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(489, 48);
            this.lblInstitucion.TabIndex = 0;
            this.lblInstitucion.Text = "Centro Educacional Bautista";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblRol.Location = new System.Drawing.Point(126, 98);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(125, 30);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol: Admin";
            // 
            // imgUser
            // 
            this.imgUser.Image = global::CapaPresentacion.Properties.Resources.login_imagen;
            this.imgUser.ImageRotate = 0F;
            this.imgUser.Location = new System.Drawing.Point(1040, 31);
            this.imgUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(82, 85);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 2;
            this.imgUser.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(1130, 52);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(205, 30);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario: Leurianny";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BorderRadius = 12;
            this.btnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1346, 37);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(225, 69);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(1164, 111);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(281, 28);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "domingo, 24 de mayo de 2026";
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.Transparent;
            this.panelDashboard.Controls.Add(this.linkLabel1);
            this.panelDashboard.Controls.Add(this.label3);
            this.panelDashboard.Controls.Add(this.panelContenido);
            this.panelDashboard.Controls.Add(this.lblTitulo);
            this.panelDashboard.Controls.Add(this.cardEstudiantes);
            this.panelDashboard.Controls.Add(this.cardCursos);
            this.panelDashboard.Controls.Add(this.cardMensajes);
            this.panelDashboard.FillColor = System.Drawing.Color.White;
            this.panelDashboard.Location = new System.Drawing.Point(405, 200);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Radius = 25;
            this.panelDashboard.ShadowColor = System.Drawing.Color.Silver;
            this.panelDashboard.Size = new System.Drawing.Size(1620, 1046);
            this.panelDashboard.TabIndex = 1;
            // 
            // panelContenido
            // 
            this.panelContenido.Location = new System.Drawing.Point(152, 383);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1276, 612);
            this.panelContenido.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTitulo.Location = new System.Drawing.Point(52, 38);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(826, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido al Panel de Administracion";
            // 
            // cardEstudiantes
            // 
            this.cardEstudiantes.BorderRadius = 20;
            this.cardEstudiantes.Controls.Add(this.lblEstudiantesNumero);
            this.cardEstudiantes.Controls.Add(this.lblEstudiantesTexto);
            this.cardEstudiantes.Controls.Add(this.lblIcono1);
            this.cardEstudiantes.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.cardEstudiantes.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.cardEstudiantes.Location = new System.Drawing.Point(60, 154);
            this.cardEstudiantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardEstudiantes.Name = "cardEstudiantes";
            this.cardEstudiantes.Size = new System.Drawing.Size(450, 200);
            this.cardEstudiantes.TabIndex = 1;
            // 
            // lblEstudiantesNumero
            // 
            this.lblEstudiantesNumero.AutoSize = true;
            this.lblEstudiantesNumero.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblEstudiantesNumero.ForeColor = System.Drawing.Color.White;
            this.lblEstudiantesNumero.Location = new System.Drawing.Point(30, 23);
            this.lblEstudiantesNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstudiantesNumero.Name = "lblEstudiantesNumero";
            this.lblEstudiantesNumero.Size = new System.Drawing.Size(112, 65);
            this.lblEstudiantesNumero.TabIndex = 0;
            this.lblEstudiantesNumero.Text = "487";
            // 
            // lblEstudiantesTexto
            // 
            this.lblEstudiantesTexto.AutoSize = true;
            this.lblEstudiantesTexto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEstudiantesTexto.ForeColor = System.Drawing.Color.White;
            this.lblEstudiantesTexto.Location = new System.Drawing.Point(33, 138);
            this.lblEstudiantesTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstudiantesTexto.Name = "lblEstudiantesTexto";
            this.lblEstudiantesTexto.Size = new System.Drawing.Size(239, 30);
            this.lblEstudiantesTexto.TabIndex = 1;
            this.lblEstudiantesTexto.Text = "Estudiantes Registrados";
            // 
            // lblIcono1
            // 
            this.lblIcono1.AutoSize = true;
            this.lblIcono1.Font = new System.Drawing.Font("Segoe UI Emoji", 35F);
            this.lblIcono1.ForeColor = System.Drawing.Color.White;
            this.lblIcono1.Location = new System.Drawing.Point(330, 31);
            this.lblIcono1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcono1.Name = "lblIcono1";
            this.lblIcono1.Size = new System.Drawing.Size(136, 94);
            this.lblIcono1.TabIndex = 2;
            this.lblIcono1.Text = "🎓";
            // 
            // cardCursos
            // 
            this.cardCursos.BorderRadius = 20;
            this.cardCursos.Controls.Add(this.lblCursosNumero);
            this.cardCursos.Controls.Add(this.lblCursosTexto);
            this.cardCursos.Controls.Add(this.lblIcono2);
            this.cardCursos.FillColor = System.Drawing.Color.LimeGreen;
            this.cardCursos.FillColor2 = System.Drawing.Color.SeaGreen;
            this.cardCursos.Location = new System.Drawing.Point(570, 154);
            this.cardCursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardCursos.Name = "cardCursos";
            this.cardCursos.Size = new System.Drawing.Size(450, 200);
            this.cardCursos.TabIndex = 2;
            // 
            // lblCursosNumero
            // 
            this.lblCursosNumero.AutoSize = true;
            this.lblCursosNumero.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCursosNumero.ForeColor = System.Drawing.Color.White;
            this.lblCursosNumero.Location = new System.Drawing.Point(30, 23);
            this.lblCursosNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCursosNumero.Name = "lblCursosNumero";
            this.lblCursosNumero.Size = new System.Drawing.Size(84, 65);
            this.lblCursosNumero.TabIndex = 0;
            this.lblCursosNumero.Text = "14";
            // 
            // lblCursosTexto
            // 
            this.lblCursosTexto.AutoSize = true;
            this.lblCursosTexto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCursosTexto.ForeColor = System.Drawing.Color.White;
            this.lblCursosTexto.Location = new System.Drawing.Point(33, 138);
            this.lblCursosTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCursosTexto.Name = "lblCursosTexto";
            this.lblCursosTexto.Size = new System.Drawing.Size(178, 30);
            this.lblCursosTexto.TabIndex = 1;
            this.lblCursosTexto.Text = "Cursos Ofrecidos";
            // 
            // lblIcono2
            // 
            this.lblIcono2.AutoSize = true;
            this.lblIcono2.Font = new System.Drawing.Font("Segoe UI Emoji", 35F);
            this.lblIcono2.ForeColor = System.Drawing.Color.White;
            this.lblIcono2.Location = new System.Drawing.Point(330, 31);
            this.lblIcono2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcono2.Name = "lblIcono2";
            this.lblIcono2.Size = new System.Drawing.Size(136, 94);
            this.lblIcono2.TabIndex = 2;
            this.lblIcono2.Text = "📖";
            // 
            // cardMensajes
            // 
            this.cardMensajes.BorderRadius = 20;
            this.cardMensajes.Controls.Add(this.lblMensajesNumero);
            this.cardMensajes.Controls.Add(this.lblMensajesTexto);
            this.cardMensajes.Controls.Add(this.lblIcono3);
            this.cardMensajes.FillColor = System.Drawing.Color.Orange;
            this.cardMensajes.FillColor2 = System.Drawing.Color.DarkOrange;
            this.cardMensajes.Location = new System.Drawing.Point(1080, 154);
            this.cardMensajes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardMensajes.Name = "cardMensajes";
            this.cardMensajes.Size = new System.Drawing.Size(450, 200);
            this.cardMensajes.TabIndex = 3;
            // 
            // lblMensajesNumero
            // 
            this.lblMensajesNumero.AutoSize = true;
            this.lblMensajesNumero.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMensajesNumero.ForeColor = System.Drawing.Color.White;
            this.lblMensajesNumero.Location = new System.Drawing.Point(30, 23);
            this.lblMensajesNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensajesNumero.Name = "lblMensajesNumero";
            this.lblMensajesNumero.Size = new System.Drawing.Size(56, 65);
            this.lblMensajesNumero.TabIndex = 0;
            this.lblMensajesNumero.Text = "8";
            // 
            // lblMensajesTexto
            // 
            this.lblMensajesTexto.AutoSize = true;
            this.lblMensajesTexto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMensajesTexto.ForeColor = System.Drawing.Color.White;
            this.lblMensajesTexto.Location = new System.Drawing.Point(33, 138);
            this.lblMensajesTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensajesTexto.Name = "lblMensajesTexto";
            this.lblMensajesTexto.Size = new System.Drawing.Size(201, 30);
            this.lblMensajesTexto.TabIndex = 1;
            this.lblMensajesTexto.Text = "Mensajes Recibidos";
            // 
            // lblIcono3
            // 
            this.lblIcono3.AutoSize = true;
            this.lblIcono3.Font = new System.Drawing.Font("Segoe UI Emoji", 35F);
            this.lblIcono3.ForeColor = System.Drawing.Color.White;
            this.lblIcono3.Location = new System.Drawing.Point(330, 31);
            this.lblIcono3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcono3.Name = "lblIcono3";
            this.lblIcono3.Size = new System.Drawing.Size(136, 94);
            this.lblIcono3.TabIndex = 2;
            this.lblIcono3.Text = "✉️";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(1209, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "¿Necesitas Ayuda?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1230, 57);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Soporte Tecnico";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load_1);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.cardEstudiantes.ResumeLayout(false);
            this.cardEstudiantes.PerformLayout();
            this.cardCursos.ResumeLayout(false);
            this.cardCursos.PerformLayout();
            this.cardMensajes.ResumeLayout(false);
            this.cardMensajes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContenido;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label3;
    }
}