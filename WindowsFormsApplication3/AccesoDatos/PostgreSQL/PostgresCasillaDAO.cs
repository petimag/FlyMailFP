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

        /*List<string> listaNombres(int idCuenta)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"CasillaEmail\" WHERE usuario = '" + idCuenta + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return true;
            else
                return false;
        }*/
        public string buscarDireccion(string pNombre)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT \"direccionEmail\" FROM \"CasillaEmail\" WHERE nombre = '" + pNombre + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                return reader[0].ToString();
            }
            else
            {
                throw new DAOException("Nombre de Casilla no encontrado");
            }
        }

        public void agregar(CasillaCorreo pCasilla, int pServicio, int pUsuario)
        {
            using (NpgsqlTransaction transaccion = this._conexion.BeginTransaction())
            {

                NpgsqlCommand comando = this._conexion.CreateCommand();

                comando.Transaction = transaccion;
                comando.CommandText = "INSERT INTO \"CasillaEmail\"(nombre,\"contrasenaEmail\",servicio,usuario,\"direccionEmail\") VALUES(@nombre,@contrasenaEmail,@servicio,@usuario,@direccionEmail)";
                comando.Parameters.AddWithValue("@nombre", pCasilla.Nombre);
                comando.Parameters.AddWithValue("@contrasenaEmail", pCasilla.Contraseña);
                comando.Parameters.AddWithValue("@servicio", pServicio);
                comando.Parameters.AddWithValue("@usuario", pUsuario);
                comando.Parameters.AddWithValue("@direccionEmail", pCasilla.Direccion);

                comando.ExecuteNonQuery();

                transaccion.Commit();
            }
        }

        public void modificar(CasillaCorreo pCasilla)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "UPDATE \"CasillaEmail\" SET \"direccionEmail\"  = @direccion, \"contrasenaEmail\" = @contrasena WHERE nombre = '" + pCasilla.Nombre + "'";

            comando.Parameters.AddWithValue("@direccion", pCasilla.Direccion);
            if (pCasilla.Contraseña != string.Empty)
            {
                comando.Parameters.AddWithValue("@contrasena", pCasilla.Contraseña);
            }
            comando.ExecuteNonQuery();
        }
    }
}
