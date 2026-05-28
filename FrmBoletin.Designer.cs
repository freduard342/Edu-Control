namespace CapaPresentacion
{
    partial class FrmBoletin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurso = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.dgvBoletin = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.cboEstudiante = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(303, 157);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso:";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(346, 154);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 1;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            // 
            // dgvBoletin
            // 
            this.dgvBoletin.AllowUserToAddRows = false;
            this.dgvBoletin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoletin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletin.Location = new System.Drawing.Point(273, 222);
            this.dgvBoletin.Name = "dgvBoletin";
            this.dgvBoletin.ReadOnly = true;
            this.dgvBoletin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoletin.Size = new System.Drawing.Size(845, 452);
            this.dgvBoletin.TabIndex = 2;
            this.dgvBoletin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoletin_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1145, 222);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 50);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Generar Boletin";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(527, 162);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(57, 13);
            this.lblEstudiante.TabIndex = 4;
            this.lblEstudiante.Text = "Estudiante";
            // 
            // cboEstudiante
            // 
            this.cboEstudiante.FormattingEnabled = true;
            this.cboEstudiante.Location = new System.Drawing.Point(624, 154);
            this.cboEstudiante.Name = "cboEstudiante";
            this.cboEstudiante.Size = new System.Drawing.Size(121, 21);
            this.cboEstudiante.TabIndex = 5;
            // 
            // FrmBoletin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 712);
            this.Controls.Add(this.cboEstudiante);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvBoletin);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.lblCurso);
            this.Name = "FrmBoletin";
            this.Text = "FrmBoletin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBoletin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.DataGridView dgvBoletin;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.ComboBox cboEstudiante;
    }
}