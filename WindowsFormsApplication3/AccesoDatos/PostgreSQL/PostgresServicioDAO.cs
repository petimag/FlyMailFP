using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FlyMail
{
    public class PostgresServicioDAO : IServicioDAO
    {
        private NpgsqlConnection _conexion;

        public PostgresServicioDAO(NpgsqlConnection pConexion)
        {
            _conexion = pConexion;
        }

        public int obtenerId(string pProveedor)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT \"idServicio\" FROM \"Servicio\" WHERE \"proveedor\" = '" + pProveedor + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return Int32.Parse(reader[0].ToString());
            else
                return -1;
        }
    }
}

