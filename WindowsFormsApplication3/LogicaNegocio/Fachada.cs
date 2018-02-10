using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void agregarCuenta(Cuenta pCuenta)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                _cuentaDAO.agregar(pCuenta);
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

        public int verificarCuenta(Cuenta pCuenta)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                //Console.WriteLine(_cuentaDAO.verificarCuenta(pNombre, pContraseña));
                return _cuentaDAO.verificarCuenta(pCuenta);
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

        public bool verificarContraseña(String pContraseña)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                return _cuentaDAO.verificarContraseña(this.IDCuentaLogeado,pContraseña);
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

        public string obtenerNombreCuenta()
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                return _cuentaDAO.obtenerNombreCuenta(this.IDCuentaLogeado);
            }
            catch (Exception)
            {
                return string.Empty;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        public string obtenerContrasenaCuenta()
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                return _cuentaDAO.obtenerContraseñaCuenta(this.IDCuentaLogeado);
            }
            catch (Exception)
            {
                return string.Empty;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        public void modificarNombreCuenta(Cuenta pCuenta)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                _cuentaDAO.modificarNombre(this.IDCuentaLogeado, pCuenta);
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

        public void modificarContraseñaCuenta(string pContraseña)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                _cuentaDAO.modificarContraseña(this.IDCuentaLogeado,pContraseña);
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

        public string obtenerDireccionCasilla(string pNombreCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                return _casillaDAO.buscarDireccion(pNombreCasilla);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return string.Empty;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        public void agregarCasilla(CasillaCorreo pCasilla, int pServicio)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                _casillaDAO.agregar(pCasilla,pServicio, _idCuentaLogeado);
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

        public void modificarCasilla(CasillaCorreo pCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                if (pCasilla.Contraseña != string.Empty)
                {
                    _casillaDAO.modificar(pCasilla);
                }
                else
                {
                    _casillaDAO.modificarDireccion(pCasilla);
                }
                
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

        public List<string> obtenerNombreCasillas()
        {
            DAOFactory factory = DAOFactory.Instancia();
            List<string> _listaNombres = new List<string>();

            try
            {
                
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                _listaNombres = _casillaDAO.listaNombres(this.IDCuentaLogeado);
                return _listaNombres;
            }
            catch (Exception e)
            {
                Console.WriteLine("entro");
                return _listaNombres;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        public int obtenerIdServicio(string pProveedor)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                IServicioDAO _servicioDAO = factory.servicioDAO;
                return _servicioDAO.obtenerId(pProveedor);
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
    }
}
