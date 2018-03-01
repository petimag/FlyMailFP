using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    /// <summary>
    /// Contiene las configuraciones necesarias para la conexión a un servidor de correo
    /// </summary>
    public abstract class ProtocoloEMail
    {
        /// <summary>
        /// Nombre de usuario de la Casilla de Correo
        /// </summary>
        private string _usuario;

        /// <summary>
        /// Contraseña de la Casilla de Correo
        /// </summary>
        private string _contraseña;

        /// <summary>
        /// Puerto para conectar con el servidor SMTP
        /// </summary>
        private int _puerto;

        /// <summary>
        /// Host del servidor SMTP
        /// </summary>
        private string _ip;

        /// <summary>
        /// True si se requiere seguridad SSL. False en caso contrario
        /// </summary>
        private bool _ssl;

        /// <summary>
        /// Retorna o asigna un valor a Usuario
        /// </summary>
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        /// <summary>
        /// Retorna o asigna un valor a Contraseña
        /// </summary>
        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

        /// <summary>
        /// Retorna o asigna un valor a Puerto
        /// </summary>
        public int Puerto
        {
            get { return _puerto; }
            set { _puerto = value; }
        }

        /// <summary>
        /// Retorna o asigna un valor a Ip
        /// </summary>
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }

        /// <summary>
        /// Retorna o asigna un valor a SSL determinando si se requiere o no
        /// </summary>
        public bool SSL
        {
            get { return _ssl; }
            set { _ssl = value; }
        }
    }
}
