
using System.Windows.Forms;
using System.Drawing;

namespace CapaPresentacion



{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panelMensajes = new System.Windows.Forms.Panel();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.lblNumMensajes = new System.Windows.Forms.Label();
            this.panelCursos = new System.Windows.Forms.Panel();
            this.lblCursos = new System.Windows.Forms.Label();
            this.lblNumCursos = new System.Windows.Forms.Label();
            this.panelEstudiantes = new System.Windows.Forms.Panel();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.lblNumEstudiantes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnContacto = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnMaestro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.LabelPanel = new System.Windows.Forms.Label();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panelMensajes.SuspendLayout();
            this.panelCursos.SuspendLayout();
            this.panelEstudiantes.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblAdmin);
            this.panelTop.Controls.Add(this.btnCerrarSesion);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(189, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(925, 52);
            this.panelTop.TabIndex = 1;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAdmin.Location = new System.Drawing.Point(729, 16);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(86, 21);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "alberto360";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(814, 13);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(86, 26);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContenido.Controls.Add(this.dgvDatos);
            this.panelContenido.Controls.Add(this.panelMensajes);
            this.panelContenido.Controls.Add(this.panelCursos);
            this.panelContenido.Controls.Add(this.panelEstudiantes);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(189, 52);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(925, 572);
            this.panelContenido.TabIndex = 0;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.Location = new System.Drawing.Point(26, 147);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(857, 390);
            this.dgvDatos.TabIndex = 0;
            // 
            // panelMensajes
            // 
            this.panelMensajes.BackColor = System.Drawing.Color.Gold;
            this.panelMensajes.Controls.Add(this.lblMensajes);
            this.panelMensajes.Controls.Add(this.lblNumMensajes);
            this.panelMensajes.Location = new System.Drawing.Point(523, 26);
            this.panelMensajes.Name = "panelMensajes";
            this.panelMensajes.Size = new System.Drawing.Size(214, 87);
            this.panelMensajes.TabIndex = 1;
            // 
            // lblMensajes
            // 
            this.lblMensajes.ForeColor = System.Drawing.Color.Black;
            this.lblMensajes.Location = new System.Drawing.Point(15, 56);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(86, 20);
            this.lblMensajes.TabIndex = 0;
            this.lblMensajes.Text = "Mensajes Recibidos";
            // 
            // lblNumMensajes
            // 
            this.lblNumMensajes.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumMensajes.ForeColor = System.Drawing.Color.Black;
            this.lblNumMensajes.Location = new System.Drawing.Point(13, 9);
            this.lblNumMensajes.Name = "lblNumMensajes";
            this.lblNumMensajes.Size = new System.Drawing.Size(86, 38);
            this.lblNumMensajes.TabIndex = 1;
            this.lblNumMensajes.Text = "8";
            // 
            // panelCursos
            // 
            this.panelCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.panelCursos.Controls.Add(this.lblCursos);
            this.panelCursos.Controls.Add(this.lblNumCursos);
            this.panelCursos.Location = new System.Drawing.Point(274, 26);
            this.panelCursos.Name = "panelCursos";
            this.panelCursos.Size = new System.Drawing.Size(214, 87);
            this.panelCursos.TabIndex = 2;
            // 
            // lblCursos
            // 
            this.lblCursos.ForeColor = System.Drawing.Color.White;
            this.lblCursos.Location = new System.Drawing.Point(15, 56);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(86, 20);
            this.lblCursos.TabIndex = 0;
            this.lblCursos.Text = "Cursos Ofrecidos";
            // 
            // lblNumCursos
            // 
            this.lblNumCursos.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumCursos.ForeColor = System.Drawing.Color.White;
            this.lblNumCursos.Location = new System.Drawing.Point(13, 9);
            this.lblNumCursos.Name = "lblNumCursos";
            this.lblNumCursos.Size = new System.Drawing.Size(86, 38);
            this.lblNumCursos.TabIndex = 1;
            this.lblNumCursos.Text = "14";
            // 
            // panelEstudiantes
            // 
            this.panelEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panelEstudiantes.Controls.Add(this.lblEstudiantes);
            this.panelEstudiantes.Controls.Add(this.lblNumEstudiantes);
            this.panelEstudiantes.Location = new System.Drawing.Point(26, 26);
            this.panelEstudiantes.Name = "panelEstudiantes";
            this.panelEstudiantes.Size = new System.Drawing.Size(214, 87);
            this.panelEstudiantes.TabIndex = 3;
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.ForeColor = System.Drawing.Color.White;
            this.lblEstudiantes.Location = new System.Drawing.Point(15, 56);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(86, 20);
            this.lblEstudiantes.TabIndex = 0;
            this.lblEstudiantes.Text = "Estudiantes Registrados";
            // 
            // lblNumEstudiantes
            // 
            this.lblNumEstudiantes.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumEstudiantes.ForeColor = System.Drawing.Color.White;
            this.lblNumEstudiantes.Location = new System.Drawing.Point(13, 9);
            this.lblNumEstudiantes.Name = "lblNumEstudiantes";
            this.lblNumEstudiantes.Size = new System.Drawing.Size(86, 38);
            this.lblNumEstudiantes.TabIndex = 1;
            this.lblNumEstudiantes.Text = "481";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(17, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(143, 30);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Panel Admin";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(64, 20);
            this.btnRegistrar.TabIndex = 5;
            // 
            // btnCursos
            // 
            this.btnCursos.Location = new System.Drawing.Point(0, 0);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(64, 20);
            this.btnCursos.TabIndex = 4;
            // 
            // btnContacto
            // 
            this.btnContacto.Location = new System.Drawing.Point(0, 0);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(64, 20);
            this.btnContacto.TabIndex = 3;
            // 
            // btnMaterias
            // 
            this.btnMaterias.Location = new System.Drawing.Point(0, 0);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(64, 20);
            this.btnMaterias.TabIndex = 2;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(64, 20);
            this.btnConfiguracion.TabIndex = 1;
            // 
            // btnMaestro
            // 
            this.btnMaestro.Location = new System.Drawing.Point(0, 0);
            this.btnMaestro.Name = "btnMaestro";
            this.btnMaestro.Size = new System.Drawing.Size(64, 20);
            this.btnMaestro.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnMaestro);
            this.panelMenu.Controls.Add(this.btnConfiguracion);
            this.panelMenu.Controls.Add(this.btnMaterias);
            this.panelMenu.Controls.Add(this.btnContacto);
            this.panelMenu.Controls.Add(this.btnCursos);
            this.panelMenu.Controls.Add(this.btnRegistrar);
            this.panelMenu.Controls.Add(this.lblTitulo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(189, 624);
            this.panelMenu.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.LabelPanel);
            this.panel1.Controls.Add(this.btnEstudiante);
            this.panel1.Controls.Add(this.btnCurso);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Location = new System.Drawing.Point(-51, -110);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 845);
            this.panel1.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(13, 653);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(267, 85);
            this.button5.TabIndex = 6;
            this.button5.Text = "⚙ Configuracion ";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // LabelPanel
            // 
            this.LabelPanel.AutoSize = true;
            this.LabelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelPanel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPanel.ForeColor = System.Drawing.Color.White;
            this.LabelPanel.Location = new System.Drawing.Point(14, 30);
            this.LabelPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(215, 52);
            this.LabelPanel.TabIndex = 1;
            this.LabelPanel.Text = "📖 Sistema de Gestion \r\nde Calificaciones\r\n";
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEstudiante.FlatAppearance.BorderSize = 0;
            this.btnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiante.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnEstudiante.Location = new System.Drawing.Point(29, 162);
            this.btnEstudiante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(230, 84);
            this.btnEstudiante.TabIndex = 1;
            this.btnEstudiante.Text = "📝 Registrar Estudiantes";
            this.btnEstudiante.UseVisualStyleBackColor = false;
            // 
            // btnCurso
            // 
            this.btnCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnCurso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCurso.FlatAppearance.BorderSize = 0;
            this.btnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurso.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurso.ForeColor = System.Drawing.Color.White;
            this.btnCurso.Location = new System.Drawing.Point(-7, 262);
            this.btnCurso.Margin = new System.Windows.Forms.Padding(20, 20, 20, 30);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(309, 90);
            this.btnCurso.TabIndex = 2;
            this.btnCurso.Text = "📚 Listado Curso";
            this.btnCurso.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(4, 355);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(276, 109);
            this.button6.TabIndex = 3;
            this.button6.Text = "👨‍🏫 Maestro";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(-7, 556);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(298, 100);
            this.button7.TabIndex = 4;
            this.button7.Text = "📞 Contacto";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(-12, 464);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(298, 102);
            this.button8.TabIndex = 5;
            this.button8.Text = "📖 Materias";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 624);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panelMensajes.ResumeLayout(false);
            this.panelCursos.ResumeLayout(false);
            this.panelEstudiantes.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblAdmin;

        private System.Windows.Forms.Button btnCerrarSesion;

        private System.Windows.Forms.Panel panelEstudiantes;
        private System.Windows.Forms.Panel panelCursos;
        private System.Windows.Forms.Panel panelMensajes;

        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Label lblMensajes;

        private System.Windows.Forms.Label lblNumEstudiantes;
        private System.Windows.Forms.Label lblNumCursos;
        private System.Windows.Forms.Label lblNumMensajes;

        private System.Windows.Forms.DataGridView dgvDatos;
        private Label lblTitulo;
        private Button btnRegistrar;
        private Button btnCursos;
        private Button btnContacto;
        private Button btnMaterias;
        private Button btnConfiguracion;
        private Button btnMaestro;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panelMenu;
        private Panel panel1;
        private Button button5;
        private Label LabelPanel;
        private Button btnCurso;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnEstudiante;
    }
}