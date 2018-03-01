using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mail
    {
        int _idMail = 0;
        string _remitente;
        string _destinatario;
        string _asunto;
        string _cc;
        string _cco;
        string _fecha;
        string _mensaje;
        string _tipoMail;
        bool _leido;
        
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
       public Mail(string pRemitente, string pDestinatario, string pAsunto, string pCC, string pCCO, string pFecha, string pMensaje, string pTipoMail, bool pLeido)
        {
            _remitente = pRemitente;
            _destinatario = pDestinatario;
            _asunto = pAsunto;
            _cc = pCC;
            _cco = pCCO;
            _fecha = pFecha;
            _mensaje = pMensaje;
            _tipoMail = pTipoMail;
            _leido = pLeido;
        }

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
        public Mail(int pIdMail, string pRemitente, string pDestinatario, string pAsunto, string pCC, string pCCO, string pFecha, string pMensaje, string pTipoMail, bool pLeido)
        {
            _idMail = pIdMail;
            _remitente = pRemitente;
            _destinatario = pDestinatario;
            _asunto = pAsunto;
            _cc = pCC;
            _cco = pCCO;
            _fecha = pFecha;
            _mensaje = pMensaje;
            _tipoMail = pTipoMail;
            _leido = pLeido;
        }

        /// <summary>
        /// Id del Mail
        /// </summary>
        public int IdMail
        {
            get { return _idMail; }
            set { _idMail = value; }
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
        public string Destinatario
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
        public string CC
        {
            get { return _cc; }
        }

        /// <summary>
        /// Dirección del/los destinatarios en copia oculta.
        /// </summary>
        public string CCO
        {
            get { return _cco; }
        }

        /// <summary>
        /// Fecha y hora del mensaje.
        /// </summary>
        public string Fecha
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

        public string TipoMail
        {
            get { return _tipoMail; }
        }

        public bool Leido
        {
            get { return _leido; }
        }
    }
}
