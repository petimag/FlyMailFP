using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace FlyMail
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

                comando.CommandText = "INSERT INTO \"Email\"(\"cabRemitente\",\"cabDestinatario\",\"cabFecha\",\"cabCC\",\"cabCCO\",cuerpo,mailbox,casilla,asunto) VALUES(@remitente,@destinatario,@fecha,@cabCC,@cabCCO,@cuerpo,@mailbox,@casilla,@asunto)";
                Console.WriteLine("pasa");
                comando.Parameters.AddWithValue("@remitente", pMail.Remitente);
                Console.WriteLine("pasa remitente "+pMail.Remitente.ToString());
                comando.Parameters.AddWithValue("@destinatario ", pMail.Destinatario);
                Console.WriteLine("pasa destinatario"+pMail.Destinatario);
                comando.Parameters.AddWithValue("@fecha ", pMail.Fecha);
                Console.WriteLine("pasa fecha"+pMail.Fecha);
                comando.Parameters.AddWithValue("@cabCC ", pMail.CC);
                Console.WriteLine("pasa cc "+pMail.CC);
                comando.Parameters.AddWithValue("@cabCCO", pMail.CCO);
                Console.WriteLine("pasa cco "+pMail.CCO);
                comando.Parameters.AddWithValue("@cuerpo", pMail.Mensaje);
                Console.WriteLine("pasa cuerpo "+pMail.Mensaje);
                comando.Parameters.AddWithValue("@mailbox", pMail.TipoMail);
                Console.WriteLine("pasa lista "+pMail.TipoMail.ToString());
                comando.Parameters.AddWithValue("@casilla", idCasilla);
                Console.WriteLine("pasa casilla "+idCasilla.ToString());
                comando.Parameters.AddWithValue("@asunto", pMail.Asunto);
                Console.WriteLine("pasa asunto :("+pMail.Asunto);

                comando.ExecuteNonQuery();

                transaccion.Commit();
            }
        }

        public List<Mail> ListarMail(int idCasilla, string pMailBox)
        {
            NpgsqlCommand comando = this._conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM \"Email\" WHERE casilla = '" + idCasilla + "' and mailbox = '"+ pMailBox + "'";
            NpgsqlDataReader reader = comando.ExecuteReader();
            List<Mail> _listaMail = new List<Mail>();

            using (NpgsqlDataAdapter  adaptador = new NpgsqlDataAdapter(comando))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                foreach (DataRow fila in tabla.Rows)
                {
                    _listaMail.Add(new Mail(Convert.ToString(fila["cabRemitente"]), Convert.ToString(fila["cabDestinatario"]), Convert.ToString(fila["asunto"]), Convert.ToString(fila["cabCC"]), Convert.ToString(fila["cabCCO"]), Convert.ToString(fila["cabFecha"]), Convert.ToString(fila["cuerpo"]), Convert.ToString(fila["mailbox"])));
                }
            }
            return _listaMail ;
        }
    }
}
