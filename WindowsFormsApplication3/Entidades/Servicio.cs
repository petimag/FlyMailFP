using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public class Servicio
    {
        string _nombre;
        string _ip;
        int _puerto;

        /// <summary>
        /// Representa un Servicio de Correo Electrónico, como ser Gmail o Yahoo.
        /// </summary>
        /// <param name="pNombre">Nombre del servicio</param>
        /// <param name="pIp">Dirección IP del servidor de Correo Electrónico</param>
        /// <param name="pPuerto">Puerto donde atiende el servidor de Correo Electrónico</param>
        public Servicio(string pNombre, string pIp, int pPuerto)
        {
            _nombre = pNombre;
            _ip = pIp;
            _puerto = pPuerto;
        }

        /// <summary>
        /// Nombre del servicio.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
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
    }
}
