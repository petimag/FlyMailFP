using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using AccesoDatos;
using Entidades;

namespace AccesoDatos.PostgreSQL
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

        public List<string> listaServicio()
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT proveedor FROM \"Servicio\"";
            NpgsqlDataReader reader = comando.ExecuteReader();
            List<string> _listaServicio = new List<string>();
            while (reader.Read())
            {
                _listaServicio.Add(reader[0].ToString());
            }
            return _listaServicio;
        }

        public string obtenerDominio(string pProveedor)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT dominio FROM \"Servicio\" WHERE \"proveedor\" = '" + pProveedor + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
                return reader[0].ToString();
            else
                return string.Empty;
        }

        public Servicio obtenerServicioPop3(int pIdServicio)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"Servicio\" WHERE \"idServicio\" = '" + pIdServicio + "'";
            Servicio _servicio = new Servicio("", "", "", 0, false);

            using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(comando))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                foreach (DataRow fila in tabla.Rows)
                {
                    _servicio.Proveedor = Convert.ToString(fila["proveedor"]);
                    _servicio.Dominio = Convert.ToString(fila["dominio"]);
                    _servicio.Ip = Convert.ToString(fila["hostPOP"]);
                    _servicio.Puerto = Convert.ToInt32(fila["portPOP"]);
                    _servicio.SSL = Convert.ToBoolean(fila["sslPOP"]);
                }
            }
            return _servicio;
        }

        public Servicio obtenerServicioSMTP(int pIdServicio)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"Servicio\" WHERE \"idServicio\" = '" + pIdServicio + "'";
            Servicio _servicio = new Servicio("", "", "", 0, false);

            using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(comando))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                foreach (DataRow fila in tabla.Rows)
                {
                    _servicio.Proveedor = Convert.ToString(fila["proveedor"]);
                    _servicio.Dominio = Convert.ToString(fila["dominio"]);
                    _servicio.Ip = Convert.ToString(fila["hostSMTP"]);
                    _servicio.Puerto = Convert.ToInt32(fila["portSMTP"]);
                    _servicio.SSL = Convert.ToBoolean(fila["sslSMTP"]);
                }
            }
            return _servicio;
        }
    }
}

