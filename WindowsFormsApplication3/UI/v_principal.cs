using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace FlyMail
{
    public partial class v_principal : Form
    {
        public v_principal()
        {
            InitializeComponent();
        }

        private Fachada _controlador = Fachada.Instancia;

        private bool _cerrarSesion = false;

        private v_mail i_mail = new v_mail();

        private v_correo i_correo = new v_correo();

        private v_login i_login = new v_login();

        private v_cuenta i_cuenta = new v_cuenta();

        private v_eliminarCasilla i_eliminarCasilla = new v_eliminarCasilla();

        private void v_principal_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            this.comboBox1.Text = "Seleccionar";
            this.comboBox1.Items.Add("Todos");
            List<string> _listaDirecciones = new List<string>();
            _listaDirecciones = _controlador.ObtenerNombreCasillas();
            for (int i = 0; i < _listaDirecciones.Count; i++)
                this.comboBox1.Items.Add(_listaDirecciones[i]);
        }

        /// <summary>
        /// Lista los mail "Recibidos"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_recibidos_Click(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.LightSkyBlue;
            button_enviados.BackColor = Color.PowderBlue;
            button_papelera.BackColor = Color.PowderBlue;
        }

        /// <summary>
        /// Lista los mail "Enviados"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_enviados_Click(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.PowderBlue;
            button_enviados.BackColor = Color.LightSkyBlue;
            button_papelera.BackColor = Color.PowderBlue;
        }

        /// <summary>
        /// Lista los mail de la papelera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_papelera_Click(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.PowderBlue;
            button_enviados.BackColor = Color.PowderBlue;
            button_papelera.BackColor = Color.LightSkyBlue;
        }

        /// <summary>
        /// Actualiza y descarga los mails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_actualizar_Click(object sender, EventArgs e)
        {
            this.refrescarDataGrid();
        }

        /// <summary>
        /// Permite redactar un nuevo mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_enviar_Click(object sender, EventArgs e)
        {
            this.i_mail.Text = "Enviar Mail";
            this.i_mail.ShowDialog(this);
        }

        /// <summary>
        /// Eliminar el mail de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            this.i_mail.Text = "Leer Mail";
            this.i_mail.ShowDialog(this);
            //    string pISBN = ((Libro)dataGridView1.CurrentRow.DataBoundItem).ISBN;
            //    this.iBiblioteca.BajaLibro(pISBN);
            //    this.refrescarDataGrid();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_responder_Click(object sender, EventArgs e)
        {
            this.i_mail.Text = "Enviar Mail";
            this.i_mail.ShowDialog(this);
        }

        /// <summary>
        /// Actualizar la lista de los mail
        /// </summary>
        private void refrescarDataGrid()
        {
  //          dataGridView1.DataSource = this.iCorreo.Libros;
            dataGridView1.Refresh();
        }

        /// <summary>
        /// Modificar el nombre de la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarNombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.i_cuenta.Text = "Modificar Nombre";
            this.i_cuenta.ShowDialog(this);
        }

        /// <summary>
        /// Modificar la contraseña de la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarContraseñaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.i_cuenta.Text = "Modificar Contraseña";
            this.i_cuenta.ShowDialog(this);
        }

        /// <summary>
        /// Agregar una nueva casilla de correo a la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.i_correo.Text = "Agregar Casilla";
            this.i_correo.ShowDialog(this);
        }

        /// <summary>
        /// Modificar los datos de la casilla de correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> _listaNombres = new List<string>();
            _listaNombres = _controlador.ObtenerNombreCasillas();
            if (_listaNombres.Count == 0)
            {
                MessageBox.Show("No tiene Casillas de Correo agregadas");
            }
            else
            {
                this.i_correo.Text = "Modificar Casilla";
                this.i_correo.ShowDialog(this);
            }
        }

        /// <summary>
        /// Eliminar una casilla de correo de la cuenta 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> _listaNombres = new List<string>();
            _listaNombres = _controlador.ObtenerNombreCasillas();
            if (_listaNombres.Count == 0)
            {
                MessageBox.Show("No tiene Casilla de Correo agregadas");
            }
            else
            {
                this.i_eliminarCasilla.Text = "Eliminar Casilla";
                this.i_eliminarCasilla.ShowDialog(this);
            }
            
        }

        /// <summary>
        /// Cerrar Sesión de la cuenta abierta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Cerrar Sesión?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this._cerrarSesion = true;
                this.Close();
            }
        }

        /// <summary>
        /// Salir de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Salir?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Información de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los íconos fueron tomados de http://dryicons.com");
        }

        /// <summary>
        /// Al cerrrar la ventana asigna los valores por defecto a la misma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void v_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._cerrarSesion)
            {
                (new v_login()).Show();
            }
            else
            {
                Application.Exit();
            }
            this.Width = 942;
            this.Height = 529;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(_controlador.ObtenerContraseñaCasilla(comboBox1.Text)=="vacia")
            {
                //No tiene contraseña almacenada
            }
            else
            {
                string _direccion = _controlador.ObtenerDireccionCasilla(this.comboBox1.Text);
                string _contraseña = _controlador.ObtenerContraseñaCasilla(this.comboBox1.Text);

                Pop3 _pop3 = new Pop3(_direccion,_contraseña, 995, "pop.gmail.com", true);
                List<OpenPop.Mime.Message> _listaMensajes = new List<OpenPop.Mime.Message>();
                _listaMensajes = _controlador.ObtenerMail(_pop3);
                if (_listaMensajes.Count >= 1)
                {
                    Console.WriteLine(_listaMensajes[0].Headers.To);
                }
                else
                {
                    Console.WriteLine("No hay mensajes. Count: " + _listaMensajes.Count.ToString());
                }
                
                //dataGridView1.DataSource = _listaMensajes;
                
            }
        }
    }
}
