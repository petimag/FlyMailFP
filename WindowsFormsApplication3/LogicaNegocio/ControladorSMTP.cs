using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace FlyMail
{
    class ControladorSMTP
    {
        public void EnviarMail(SMTP pSmtp, Mail pMail)
        {
            try
            {
                SmtpClient _cliente = new SmtpClient(pSmtp.Ip, pSmtp.Puerto)
                {
                    EnableSsl = true,
                    Timeout = 100000,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(pSmtp.Usuario, pSmtp.Contraseña)
                };

                MailMessage _mensaje = new MailMessage(pMail.Remitente, pMail.Destinatario, pMail.Asunto, pMail.Mensaje);
                _mensaje.BodyEncoding = UTF8Encoding.UTF8;
                _mensaje.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                _cliente.Send(_mensaje);
            }

            catch (Exception ex)
            {
                //si ocurre una excepción regresamos null, es importante que cachen las excepciones, yo
                //lo hice general por modo de ejemplo
            }
        }
    }
}
