using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;



namespace Datos
{
    class Conexion
    {


        private SqlConnection Conexion = new SqlConnection("Server=192.168.1.40\\SQLEXPRESS;DataBase=SISCONT;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
