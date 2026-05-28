using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CapaPresentacion
{
    partial class FormMaterias
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
        private Guna2ShadowPanel panelMaterias;
        private Guna2ShadowPanel panelAyuda;
        private Guna2PictureBox imgUser;

        private Label lblSistema;
        private Label lblInstitucion;
        private Label lblRol;
        private Label lblUsuario;
        private Label lblFecha;

        private Guna2Button btnRegistrar;
        private Guna2Button btnCursos;
        private Guna2Button btnMaestro;
        private Guna2Button btnMaterias;
        private Guna2Button btnContacto;
        private Guna2Button btnConfiguracion;
        private Guna2Button btnCerrarSesion;

        private Label lblTitulo;
        private Label lblSubtitulo;

        private Guna2GradientButton btnNuevaMateria;
        private Guna2TextBox txtBuscar;

        private Guna2DataGridView dgvMaterias;

        private Label lblAyuda;
        private Label lblAyudaTexto;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelMaterias = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnNuevaMateria = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvMaterias = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelAyuda = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblAyudaTexto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgUser = new Guna.UI2.WinForms.Guna2PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.panelAyuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
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
            this.panelSidebar.Size = new System.Drawing.Size(338, 1106);
            this.panelSidebar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(84, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sistema de Calificaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(69, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 163);
            this.label1.TabIndex = 9;
            this.label1.Text = "🎓";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(52, 200);
            this.lblSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(249, 54);
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
            this.btnRegistrar.Location = new System.Drawing.Point(0, 358);
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
            this.btnCursos.Location = new System.Drawing.Point(-28, 428);
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
            this.btnMaestro.Location = new System.Drawing.Point(-56, 492);
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
            this.btnMaterias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnMaterias.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.ForeColor = System.Drawing.Color.White;
            this.btnMaterias.Location = new System.Drawing.Point(-56, 565);
            this.btnMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(330, 77);
            this.btnMaterias.TabIndex = 5;
            this.btnMaterias.Text = "📖 Materias";
            // 
            // btnContacto
            // 
            this.btnContacto.BorderRadius = 12;
            this.btnContacto.FillColor = System.Drawing.Color.Transparent;
            this.btnContacto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacto.ForeColor = System.Drawing.Color.White;
            this.btnContacto.Location = new System.Drawing.Point(-45, 651);
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
            this.btnConfiguracion.Location = new System.Drawing.Point(-28, 726);
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
            this.panelTop.Location = new System.Drawing.Point(338, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1608, 169);
            this.panelTop.TabIndex = 2;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInstitucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblInstitucion.Location = new System.Drawing.Point(124, 31);
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
            this.lblRol.Location = new System.Drawing.Point(128, 78);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(125, 30);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol: Admin";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(1096, 49);
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(1383, 40);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(225, 69);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(1218, 111);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 28);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // panelMaterias
            // 
            this.panelMaterias.BackColor = System.Drawing.Color.Transparent;
            this.panelMaterias.Controls.Add(this.lblTitulo);
            this.panelMaterias.Controls.Add(this.lblSubtitulo);
            this.panelMaterias.Controls.Add(this.btnNuevaMateria);
            this.panelMaterias.Controls.Add(this.txtBuscar);
            this.panelMaterias.Controls.Add(this.dgvMaterias);
            this.panelMaterias.FillColor = System.Drawing.Color.White;
            this.panelMaterias.Location = new System.Drawing.Point(405, 200);
            this.panelMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMaterias.Name = "panelMaterias";
            this.panelMaterias.Radius = 25;
            this.panelMaterias.ShadowColor = System.Drawing.Color.Silver;
            this.panelMaterias.ShadowDepth = 60;
            this.panelMaterias.Size = new System.Drawing.Size(1180, 905);
            this.panelMaterias.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTitulo.Location = new System.Drawing.Point(52, 46);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(439, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Materias";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(60, 123);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(402, 28);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Administra las materias del centro educativo.";
            // 
            // btnNuevaMateria
            // 
            this.btnNuevaMateria.BorderRadius = 15;
            this.btnNuevaMateria.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNuevaMateria.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnNuevaMateria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevaMateria.ForeColor = System.Drawing.Color.White;
            this.btnNuevaMateria.Location = new System.Drawing.Point(63, 185);
            this.btnNuevaMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevaMateria.Name = "btnNuevaMateria";
            this.btnNuevaMateria.Size = new System.Drawing.Size(300, 69);
            this.btnNuevaMateria.TabIndex = 2;
            this.btnNuevaMateria.Text = "+ Nueva Materia";
            this.btnNuevaMateria.Click += new System.EventHandler(this.button11_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderRadius = 15;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(735, 175);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Buscar materia...";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(360, 78);
            this.txtBuscar.TabIndex = 3;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvMaterias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgvMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMaterias.ColumnHeadersHeight = 45;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterias.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMaterias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvMaterias.Location = new System.Drawing.Point(63, 292);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.RowHeadersVisible = false;
            this.dgvMaterias.RowHeadersWidth = 62;
            this.dgvMaterias.RowTemplate.Height = 40;
            this.dgvMaterias.Size = new System.Drawing.Size(1058, 569);
            this.dgvMaterias.TabIndex = 4;
            this.dgvMaterias.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMaterias.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMaterias.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMaterias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMaterias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMaterias.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMaterias.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvMaterias.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMaterias.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMaterias.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMaterias.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMaterias.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaterias.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvMaterias.ThemeStyle.ReadOnly = false;
            this.dgvMaterias.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMaterias.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMaterias.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMaterias.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMaterias.ThemeStyle.RowsStyle.Height = 40;
            this.dgvMaterias.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMaterias.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelAyuda
            // 
            this.panelAyuda.BackColor = System.Drawing.Color.Transparent;
            this.panelAyuda.Controls.Add(this.linkLabel1);
            this.panelAyuda.Controls.Add(this.lblAyuda);
            this.panelAyuda.Controls.Add(this.lblAyudaTexto);
            this.panelAyuda.FillColor = System.Drawing.Color.White;
            this.panelAyuda.Location = new System.Drawing.Point(1594, 195);
            this.panelAyuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAyuda.Name = "panelAyuda";
            this.panelAyuda.Radius = 25;
            this.panelAyuda.ShadowColor = System.Drawing.Color.Silver;
            this.panelAyuda.ShadowDepth = 60;
            this.panelAyuda.Size = new System.Drawing.Size(351, 909);
            this.panelAyuda.TabIndex = 1;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblAyuda.Location = new System.Drawing.Point(8, 51);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(321, 48);
            this.lblAyuda.TabIndex = 0;
            this.lblAyuda.Text = "¿Necesitas ayuda?";
            // 
            // lblAyudaTexto
            // 
            this.lblAyudaTexto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAyudaTexto.ForeColor = System.Drawing.Color.Gray;
            this.lblAyudaTexto.Location = new System.Drawing.Point(38, 185);
            this.lblAyudaTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAyudaTexto.Name = "lblAyudaTexto";
            this.lblAyudaTexto.Size = new System.Drawing.Size(300, 385);
            this.lblAyudaTexto.TabIndex = 1;
            this.lblAyudaTexto.Text = "Aquí podrás gestionar las materias del sistema.\n\nAgrega, edita o elimina materias" +
    " fácilmente.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imagen_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // imgUser
            // 
            this.imgUser.Image = global::CapaPresentacion.Properties.Resources.login_imagen;
            this.imgUser.ImageRotate = 0F;
            this.imgUser.Location = new System.Drawing.Point(1015, 24);
            this.imgUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(82, 85);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 2;
            this.imgUser.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(92, 392);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Soporte Tecnico";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panelMaterias);
            this.Controls.Add(this.panelAyuda);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Materias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMaterias_Load_1);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMaterias.ResumeLayout(false);
            this.panelMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.panelAyuda.ResumeLayout(false);
            this.panelAyuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}