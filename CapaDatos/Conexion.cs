
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        // Cadena desde App.config
        private string cadena =
            ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        // Crear conexión
        public SqlConnection cn = new SqlConnection();

        // Constructor
        public Conexion()
        {
            cn.ConnectionString = cadena;
        }

        // Abrir conexión
        public SqlConnection AbrirConexion()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            return cn;
        }

        // Cerrar conexión
        public SqlConnection CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }

            return cn;
        }
    }
}
