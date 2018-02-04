using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyMail
{
    public partial class v_principal : Form
    {
        public v_principal()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_ventaEntradaFormClosed);
        }

        private bool _salir = true;

        private v_mail i_mail = new v_mail();

        private v_correo i_correo = new v_correo();

        //private v_login i_login = new v_login();

        private void UI_ventaEntradaFormClosed(object sender, FormClosedEventArgs e)
        {
            if (this._salir)
                Application.Exit();
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
        /// Modificar la cuenta del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Eliminar la cuenta de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Agregar una nueva casilla de correo a la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.i_correo.Text = "Nuevo correo";
            this.i_correo.ShowDialog(this);
        }

        /// <summary>
        /// Modificar los datos de la casilla de correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.i_correo.Text = "Modificar correo";
            this.i_correo.ShowDialog(this);
        }

        /// <summary>
        /// Eliminar una casilla de correo de la cuenta 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Cerrar Sesión de la cuenta abierta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            this.Close();
            //            this.i_login.ShowDialog(this);
        }

        /// <summary>
        /// Salir de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.Width = 942;
            this.Height = 529;
        }
    }
}
