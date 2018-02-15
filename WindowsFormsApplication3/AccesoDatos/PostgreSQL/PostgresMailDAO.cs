using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FlyMail
{
    class PostgresMailDAO : IMailDAO
    {
        private NpgsqlConnection _conexion;

        public PostgresMailDAO(NpgsqlConnection pConexion)
        {
            _conexion = pConexion;
        }

        public void Guardar(OpenPop.Mime.Message pMail, int idCasilla)
        {
            using (NpgsqlTransaction transaccion = this._conexion.BeginTransaction())
            {

                NpgsqlCommand comando = this._conexion.CreateCommand();

                comando.Transaction = transaccion;

                comando.CommandText = "INSERT INTO \"Email\"(\"cabRemitente\",\"cabDestinatario\",\"cabFecha\",\"cabCC\",\"cabCCO\",cuerpo,mailbox,casilla,asunto) VALUES(@remitente,@destinatario,@fecha,@cabCC,@cabCCO,@cuerpo,@mailbox,@casilla,@asunto)";
                comando.Parameters.AddWithValue("@remitente", pMail.Headers.From.ToString());
                comando.Parameters.AddWithValue("@destinatario", pMail.Headers.To.ToString());
                comando.Parameters.AddWithValue("@fecha", pMail.Headers.Date.ToString());
                comando.Parameters.AddWithValue("@cabCC", pMail.Headers.Cc.ToString());
                comando.Parameters.AddWithValue("@cabCCO", pMail.Headers.Bcc.ToString());
                comando.Parameters.AddWithValue("@cuerpo", pMail.MessagePart.ToString());
                comando.Parameters.AddWithValue("@mailbox", String.Empty);
                comando.Parameters.AddWithValue("@casilla", idCasilla);
                comando.Parameters.AddWithValue("@asunto", pMail.Headers.Subject.ToString());

                comando.ExecuteNonQuery();

                transaccion.Commit();
            }
        }

    }
}
