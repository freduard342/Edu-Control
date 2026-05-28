using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMaestro : Form
    {
        // --- DECLARACIÓN DE CONTROLES (DISEÑO) ---
        private Panel panelHeader;
        private Label lblCentroEducativo;
        private Label lblUsuario;
        private Label lblFechaHora;
        private Button btnCerrarSesion;

        private Label lblTituloPanel;
        private Panel panelAviso;
        private Label lblTextoAviso;

        private Label lblTab2doA;
        private Label lblTab2doB;
        private Label lblTab5to;

        private DataGridView dgvNotas;
        private Button btnGuardarCambios;
        private Label lblFooter;

        public FormMaestro()
        {
            // En lugar de usar InitializeComponent del diseñador, 
            // construimos toda la interfaz pura por código aquí:
            ConstruirDisenoPorCodigo();

            // Aplicamos los estilos avanzados y cargamos los datos
            ConfigurarTablaNotas();
            CargarDatosTabla();
        }

        private void ConstruirDisenoPorCodigo()
        {
            // 1. Configuración del Formulario Principal
            this.Text = "Centro Educacional Bautista - Panel de Calificaciones";
            this.Size = new Size(1050, 720);
            this.BackColor = Color.FromArgb(248, 249, 250); // Gris muy claro de fondo
            this.StartPosition = FormStartPosition.CenterScreen;

            // 2. Panel Superior (Header)
            panelHeader = new Panel();
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 70;
            panelHeader.BackColor = Color.White;

            lblCentroEducativo = new Label();
            lblCentroEducativo.Text = "Centro Educacional Bautista";
            lblCentroEducativo.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            lblCentroEducativo.ForeColor = Color.Gray;
            lblCentroEducativo.Location = new Point(30, 23);
            lblCentroEducativo.AutoSize = true;

            lblUsuario = new Label();
            lblUsuario.Text = "profemaria";
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(33, 37, 41);
            lblUsuario.Location = new Point(730, 15);
            lblUsuario.AutoSize = true;

            lblFechaHora = new Label();
            lblFechaHora.Text = "26/05/2025 10:30 AM";
            lblFechaHora.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblFechaHora.ForeColor = Color.Gray;
            lblFechaHora.Location = new Point(700, 38);
            lblFechaHora.AutoSize = true;

            btnCerrarSesion = new Button();
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.Font = new Font("Segoe UI", 9F);
            btnCerrarSesion.ForeColor = Color.FromArgb(220, 53, 69);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69);
            btnCerrarSesion.Size = new Size(110, 32);
            btnCerrarSesion.Location = new Point(880, 18);
            btnCerrarSesion.Cursor = Cursors.Hand;

            panelHeader.Controls.AddRange(new Control[] { lblCentroEducativo, lblUsuario, lblFechaHora, btnCerrarSesion });

            // 3. Título del Panel
            lblTituloPanel = new Label();
            lblTituloPanel.Text = "Panel del Maestro - Lengua Española";
            lblTituloPanel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloPanel.ForeColor = Color.FromArgb(25, 135, 84); // Verde oscuro elegante
            lblTituloPanel.Location = new Point(50, 100);
            lblTituloPanel.AutoSize = true;

            // 4. Banner de Aviso Azul Informativo
            panelAviso = new Panel();
            panelAviso.Location = new Point(50, 150);
            panelAviso.Size = new Size(940, 48);
            panelAviso.BackColor = Color.FromArgb(225, 245, 254); // Azul claro

            lblTextoAviso = new Label();
            lblTextoAviso.Text = "Solo puedes modificar las notas de la asignatura Lengua Española.";
            lblTextoAviso.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblTextoAviso.ForeColor = Color.FromArgb(30, 70, 90);
            lblTextoAviso.Location = new Point(15, 14);
            lblTextoAviso.AutoSize = true;
            panelAviso.Controls.Add(lblTextoAviso);

            // Redondear esquinas del panel de aviso automáticamente
            panelAviso.Paint += (s, e) => RedondearControl(panelAviso, e.Graphics, Color.FromArgb(225, 245, 254), 8);

            // 5. Pestañas de Cursos (Tabs simulados)
            lblTab2doA = new Label();
            lblTab2doA.Text = "2do A";
            lblTab2doA.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTab2doA.ForeColor = Color.FromArgb(25, 135, 84);
            lblTab2doA.BackColor = Color.White;
            lblTab2doA.BorderStyle = BorderStyle.FixedSingle;
            lblTab2doA.Location = new Point(50, 220);
            lblTab2doA.Size = new Size(65, 28);
            lblTab2doA.TextAlign = ContentAlignment.MiddleCenter;

            lblTab2doB = new Label();
            lblTab2doB.Text = "2do B";
            lblTab2doB.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblTab2doB.ForeColor = Color.RoyalBlue;
            lblTab2doB.Location = new Point(125, 220);
            lblTab2doB.Size = new Size(50, 28);
            lblTab2doB.TextAlign = ContentAlignment.MiddleCenter;
            lblTab2doB.Cursor = Cursors.Hand;

            lblTab5to = new Label();
            lblTab5to.Text = "5to";
            lblTab5to.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblTab5to.ForeColor = Color.RoyalBlue;
            lblTab5to.Location = new Point(185, 220);
            lblTab5to.Size = new Size(40, 28);
            lblTab5to.TextAlign = ContentAlignment.MiddleCenter;
            lblTab5to.Cursor = Cursors.Hand;

            // 6. DataGridView (La Tabla de Calificaciones)
            dgvNotas = new DataGridView();
            dgvNotas.Location = new Point(50, 255);
            dgvNotas.Size = new Size(940, 310);
            dgvNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // 7. Botón Guardar Cambios
            btnGuardarCambios = new Button();
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarCambios.BackColor = Color.FromArgb(40, 167, 69); // Verde Bootstrap
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.FlatAppearance.BorderSize = 0;
            btnGuardarCambios.Size = new Size(160, 42);
            btnGuardarCambios.Location = new Point(830, 585);
            btnGuardarCambios.Cursor = Cursors.Hand;
            btnGuardarCambios.Click += btnGuardarCambios_Click;

            // Redondear esquinas del botón guardar
            btnGuardarCambios.Paint += (s, e) => {
                GraphicsPath path = ObtenerRutaRedondeada(btnGuardarCambios.ClientRectangle, 8);
                btnGuardarCambios.Region = new Region(path);
            };

            // 8. Footer Informativo
            lblFooter = new Label();
            lblFooter.Text = "© 2025 Centro Educacional Bautista. centro educacional bautista.";
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.Location = new Point(350, 645);
            lblFooter.AutoSize = true;
            lblFooter.Anchor = AnchorStyles.Bottom;

            // Agregar absolutamente todo al diseño de la pantalla
            this.Controls.AddRange(new Control[] {
                panelHeader, lblTituloPanel, panelAviso,
                lblTab2doA, lblTab2doB, lblTab5to,
                dgvNotas, btnGuardarCambios, lblFooter
            });
        }

        private void ConfigurarTablaNotas()
        {
            // Estilos generales para que se vea moderna y limpia
            dgvNotas.BackgroundColor = Color.White;
            dgvNotas.BorderStyle = BorderStyle.None;
            dgvNotas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNotas.GridColor = Color.FromArgb(230, 235, 240);
            dgvNotas.RowHeadersVisible = false;
            dgvNotas.AllowUserToAddRows = false;
            dgvNotas.SelectionMode = DataGridViewSelectionMode.CellSelect;

            // Diseño del Encabezado (Verde pálido)
            dgvNotas.EnableHeadersVisualStyles = false;
            dgvNotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNotas.ColumnHeadersHeight = 42;
            dgvNotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(222, 239, 227);
            dgvNotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(40, 50, 45);
            dgvNotas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            // Agregar Columnas
            dgvNotas.Columns.Add("Num", "#");
            dgvNotas.Columns.Add("Nombre", "Nombre");
            dgvNotas.Columns.Add("Lengua", "Lengua Española (editable)");
            dgvNotas.Columns.Add("Matematica", "Matemática");
            dgvNotas.Columns.Add("Sociales", "Sociales");
            dgvNotas.Columns.Add("Ingles", "Inglés");

            // Configurar Anchos de Columnas
            dgvNotas.Columns["Num"].Width = 40;
            dgvNotas.Columns["Nombre"].Width = 240;
            dgvNotas.Columns["Lengua"].Width = 180;
            dgvNotas.Columns["Matematica"].Width = 115;
            dgvNotas.Columns["Sociales"].Width = 115;
            dgvNotas.Columns["Ingles"].Width = 115;

            // REGLA: Bloquear celdas y alternar fondos para emular inputs deshabilitados
            foreach (DataGridViewColumn col in dgvNotas.Columns)
            {
                if (col.Name == "Lengua")
                {
                    col.ReadOnly = false; // Solo esta se puede editar
                    col.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    col.ReadOnly = true;  // Las demás bloqueadas
                    col.DefaultCellStyle.BackColor = Color.FromArgb(241, 243, 245); // Gris suave
                }

                if (col.Name != "Nombre" && col.Name != "Num")
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            dgvNotas.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvNotas.RowTemplate.Height = 45; // Altura para que queden amplias las celdas
        }

        private void CargarDatosTabla()
        {
            // Insertamos exactamente las filas que tienes en la captura de pantalla
            dgvNotas.Rows.Add("1", "Andrea González", "88", "92", "85", "90");
            dgvNotas.Rows.Add("2", "Freduard Rojas Ozuna", "100", "97", "98", "100");
            dgvNotas.Rows.Add("3", "Leurianny Sala Sosa", "99", "96", "99", "100");
            dgvNotas.Rows.Add("4", "Mario Ramírez", "76", "80", "78", "77");
            dgvNotas.Rows.Add("5", "Luciana Vega", "91", "95", "88", "92");
        }

        // Métodos auxiliares para dibujar bordes redondeados limpios
        private void RedondearControl(Control c, Graphics g, Color color, int radio)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = ObtenerRutaRedondeada(c.ClientRectangle, radio))
            {
                using (SolidBrush brush = new SolidBrush(color))
                {
                    g.FillPath(brush, path);
                }
            }
        }

        private GraphicsPath ObtenerRutaRedondeada(Rectangle rect, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
            path.AddArc(rect.Width - radio, rect.Y, radio, radio, 270, 90);
            path.AddArc(rect.Width - radio, rect.Height - radio, radio, radio, 0, 90);
            path.AddArc(rect.X, rect.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Las calificaciones de Lengua Española han sido guardadas con éxito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void formsMaestro_Load(object sender, EventArgs e)
        {

        }
    }
}