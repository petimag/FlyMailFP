using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entidades;

namespace LogicaNegocio
{
    public class ControladorSMTP: ProtocoloEMail
    {
        /// <summary>
        /// Constructor. Requiere los parámetros de conexión
        /// </summary>
        /// <param name="pUser"></param>
        /// <param name="pPass"></param>
        /// <param name="pHost"></param>
        /// <param name="pPort"></param>
        /// <param name="pSSL"></param>
        public ControladorSMTP(string pUser, string pPass, string pHost, int pPort, bool pSSL)
        {
            this.Usuario = pUser;
            this.Contraseña = pPass;
            this.IP = pHost;
            this.Puerto = pPort;
            this.SSL = pSSL;
        }

        /// <summary>
        /// Envia un e-mail utilizando el servidor SMTP
        /// </summary>
        /// <param name="pSmtp"></param>
        /// <param name="pMail"></param>
        public void EnviarMail(Mail pMail)
        {
            try
            {
                SmtpClient _cliente = new SmtpClient(this.IP, this.Puerto)
                {
                    EnableSsl = true,
                    Timeout = 100000,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(this.Usuario, this.Contraseña)
                };

                MailMessage _mensaje = new MailMessage(pMail.Remitente, pMail.Destinatario, pMail.Asunto, pMail.Mensaje);
                _mensaje.BodyEncoding = UTF8Encoding.UTF8;
                _mensaje.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                _cliente.Send(_mensaje);
            }

            catch (Exception)
            {
                
            }
        }
    }
}
