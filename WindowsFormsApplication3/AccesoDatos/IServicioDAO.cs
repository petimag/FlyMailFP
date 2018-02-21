using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public interface IServicioDAO
    {
        int obtenerId(string pProveedor);
        List<string> listaServicio();
        string obtenerDominio(string pProveedor);
        Servicio obtenerServicioPop3(int pIdServicio);
    }
}
