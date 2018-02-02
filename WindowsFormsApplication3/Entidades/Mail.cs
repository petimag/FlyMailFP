using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public class Mail
    {
        string _remitente;
        List<CasillaCorreo> _destinatario = new List<CasillaCorreo>();
        string _asunto;
        List<CasillaCorreo> _cc = new List<CasillaCorreo>();
        List<CasillaCorreo> _cco = new List<CasillaCorreo>();
        DateTime _fecha;
        string _mensaje;
        
       /// <summary>
       /// Representa un E-Mail con sus respectivos campos.
       /// </summary>
       /// <param name="pRemitente">Dirección del remitente</param>
       /// <param name="pDestinatario">Dirección del/los destinatario/s</param>
       /// <param name="pAsunto">Título o cabecera del mensaje</param>
       /// <param name="pCC">Destinatarios en copia</param>
       /// <param name="pCCO">Destinatarios en copia oculta</param>
       /// <param name="pFecha">Fecha y hora del mensaje</param>
       /// <param name="pMensaje">Cuerpo del mensaje en texto plano</param>
       public Mail(string pRemitente, List<CasillaCorreo> pDestinatario, string pAsunto, List<CasillaCorreo> pCC, List<CasillaCorreo> pCCO, DateTime pFecha, string pMensaje)
        {
            _remitente = pRemitente;
            _destinatario = pDestinatario;
            _asunto = pAsunto;
            _cc = pCC;
            _cco = pCCO;
            _fecha = pFecha;
            _mensaje = pMensaje;
        }

        /// <summary>
        /// Dirección de Correo del remitente.
        /// </summary>
        public string Remitente
        {
            get { return _remitente; }
        }

        /// <summary>
        /// Dirección del/los destinatario/s.
        /// </summary>
        public List<CasillaCorreo> Destinatario
        {
            get { return _destinatario; }
        }

        /// <summary>
        /// Título o cabecera del mensaje.
        /// </summary>
        public string Asunto
        {
            get { return _asunto; }
        }

        /// <summary>
        /// Dirección del/los destinatarios en copia.
        /// </summary>
        public List<CasillaCorreo> CC
        {
            get { return _cc; }
        }

        /// <summary>
        /// Dirección del/los destinatarios en copia oculta.
        /// </summary>
        public List<CasillaCorreo> CCO
        {
            get { return _cco; }
        }

        /// <summary>
        /// Fecha y hora del mensaje.
        /// </summary>
        public DateTime Fecha
        {
            get { return _fecha; }
        }

        /// <summary>
        /// Cuerpo del mensaje en texto plano.
        /// </summary>
        public string Mensaje
        {
            get { return _mensaje; }
        }
    }
}
