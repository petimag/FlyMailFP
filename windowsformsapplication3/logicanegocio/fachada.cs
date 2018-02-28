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
        #region Definición
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
        #endregion

        #region Métodos para Cuenta
        /// <summary>
        /// Agrega una cuenta de Usuario
        /// </summary>
        /// <param name="pCuenta">Cuenta de usuario</param>
        public void AgregarCuenta(Cuenta pCuenta)
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
        public bool NombreExistenteCuenta(string pNombre)
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
        public int VerificarCuenta(Cuenta pCuenta)
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
        public bool VerificarContraseña(String pContraseña)
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

        /// <summary>
        /// Devuelve el Nombre de usuario logeado
        /// </summary>
        /// <returns>Nombre de Usuario</returns>
        public string ObtenerNombreCuenta()
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

        /// <summary>
        /// Devuelve la Contraseña del usuario logeado
        /// </summary>
        /// <returns>Contraseña del Usuario</returns>
        public string ObtenerContraseñaCuenta()
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

        /// <summary>
        /// Modificar el nombre de la cuenta del usuario
        /// </summary>
        /// <param name="pCuenta">Cuenta del usuario</param>
        public void ModificarNombreCuenta(Cuenta pCuenta)
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

        /// <summary>
        /// Modificar la contraseña de la cuenta del usuario
        /// </summary>
        /// <param name="pContraseña">Contraseña a modificar</param>
        public void ModificarContraseñaCuenta(string pContraseña)
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
        #endregion

        #region Métodos para Casilla

        /// <summary>
        /// Determina si existe o no un nombre de Casilla para un usuario (Cuenta) logeado
        /// </summary>
        /// <param name="pNombre">Nombre de la Casilla de correo</param>
        /// <returns>True si el nombre existe, false en caso contrario. Devuelve false y un aviso en caso de error</returns>
        public bool NombreExistenteCasilla(string pNombre)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                return _casillaDAO.NombreExistente(pNombre,this.IDCuentaLogeado);
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
        public int ObtenerIdCasilla(string pNombreCasilla)
        {
            {
                DAOFactory factory = DAOFactory.Instancia();

                try
                {
                    factory.IniciarConexion();
                    ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                    return _casillaDAO.BuscarId(pNombreCasilla, this.IDCuentaLogeado);
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
        public string ObtenerDireccionCasilla(string pNombreCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                return _casillaDAO.BuscarDireccion(pNombreCasilla,this.IDCuentaLogeado);
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
        public string ObtenerContraseñaCasilla(string pNombreCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                string _contraseña = _casillaDAO.BuscarContraseña(pNombreCasilla, this.IDCuentaLogeado);
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
        public bool AgregarCasilla(CasillaCorreo pCasilla, int pServicio)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                _casillaDAO.Agregar(pCasilla,pServicio, _idCuentaLogeado);
                return true;
            }
            catch (DAOException)
            {
                factory.RollBack();
                return false;
            }
            catch(Npgsql.PostgresException)
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
        public bool ModificarCasilla(CasillaCorreo pCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                _casillaDAO.Modificar(pCasilla, this.IDCuentaLogeado);
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
        public bool EliminarCasilla(string pNombreCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                ICasillaDAO casillaDAO = factory.casillaCorreoDAO;
                casillaDAO.Eliminar(pNombreCasilla, this.IDCuentaLogeado);
                return true;
            }
            catch(DAOException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch(Exception e)
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
        public List<string> ObtenerNombreCasillas()
        {
            DAOFactory factory = DAOFactory.Instancia();
            List<string> _listaNombres = new List<string>();

            try
            {
                
                factory.IniciarConexion();
                ICasillaDAO _casillaDAO = factory.casillaCorreoDAO;
                _listaNombres = _casillaDAO.ListaNombres(this.IDCuentaLogeado);
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
        #endregion

        #region Métodos para Servicio
        /// <summary>
        /// Devuelve el Id del Servicio
        /// </summary>
        /// <param name="pProveedor">Proveedor del Servicio</param>
        /// <returns>ID del servicio</returns>
        public int ObtenerIdServicio(string pProveedor)
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

        /// <summary>
        /// Obtener lista de Proveedores
        /// </summary>
        /// <returns>Lista de proveedores</returns>
        public List<string> ObtenerProveedorServicio()
        {
            DAOFactory factory = DAOFactory.Instancia();
            List<string> _listaProveedor = new List<string>();

            try
            {

                factory.IniciarConexion();
                IServicioDAO _servicioDAO = factory.servicioDAO;
                _listaProveedor = _servicioDAO.listaServicio();
                return _listaProveedor;
            }
            catch (Exception)
            {
                return _listaProveedor;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Obtener dominio de un determinado proveedor
        /// </summary>
        /// <param name="pProveedor">Proveedor de servicio</param>
        /// <returns>Dominio del Servicio</returns>
        public string ObtenerDominioServicio(string pProveedor)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                IServicioDAO _servicioDAO = factory.servicioDAO;
                return _servicioDAO.obtenerDominio(pProveedor);
            }
            catch (Exception)
            {
                return String.Empty;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Obtiene un determinado Dominio
        /// </summary>
        /// <param name="pIdServicio">Id del servicio</param>
        /// <param name="pTipoProtocolo">Tipo de protocolo</param>
        /// <returns>Servicio buscado</returns>
        public Servicio ObtenerServicio(int pIdServicio, string pTipoProtocolo)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                IServicioDAO _servicioDAO = factory.servicioDAO;
                Servicio _servicio;
                if (pTipoProtocolo == "pop")
                {
                    _servicio = _servicioDAO.obtenerServicioPop3(pIdServicio);
                }
                else if (pTipoProtocolo == "smtp")
                {
                    _servicio = _servicioDAO.obtenerServicioSMTP(pIdServicio);
                }
                else
                {
                    _servicio = null;
                }
                return _servicio;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }
        #endregion

        #region Metodos para Mail
        /// <summary>
        /// Guardar un mail en la base de datos
        /// </summary>
        /// <param name="pMail">Mail a guardar</param>
        /// <param name="idCasilla">Id de la casilla</param>
        /// <returns>Devuelve True si se envió correctamente. False en caso contrario</returns>
        public bool GuardarMail(Mail pMail, int idCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                IMailDAO _mailDAO = factory.mailDAO;
                _mailDAO.Guardar(pMail, idCasilla);
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
        /// Lista los mail de una determinada casilla y tipo de lista
        /// </summary>
        /// <param name="idCasilla">Id de casilla</param>
        /// <param name="pMailBox">Tipo de lista</param>
        /// <returns>Lista de mails</returns>
        public List<Mail> ListarMail(int idCasilla,String pMailBox)
        {
            DAOFactory factory = DAOFactory.Instancia();
            List<Mail> _listaMails = new List<Mail>();

            try
            {

                factory.IniciarConexion();
                IMailDAO _mailDAO = factory.mailDAO;
                _listaMails = _mailDAO.ListarMail(idCasilla, pMailBox);
                return _listaMails;
            }
            catch (Exception)
            {
                _listaMails.Clear();
                Console.WriteLine("entra aca");
                return _listaMails;
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Obtiene los mail del servidor de la casilla
        /// </summary>
        /// <param name="pPop3">POP3 al que se conecta</param>
        /// <returns>Lista de mails</returns>
        public List<OpenPop.Mime.Message> ObtenerMail(ControladorPOP3 pPop3)
        {
            List<OpenPop.Mime.Message> lista = new List<OpenPop.Mime.Message>();
            lista = pPop3.ObtenerMensajes();
            return lista;

        }

        /// <summary>
        /// Envia un determinado mail
        /// </summary>
        /// <param name="pSmtp">SMTP al que se conecta</param>
        /// <param name="pMail">Mail a enviar</param>
        public void EnviarMail(ControladorSMTP pSmtp, Mail pMail)
        {
            pSmtp.EnviarMail(pMail);
        }

        public bool EliminarMail(int pIdCasilla)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                IMailDAO mailDAO = factory.mailDAO;
                mailDAO.EliminarMail(pIdCasilla);
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

        public void ModificarEstadoLeido(int idMail)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                IMailDAO _mailDAO = factory.mailDAO;
                _mailDAO.ModificarEstadoLeido(idMail);
            }
            catch (DAOException)
            {
                factory.RollBack();
            }
            catch (Exception e)
            {
                factory.RollBack();
                MessageBox.Show(e.Message);
            }
            finally
            {
                factory.FinalizarConexion();
            }
        }
        #endregion
    }
}
