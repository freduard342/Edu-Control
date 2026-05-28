using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteBoletin : Form
    {
        private readonly BoletinBll _bll = new BoletinBll();

        private int _idCurso;
        private int _idEstudiante;

        public FrmReporteBoletin(int idCurso, int idEstudiante)
        {
            InitializeComponent();

            _idCurso = idCurso;
            _idEstudiante = idEstudiante;
        }

        private void FrmReporteBoletin_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource();

            rds.Name = "DataSetBoletin";

            rds.Value = _bll.BoletinEstudiante(
                _idCurso,
                _idEstudiante
            );

            ReportParameter[] parameters = new ReportParameter[1];

            parameters[0] = new ReportParameter(
                "AnioEscolar",
                "2025-2026"
            );

            reportViewer1.LocalReport.SetParameters(parameters);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            // 🔥 IMPORTANTE: nombre EXACTO del RDLC
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "CapaPresentacion.Reportes.rtpBoletin.rdlc";

            reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource();


        }
    }
}