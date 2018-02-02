using System;

namespace FlyMail
{
	public class Cuenta
	{
        string _nombre;
        string _contraseña;

        public Cuenta (string pNombre, string pContraseña)
		{
            _nombre = pNombre;
            _contraseña = pContraseña;
		}

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
    }
}

