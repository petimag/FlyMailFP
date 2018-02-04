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

        public void agregar(CasillaCorreo pCasilla, Servicio pServicio, int pUsuario)
        {
            using (NpgsqlTransaction transaccion = this._conexion.BeginTransaction())
            {

                NpgsqlCommand comando = this._conexion.CreateCommand();

                comando.Transaction = transaccion;

                comando.CommandText = "INSERT INTO \"CasillaEmail\"(nombre,contrasenaEmail,servicio,usuario,direccionEmail) VALUES(@nombre,@contrasenaEmail,@servicio,@usuario,@direccionEmail)";
                comando.Parameters.AddWithValue("@nombre", pCasilla.Nombre);
                comando.Parameters.AddWithValue("@contrasenaEmail", pCasilla.Contraseña);
                comando.Parameters.AddWithValue("@servicio", pServicio.Nombre);
                comando.Parameters.AddWithValue("@usuario", pUsuario);
                comando.Parameters.AddWithValue("@direccionEmail", pCasilla.Direccion);

                comando.ExecuteNonQuery();

                transaccion.Commit();
            }
        }
    }
}
