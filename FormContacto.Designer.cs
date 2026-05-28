    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Guna.UI2.WinForms;

    namespace CapaPresentacion
    {
        partial class FormContacto
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
            private Guna2ShadowPanel panelAyuda;
            private Guna2PictureBox imgUser;

            private Label lblSistema;
            private Label lblInstitucion;
            private Label lblRol;
            private Label lblUsuario;
            private Label lblFecha;

            private Label lblTitulo;

            private Label lblNombre;
            private Label lblCurso;
            private Label lblTelefono;
            private Label lblEmail;
            private Label lblMensaje;

            private Guna2ComboBox cmbEstudiante;
            private Guna2ComboBox cmbCurso;

            private Guna2TextBox txtTelefono;
            private Guna2TextBox txtEmail;
            private Guna2TextBox txtMensaje;

            private Guna2GradientButton btnEnviar;
            private Guna2GradientButton btnEliminar;
            private Guna2GradientButton btnLimpiar;

            private Guna2Button btnRegistrar;
            private Guna2Button btnCursos;
            private Guna2Button btnMaestro;
            private Guna2Button btnMaterias;
            private Guna2Button btnContacto;
            private Guna2Button btnConfiguracion;

            private Guna2Button btnCerrarSesion;

            private Label lblAyuda;
            private Label lblAyudaTexto;

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
            this.panelFormulario = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbEstudiante = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCurso = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtMensaje = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEnviar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelAyuda = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblAyudaTexto = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.panelFormulario.SuspendLayout();
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
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 740);
            this.panelSidebar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(55, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sistema de Calificaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 108);
            this.label1.TabIndex = 10;
            this.label1.Text = "🎓";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(44, 102);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(172, 37);
            this.lblSistema.TabIndex = 1;
            this.lblSistema.Text = "Edu-Control";
            this.lblSistema.Click += new System.EventHandler(this.lblSistema_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BorderRadius = 12;
            this.btnRegistrar.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(-19, 198);
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
            this.btnCursos.Location = new System.Drawing.Point(-33, 244);
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
            this.btnMaestro.Location = new System.Drawing.Point(-51, 289);
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
            this.btnMaterias.Location = new System.Drawing.Point(-51, 335);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(220, 41);
            this.btnMaterias.TabIndex = 5;
            this.btnMaterias.Text = "📖 Materias";
            this.btnMaterias.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnContacto
            // 
            this.btnContacto.BorderRadius = 12;
            this.btnContacto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnContacto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacto.ForeColor = System.Drawing.Color.White;
            this.btnContacto.Location = new System.Drawing.Point(-51, 382);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(220, 50);
            this.btnContacto.TabIndex = 6;
            this.btnContacto.Text = "📞 Contacto";
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BorderRadius = 12;
            this.btnConfiguracion.FillColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Location = new System.Drawing.Point(-33, 432);
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
            this.panelTop.Controls.Add(this.btnCerrarSesion);
            this.panelTop.Controls.Add(this.lblFecha);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1050, 110);
            this.panelTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imagen_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInstitucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblInstitucion.Location = new System.Drawing.Point(67, 20);
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
            this.lblRol.Location = new System.Drawing.Point(79, 56);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(87, 20);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol: Admin";
            // 
            // imgUser
            // 
            this.imgUser.Image = global::CapaPresentacion.Properties.Resources.login_imagen;
            this.imgUser.ImageRotate = 0F;
            this.imgUser.Location = new System.Drawing.Point(680, 20);
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
            this.lblUsuario.Location = new System.Drawing.Point(740, 38);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(140, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario: Leurianny";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BorderRadius = 12;
            this.btnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(897, 31);
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
            this.lblFecha.Location = new System.Drawing.Point(779, 80);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 19);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.Transparent;
            this.panelFormulario.Controls.Add(this.lblTitulo);
            this.panelFormulario.Controls.Add(this.lblNombre);
            this.panelFormulario.Controls.Add(this.cmbEstudiante);
            this.panelFormulario.Controls.Add(this.lblCurso);
            this.panelFormulario.Controls.Add(this.cmbCurso);
            this.panelFormulario.Controls.Add(this.lblTelefono);
            this.panelFormulario.Controls.Add(this.txtTelefono);
            this.panelFormulario.Controls.Add(this.lblEmail);
            this.panelFormulario.Controls.Add(this.txtEmail);
            this.panelFormulario.Controls.Add(this.lblMensaje);
            this.panelFormulario.Controls.Add(this.txtMensaje);
            this.panelFormulario.Controls.Add(this.btnEnviar);
            this.panelFormulario.Controls.Add(this.btnEliminar);
            this.panelFormulario.Controls.Add(this.btnLimpiar);
            this.panelFormulario.FillColor = System.Drawing.Color.White;
            this.panelFormulario.Location = new System.Drawing.Point(256, 116);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Radius = 25;
            this.panelFormulario.ShadowColor = System.Drawing.Color.Silver;
            this.panelFormulario.ShadowDepth = 60;
            this.panelFormulario.Size = new System.Drawing.Size(773, 638);
            this.panelFormulario.TabIndex = 0;
            this.panelFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormulario_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTitulo.Location = new System.Drawing.Point(35, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(351, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formulario de Contacto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(43, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(170, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Estudiante";
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstudiante.BorderRadius = 15;
            this.cmbEstudiante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEstudiante.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEstudiante.ItemHeight = 30;
            this.cmbEstudiante.Location = new System.Drawing.Point(42, 121);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(670, 36);
            this.cmbEstudiante.TabIndex = 2;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurso.Location = new System.Drawing.Point(50, 177);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(127, 20);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso Estudiante";
            // 
            // cmbCurso
            // 
            this.cmbCurso.BackColor = System.Drawing.Color.Transparent;
            this.cmbCurso.BorderRadius = 15;
            this.cmbCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCurso.ItemHeight = 30;
            this.cmbCurso.Location = new System.Drawing.Point(44, 200);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(670, 36);
            this.cmbCurso.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(43, 249);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(134, 20);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Número del Tutor";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderRadius = 15;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(44, 272);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Ingrese el número...";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(670, 45);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(43, 327);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(137, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(40, 357);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Ingrese el correo...";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(670, 45);
            this.txtEmail.TabIndex = 8;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.Location = new System.Drawing.Point(50, 417);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(67, 20);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "Mensaje";
            // 
            // txtMensaje
            // 
            this.txtMensaje.BorderRadius = 15;
            this.txtMensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensaje.DefaultText = "";
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMensaje.Location = new System.Drawing.Point(47, 440);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.PlaceholderText = "Escriba el mensaje...";
            this.txtMensaje.SelectedText = "";
            this.txtMensaje.Size = new System.Drawing.Size(670, 80);
            this.txtMensaje.TabIndex = 10;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BorderRadius = 18;
            this.btnEnviar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnEnviar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(54, 565);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(190, 50);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 18;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnEliminar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(278, 565);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 50);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BorderRadius = 18;
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnLimpiar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(520, 565);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(190, 50);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelAyuda
            // 
            this.panelAyuda.BackColor = System.Drawing.Color.Transparent;
            this.panelAyuda.Controls.Add(this.linkLabel1);
            this.panelAyuda.Controls.Add(this.lblAyuda);
            this.panelAyuda.Controls.Add(this.lblAyudaTexto);
            this.panelAyuda.FillColor = System.Drawing.Color.White;
            this.panelAyuda.Location = new System.Drawing.Point(1045, 116);
            this.panelAyuda.Name = "panelAyuda";
            this.panelAyuda.Radius = 25;
            this.panelAyuda.ShadowColor = System.Drawing.Color.Silver;
            this.panelAyuda.ShadowDepth = 60;
            this.panelAyuda.Size = new System.Drawing.Size(255, 620);
            this.panelAyuda.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(99, 255);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Soporte técnico";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblAyuda.Location = new System.Drawing.Point(3, 46);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(248, 37);
            this.lblAyuda.TabIndex = 0;
            this.lblAyuda.Text = "¿Necesitas ayuda?";
            // 
            // lblAyudaTexto
            // 
            this.lblAyudaTexto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAyudaTexto.ForeColor = System.Drawing.Color.Gray;
            this.lblAyudaTexto.Location = new System.Drawing.Point(35, 120);
            this.lblAyudaTexto.Name = "lblAyudaTexto";
            this.lblAyudaTexto.Size = new System.Drawing.Size(250, 200);
            this.lblAyudaTexto.TabIndex = 1;
            this.lblAyudaTexto.Text = "Si tienes alguna consulta o sugerencia,\n\ncompleta el formulario y nos\n\npondremos " +
    "en contacto contigo.";
            // 
            // FormContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelAyuda);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Contacto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panelAyuda.ResumeLayout(false);
            this.panelAyuda.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            private PictureBox pictureBox1;
            private Label label1;
            private Label label2;
        private LinkLabel linkLabel1;
    }
    }