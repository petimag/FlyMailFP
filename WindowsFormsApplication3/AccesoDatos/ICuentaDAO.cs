using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public interface ICuentaDAO
    {
        void agregar(Cuenta pCuenta);
        bool nombreExistente(string pNombre);
        int verificarCuenta(Cuenta pCuenta);
        string obtenerNombreCuenta(int idUsuario);
        string obtenerContraseñaCuenta(int idUsuario);
        bool verificarContraseña(int idUsuario, string pContraseña);
        void modificarNombre(int idUsuario, Cuenta pCuenta);
        void modificarContraseña(int idUsuario, string pContraseña);
    }
}
