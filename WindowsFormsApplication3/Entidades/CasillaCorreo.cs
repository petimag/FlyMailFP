using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public class CasillaCorreo
    {
        string _nombre;
        string _direccion;
        string _contraseña;

        public CasillaCorreo(string pNombre, string pDireccion)
        {
            _nombre = pNombre;
            _nombre = pDireccion;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
    }
}
