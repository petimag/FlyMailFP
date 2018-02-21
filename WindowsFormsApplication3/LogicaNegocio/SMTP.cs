using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace FlyMail
{
    class SMTP
    {
        //usuario/mail de gmail
        private string _usuario;

        //password
        private string _contraseña;

        //el puerto para pop de gmail es el 995
        private int _puerto;
        //el host de pop de gmail es pop.gmail.com
        private string _ip;

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

        public int Puerto
        {
            get { return _puerto; }
            set { _puerto = value; }
        }

        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        public SMTP(string pUsuario, string pContraseña, int pPuerto, string pIp)
        {
            _usuario = pUsuario;
            _contraseña = pContraseña;
            _puerto = pPuerto;
            _ip = pIp;
        }
    }
}
