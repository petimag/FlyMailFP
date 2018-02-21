using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public class Servicio
    {
        string _proveedor;
        string _dominio;
        string _ip;
        int _puerto;
        bool _ssl;

        /// <summary>
        /// Representa un Servicio de Correo Electrónico, como ser Gmail o Yahoo.
        /// </summary>
        /// <param name="pProveedor">Nombre del servicio</param>
        /// <param name="pIp">Dirección IP del servidor de Correo Electrónico</param>
        /// <param name="pPuerto">Puerto donde atiende el servidor de Correo Electrónico</param>
        public Servicio(string pProveedor, string pDominio, string pIp, int pPuerto, bool pSsl)
        {
            _proveedor = pProveedor;
            _dominio = pDominio;
            _ip = pIp;
            _puerto = pPuerto;
            _ssl = pSsl;
        }

        /// <summary>
        /// Proveedor del servicio.
        /// </summary>
        public string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        /// <summary>
        /// Dominio del servicio
        /// </summary>
        public string Dominio
        {
            get { return _dominio; }
            set { _dominio = value; }
        }

        /// <summary>
        /// Dirección IP del servidor de correo.
        /// </summary>
        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        /// <summary>
        /// Puerto de escucha del servidor de correo.
        /// </summary>
        public int Puerto
        {
            get { return _puerto; }
            set { _puerto = value; }
        }

        public bool SSL
        {
            get { return _ssl; }
            set { _ssl = value; }
        }
    }
}
