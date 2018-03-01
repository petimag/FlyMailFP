using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Windows.Forms;
using Entidades;

namespace LogicaNegocio.Dominio
{
    public class ControladorCasilla
    {
        public ControladorCasilla() { }

        /// <summary>
        /// Determina si existe o no un nombre de Casilla para un usuario (Cuenta) logeado
        /// </summary>
        /// <param name="pNombre">Nombre de la Casilla de correo</param>
        /// <returns>True si el nombre existe, false en caso contrario. Devuelve false y un aviso en caso de error</returns>
        public bool NombreExistente(int pIdCuenta, string pNombre)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                return _casillaDAO.NombreExistente(pNombre, pIdCuenta);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Devuelve el id del correo electrónico a partir del nombre de la Casilla
        /// </summary>
        /// <param name="pNombreCasilla">Nombre de Casilla</param>
        /// <returns>Id de casilla. -1 en caso de error</returns>
        public int ObtenerId(int pIdCuenta, string pNombreCasilla)
        {
            {
                DAOFactory factory = DAOFactory.Instancia();

                try
                {
                    factory.IniciarConexion();
                    ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                    return _casillaDAO.BuscarId(pNombreCasilla, pIdCuenta);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
                finally
                {
                    factory.FinalizarConexion();
                }
            }
        }

        /// <summary>
        /// Devuelve la dirección de correo electrónico a partir del nombre de la Casilla. Se recomienda primero determinar si existe el nombre.
        /// </summary>
        /// <param name="pNombreCasilla">Nombre de Casilla</param>
        /// <returns>String conteniendo la dirección buscada. Cadena vacía en caso de error</returns>
        public string ObtenerDireccion(int pIdCuenta, string pNombreCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                return _casillaDAO.BuscarDireccion(pNombreCasilla, pIdCuenta);
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

        /// <summary>
        /// Devuelve la contraseña de correo electrónico a partir del nombre de la Casilla. Se recomienda primero determinar si existe el nombre.
        /// </summary>
        /// <param name="pNombreCasilla"></param>
        /// <returns>String conteniendo la contraseña buscada. Cadena vacía en caso de error o no estar almacenada</returns>
        public string ObtenerContraseña(int pIdCuenta, string pNombreCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                string _contraseña = _casillaDAO.BuscarContraseña(pNombreCasilla, pIdCuenta);
                if (_contraseña == "")
                {
                    return "vacia";
                }
                else
                {
                    return _contraseña;
                }

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

        /// <summary>
        /// Inserta una nueva Casilla en la base de datos, para el usuario actual
        /// </summary>
        /// <param name="pCasilla"></param>
        /// <param name="pServicio"></param>
        public bool Agregar(int pIdCuenta, CasillaCorreo pCasilla, int pServicio)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                _casillaDAO.Agregar(pCasilla, pServicio, pIdCuenta);
                return true;
            }
            catch (DAOException)
            {
                factory.RollBack();
                return false;
            }
            catch (Npgsql.PostgresException)
            {
                factory.RollBack();
                MessageBox.Show("La dirección de Correo Electrónico tiene un formato incorrecto");
                return false;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Modifica una Casilla de correo. El campo Contraseña es opcional y puede dejarse vacio para no modificarla
        /// </summary>
        /// <param name="pCasilla"></param>
        public bool Modificar(int pIdCuenta, CasillaCorreo pCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                _casillaDAO.Modificar(pCasilla, pIdCuenta);
                return true;
            }
            catch (DAOException)
            {
                factory.RollBack();
                return false;
            }
            catch (Exception e)
            {
                factory.RollBack();
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Elimina una Casilla de Correo del usuario logeado, a través de su nombre
        /// </summary>
        /// <param name="pNombreCasilla"></param>
        public bool Eliminar(int pIdCuenta, string pNombreCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO casillaDAO = factory.casillaCorreoDAO;
                casillaDAO.Eliminar(pNombreCasilla, pIdCuenta);
                return true;
            }
            catch (DAOException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Obtiene todos los nombres de Casillas del usuario logeado
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerNombre(int pIdCuenta)
        {
            DAOFactory factory = DAOFactory.Instancia();
            List<string> _listaNombres = new List<string>();

            try
            {

                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                _listaNombres = _casillaDAO.ListaNombres(pIdCuenta);
                return _listaNombres;
            }
            catch (Exception)
            {
                _listaNombres.Clear();
                return _listaNombres;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Devuelve el Id del servicio de una determinada casilla
        /// </summary>
        /// <param name="idCasilla">ID de casilla seleccionada</param>
        /// <returns>ID de servicio</returns>
        public int ObtenerIdServicio(int idCasilla)
        {
            {
                DAOFactory factory = DAOFactory.Instancia();

                try
                {
                    factory.IniciarConexion();
                    ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                    return _casillaDAO.ObtenerIdServicio(idCasilla);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
                finally
                {
                    factory.FinalizarConexion();
                }
            }
        }

    }
}
