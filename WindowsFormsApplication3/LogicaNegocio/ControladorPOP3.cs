using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace FlyMail
{
    public class ControladorPOP3: ProtocoloEMail
    {
        /// <summary>
        /// Constructor. Requiere los parámetros de conexión
        /// </summary>
        /// <param name="pUser"></param>
        /// <param name="pPass"></param>
        /// <param name="pHost"></param>
        /// <param name="pPort"></param>
        /// <param name="pSSL"></param>
        public ControladorPOP3(string pUser, string pPass, string pHost, int pPort, bool pSSL)
        {
            this.Usuario = pUser;
            this.Contraseña = pPass;
            this.IP = pHost;
            this.Puerto = pPort;
            this.SSL = pSSL;
        }

        /// <summary>
        /// Obtiene el listado de los nuevos e-mails desde el servidor POP3
        /// </summary>
        /// <param name="pop3"></param>
        /// <returns></returns>
        public List<Message> ObtenerMensajes()
        {
            try
            {
                // El cliente se desconecta al terminar el using
                using (Pop3Client client = new Pop3Client())
                {
                    // conectamos al servidor
                    client.Connect(this.IP, this.Puerto, this.SSL);
                    Console.WriteLine("1 " + this.Usuario + " " + this.Contraseña);

                    // Autentificación
                    client.Authenticate(this.Usuario, this.Contraseña);
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

            catch (Exception)
            {
                return null;
            }
        }
    }
}
