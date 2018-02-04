using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FlyMail
{
    class PostgresCasillaDAO : ICasillaDAO
    {
        private NpgsqlConnection _conexion;

        public PostgresCasillaDAO(NpgsqlConnection pConexion)
        {
            _conexion = pConexion;
        }

        public bool nombreExistente(string pNombre, int idCuenta)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"CasillaEmail\" WHERE nombre = '" + pNombre + "' and usuario = '" + idCuenta + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return true;
            else
                return false;
        }
    }
}
