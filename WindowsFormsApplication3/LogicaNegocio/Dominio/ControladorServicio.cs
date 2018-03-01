using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio.Dominio
{
    public class ControladorServicio
    {
        public ControladorServicio() { }

        /// <summary>
        /// Devuelve el Id del Servicio
        /// </summary>
        /// <param name="pProveedor">Proveedor del Servicio</param>
        /// <returns>ID del servicio</returns>
        public int ObtenerId(string pProveedor)
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
        public List<string> ObtenerProveedor()
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
        public string ObtenerDominio(string pProveedor)
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
    }
}
