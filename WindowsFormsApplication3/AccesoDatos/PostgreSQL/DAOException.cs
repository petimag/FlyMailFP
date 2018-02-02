using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public class DAOException : Exception
    {
        public DAOException(string pDescription, Exception pException) : base(pDescription, pException)
        {

        }

        public DAOException(string pDescription) : base(pDescription)
        {

        }
    }
}
