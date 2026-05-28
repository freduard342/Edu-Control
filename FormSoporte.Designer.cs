namespace CapaPresentacion // <-- Recuerda cambiar esto por el nombre exacto de tu proyecto
{
    partial class FormSoporte
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

        private void InitializeComponent()
        {
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnPreguntarIA = new System.Windows.Forms.Button();
            this.lblRespuestaIA = new System.Windows.Forms.Label();
            this.txtRespuestaIA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAsunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAsunto.Location = new System.Drawing.Point(25, 20);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(131, 19);
            this.lblAsunto.TabIndex = 0;
            this.lblAsunto.Text = "Asunto del Reporte";
            // 
            // txtAsunto
            // 
            this.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsunto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAsunto.Location = new System.Drawing.Point(25, 45);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(430, 27);
            this.txtAsunto.TabIndex = 1;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMensaje.Location = new System.Drawing.Point(25, 90);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(199, 19);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Describe tu problema o duda";
            // 
            // txtMensaje
            // 
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMensaje.Location = new System.Drawing.Point(25, 115);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensaje.Size = new System.Drawing.Size(430, 120);
            this.txtMensaje.TabIndex = 3;
            // 
            // btnPreguntarIA
            // 
            this.btnPreguntarIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173))))); // Color Morado IA
            this.btnPreguntarIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreguntarIA.FlatAppearance.BorderSize = 0;
            this.btnPreguntarIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreguntarIA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPreguntarIA.ForeColor = System.Drawing.Color.White;
            this.btnPreguntarIA.Location = new System.Drawing.Point(25, 250);
            this.btnPreguntarIA.Name = "btnPreguntarIA";
            this.btnPreguntarIA.Size = new System.Drawing.Size(200, 38);
            this.btnPreguntarIA.TabIndex = 4;
            this.btnPreguntarIA.Text = "✨ Preguntar a la IA";
            this.btnPreguntarIA.UseVisualStyleBackColor = false;
            this.btnPreguntarIA.Click += new System.EventHandler(this.btnPreguntarIA_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))); // Azul Correo
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(255, 250);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(200, 38);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "✉️ Enviar por Correo";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblRespuestaIA
            // 
            this.lblRespuestaIA.AutoSize = true;
            this.lblRespuestaIA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRespuestaIA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.lblRespuestaIA.Location = new System.Drawing.Point(25, 310);
            this.lblRespuestaIA.Name = "lblRespuestaIA";
            this.lblRespuestaIA.Size = new System.Drawing.Size(161, 19);
            this.lblRespuestaIA.TabIndex = 6;
            this.lblRespuestaIA.Text = "Respuesta del Asistente";
            // 
            // txtRespuestaIA
            // 
            this.txtRespuestaIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtRespuestaIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRespuestaIA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtRespuestaIA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtRespuestaIA.Location = new System.Drawing.Point(25, 335);
            this.txtRespuestaIA.Multiline = true;
            this.txtRespuestaIA.Name = "txtRespuestaIA";
            this.txtRespuestaIA.ReadOnly = true;
            this.txtRespuestaIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuestaIA.Size = new System.Drawing.Size(430, 130);
            this.txtRespuestaIA.TabIndex = 7;
            this.txtRespuestaIA.Text = "Aquí aparecerá la respuesta automática de la IA...";
            // 
            // FormSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 491);
            this.Controls.Add(this.txtRespuestaIA);
            this.Controls.Add(this.lblRespuestaIA);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnPreguntarIA);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.lblAsunto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSoporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soporte Técnico con IA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnPreguntarIA;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblRespuestaIA;
        private System.Windows.Forms.TextBox txtRespuestaIA;
    }
}