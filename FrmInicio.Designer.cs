using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class FrmInicio
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelIzquierdo;
        private Panel panelDerecho;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxDecoracion;
        private Label lblBienvenidos;
        private Label lblSistema;
        private Label lblEduControl;
        private Label lblDescripcion;
        private Button btnInicio;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblEduControl = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.pictureBoxDecoracion = new System.Windows.Forms.PictureBox();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecoracion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.White;
            this.panelIzquierdo.Controls.Add(this.lblDescripcion);
            this.panelIzquierdo.Controls.Add(this.btnInicio);
            this.panelIzquierdo.Controls.Add(this.lblEduControl);
            this.panelIzquierdo.Controls.Add(this.lblSistema);
            this.panelIzquierdo.Controls.Add(this.lblBienvenidos);
            this.panelIzquierdo.Controls.Add(this.pictureBoxLogo);
            this.panelIzquierdo.Location = new System.Drawing.Point(364, 225);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(540, 550);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescripcion.Location = new System.Drawing.Point(39, 350);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(450, 80);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Una plataforma diseñada para gestionar y administrar las calificaciones de manera" +
    " eficiente, segura y sencilla.";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(135, 460);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(270, 60);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // lblEduControl
            // 
            this.lblEduControl.AutoSize = true;
            this.lblEduControl.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblEduControl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEduControl.Location = new System.Drawing.Point(79, 260);
            this.lblEduControl.Name = "lblEduControl";
            this.lblEduControl.Size = new System.Drawing.Size(351, 81);
            this.lblEduControl.TabIndex = 2;
            this.lblEduControl.Text = "EduControl";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSistema.Location = new System.Drawing.Point(39, 210);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(431, 36);
            this.lblSistema.TabIndex = 3;
            this.lblSistema.Text = "Sistema de Gestión de Calificaciones";
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBienvenidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.lblBienvenidos.Location = new System.Drawing.Point(84, 145);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(342, 65);
            this.lblBienvenidos.TabIndex = 4;
            this.lblBienvenidos.Text = "Bienvenidos a";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.logo1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(191, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(146, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panelDerecho.Controls.Add(this.pictureBoxDecoracion);
            this.panelDerecho.Location = new System.Drawing.Point(910, 225);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(562, 550);
            this.panelDerecho.TabIndex = 0;
            // 
            // pictureBoxDecoracion
            // 
            this.pictureBoxDecoracion.Image = global::CapaPresentacion.Properties.Resources.dashboard;
            this.pictureBoxDecoracion.Location = new System.Drawing.Point(34, 100);
            this.pictureBoxDecoracion.Name = "pictureBoxDecoracion";
            this.pictureBoxDecoracion.Size = new System.Drawing.Size(484, 350);
            this.pictureBoxDecoracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDecoracion.TabIndex = 0;
            this.pictureBoxDecoracion.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1569, 849);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EduControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelIzquierdo.ResumeLayout(false);
            this.panelIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecoracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}