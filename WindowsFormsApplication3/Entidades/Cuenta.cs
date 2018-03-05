using System;

namespace Entidades
{
	public class Cuenta
	{
        string _nombre;
        string _contraseña;

        /// <summary>
        /// Representa una cuenta de usuario dentro de la aplicación.
        /// </summary>
        /// <param name="pNombre">Nombre de usuario</param>
        /// <param name="pContraseña">Contraseña</param>
        public Cuenta (string pNombre, string pContraseña)
		{
            _nombre = pNombre;
            _contraseña = pContraseña;
		}

        /// <summary>
        /// Nombre de usuario.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        /// <summary>
        /// Contraseña de la cuenta.
        /// </summary>
        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
    }
}

