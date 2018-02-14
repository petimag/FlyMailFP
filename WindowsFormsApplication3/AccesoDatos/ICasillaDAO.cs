using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public interface ICasillaDAO
    {
        bool NombreExistente(string pNombre, int idCuenta);
        List<string> ListaNombres(int idCuenta);
        string BuscarDireccion(string pNombre, int pIdUsuario);
        string BuscarContraseña(string pNombre,int pIdUsuario);
        void Agregar(CasillaCorreo pCasilla, int pServicio, int pUsuario);
        void Modificar(CasillaCorreo pCasilla, int pIDUsuario);
        void Eliminar(string pNombreCasilla, int pIDUsaruio);
    }
}
