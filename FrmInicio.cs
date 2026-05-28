using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Aquí luego conectamos con login
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show();   
        }
    }
}