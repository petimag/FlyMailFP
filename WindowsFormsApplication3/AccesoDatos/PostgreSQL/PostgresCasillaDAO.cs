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
        /// <summary>
        /// Conexión con la Base de Datos
        /// </summary>
        private NpgsqlConnection _conexion;

        /// <summary>
        /// Nueva CasillaDAO
        /// </summary>
        /// <param name="pConexion"></param>
        public PostgresCasillaDAO(NpgsqlConnection pConexion)
        {
            _conexion = pConexion;
        }

        /// <summary>
        /// Determina si existe o no el nombre de la Casilla. Se utiliza para comprobar que no existan dos nombres iguales
        /// </summary>
        /// <param name="pNombre">Nombre a buscar</param>
        /// <param name="idCuenta">ID de la Cuenta</param>
        /// <returns></returns>
        public bool NombreExistente(string pNombre, int idCuenta)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"CasillaEmail\" WHERE nombre = '" + pNombre + "' and usuario = '" + idCuenta + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return true;
            else
                return false;
        }

        public List<string> ListaNombres(int idCuenta)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT nombre FROM \"CasillaEmail\" WHERE usuario = '" + idCuenta + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            List<string> _listaNombre = new List<string>();
            while (reader.Read())
            {
                _listaNombre.Add(reader[0].ToString());
            }   
            return _listaNombre;
        }

        /// <summary>
        /// Busca y devuelve un Dirección de Correo a través del nombre
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public string BuscarDireccion(string pNombre)
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


        /// <summary>
        /// Agrega una Nueva Casilla de Correo
        /// </summary>
        /// <param name="pCasilla">Casilla de Correo</param>
        /// <param name="pServicio">Servicio de Correo (GMAIL, YAHOO)</param>
        /// <param name="pUsuario">Número de Usuario</param>
        public void Agregar(CasillaCorreo pCasilla, int pServicio, int pUsuario)
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

                // ExecuteNonQuery = 1 si se modificó 1 fila en la tabla.
                if (comando.ExecuteNonQuery() != 1)
                {
                    //Deshacer la operación
                    transaccion.Rollback();
                    throw new DAOException("No se pudieron insertar los valores");
                }
                
                //Confirmar la operación
                transaccion.Commit();
            }
            
        }

        /// <summary>
        /// Modifica la dirección y la contraseña de la Casilla de Correo
        /// </summary>
        /// <param name="pCasilla"></param>
        public void Modificar(CasillaCorreo pCasilla, int pIDUSuario)
        {
            string cmd = String.Empty;
            if (pCasilla.Contraseña == String.Empty)
                cmd = "UPDATE \"CasillaEmail\" SET \"direccionEmail\"  = @direccion WHERE nombre = '" + pCasilla.Nombre + "' and usuario = '" + pIDUSuario + "'";
            else
                cmd = "UPDATE \"CasillaEmail\" SET \"direccionEmail\"  = @direccion, \"contrasenaEmail\" = @contrasena WHERE nombre = '" + pCasilla.Nombre + "' and usuario = '" + pIDUSuario + "'";

            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = cmd;

            comando.Parameters.AddWithValue("@direccion", pCasilla.Direccion);
            comando.Parameters.AddWithValue("@contrasena", pCasilla.Contraseña);

            // ExecuteNonQuery = -1 si no se modificaron filas
            if (comando.ExecuteNonQuery() == -1)
            {
                throw new DAOException("No se pudieron actualizar los valores");
            }
        }

        /* ELIMIAR SI NO SE ENCUENTRAN FALLOS EN MODIFICAR
        /// <summary>
        /// Modifica la dirección de la Casilla de Correo
        /// </summary>
        /// <param name="pCasilla"></param>
        public void modificarDireccion(CasillaCorreo pCasilla)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "UPDATE \"CasillaEmail\" SET \"direccionEmail\"  = @direccion WHERE nombre = '" + pCasilla.Nombre + "'";

            comando.Parameters.AddWithValue("@direccion", pCasilla.Direccion);

            // ExecuteNonQuery = -1 si no se modificaron filas
            if (comando.ExecuteNonQuery() == -1)
            {
                throw new DAOException("No se pudieron actualizar los valores");
            }
        }
        */

        /// <summary>
        /// Elimina una Casilla de Correo
        /// </summary>
        /// <param name="pNombreCasilla">Nombre de la Casilla</param>
        /// <param name="pIDUsuario">ID de la Cuenta de usuario</param>
        public void Eliminar(string pNombreCasilla, int pIDUsuario)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();

            comando.CommandText = "DELETE FROM \"CasillaEmail\" WHERE nombre = @nombre and usuario = @usuario";
            comando.Parameters.AddWithValue("@nombre", pNombreCasilla);
            comando.Parameters.AddWithValue("@usuario", pIDUsuario);

            // ExecuteNonQuery = -1 si no se modificaron filas
            if (comando.ExecuteNonQuery() == -1)
            {
                throw new DAOException("No se pudo eliminar la Casilla, intentelo nuevamente");
            }
        }
    }
}
