using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Listado_Estudiantes : Form
    {
       private EstudianteBll bll = new EstudianteBll();
        public Listado_Estudiantes()
        {
            InitializeComponent();
        }

        private void Listado_Estudiantes_Load(object sender, EventArgs e)
        {
            MostrarEstudiantes();

        }

        private void MostrarEstudiantes()
        {
            dgvEstudiante.DataSource =
                bll.GetAll().ToList();
        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex >= 0)
            {
                EstudianteDto estudiante =
                    (EstudianteDto)
                    dgvEstudiante.Rows[e.RowIndex]
                    .DataBoundItem;

                Form1 frm =
                    new Form1();

                frm.CargarEstudiante(estudiante);

                frm.Show();
            }
        }
    }
        }
  
