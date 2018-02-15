using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace FlyMail
{
    public class ControladorPOP3
    {
        private Pop3 pop3;

        public List<Message> obtenerMensajes(Pop3 pop3)
        {
            try
            {

                // El cliente se desconecta al terminar el using
                using (Pop3Client client = new Pop3Client())
                {
                    // conectamos al servidor
                    client.Connect(pop3.Usuario, pop3.Puerto, pop3.SSL);

                    // Autentificación
                    client.Authenticate(pop3.Usuario, pop3.Contraseña);

                    // Obtenemos los Uids mensajes
                    List<string> uids = client.GetMessageUids();

                    // creamos instancia de mensajes
                    List<Message> lstMessages = new List<Message>();

                    // Recorremos para comparar
                    for (int i = 0; i < uids.Count; i++)
                    {
                        //obtenemos el uid actual, es él id del mensaje
                        string currentUidOnServer = uids[i];

                        //por medio del uid obtenemos el mensaje con el siguiente metodo
                        Message oMessage = client.GetMessage(i + 1);

                        //agregamos el mensaje a la lista que regresa el metodo
                        lstMessages.Add(oMessage);

                    }

                    // regresamos la lista
                    return lstMessages;
                }
            }

            catch (Exception ex)
            {
                //si ocurre una excepción regresamos null, es importante que cachen las excepciones, yo
                //lo hice general por modo de ejemplo
                return null;
            }
        }
    }
}
