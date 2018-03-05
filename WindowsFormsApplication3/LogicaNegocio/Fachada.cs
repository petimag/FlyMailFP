using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using LogicaNegocio.Dominio;

namespace LogicaNegocio
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

        ControladorCuenta _controladorCuenta = new ControladorCuenta();
        ControladorCasilla _controladorCasilla = new ControladorCasilla();
        ControladorServicio _controladorServicio = new ControladorServicio();
        ControladorMail _controladorMail = new ControladorMail();
        #endregion

        #region Métodos para Cuenta
        /// <summary>
        /// Agrega una cuenta de Usuario
        /// </summary>
        /// <param name="pCuenta">Cuenta de usuario</param>
        public void AgregarCuenta(Cuenta pCuenta)
        {
            _controladorCuenta.Agregar(pCuenta);
        }

        /// <summary>
        /// Verifica si ya existe el nombre de Usuario
        /// </summary>
        /// <param name="pNombre">Nombre de usuario</param>
        /// <returns>Devuelve True si encuentra el nombre</returns>
        public bool NombreExistenteCuenta(string pNombre)
        {
            return _controladorCuenta.NombreExistente(pNombre);
        }

        /// <summary>
        /// Verifica si la cuenta de usuario es correcta
        /// </summary>
        /// <param name="pCuenta">Cuenta de usuario</param>
        /// <returns>Devuelve el Id de usuario, -1 en caso de error </returns>
        public int VerificarCuenta(Cuenta pCuenta)
        {
            return _controladorCuenta.Verificar(pCuenta);
        }

        /// <summary>
        /// Verifica que la contraseña sea correcta
        /// </summary>
        /// <param name="pContraseña">Contraseña de Usuario</param>
        /// <returns>Devuelve True si es correcta. False en caso contrario</returns>
        public bool VerificarContraseña(String pContraseña)
        {
            return _controladorCuenta.VerificarContraseña(this.IDCuentaLogeado, pContraseña);
        }

        /// <summary>
        /// Devuelve el Nombre de usuario logeado
        /// </summary>
        /// <returns>Nombre de Usuario</returns>
        public string ObtenerNombreCuenta()
        {
            return _controladorCuenta.ObtenerNombre(this.IDCuentaLogeado);
        }

        /// <summary>
        /// Devuelve la Contraseña del usuario logeado
        /// </summary>
        /// <returns>Contraseña del Usuario</returns>
        public string ObtenerContraseñaCuenta()
        {
            return _controladorCuenta.ObtenerContraseña(this.IDCuentaLogeado);
        }

        /// <summary>
        /// Modificar el nombre de la cuenta del usuario
        /// </summary>
        /// <param name="pCuenta">Cuenta del usuario</param>
        public void ModificarNombreCuenta(Cuenta pCuenta)
        {
            _controladorCuenta.ModificarNombre(this.IDCuentaLogeado, pCuenta);

        }

        /// <summary>
        /// Modificar la contraseña de la cuenta del usuario
        /// </summary>
        /// <param name="pContraseña">Contraseña a modificar</param>
        public void ModificarContraseñaCuenta(string pContraseña)
        {
            _controladorCuenta.ModificarContraseña(this.IDCuentaLogeado, pContraseña);
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
            return _controladorCasilla.NombreExistente(this.IDCuentaLogeado, pNombre);
        }

        /// <summary>
        /// Devuelve el id del correo electrónico a partir del nombre de la Casilla
        /// </summary>
        /// <param name="pNombreCasilla">Nombre de Casilla</param>
        /// <returns>Id de casilla. -1 en caso de error</returns>
        public int ObtenerIdCasilla(string pNombreCasilla)
        {
            return _controladorCasilla.ObtenerId(this.IDCuentaLogeado, pNombreCasilla);
        }

        /// <summary>
        /// Devuelve la dirección de correo electrónico a partir del nombre de la Casilla. Se recomienda primero determinar si existe el nombre.
        /// </summary>
        /// <param name="pNombreCasilla">Nombre de Casilla</param>
        /// <returns>String conteniendo la dirección buscada. Cadena vacía en caso de error</returns>
        public string ObtenerDireccionCasilla(string pNombreCasilla)
        {
            return _controladorCasilla.ObtenerDireccion(this.IDCuentaLogeado, pNombreCasilla);
        }

        /// <summary>
        /// Devuelve la contraseña de correo electrónico a partir del nombre de la Casilla. Se recomienda primero determinar si existe el nombre.
        /// </summary>
        /// <param name="pNombreCasilla"></param>
        /// <returns>String conteniendo la contraseña buscada. Cadena vacía en caso de error o no estar almacenada</returns>
        public string ObtenerContraseñaCasilla(string pNombreCasilla)
        {
            return _controladorCasilla.ObtenerContraseña(this.IDCuentaLogeado, pNombreCasilla);
        }

        /// <summary>
        /// Inserta una nueva Casilla en la base de datos, para el usuario actual
        /// </summary>
        /// <param name="pCasilla"></param>
        /// <param name="pServicio"></param>
        public bool AgregarCasilla(CasillaCorreo pCasilla, int pServicio)
        {
            return _controladorCasilla.Agregar(this.IDCuentaLogeado, pCasilla, pServicio);
        }

        /// <summary>
        /// Modifica una Casilla de correo. El campo Contraseña es opcional y puede dejarse vacio para no modificarla
        /// </summary>
        /// <param name="pCasilla"></param>
        public bool ModificarCasilla(CasillaCorreo pCasilla)
        {
            return _controladorCasilla.Modificar(this.IDCuentaLogeado, pCasilla);
        }

        /// <summary>
        /// Elimina una Casilla de Correo del usuario logeado, a través de su nombre
        /// </summary>
        /// <param name="pNombreCasilla"></param>
        public bool EliminarCasilla(string pNombreCasilla)
        {
            return _controladorCasilla.Eliminar(this.IDCuentaLogeado, pNombreCasilla);
        }

        /// <summary>
        /// Obtiene todos los nombres de Casillas del usuario logeado
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerNombreCasillas()
        {
            return _controladorCasilla.ObtenerNombre(this.IDCuentaLogeado);
        }

        /// <summary>
        /// Devuelve el Id del servicio de una determinada casilla
        /// </summary>
        /// <param name="idCasilla">ID de casilla seleccionada</param>
        /// <returns>ID de servicio</returns>
        public int ObtenerIdServicio(int pIdCasilla)
        {
            return _controladorCasilla.ObtenerIdServicio(pIdCasilla);
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
            return _controladorServicio.ObtenerId(pProveedor);
        }

        /// <summary>
        /// Obtener lista de Proveedores
        /// </summary>
        /// <returns>Lista de proveedores</returns>
        public List<string> ObtenerProveedorServicio()
        {
            return _controladorServicio.ObtenerProveedor();
        }

        /// <summary>
        /// Obtener dominio de un determinado proveedor
        /// </summary>
        /// <param name="pProveedor">Proveedor de servicio</param>
        /// <returns>Dominio del Servicio</returns>
        public string ObtenerDominioServicio(string pProveedor)
        {
            return _controladorServicio.ObtenerDominio(pProveedor);
        }

        /// <summary>
        /// Obtiene un determinado Dominio
        /// </summary>
        /// <param name="pIdServicio">Id del servicio</param>
        /// <param name="pTipoProtocolo">Tipo de protocolo</param>
        /// <returns>Servicio buscado</returns>
        public Servicio ObtenerServicio(int pIdServicio, string pTipoProtocolo)
        {
            return _controladorServicio.ObtenerServicio(pIdServicio, pTipoProtocolo);
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
            return _controladorMail.Guardar(pMail, idCasilla);
        }

        /// <summary>
        /// Lista los mail de una determinada casilla y tipo de lista
        /// </summary>
        /// <param name="idCasilla">Id de casilla</param>
        /// <param name="pMailBox">Tipo de lista</param>
        /// <returns>Lista de mails</returns>
        public List<Mail> ListarMail(int idCasilla,String pMailBox)
        {
            return _controladorMail.Listar(idCasilla, pMailBox);
        }

        /// <summary>
        /// Establece conexión con el servidor
        /// </summary>
        /// <param name="pPop3"></param>
        /// <returns></returns>
        public bool EstablecerConexion(ControladorPOP3 pPop3)
        {
            return _controladorMail.EstablecerConexion(pPop3);
        }

        /// <summary>
        /// Establece conexión con la casilla de correo
        /// </summary>
        /// <param name="pPop3"></param>
        /// <returns></returns>
        public bool Autentificación(ControladorPOP3 pPop3)
        {
            return _controladorMail.Autentificacion(pPop3);
        }

        /// <summary>
        /// Obtiene los mail del servidor de la casilla
        /// </summary>
        /// <param name="pPop3">POP3 al que se conecta</param>
        /// <returns>Lista de mails</returns>
        public List<OpenPop.Mime.Message> ObtenerMail(ControladorPOP3 pPop3)
        {
            return _controladorMail.Obtener(pPop3);

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

        /// <summary>
        /// Eliminar determinado Mail
        /// </summary>
        /// <param name="pIdMail">Id Mail</param>
        /// <returns></returns>
        public bool EliminarMail(int pIdMail)
        {
            return _controladorMail.Eliminar(pIdMail);
        }

        /// <summary>
        /// Modificar el MailBox del Mail
        /// </summary>
        /// <param name="IdMail">ID del mail</param>
        /// <param name="pMailBox">MailBox a modificar</param>
        /// <returns></returns>
        public bool ModificarMailBox(int IdMail, string pMailBox)
        {
            return _controladorMail.ModificarMailBox(IdMail, pMailBox);
        }

        /// <summary>
        /// Modificar Estado del Mail a Leido
        /// </summary>
        /// <param name="idMail">Id Mail</param>
        public void ModificarEstadoLeido(int pIdMail)
        {
            _controladorMail.ModificarEstadoLeido(pIdMail);
        }

        /// <summary>
        /// Descarga un determinado mail en la PC
        /// </summary>
        /// <param name="pMail"></param>
        public void DescargarMail(Mail pMail)
        {
            _controladorMail.Descargar(pMail);
        }
        #endregion
    }
}
