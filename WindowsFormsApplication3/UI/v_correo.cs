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
    public partial class v_correo : Form
    {
        public v_correo()
        {
            InitializeComponent();
        }

        private Fachada _controlador = Fachada.Instancia;

        /// <summary>
        /// Método que le da formato a los campos de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void v_correo_Load(object sender, EventArgs e)
        {
            this.comboBox_servicio.Text = "Seleccionar";
            this.textBox_contraseña.Text = "";
            this.textBox_direccion.Text = "";
            if (this.Text == "Agregar Correo")
            {
                this.comboBox_servicio.Enabled = false;
                this.textBox_direccion.Enabled = false;
                this.textBox_contraseña.Enabled = false;
            }
            if (this.Text == "Nuevo Correo")
            {
                this.comboBox_servicio.Enabled = false;
                this.textBox_direccion.Enabled = false;
                this.textBox_contraseña.Enabled = false;
            }
            if (this.Text == "Modificar correo")
            {
                this.comboBox_servicio.Enabled = true;
                this.textBox_direccion.Enabled = true;
                this.textBox_contraseña.Enabled = true;
            }
        }

        /// <summary>
        /// Verifica si el nombre de correo aun no existe para dicha cuenta, habilitando los demás campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_verificar_Click(object sender, EventArgs e)
        {
            //Verifica que el nombre del correo no existe ya en esta cuenta
            if (!_controlador.nombreExistenteCasilla(this.textBox_nombre.Text))
            {
                this.comboBox_servicio.Enabled = true;
                this.textBox_direccion.Enabled = true;
                this.textBox_contraseña.Enabled = true;
                this.button_guardar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nombre de Casilla ya existente");
            }
            
        }

        /// <summary>
        /// Asigna los estados por defecto a la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void v_correo_FormClosing(object sender, FormClosingEventArgs e)
        {
            comboBox_servicio.Enabled = false;
            this.textBox_direccion.Enabled = false;
            this.textBox_contraseña.Enabled = false;
            this.Width = 300;
            this.Height = 279;
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            CasillaCorreo _casilla = new CasillaCorreo(textBox_nombre.Text,textBox_direccion.Text,textBox_contraseña.Text);
            int idServicio = _controlador.obtenerIdServicio(comboBox_servicio.Text);
            _controlador.agregarCasilla(_casilla, idServicio);
            this.Close();
        }
    }
}
