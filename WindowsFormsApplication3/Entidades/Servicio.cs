using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public class Servicio
    {
        string _ip;
        int _puerto;

        public Servicio(string pIp, int pPuerto)
        {
            _ip = pIp;
            _puerto = pPuerto;
        }

        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        public int Puerto
        {
            get { return _puerto; }
            set { _puerto = value; }
        }
    }
}
