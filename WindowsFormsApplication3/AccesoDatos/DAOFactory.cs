using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.PostgreSQL;

namespace AccesoDatos
{
    public abstract class DAOFactory
    {
        private static PostgresDAOFactory _instancia = null;
        public abstract ICuentaDAO cuentaDAO { get; }
        public abstract ICasillaDAO casillaCorreoDAO { get; }
        public abstract IMailDAO mailDAO { get; }
        public abstract IServicioDAO servicioDAO { get; }

        public static PostgresDAOFactory Instancia()
        {
            if (_instancia == null)
                _instancia = new PostgresDAOFactory();
            return _instancia;
        }

        public abstract void IniciarConexion();
        public abstract void FinalizarConexion();
        public abstract void IniciarTransaccion();
        public abstract void Commit();
        public abstract void RollBack();
    }
}
