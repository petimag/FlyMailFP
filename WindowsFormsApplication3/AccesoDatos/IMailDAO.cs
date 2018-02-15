using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public interface IMailDAO
    {
        void Guardar(OpenPop.Mime.Message pMail,int idCasilla);
    }
}
