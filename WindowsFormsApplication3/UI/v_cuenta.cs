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
    public partial class v_cuenta : Form
    {
        public v_cuenta()
        {
            InitializeComponent();
        }

        private Fachada _controlador = Fachada.Instancia;

        /// <summary>
        /// Establece los formatos adecuados a la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void v_cuenta_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            if (this.Text == "Modificar Nombre")
            {
                this.textBox1.PasswordChar ='\0';
                this.label1.Text = "Nuevo Nombre:";
                this.label2.Visible = false;
                this.textBox2.Visible = false;
                this.label3.Text = "Contraseña:";
            }

            if (this.Text == "Modificar Contraseña")
            {
                this.textBox1.PasswordChar = '♦';
                this.label1.Text = "Contraseña Actual:";
                this.label2.Visible = true;
                this.textBox2.Visible = true;
                this.label2.Text = "Contraseña Nueva:";
                this.label3.Text = "Repetir Contraseña:";
            }
        }
        
        /// <summary>
        /// Guardo los cambios realizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Controla si se desea midificar el nombre del usuario
            if (this.Text == "Modificar Nombre")
            {
                if ((this.textBox1.Text=="")||(this.textBox3.Text == ""))
                {
                    MessageBox.Show("Falta completar campos obligatorios");
                }
                else
                {
                    //Verifica si ya existe en nombre de cuenta
                    if (_controlador.nombreExistenteCuenta(this.textBox1.Text))
                    {
                        MessageBox.Show("Nombre ya existente");
                    }
                    else
                    {
                        string _hash = Utilidades.Encriptar(string.Concat(_controlador.obtenerNombreCuenta(), this.textBox3.Text));
                        //Verifica si la contraseña es correcta
                        if (_controlador.obtenerContrasenaCuenta() !=_hash)
                        {
                            MessageBox.Show("Contraseña incorrecta");
                        }
                        else
                        {
                            _hash = Utilidades.Encriptar(string.Concat(this.textBox1.Text, this.textBox3.Text));
                            Cuenta _cuenta = new Cuenta(this.textBox1.Text, _hash);
                            _controlador.modificarNombreCuenta(_cuenta);
                            this.Close();
                        }
                        
                    }
                }
            }

            //Controla si se desea midificar la contraseña del usuario
            if (this.Text == "Modificar Contraseña")
            {
                if ((textBox1.Text=="")||(textBox2.Text == "")||(textBox3.Text == ""))
                {
                    MessageBox.Show("Falta completar campos obligatorios");
                }
                else
                {
                    //Nueva contraseña y repetir contraseña no coinciden
                    if (textBox2.Text != textBox3.Text)
                    {
                        MessageBox.Show("La nueva contraseña no coincide");
                    }
                    else
                    {
                        string hash1 = Utilidades.Encriptar(string.Concat(_controlador.obtenerNombreCuenta(), this.textBox1.Text));

                        //No coincide con la contraseña actual
                        if (!_controlador.verificarContraseña(hash1))
                        {
                            MessageBox.Show("La contraseña actual no coincide");
                        }
                        else
                        {
                            string hash2 = Utilidades.Encriptar(string.Concat(_controlador.obtenerNombreCuenta(), this.textBox2.Text));
                            _controlador.modificarContraseñaCuenta(hash2);
                            this.Close();
                        }
                    }
                }

            }
        }
    }
}
