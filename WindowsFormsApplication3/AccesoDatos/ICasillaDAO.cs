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

    }
}
