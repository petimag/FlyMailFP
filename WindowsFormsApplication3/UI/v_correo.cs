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
            this.textBox_nombre.Text = "";
            this.comboBox1_nombre.Text = "";
            this.textBox_contraseña.Text = "";
            this.textBox_direccion.Text = "";
            if (this.Text == "Agregar Casilla")
            {
                this.label3.Visible = true;
                this.label2.Visible = true;
                this.comboBox1_nombre.Visible = false;
                this.textBox_nombre.Visible = true;
                this.button_verificar.Text = "Verificar";
                this.comboBox_servicio.Text = "Seleccionar";
                this.comboBox_servicio.Enabled = false;
                this.textBox_direccion.Enabled = false;
                this.textBox_contraseña.Enabled = false;
                this.comboBox_servicio.Visible = true;
                this.textBox_direccion.Visible = true;
            }
            if (this.Text == "Modificar Casilla")
            {
                this.label3.Visible = true;
                this.label2.Visible = true;
                this.comboBox1_nombre.Visible = true;
                this.comboBox1_nombre.Text = "";
                List<string> _listaNombres = new List<string>();
                _listaNombres = _controlador.obtenerNombreCasillas();
                for (int i = 0; i < _listaNombres.Count; i++)
                    this.comboBox1_nombre.Items.Add(_listaNombres[i]);
                this.textBox_nombre.Visible = false;
                this.comboBox_servicio.Text = "";
                this.button_verificar.Text = "Buscar";
                this.comboBox_servicio.Enabled = false;
                this.textBox_direccion.Enabled = false;
                this.textBox_contraseña.Enabled = false;
                this.comboBox_servicio.Visible = true;
                this.textBox_direccion.Visible = true;
            }
            if(this.Text == "Eliminar Casilla")
            {
                this.label3.Visible = false;
                this.label2.Visible = false;
                this.comboBox1_nombre.Visible = true;
                this.comboBox1_nombre.Text = "";
                this.textBox_nombre.Visible = false;
                this.comboBox_servicio.Text = "";
                this.button_verificar.Text = "Buscar";
                this.comboBox_servicio.Visible = false;
                this.textBox_direccion.Visible = false;
                this.textBox_contraseña.Enabled = false;
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
            if (button_verificar.Text=="Verificar")
            {
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
            if (button_verificar.Text == "Buscar")
            {
                if (_controlador.obtenerDireccionCasilla(this.comboBox1_nombre.Text) != String.Empty)
                {
                    this.textBox_direccion.Enabled = true;
                    this.textBox_direccion.Text = _controlador.obtenerDireccionCasilla(this.comboBox1_nombre.Text);
                    this.textBox_contraseña.Enabled = true;
                    this.textBox_contraseña.PasswordChar = '\0';
                    this.textBox_contraseña.Text = "Si desea realizar cambios";
                    this.button_guardar.Enabled = true;
                    
                }
            }


        }

        private void textBox_contraseña_Focus(object sender, EventArgs e)
        {
            if (this.Text == "Modificar Casilla")
            {
                this.textBox_contraseña.Text = "";
                this.textBox_contraseña.ForeColor = Color.Black;
                this.textBox_contraseña.PasswordChar = '♦';
            }
        }

        private void textBox_contraseña_noFocus(object sender, EventArgs e)
        {
            if ((this.textBox_contraseña.Text == "") && (this.Text == "Modificar Casilla"))
            {
                this.textBox_contraseña.PasswordChar = '\0';
                this.textBox_contraseña.Text = "Si desea realizar cambios";
                this.textBox_contraseña.ForeColor = Color.LightGray;
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
            if (this.Text == "Agregar Casilla")
            {
                CasillaCorreo _casilla = new CasillaCorreo(this.textBox_nombre.Text,this.textBox_direccion.Text, this.textBox_contraseña.Text);
                int idServicio = _controlador.obtenerIdServicio(comboBox_servicio.Text);
                _controlador.agregarCasilla(_casilla, idServicio);
            }

            if (this.Text=="Modificar Casilla")
            {
                CasillaCorreo _casilla = new CasillaCorreo(this.comboBox1_nombre.Text, this.textBox_direccion.Text, this.textBox_contraseña.Text);
                if (this.textBox_contraseña.Text=="Si desea realizar cambios")
                {
                    _casilla.Contraseña = String.Empty;
                }
                _controlador.modificarCasilla(_casilla);
            }
            this.Close();
        }

        private void textBox_direccion_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button_guardar;
        }

        private void textBox_contraseña_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button_guardar;
        }

        private void comboBox1_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
