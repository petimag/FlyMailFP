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
        List<string> listaNombres(int idCuenta);
        CasillaCorreo buscarCasilla(int idCasilla);
        void agregar(CasillaCorreo pCasilla, int pServicio, int pUsuario);
    }
}
