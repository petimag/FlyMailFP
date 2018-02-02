using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public interface ICuentaDAO
    {
        void agregar(string pNombre, string pContraseña);
        bool nombreExistente(string pNombre);
        int verificarCuenta(string pNombre, string pContraseña);
    }
}
