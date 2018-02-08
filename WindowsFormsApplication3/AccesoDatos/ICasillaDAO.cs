using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public interface ICasillaDAO
    {
        bool nombreExistente(string pNombre, int idCuenta);
        //List<string> listaNombres(int idCuenta);
        string buscarDireccion(string pNombre);
        void agregar(CasillaCorreo pCasilla, int pServicio, int pUsuario);
        void modificar(CasillaCorreo pCasilla);
        void modificarDireccion(CasillaCorreo pCasilla);
    }
}
