using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public class FormHorario : Form
    {
        private Button btnVolver;
        private Label lblTitulo;
        private DataGridView dgvHorario;
        private Label lblFooter;

        public FormHorario()
        {
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            // FORMULARIO
            this.Text = "Horario - 1° de Primaria";
            this.Size = new Size(1500, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Gainsboro;

            // BOTÓN VOLVER
            btnVolver = new Button();
            btnVolver.Text = "← Volver al menú principal";
            btnVolver.Size = new Size(260, 45);
            btnVolver.Location = new Point(100, 60);
            btnVolver.BackColor = Color.RoyalBlue;
            btnVolver.ForeColor = Color.White;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.Font = new Font("Segoe UI", 11);

            // TÍTULO
            lblTitulo = new Label();
            lblTitulo.Text = "Horario - 1° de Primaria";
            lblTitulo.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(520, 140);

            // TABLA
            dgvHorario = new DataGridView();
            dgvHorario.Location = new Point(20, 240);
            dgvHorario.Size = new Size(1320, 320);

            dgvHorario.ColumnCount = 6;

            dgvHorario.Columns[0].Name = "Hora";
            dgvHorario.Columns[1].Name = "Lunes";
            dgvHorario.Columns[2].Name = "Martes";
            dgvHorario.Columns[3].Name = "Miércoles";
            dgvHorario.Columns[4].Name = "Jueves";
            dgvHorario.Columns[5].Name = "Viernes";

            dgvHorario.Rows.Add("8:00 - 8:45", "Matemáticas", "Lengua", "Arte", "Ciencias", "Educación Física");
            dgvHorario.Rows.Add("8:45 - 9:30", "Lengua", "Matemáticas", "Música", "Inglés", "Religión");
            dgvHorario.Rows.Add("", "", "RECREO", "", "", "");
            dgvHorario.Rows.Add("9:45 - 10:30", "Ciencias", "Educación Física", "Lengua", "Matemáticas", "Computación");
            dgvHorario.Rows.Add("10:30 - 11:15", "Inglés", "Ciencias", "Matemáticas", "Arte", "Música");

            // ESTILO
            dgvHorario.EnableHeadersVisualStyles = false;

            dgvHorario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            dgvHorario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHorario.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            dgvHorario.ColumnHeadersHeight = 55;

            dgvHorario.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorario.DefaultCellStyle.Font = new Font("Segoe UI", 11);

            dgvHorario.RowTemplate.Height = 55;

            dgvHorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHorario.AllowUserToAddRows = false;
            dgvHorario.RowHeadersVisible = false;
            dgvHorario.ReadOnly = true;

            // FILA RECREO
            dgvHorario.Rows[2].DefaultCellStyle.BackColor = Color.LightBlue;
            dgvHorario.Rows[2].DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // FOOTER
            lblFooter = new Label();
            lblFooter.Text = "© 2025 Centro Educacional Bautista";
            lblFooter.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(520, 580);

            // AGREGAR CONTROLES
            this.Controls.Add(btnVolver);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(dgvHorario);
            this.Controls.Add(lblFooter);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormHorario
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "FormHorario";
            this.Load += new System.EventHandler(this.FormHorario_Load);
            this.ResumeLayout(false);

        }

        private void FormHorario_Load(object sender, EventArgs e)
        {

        }
    }
}