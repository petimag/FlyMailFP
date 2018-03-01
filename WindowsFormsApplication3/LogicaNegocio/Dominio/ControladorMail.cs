using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;
using System.Windows.Forms;

namespace LogicaNegocio.Dominio
{
    public class ControladorMail
    {
        public ControladorMail() { }

        /// <summary>
        /// Guardar un mail en la base de datos
        /// </summary>
        /// <param name="pMail">Mail a guardar</param>
        /// <param name="idCasilla">Id de la casilla</param>
        /// <returns>Devuelve True si se envió correctamente. False en caso contrario</returns>
        public bool Guardar(Mail pMail, int idCasilla)
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
        public List<Mail> Listar(int idCasilla, String pMailBox)
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
        public List<OpenPop.Mime.Message> Obtener(ControladorPOP3 pPop3)
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
        public void Enviar(ControladorSMTP pSmtp, Mail pMail)
        {
            pSmtp.EnviarMail(pMail);
        }

        /// <summary>
        /// Eliminar determinado Mail
        /// </summary>
        /// <param name="pIdMail">Id Mail</param>
        /// <returns></returns>
        public bool Eliminar(int pIdMail)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                IMailDAO mailDAO = factory.mailDAO;
                mailDAO.EliminarMail(pIdMail);
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
        /// Modificar el MailBox del Mail
        /// </summary>
        /// <param name="IdMail">ID del mail</param>
        /// <param name="pMailBox">MailBox a modificar</param>
        /// <returns></returns>
        public bool ModificarMailBox(int IdMail, string pMailBox)
        {
            DAOFactory factory = DAOFactory.Instancia();

            try
            {
                factory.IniciarConexion();
                IMailDAO mailDAO = factory.mailDAO;
                mailDAO.ModificarMailBox(IdMail, pMailBox);
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
        /// Modificar Estado del Mail a Leido
        /// </summary>
        /// <param name="idMail">Id Mail</param>
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
    }
}
