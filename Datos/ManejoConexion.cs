using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class ManejoConexion
    {
         public SqlConnection Conexion;

        public ManejoConexion(string cadenaConexion)
        {
            Conexion = new SqlConnection(cadenaConexion);
        }

        public void Open()
        {
            Conexion.Open();
        }

        public void Close()
        {
            Conexion.Close();
        }
}
}
