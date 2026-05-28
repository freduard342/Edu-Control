
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private Guna.UI2.WinForms.Guna2ShadowPanel panelLogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox imgLogo;
        private System.Windows.Forms.Label lblLogin;

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRol;

        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;

        private Guna.UI2.WinForms.Guna2ComboBox cmbRol;

        private Guna.UI2.WinForms.Guna2GradientButton btnIngresar;

        private System.Windows.Forms.Label lblOlvido;
        private System.Windows.Forms.LinkLabel linkRecuperar;

        private void InitializeComponent()
        {
            this.panelLogin = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMostrarPassword = new System.Windows.Forms.Button();
            this.imgLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnIngresar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblOlvido = new System.Windows.Forms.Label();
            this.linkRecuperar = new System.Windows.Forms.LinkLabel();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.btnMostrarPassword);
            this.panelLogin.Controls.Add(this.imgLogo);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.lblUsuario);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.lblRol);
            this.panelLogin.Controls.Add(this.cmbRol);
            this.panelLogin.Controls.Add(this.btnIngresar);
            this.panelLogin.Controls.Add(this.lblOlvido);
            this.panelLogin.Controls.Add(this.linkRecuperar);
            this.panelLogin.FillColor = System.Drawing.Color.White;
            this.panelLogin.Location = new System.Drawing.Point(727, 25);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Radius = 35;
            this.panelLogin.ShadowColor = System.Drawing.Color.Silver;
            this.panelLogin.ShadowDepth = 80;
            this.panelLogin.Size = new System.Drawing.Size(560, 765);
            this.panelLogin.TabIndex = 1;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.login_imagen;
            this.pictureBox2.Location = new System.Drawing.Point(105, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.icons8_contraseña;
            this.pictureBox1.Location = new System.Drawing.Point(120, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            //    
            // btnMostrarPassword
            // 
            this.btnMostrarPassword.Image = global::CapaPresentacion.Properties.Resources.icons8_visible_24;
            this.btnMostrarPassword.Location = new System.Drawing.Point(447, 378);
            this.btnMostrarPassword.Name = "btnMostrarPassword";
            this.btnMostrarPassword.Size = new System.Drawing.Size(45, 25);
            this.btnMostrarPassword.TabIndex = 11;
            this.btnMostrarPassword.UseVisualStyleBackColor = true;
            this.btnMostrarPassword.Click += new System.EventHandler(this.btnMostrarPassword_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::CapaPresentacion.Properties.Resources.imagen_sin_fondo;
            this.imgLogo.ImageRotate = 0F;
            this.imgLogo.Location = new System.Drawing.Point(195, 15);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(160, 160);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.lblLogin.Location = new System.Drawing.Point(130, 180);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(249, 41);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "👤 Iniciar Sesión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(55, 253);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 23);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderRadius = 15;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario.Location = new System.Drawing.Point(55, 281);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ingresa tu usuario";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(450, 45);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(51, 341);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(55, 369);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Ingresa tu contraseña";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(450, 45);
            this.txtPassword.TabIndex = 5;
            // 
            // lblRol
            // 
            this.lblRol.Location = new System.Drawing.Point(55, 440);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(100, 23);
            this.lblRol.TabIndex = 6;
            this.lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Transparent;
            this.cmbRol.BorderRadius = 15;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRol.ItemHeight = 30;
            this.cmbRol.Location = new System.Drawing.Point(55, 466);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(450, 36);
            this.cmbRol.TabIndex = 7;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BorderRadius = 20;
            this.btnIngresar.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnIngresar.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(55, 536);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(450, 55);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // lblOlvido
            // 
            this.lblOlvido.AutoSize = true;
            this.lblOlvido.Location = new System.Drawing.Point(181, 618);
            this.lblOlvido.Name = "lblOlvido";
            this.lblOlvido.Size = new System.Drawing.Size(131, 13);
            this.lblOlvido.TabIndex = 9;
            this.lblOlvido.Text = "¿Olvidaste tu contraseña?";
            // 
            // linkRecuperar
            // 
            this.linkRecuperar.AutoSize = true;
            this.linkRecuperar.Location = new System.Drawing.Point(191, 649);
            this.linkRecuperar.Name = "linkRecuperar";
            this.linkRecuperar.Size = new System.Drawing.Size(113, 13);
            this.linkRecuperar.TabIndex = 10;
            this.linkRecuperar.TabStop = true;
            this.linkRecuperar.Text = "Recuperar contraseña";
            this.linkRecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRecuperar_LinkClicked);
            // 
            // FormLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondologin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogin_Load_1);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Button btnMostrarPassword;
    }
}