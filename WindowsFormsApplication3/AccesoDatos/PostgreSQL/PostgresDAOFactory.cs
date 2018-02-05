using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace FlyMail
{
    public class PostgresDAOFactory : DAOFactory
    {
        private String STRING_CONEXION = "Host=localhost;Username=postgres;Password=1234;Database=postgres";

        private NpgsqlConnection _conexion = null;
        private NpgsqlTransaction _transaction = null;

        public PostgresDAOFactory()
        {
            _conexion = new NpgsqlConnection(STRING_CONEXION);
        }

        public override ICuentaDAO cuentaDAO
        {
            get { return new PostgresCuentaDAO(_conexion); }
        }

        public override ICasillaDAO casillaCorreoDAO
        {
            get { return new PostgresCasillaDAO(_conexion); }
        }

        public override IMailDAO mailDAO
        {
            get { return new PostgresMailDAO(_conexion); }
        }

        public override IServicioDAO servicioDAO
        {
            get { return new PostgresServicioDAO(_conexion); }
        }

        public override void Commit()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
            }
        }

        public override void FinalizarConexion()
        {
            if (this._conexion.State == ConnectionState.Open)
                this._conexion.Close();
        }

        public override void IniciarConexion()
        {
            if (this._conexion.State != ConnectionState.Open)
                this._conexion.Open();
        }

        public override void IniciarTransaccion()
        {
            if (_conexion == null)
            {
                throw new DAOException("No se puede iniciar una transacción sin una conexión abierta.");
            }

            _transaction = _conexion.BeginTransaction();
        }

        public override void RollBack()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
            }
        }
    }
}
