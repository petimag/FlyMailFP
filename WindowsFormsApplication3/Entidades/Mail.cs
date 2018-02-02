using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public class Mail
    {
        string _de;
        string _para;
        string _asunto;
        DateTime _fecha;
        string _mensaje;
 
       public Mail(string pDe, string pPara, string pAsunto, DateTime pFecha, string pMensaje)
        {
            _de = pDe;
            _para = pPara;
            _asunto = pAsunto;
            _fecha = pFecha;
            _mensaje = pMensaje;
        }

        public string De
        {
            get { return _de; }
            set { _de = value; }
        }

        public string Para
        {
            get { return _para; }
            set { _para = value; }
        }

        public string Asunto
        {
            get { return _asunto; }
            set { _asunto = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
    }
}
