using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmBoletin : Form
    {
        private readonly BoletinBll _bll = new BoletinBll();

        private int _idCurso;
        private int _idEstudiante;

        public FrmBoletin()
        {
            InitializeComponent();
        }

        private void FrmBoletin_Load(object sender, EventArgs e)
        {
            CargarCursos();
        }

        // =========================
        // CARGAR CURSOS
        // =========================
        private void CargarCursos()
        {
            cboCurso.DataSource = _bll.CargarCursos();
            cboCurso.DisplayMember = "Nombre_Curso";
            cboCurso.ValueMember = "Id_Curso";
            cboCurso.SelectedIndex = -1;
        }

        // =========================
        // CAMBIO DE CURSO
        // =========================
        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurso.SelectedValue == null)
                return;

            if (cboCurso.SelectedValue is DataRowView)
                return;

            _idCurso = Convert.ToInt32(cboCurso.SelectedValue);

            dgvBoletin.DataSource =
                _bll.CargarEstudiantePorCurso(_idCurso);
        }

        // =========================
        // SELECCIONAR ESTUDIANTE
        // =========================
        private void dgvBoletin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _idEstudiante =
                Convert.ToInt32(
                    dgvBoletin.Rows[e.RowIndex]
                    .Cells["Id_Estudiante"].Value
                );
        }

        // =========================
        // GENERAR BOLETÍN
        // =========================
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (_idCurso == 0 || _idEstudiante == 0)
            {
                MessageBox.Show("Seleccione curso y estudiante.");
                return;
            }

            FrmReporteBoletin frm =
                new FrmReporteBoletin(_idCurso, _idEstudiante);

            frm.ShowDialog();
        }
    }
}
