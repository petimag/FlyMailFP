using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio.Dominio
{
    public class ControladorCuenta
    {
        public ControladorCuenta() { }

        /// <summary>
        /// Agrega una cuenta de Usuario
        /// </summary>
        /// <param name="pCuenta">Cuenta de usuario</param>
        public void Agregar(Cuenta pCuenta)
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

        /// <summary>
        /// Verifica si ya existe el nombre de Usuario
        /// </summary>
        /// <param name="pNombre">Nombre de usuario</param>
        /// <returns>Devuelve True si encuentra el nombre</returns>
        public bool NombreExistente(string pNombre)
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

        /// <summary>
        /// Verifica si la cuenta de usuario es correcta
        /// </summary>
        /// <param name="pCuenta">Cuenta de usuario</param>
        /// <returns>Devuelve el Id de usuario, -1 en caso de error </returns>
        public int Verificar(Cuenta pCuenta)
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

        /// <summary>
        /// Verifica que la contraseña sea correcta
        /// </summary>
        /// <param name="pContraseña">Contraseña de Usuario</param>
        /// <returns>Devuelve True si es correcta. False en caso contrario</returns>
        public bool VerificarContraseña(int pIdCuenta, String pContraseña)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                return _cuentaDAO.verificarContraseña(pIdCuenta, pContraseña);
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

        /// <summary>
        /// Devuelve el Nombre de usuario logeado
        /// </summary>
        /// <returns>Nombre de Usuario</returns>
        public string ObtenerNombre(int pIdCuenta)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                return _cuentaDAO.obtenerNombreCuenta(pIdCuenta);
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

        /// <summary>
        /// Devuelve la Contraseña del usuario logeado
        /// </summary>
        /// <returns>Contraseña del Usuario</returns>
        public string ObtenerContraseña(int pIdCuenta)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                return _cuentaDAO.obtenerContraseñaCuenta(pIdCuenta);
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

        /// <summary>
        /// Modificar el nombre de la cuenta del usuario
        /// </summary>
        /// <param name="pCuenta">Cuenta del usuario</param>
        public void ModificarNombre(int pIdCuenta, Cuenta pCuenta)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                _cuentaDAO.modificarNombre(pIdCuenta, pCuenta);
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

        /// <summary>
        /// Modificar la contraseña de la cuenta del usuario
        /// </summary>
        /// <param name="pContraseña">Contraseña a modificar</param>
        public void ModificarContraseña(int pIdCuenta, string pContraseña)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICuentaDAO _cuentaDAO = factory.cuentaDAO;
                _cuentaDAO.modificarContraseña(pIdCuenta, pContraseña);
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
    }
}
