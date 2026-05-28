using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CapaPresentacion
{
    partial class Cursos
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
        private Guna2ShadowPanel panelCursos;

        private Label lblSistema;
        private Label lblInstitucion;
        private Label lblRol;
        private Label lblUsuario;
        private Label lblFecha;
        private Label labelTitulo;

        private Guna2Button btnRegistrar;
        private Guna2Button btnCursos;
        private Guna2Button btnMaestro;
        private Guna2Button btnMaterias;
        private Guna2Button btnContacto;
        private Guna2Button btnConfiguracion;
        private Guna2Button btnCerrarSesion;

        private Guna2GradientButton btnTandaMatutina;
        private Guna2GradientButton btnTandaVespertina;
        private Guna2GradientButton btnVolver;

        private Guna2PictureBox imgUser;

        private DataGridView dgvCursos;

        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Maestro;
        private DataGridViewTextBoxColumn Estudiantes;

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;

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
            this.panelCursos = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnTandaMatutina = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTandaVespertina = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnVolver = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAyuda = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblAyudaTexto = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.panelCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.panelAyuda.SuspendLayout();
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
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 739);
            this.panelSidebar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sistema de Calificaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "🎓";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(44, 102);
            this.lblSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(172, 37);
            this.lblSistema.TabIndex = 2;
            this.lblSistema.Text = "Edu-Control";
            this.lblSistema.Click += new System.EventHandler(this.lblSistema_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BorderRadius = 12;
            this.btnRegistrar.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(-19, 182);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(220, 50);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "📝 Registrar Estudiantes";
            this.btnRegistrar.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BorderRadius = 12;
            this.btnCursos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCursos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCursos.ForeColor = System.Drawing.Color.White;
            this.btnCursos.Location = new System.Drawing.Point(-39, 236);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(220, 50);
            this.btnCursos.TabIndex = 4;
            this.btnCursos.Text = "📚 Listado Cursos";
            // 
            // btnMaestro
            // 
            this.btnMaestro.BorderRadius = 12;
            this.btnMaestro.FillColor = System.Drawing.Color.Transparent;
            this.btnMaestro.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMaestro.ForeColor = System.Drawing.Color.White;
            this.btnMaestro.Location = new System.Drawing.Point(-57, 290);
            this.btnMaestro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaestro.Name = "btnMaestro";
            this.btnMaestro.Size = new System.Drawing.Size(220, 50);
            this.btnMaestro.TabIndex = 5;
            this.btnMaestro.Text = "👨‍🏫 Maestro";
            this.btnMaestro.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.BorderRadius = 12;
            this.btnMaterias.FillColor = System.Drawing.Color.Transparent;
            this.btnMaterias.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMaterias.ForeColor = System.Drawing.Color.White;
            this.btnMaterias.Location = new System.Drawing.Point(-57, 337);
            this.btnMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(220, 41);
            this.btnMaterias.TabIndex = 6;
            this.btnMaterias.Text = "📖 Materias";
            this.btnMaterias.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnContacto
            // 
            this.btnContacto.BorderRadius = 12;
            this.btnContacto.FillColor = System.Drawing.Color.Transparent;
            this.btnContacto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnContacto.ForeColor = System.Drawing.Color.White;
            this.btnContacto.Location = new System.Drawing.Point(-57, 376);
            this.btnContacto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(220, 50);
            this.btnContacto.TabIndex = 7;
            this.btnContacto.Text = "📞 Contacto";
            this.btnContacto.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BorderRadius = 12;
            this.btnConfiguracion.FillColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Location = new System.Drawing.Point(-39, 417);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(220, 50);
            this.btnConfiguracion.TabIndex = 8;
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
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1050, 110);
            this.panelTop.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imagen_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInstitucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblInstitucion.Location = new System.Drawing.Point(83, 24);
            this.lblInstitucion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(334, 32);
            this.lblInstitucion.TabIndex = 1;
            this.lblInstitucion.Text = "Centro Educacional Bautista";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblRol.Location = new System.Drawing.Point(85, 56);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(87, 20);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol: Admin";
            // 
            // imgUser
            // 
            this.imgUser.ImageRotate = 0F;
            this.imgUser.Location = new System.Drawing.Point(421, 11);
            this.imgUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(55, 55);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 3;
            this.imgUser.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(661, 32);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(140, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario: Leurianny";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BorderRadius = 12;
            this.btnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(856, 24);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(150, 45);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(735, 77);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 19);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // panelCursos
            // 
            this.panelCursos.BackColor = System.Drawing.Color.Transparent;
            this.panelCursos.Controls.Add(this.labelTitulo);
            this.panelCursos.Controls.Add(this.btnTandaMatutina);
            this.panelCursos.Controls.Add(this.btnTandaVespertina);
            this.panelCursos.Controls.Add(this.btnVolver);
            this.panelCursos.Controls.Add(this.dgvCursos);
            this.panelCursos.FillColor = System.Drawing.Color.White;
            this.panelCursos.Location = new System.Drawing.Point(270, 131);
            this.panelCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCursos.Name = "panelCursos";
            this.panelCursos.Radius = 25;
            this.panelCursos.ShadowColor = System.Drawing.Color.Silver;
            this.panelCursos.Size = new System.Drawing.Size(769, 533);
            this.panelCursos.TabIndex = 0;
            this.panelCursos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCursos_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(57, 272);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Soporte Tecnico";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.labelTitulo.Location = new System.Drawing.Point(31, 23);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(264, 41);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Listado de Cursos";
            // 
            // btnTandaMatutina
            // 
            this.btnTandaMatutina.BorderRadius = 15;
            this.btnTandaMatutina.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnTandaMatutina.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTandaMatutina.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTandaMatutina.ForeColor = System.Drawing.Color.White;
            this.btnTandaMatutina.Location = new System.Drawing.Point(37, 78);
            this.btnTandaMatutina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTandaMatutina.Name = "btnTandaMatutina";
            this.btnTandaMatutina.Size = new System.Drawing.Size(167, 36);
            this.btnTandaMatutina.TabIndex = 1;
            this.btnTandaMatutina.Text = "Tanda Matutina";
            this.btnTandaMatutina.Click += new System.EventHandler(this.btnTandaMatutina_Click);
            // 
            // btnTandaVespertina
            // 
            this.btnTandaVespertina.BorderRadius = 15;
            this.btnTandaVespertina.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnTandaVespertina.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnTandaVespertina.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTandaVespertina.ForeColor = System.Drawing.Color.White;
            this.btnTandaVespertina.Location = new System.Drawing.Point(227, 78);
            this.btnTandaVespertina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTandaVespertina.Name = "btnTandaVespertina";
            this.btnTandaVespertina.Size = new System.Drawing.Size(167, 36);
            this.btnTandaVespertina.TabIndex = 2;
            this.btnTandaVespertina.Text = "Tanda Vespertina";
            this.btnTandaVespertina.Click += new System.EventHandler(this.btnTandaVespertina_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BorderRadius = 15;
            this.btnVolver.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnVolver.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(564, 51);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(167, 36);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.ColumnHeadersHeight = 45;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Curso,
            this.Maestro,
            this.Estudiantes});
            this.dgvCursos.Location = new System.Drawing.Point(23, 144);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowHeadersWidth = 62;
            this.dgvCursos.Size = new System.Drawing.Size(725, 350);
            this.dgvCursos.TabIndex = 4;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.MinimumWidth = 8;
            this.Curso.Name = "Curso";
            this.Curso.Width = 400;
            // 
            // Maestro
            // 
            this.Maestro.HeaderText = "Maestro";
            this.Maestro.MinimumWidth = 8;
            this.Maestro.Name = "Maestro";
            this.Maestro.Width = 450;
            // 
            // Estudiantes
            // 
            this.Estudiantes.HeaderText = "Estudiantes";
            this.Estudiantes.MinimumWidth = 8;
            this.Estudiantes.Name = "Estudiantes";
            this.Estudiantes.Width = 250;
            // 
            // panelAyuda
            // 
            this.panelAyuda.BackColor = System.Drawing.Color.Transparent;
            this.panelAyuda.Controls.Add(this.linkLabel1);
            this.panelAyuda.Controls.Add(this.lblAyuda);
            this.panelAyuda.Controls.Add(this.lblAyudaTexto);
            this.panelAyuda.FillColor = System.Drawing.Color.White;
            this.panelAyuda.Location = new System.Drawing.Point(1054, 209);
            this.panelAyuda.Name = "panelAyuda";
            this.panelAyuda.Radius = 25;
            this.panelAyuda.ShadowColor = System.Drawing.Color.Silver;
            this.panelAyuda.ShadowDepth = 60;
            this.panelAyuda.Size = new System.Drawing.Size(246, 362);
            this.panelAyuda.TabIndex = 3;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblAyuda.Location = new System.Drawing.Point(3, 45);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(248, 37);
            this.lblAyuda.TabIndex = 0;
            this.lblAyuda.Text = "¿Necesitas ayuda?";
            // 
            // lblAyudaTexto
            // 
            this.lblAyudaTexto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAyudaTexto.ForeColor = System.Drawing.Color.Gray;
            this.lblAyudaTexto.Location = new System.Drawing.Point(19, 95);
            this.lblAyudaTexto.Name = "lblAyudaTexto";
            this.lblAyudaTexto.Size = new System.Drawing.Size(160, 200);
            this.lblAyudaTexto.TabIndex = 1;
            this.lblAyudaTexto.Text = "Si tienes alguna consulta o sugerencia,\r\n\r\nManda tu mensaje y \r\n\r\npondremos en co" +
    "ntacto contigo.";
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1300, 739);
            this.Controls.Add(this.panelAyuda);
            this.Controls.Add(this.panelCursos);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.panelCursos.ResumeLayout(false);
            this.panelCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.panelAyuda.ResumeLayout(false);
            this.panelAyuda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LinkLabel linkLabel1;
        private Guna2ShadowPanel panelAyuda;
        private Label lblAyuda;
        private Label lblAyudaTexto;
    }
}