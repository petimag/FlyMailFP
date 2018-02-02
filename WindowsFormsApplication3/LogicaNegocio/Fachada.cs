using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    public class Fachada
    {
        private static Fachada instancia;

        private int _idCuentaLogeado;

        public static Fachada Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new Fachada();
                return instancia;
            }
        }

        public int IDCuentaLogeado
        {
            get { return _idCuentaLogeado; }
            set { _idCuentaLogeado = value; }
        }

        public void agregarCuenta(string pNombre, string pContraseña)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                _cuentaDAO.agregar(pNombre,pContraseña);
            }
            catch (DAOException)
            {
                factory.RollBack();
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        public bool nombreExistenteCuenta(string pNombre)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                return _cuentaDAO.nombreExistente(pNombre);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        public int verificarCuenta(string pNombre, string pContraseña)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                //Console.WriteLine(_cuentaDAO.verificarCuenta(pNombre, pContraseña));
                return _cuentaDAO.verificarCuenta(pNombre, pContraseña);
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        public bool nombreExistenteCasilla(string pNombre)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                return _casillaDAO.nombreExistente(pNombre,this.IDCuentaLogeado);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }
    }
}
