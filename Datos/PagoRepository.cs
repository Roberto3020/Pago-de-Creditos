using System.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class PagoRepository
    {
        private readonly SqlConnection connection;
        public PagoRepository(ManejoConexion manejo){
            connection = manejo.Conexion;
        }

        public void Guardar(Pago pago)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "insert into Pago(Valor,Fecha) Values (@Valor,@Fecha)";
                command.Parameters.AddWithValue("@Valor" , pago.Valor);
                command.Parameters.AddWithValue("@Fecha" , pago.Fecha);
                command.ExecuteNonQuery();
            }
        }
    }
}
