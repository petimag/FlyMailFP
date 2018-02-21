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
        public List<Message> obtenerMensajes(Pop3 pop3)
        {
            try
            {
                // El cliente se desconecta al terminar el using
                using (Pop3Client client = new Pop3Client())
                {
                    // conectamos al servidor
                    client.Connect(pop3.Ip, pop3.Puerto, pop3.SSL);
                    Console.WriteLine("1 "+pop3.Usuario+" "+pop3.Contraseña);

                    // Autentificación
                    client.Authenticate(pop3.Usuario, pop3.Contraseña);
                    Console.WriteLine("2");
                    // Obtenemos los Uids mensajes
                    List<string> uids = client.GetMessageUids();
                    Console.WriteLine("3");
                    // creamos instancia de mensajes
                    List<Message> lstMessages = new List<Message>();
                    Console.WriteLine("4");
                    // Recorremos para comparar
                    for (int i = 0; i < uids.Count; i++)
                    {
                        Console.WriteLine("5");
                        //obtenemos el uid actual, es él id del mensaje
                        string currentUidOnServer = uids[i];
                        Console.WriteLine("6");
                        //por medio del uid obtenemos el mensaje con el siguiente metodo
                        Message oMessage = client.GetMessage(i + 1);
                        Console.WriteLine("7");
                        //agregamos el mensaje a la lista que regresa el metodo
                        lstMessages.Add(oMessage);

                    }
                    Console.WriteLine("8");
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
