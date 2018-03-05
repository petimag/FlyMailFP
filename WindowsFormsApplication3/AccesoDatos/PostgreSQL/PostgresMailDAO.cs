using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using Entidades;
using AccesoDatos;

namespace AccesoDatos.PostgreSQL
{
    class PostgresMailDAO : IMailDAO
    {
        private NpgsqlConnection _conexion;

        public PostgresMailDAO(NpgsqlConnection pConexion)
        {
            _conexion = pConexion;
        }

        public void Guardar(Mail pMail, int idCasilla)
        {
            using (NpgsqlTransaction transaccion = this._conexion.BeginTransaction())
            {

                NpgsqlCommand comando = this._conexion.CreateCommand();

                comando.Transaction = transaccion;

                comando.CommandText = "INSERT INTO \"Email\"(\"cabRemitente\",\"cabDestinatario\",\"cabFecha\",\"cabCC\",\"cabCCO\",cuerpo,mailbox,casilla,asunto,leido) VALUES(@remitente,@destinatario,@fecha,@cabCC,@cabCCO,@cuerpo,@mailbox,@casilla,@asunto,@leido)";
                comando.Parameters.AddWithValue("@remitente", pMail.Remitente);
                comando.Parameters.AddWithValue("@destinatario ", pMail.Destinatario);
                comando.Parameters.AddWithValue("@fecha ", pMail.Fecha);
                comando.Parameters.AddWithValue("@cabCC ", pMail.CC);
                comando.Parameters.AddWithValue("@cabCCO", pMail.CCO);
                comando.Parameters.AddWithValue("@cuerpo", pMail.Mensaje);
                comando.Parameters.AddWithValue("@mailbox", pMail.TipoMail);
                comando.Parameters.AddWithValue("@casilla", idCasilla);
                comando.Parameters.AddWithValue("@asunto", pMail.Asunto);
                comando.Parameters.AddWithValue("@asunto", pMail.Asunto);
                comando.Parameters.AddWithValue("@leido", pMail.Leido);

                comando.ExecuteNonQuery();

                transaccion.Commit();
            }
        }

        public List<Mail> ListarMail(int idCasilla, string pMailBox)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"Email\" WHERE casilla = '" + idCasilla + "' and mailbox = '" + pMailBox + "' ORDER by \"cabFecha\" asc";

            List<Mail> _listaMail = new List<Mail>();
            
            using (NpgsqlDataAdapter  adaptador = new NpgsqlDataAdapter(comando))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                foreach (DataRow fila in tabla.Rows)
                {
                    _listaMail.Add(new Mail(Convert.ToInt32(fila["idEmail"]), Convert.ToString(fila["cabRemitente"]), Convert.ToString(fila["cabDestinatario"]), Convert.ToString(fila["asunto"]), Convert.ToString(fila["cabCC"]), Convert.ToString(fila["cabCCO"]), Convert.ToString(fila["cabFecha"]), Convert.ToString(fila["cuerpo"]), Convert.ToString(fila["mailbox"]), Convert.ToBoolean(fila["leido"])));
                }
            }
            return _listaMail ;
        }

        public void EliminarMail(int idMail)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();

            comando.CommandText = "DELETE FROM \"Email\" WHERE \"idEmail\" = @idEmail";
            comando.Parameters.AddWithValue("@idEmail", idMail);

            // ExecuteNonQuery = -1 si no se modificaron filas
            if (comando.ExecuteNonQuery() == -1)
            {
                throw new DAOException("No se pudo eliminar la Casilla, intentelo nuevamente");
            }
        }

        public void ModificarEstadoLeido(int idMail)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "UPDATE \"Email\" SET leido  = @leido WHERE \"idEmail\" = '" + idMail + "'";

            comando.Parameters.AddWithValue("@leido", true);
            comando.ExecuteNonQuery();
        }

        public void ModificarMailBox(int idMail, string pMailBox)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "UPDATE \"Email\" SET mailbox  = @mailbox WHERE \"idEmail\" = '" + idMail + "'";

            comando.Parameters.AddWithValue("@mailbox", pMailBox);
            comando.ExecuteNonQuery();
        }
    }
}
