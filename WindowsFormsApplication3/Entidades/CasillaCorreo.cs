using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CasillaCorreo
    {
        string _nombre;
        string _direccion;
        string _contraseña;

        /// <summary>
        /// Representa una Casilla de Correo Electrónico.
        /// </summary>
        /// <param name="pNombre">Alias opcional de la cuenta</param>
        /// <param name="pDireccion">Dirección de Correo Electrónico</param>
        /// <remarks>Una Cuenta tiene asociadas cero o más Casillas de Correo</remarks>
        public CasillaCorreo(string pNombre, string pDireccion)
        {
            _nombre = pNombre;
            _direccion = pDireccion;
            _contraseña = String.Empty;
        }

        /// <summary>
        /// Representa una Casilla de Correo Electrónico.
        /// </summary>
        /// <param name="pNombre">Alias opcional de la cuenta</param>
        /// <param name="pDireccion">Dirección de Correo Electrónico</param>
        /// <param name="pPassword">Contraseña de la Casilla de Correo</param>
        public CasillaCorreo(string pNombre, string pDireccion, string pPassword)
        {
            _nombre = pNombre;
            _direccion = pDireccion;
            _contraseña = pPassword;
        }

        /// <summary>
        /// Nombre o alias asociado a una Casilla de Correo. Opcional.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        /// <summary>
        /// Dirección completa de la Casilla de Correo.
        /// </summary>
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        /// <summary>
        /// Contraseña de la Casilla de Correo.
        /// </summary>
        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
    }
}
