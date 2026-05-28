using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CapaPresentacion
{
    partial class Form1
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
        private Guna2ShadowPanel panelFormulario;
        private Guna2ShadowPanel panelInfo;
        private Guna2PictureBox imgUser;

        private Label lblSistema;
        private Label lblInstitucion;
        private Label lblRol;
        private Label lblUsuario;
        private Label lblFecha;
        private Label lblTitulo;

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblGenero;
        private Label lblNacimiento;
        private Label lblPadre;
        private Label lblTelefono;
        private Label lblIngreso;
        private Label lblCurso;

        private Guna2TextBox txtNombre;
        private Guna2TextBox txtApellido;
        private Guna2TextBox txtDireccion;
        private Guna2TextBox txtPadre;
        private Guna2TextBox txtTelefono;

        private Guna2ComboBox cbGenero;
        private Guna2ComboBox cmbCurso;

        private Guna2DateTimePicker dtpFechaNacimiento;
        private Guna2DateTimePicker dtpIngreso;

        private Guna2GradientButton btnGuardar;
        private Guna2GradientButton btnActualizar;
        private Guna2GradientButton btnEliminar;
        private Guna2GradientButton button14;

        private Guna2Button btnRegistrar;
        private Guna2Button btnCursos;
        private Guna2Button btnMaestro;
        private Guna2Button btnMaterias;
        private Guna2Button btnContacto;
        private Guna2Button btnConfiguracion;

        private Guna2Button btnCerrarSeccion;

        private Label lblInfo;
        private Label lblInfoTexto;

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
            this.btnCerrarSeccion = new Guna.UI2.WinForms.Guna2Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelFormulario = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cbGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblPadre = new System.Windows.Forms.Label();
            this.txtPadre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button14 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelInfo = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInfoTexto = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCurso = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpIngreso = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.panelFormulario.SuspendLayout();
            this.panelInfo.SuspendLayout();
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
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(279, 740);
            this.panelSidebar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(43, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sistema de Calificaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, -21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 91);
            this.label1.TabIndex = 10;
            this.label1.Text = "🎓";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(22, 114);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(153, 32);
            this.lblSistema.TabIndex = 1;
            this.lblSistema.Text = "Edu-Control";
            this.lblSistema.Click += new System.EventHandler(this.lblSistema_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BorderRadius = 12;
            this.btnRegistrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(-53, 240);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(352, 50);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "📝 Registrar Estudiantes";
            // 
            // btnCursos
            // 
            this.btnCursos.BorderRadius = 12;
            this.btnCursos.FillColor = System.Drawing.Color.Transparent;
            this.btnCursos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.White;
            this.btnCursos.Location = new System.Drawing.Point(-10, 296);
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
            this.btnMaestro.Location = new System.Drawing.Point(-38, 352);
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
            this.btnMaterias.Location = new System.Drawing.Point(-38, 403);
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
            this.btnContacto.Location = new System.Drawing.Point(-38, 460);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(220, 50);
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
            this.btnConfiguracion.Location = new System.Drawing.Point(-10, 525);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(220, 50);
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
            this.panelTop.Controls.Add(this.btnCerrarSeccion);
            this.panelTop.Controls.Add(this.lblFecha);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(279, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1021, 110);
            this.panelTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imagen_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstitucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblInstitucion.Location = new System.Drawing.Point(102, 20);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(303, 30);
            this.lblInstitucion.TabIndex = 0;
            this.lblInstitucion.Text = "Centro Educacional Bautista";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblRol.Location = new System.Drawing.Point(112, 68);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(87, 20);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol: Admin";
            // 
            // imgUser
            // 
            this.imgUser.Image = global::CapaPresentacion.Properties.Resources.login_imagen;
            this.imgUser.ImageRotate = 0F;
            this.imgUser.Location = new System.Drawing.Point(572, 25);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(55, 55);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 2;
            this.imgUser.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(633, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(129, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario: Leurianny";
            // 
            // btnCerrarSeccion
            // 
            this.btnCerrarSeccion.BorderRadius = 12;
            this.btnCerrarSeccion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCerrarSeccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSeccion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSeccion.Location = new System.Drawing.Point(836, 25);
            this.btnCerrarSeccion.Name = "btnCerrarSeccion";
            this.btnCerrarSeccion.Size = new System.Drawing.Size(181, 45);
            this.btnCerrarSeccion.TabIndex = 4;
            this.btnCerrarSeccion.Text = "Cerrar Sesión";
            this.btnCerrarSeccion.Click += new System.EventHandler(this.btnCerrarSeccion_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(745, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 19);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.Transparent;
            this.panelFormulario.Controls.Add(this.label4);
            this.panelFormulario.Controls.Add(this.lblTitulo);
            this.panelFormulario.Controls.Add(this.lblNombre);
            this.panelFormulario.Controls.Add(this.txtNombre);
            this.panelFormulario.Controls.Add(this.lblApellido);
            this.panelFormulario.Controls.Add(this.txtApellido);
            this.panelFormulario.Controls.Add(this.lblDireccion);
            this.panelFormulario.Controls.Add(this.txtDireccion);
            this.panelFormulario.Controls.Add(this.lblGenero);
            this.panelFormulario.Controls.Add(this.cbGenero);
            this.panelFormulario.Controls.Add(this.lblNacimiento);
            this.panelFormulario.Controls.Add(this.dtpFechaNacimiento);
            this.panelFormulario.Controls.Add(this.lblPadre);
            this.panelFormulario.Controls.Add(this.txtPadre);
            this.panelFormulario.Controls.Add(this.lblTelefono);
            this.panelFormulario.Controls.Add(this.txtTelefono);
            this.panelFormulario.Controls.Add(this.btnGuardar);
            this.panelFormulario.Controls.Add(this.btnActualizar);
            this.panelFormulario.Controls.Add(this.btnEliminar);
            this.panelFormulario.Controls.Add(this.button14);
            this.panelFormulario.FillColor = System.Drawing.Color.White;
            this.panelFormulario.Location = new System.Drawing.Point(285, 116);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Radius = 25;
            this.panelFormulario.ShadowColor = System.Drawing.Color.Black;
            this.panelFormulario.Size = new System.Drawing.Size(749, 699);
            this.panelFormulario.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Informacion Madre Padre o Tutor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTitulo.Location = new System.Drawing.Point(33, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(349, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Estudiantes";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(40, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderRadius = 15;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(40, 88);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(650, 40);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(40, 133);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 23);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderRadius = 15;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.DefaultText = "";
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.Location = new System.Drawing.Point(40, 150);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "";
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(650, 40);
            this.txtApellido.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(40, 195);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(100, 23);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderRadius = 15;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "";
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.Location = new System.Drawing.Point(40, 212);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.Size = new System.Drawing.Size(650, 40);
            this.txtDireccion.TabIndex = 6;
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(40, 257);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(100, 23);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Género";
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.Color.Transparent;
            this.cbGenero.BorderRadius = 15;
            this.cbGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FocusedColor = System.Drawing.Color.Empty;
            this.cbGenero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGenero.ItemHeight = 30;
            this.cbGenero.Items.AddRange(new object[] {
            "Masculino",
            "",
            "Femenino"});
            this.cbGenero.Location = new System.Drawing.Point(40, 279);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(650, 36);
            this.cbGenero.TabIndex = 8;
            this.cbGenero.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.Location = new System.Drawing.Point(40, 328);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(100, 23);
            this.lblNacimiento.TabIndex = 9;
            this.lblNacimiento.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.BorderRadius = 15;
            this.dtpFechaNacimiento.Checked = true;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(43, 354);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(650, 40);
            this.dtpFechaNacimiento.TabIndex = 10;
            this.dtpFechaNacimiento.Value = new System.DateTime(2026, 5, 24, 17, 9, 32, 972);
            // 
            // lblPadre
            // 
            this.lblPadre.Location = new System.Drawing.Point(40, 436);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(100, 23);
            this.lblPadre.TabIndex = 11;
            this.lblPadre.Text = "Nombre Padre/Tutor";
            // 
            // txtPadre
            // 
            this.txtPadre.BorderRadius = 15;
            this.txtPadre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPadre.DefaultText = "";
            this.txtPadre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPadre.Location = new System.Drawing.Point(40, 471);
            this.txtPadre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPadre.Name = "txtPadre";
            this.txtPadre.PlaceholderText = "";
            this.txtPadre.SelectedText = "";
            this.txtPadre.Size = new System.Drawing.Size(650, 40);
            this.txtPadre.TabIndex = 12;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(39, 516);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 23);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderRadius = 15;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(40, 544);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(650, 40);
            this.txtTelefono.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 15;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnGuardar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(20, 616);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 45);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BorderRadius = 15;
            this.btnActualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnActualizar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(180, 616);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 45);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 15;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnEliminar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(339, 616);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 45);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button14
            // 
            this.button14.BorderRadius = 15;
            this.button14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.button14.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234)))));
            this.button14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(508, 616);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(140, 45);
            this.button14.TabIndex = 18;
            this.button14.Text = "Listado";
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.linkLabel1);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.lblInfo);
            this.panelInfo.Controls.Add(this.lblInfoTexto);
            this.panelInfo.FillColor = System.Drawing.Color.White;
            this.panelInfo.Location = new System.Drawing.Point(1040, 198);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Radius = 25;
            this.panelInfo.ShadowColor = System.Drawing.Color.Black;
            this.panelInfo.Size = new System.Drawing.Size(260, 377);
            this.panelInfo.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(71, 272);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Soporte Tecnico ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(47, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "¿Necesitas Ayuda?";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblInfo.Location = new System.Drawing.Point(30, 30);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(155, 32);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Información";
            // 
            // lblInfoTexto
            // 
            this.lblInfoTexto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInfoTexto.ForeColor = System.Drawing.Color.Gray;
            this.lblInfoTexto.Location = new System.Drawing.Point(30, 100);
            this.lblInfoTexto.Name = "lblInfoTexto";
            this.lblInfoTexto.Size = new System.Drawing.Size(220, 300);
            this.lblInfoTexto.TabIndex = 1;
            this.lblInfoTexto.Text = "Complete correctamente los datos del estudiante.";
            // 
            // lblIngreso
            // 
            this.lblIngreso.Location = new System.Drawing.Point(0, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(100, 23);
            this.lblIngreso.TabIndex = 0;
            // 
            // lblCurso
            // 
            this.lblCurso.Location = new System.Drawing.Point(0, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(100, 23);
            this.lblCurso.TabIndex = 0;
            // 
            // cmbCurso
            // 
            this.cmbCurso.BackColor = System.Drawing.Color.Transparent;
            this.cmbCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCurso.ItemHeight = 30;
            this.cmbCurso.Location = new System.Drawing.Point(0, 0);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(140, 36);
            this.cmbCurso.TabIndex = 0;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Checked = true;
            this.dtpIngreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpIngreso.Location = new System.Drawing.Point(0, 0);
            this.dtpIngreso.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpIngreso.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(200, 36);
            this.dtpIngreso.TabIndex = 0;
            this.dtpIngreso.Value = new System.DateTime(2026, 5, 24, 17, 9, 33, 233);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Estudiantes";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
    }
}