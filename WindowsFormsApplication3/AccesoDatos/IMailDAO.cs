using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public interface IMailDAO
    {
        void Guardar(Mail pMail,int idCasilla);
        List<Mail> ListarMail(int idCasilla,string pMailBox);
        void EliminarMail(int idMail);
        void ModificarEstadoLeido(int idMail);
    }
}
