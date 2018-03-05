using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace LogicaNegocio
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

        public bool EstablecerConexión()
        {
            // creamos instancia de mensajes
            List<Message> lstMessages = new List<Message>();
            try
            {
                // El cliente se desconecta al terminar el using
                using (Pop3Client client = new Pop3Client())
                {
                    // conectamos al servidor
                    client.Connect(this.IP, this.Puerto, this.SSL);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Establece si logra establecer conexión con la casilla de correo
        /// </summary>
        /// <returns></returns>
        public bool Autenticación()
        {
            // creamos instancia de mensajes
            List<Message> lstMessages = new List<Message>();
            try
            {
                // El cliente se desconecta al terminar el using
                using (Pop3Client client = new Pop3Client())
                {
                    // conectamos al servidor
                    client.Connect(this.IP, this.Puerto, this.SSL);

                    // Autentificación
                    client.Authenticate(this.Usuario, this.Contraseña);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene el listado de los nuevos e-mails desde el servidor POP3
        /// </summary>
        /// <param name="pop3"></param>
        /// <returns></returns>
        public List<Message> ObtenerMensajes()
        {
            // creamos instancia de mensajes
            List<Message> lstMessages = new List<Message>();
            try
            {
                // El cliente se desconecta al terminar el using
                using (Pop3Client client = new Pop3Client())
                {
                    // conectamos al servidor
                    client.Connect(this.IP, this.Puerto, this.SSL);

                    // Autentificación
                    client.Authenticate(this.Usuario, this.Contraseña);

                    // Obtenemos los Uids mensajes
                    List<string> uids = client.GetMessageUids();

                    // Recorremos para comparar
                    for (int i = 0; i < uids.Count; i++)
                    {
                        //obtenemos el uid actual, es él id del mensaje
                        string currentUidOnServer = uids[i];

                        //por medio del uid obtenemos el mensaje con el siguiente metodo
                        Message oMessage = client.GetMessage(i + 1);

                        //agregamos el mensaje a la lista que regresa el metodo
                        lstMessages.Add(oMessage);
                        client.DeleteMessage(i + 1);

                    }
                    // regresamos la lista
                    return lstMessages;
                }
            }

            catch (Exception)
            {
                return lstMessages;
            }
        }


    }
}
