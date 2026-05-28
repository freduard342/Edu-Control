using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;


namespace CapaPresentacion
{
    public partial class Probar_conexion : Form
    {
        Conexion conexion = new Conexion();
        public Probar_conexion()
        {
            InitializeComponent();

        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.AbrirConexion();

                MessageBox.Show("Conexión exitosa con SQL Server");

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
