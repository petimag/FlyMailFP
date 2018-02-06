using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FlyMail
{
    public class PostgresCuentaDAO : ICuentaDAO
    {
        private NpgsqlConnection _conexion;

        public PostgresCuentaDAO(NpgsqlConnection pConexion)
        {
            _conexion = pConexion;
        }

        /// <summary>
        /// Permite agregar una nueva cuenta
        /// </summary>
        /// <param name="pCuenta">Datos de la cuenta</param>
        public void agregar(Cuenta pCuenta)
        {
            using (NpgsqlTransaction transaccion = this._conexion.BeginTransaction())
            {

                NpgsqlCommand comando = this._conexion.CreateCommand();

                comando.Transaction = transaccion;

                comando.CommandText = "INSERT INTO \"Usuario\"(nombre,contrasena) VALUES(@nombre,@contrasena)";
                comando.Parameters.AddWithValue("@nombre", pCuenta.Nombre);
                comando.Parameters.AddWithValue("@contrasena", pCuenta.Contraseña);

                comando.ExecuteNonQuery();

                transaccion.Commit();
            }
        }

        /// <summary>
        /// Verifica si existe el nombre
        /// </summary>
        /// <param name="pNombre">Nombre de Cuenta</param>
        /// <returns>Devuelve True si lo encuenta, False en caso contrario</returns>
        public bool nombreExistente(string pNombre)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"Usuario\" WHERE nombre = '" + pNombre + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Verifica si el nombre y contraseña coincide con los almacenados
        /// </summary>
        /// <param name="pCuenta">Datos de la cuenta</param>
        /// <returns>Devuelve el id de la Cuenta, en caso de no encontrarlo devuelve -1</returns>
        public int verificarCuenta(Cuenta pCuenta)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT \"idUsuario\" FROM \"Usuario\" WHERE \"nombre\" = '" + pCuenta.Nombre + "' and contrasena = '" + pCuenta.Contraseña + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return Int32.Parse(reader[0].ToString());
            else
                return -1;
        }

        /// <summary>
        /// Obtiene el Nombre de la cuenta logeado
        /// </summary>
        /// <param name="idUsuario">Id de la Cuenta</param>
        /// <returns>Devuelve el nombre de la Cuenta, en caso conttrario devuelve una cadena vacía</returns>
        public string obtenerNombreCuenta(int idUsuario)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT nombre FROM \"Usuario\" WHERE \"idUsuario\" = '" + idUsuario + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return reader[0].ToString();
            else
                return string.Empty;
        }

        /// <summary>
        /// Obtiene la Contraseña de la cuenta logeado
        /// </summary>
        /// <param name="idUsuario">Id de la Cuenta</param>
        /// <returns>Devuelve la Contraseña de la Cuenta, en caso conttrario devuelve una cadena vacía</returns>
        public string obtenerContraseñaCuenta(int idUsuario)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT contrasena FROM \"Usuario\" WHERE \"idUsuario\" = '" + idUsuario + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return reader[0].ToString();
            else
                return string.Empty;
        }

        /// <summary>
        /// Verifica la contraseña del Usuario
        /// </summary>
        /// <param name="idUsuario">ID Usuario</param>
        /// <param name="pContraseña">Contraseña de Usuario</param>
        /// <returns>Devuelve True si la contraseña es correcta, False en caso contrario</returns>
        public bool verificarContraseña(int idUsuario, string pContraseña)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"Usuario\" WHERE \"idUsuario\" = '" + idUsuario + "' and contrasena = '" + pContraseña + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Modifica el nombre de Usuario
        /// </summary>
        /// <param name="idUsuario">Id del Usuario</param>
        /// <param name="pCuenta">Datos de la Cuenta</param>
        public void modificarNombre(int idUsuario, Cuenta pCuenta)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "UPDATE \"Usuario\" SET nombre  = @nombre, contrasena = @contrasena WHERE \"idUsuario\" = '" + idUsuario + "'";

            comando.Parameters.AddWithValue("@nombre", pCuenta.Nombre);
            comando.Parameters.AddWithValue("@contrasena", pCuenta.Contraseña);
            comando.ExecuteNonQuery();
        }

        /// <summary>
        /// Modifica la contraseña de Usuario
        /// </summary>
        /// <param name="idUsuario">ID del Usuario</param>
        /// <param name="pContraseña">Nueva Contraseña</param>
        public void modificarContraseña(int idUsuario, string pContraseña)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "UPDATE \"Usuario\" SET contrasena = @contrasena WHERE \"idUsuario\" = '" + idUsuario + "'";

            comando.Parameters.AddWithValue("@contrasena", pContraseña);
            comando.ExecuteNonQuery();
        }
    }
}
