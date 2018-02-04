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

        public void agregar(string pNombre, string pContraseña)
        {
            using (NpgsqlTransaction transaccion = this._conexion.BeginTransaction())
            {

                NpgsqlCommand comando = this._conexion.CreateCommand();

                comando.Transaction = transaccion;

                comando.CommandText = "INSERT INTO \"Usuario\"(nombre,contrasena) VALUES(@nombre,@contrasena)";
                comando.Parameters.AddWithValue("@nombre", pNombre);
                comando.Parameters.AddWithValue("@contrasena", pContraseña);

                comando.ExecuteNonQuery();

                transaccion.Commit();
            }
        }

        public bool nombreExistente(string pNombre)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"Cuenta\" WHERE nombre = '" + pNombre + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return true;
            else
                return false;
        }

        public int verificarCuenta(string pNombre, string pContraseña)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT \"idCuenta\" FROM \"Cuenta\" WHERE \"nombre\" = '" + pNombre + "' and contraseña = '" + pContraseña + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            //Console.WriteLine(Int32.Parse(reader[0].ToString()));
            if (reader.Read())
                return Int32.Parse(reader[0].ToString());
            else
                return -1;
        }
    }
}
