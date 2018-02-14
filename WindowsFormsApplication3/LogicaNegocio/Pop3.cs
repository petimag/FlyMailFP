using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public class Pop3
    {
        //usuario/mail de gmail
        private string _usuario;
        //password
        private string _contraseña;
        //el puerto para pop de gmail es el 995
        private int _puerto;
        //el host de pop de gmail es pop.gmail.com
        private string _ip;
        //esta opción debe ir en true
        private bool _ssl;

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

        public bool SSL
        {
            get { return _ssl; }
            set { _ssl = value; }
        }

        public Pop3(string pUsuario, string pContraseña, int pPuerto, string pIp, bool pSsl)
        {
            _usuario = pUsuario;
            _contraseña = pContraseña;
            _puerto = pPuerto;
            _ip = pIp;
            _ssl = pSsl;
        }
    }
}
