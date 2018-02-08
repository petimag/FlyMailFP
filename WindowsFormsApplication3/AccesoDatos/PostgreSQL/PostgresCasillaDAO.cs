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

        List<string> listaNombres(int idCuenta)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"CasillaEmail\" WHERE usuario = '" + idCuenta + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return true;
            else
                return false;
        }
        CasillaCorreo buscarCasilla(int idCasilla)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"CasillaEmail\" WHERE \"idCasillaEmail\" = '" + idCasilla + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();
            if (reader.Read())
                return ;
            else
                return false;

            /*SqlDataReader reader = command.ExecuteReader();
        DataTable schemaTable = reader.GetSchemaTable();

        foreach (DataRow row in schemaTable.Rows)
        {
            foreach (DataColumn column in schemaTable.Columns)
            {
                Console.WriteLine(String.Format("{0} = {1}",
                   column.ColumnName, row[column]));
            }
        }*/
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
    }
}
