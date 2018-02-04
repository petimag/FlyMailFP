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
    public partial class v_login : Form
    {
        private bool app_access = false;

        private Fachada _controlador = Fachada.Instancia;

        public v_login()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_iniciarFormClosed);
        }

        /// <summary>
        /// Asigna formato al campo "Nombre" para crear usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Click(object sender, EventArgs e)
        {
            this.textBox_crear_nombre.Text = "";
            this.textBox_crear_nombre.ForeColor = Color.Black;
        }

        /// <summary>
        /// Asigna formato al campo "Contraseña" para crear usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Contraseña_Click(object sender, EventArgs e)
        {
            this.textBox_crear_contraseña.Text = "";
            this.textBox_crear_contraseña.ForeColor = Color.Black;
            this.textBox_crear_contraseña.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Asigna formato al campo "Repetir contraseña" para crear usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_repetir_Click(object sender, EventArgs e)
        {
            this.textBox_crear_repetir.Text = "";
            this.textBox_crear_repetir.ForeColor = Color.Black;
            this.textBox_crear_repetir.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Permite el inicio de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_iniciar_Click(object sender, EventArgs e)
        {
            //Verifica que se ingrese nombre de usuario
            if (this.textBox_iniciar_contraseña.Text == "") 
            {
                MessageBox.Show("Falta ingresar Nombre");
            }
            else
            {
                //Verifica que se ingrese contraseña
                if (this.textBox_iniciar_nombre.Text == "")
                {
                    MessageBox.Show("Falta ingresar Contraseña");
                }
                else
                {
                    string hash = Utilidades.Encriptar(string.Concat(this.textBox_iniciar_nombre.Text, this.textBox_iniciar_contraseña.Text));
                    Console.WriteLine(hash);

                    //Verifica si el usuario esta en la bd
                    if (_controlador.verificarCuenta(this.textBox_iniciar_nombre.Text, hash) != -1)
                    {
                        _controlador.IDCuentaLogeado = _controlador.verificarCuenta(this.textBox_iniciar_nombre.Text, hash);
                        app_access = true;
                        this.Close();
                    }
                    else
                    {
                       // Console.WriteLine(_controlador.verificarCuenta(this.textBox_iniciar_nombre.Text, hash));
                        MessageBox.Show("Usuario o contraseña incorrecta");
                    }
                        
                }
            }
        }

        /// <summary>
        /// Permite crear una nueva cuenta de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_crear_Click(object sender, EventArgs e)
        {
            //Comprueba que se ingrese nombre de usuario
            if ((this.textBox_crear_nombre.Text == "") || (this.textBox_crear_nombre.Text == "Nombre"))
            {
                MessageBox.Show("Falta ingresar Nombre");
            }
            else
            {
                //Comprueba que se ingresa contraseña
                if ((this.textBox_crear_contraseña.Text == "") || (this.textBox_crear_contraseña.Text == "Contraseña"))
                {
                    MessageBox.Show("Falta ingresar Contraseña");
                }
                else
                {
                    //Comprueba que se ingresa la reiteración de la contraseña
                    if ((this.textBox_crear_repetir.Text == "") || (this.textBox_crear_repetir.Text == "Repetir Contraseña"))
                    {
                        MessageBox.Show("Falta ingresar Repetir Contraseña");
                    }
                    else
                    {
                        //Verifica que la contraseña y repetición sean iguales
                        if (this.textBox_crear_contraseña.Text != this.textBox_crear_repetir.Text)
                        {
                            MessageBox.Show("Contraseña incorrecta");
                        }
                        else
                        {
                            //Verifica si el nombre de usuario ya existe
                            if (!(_controlador.nombreExistenteCuenta(this.textBox_crear_nombre.Text)))
                            {
                                this.DialogResult = DialogResult.Yes;

                                string hash = Utilidades.Encriptar(string.Concat(this.textBox_crear_nombre.Text, this.textBox_crear_contraseña.Text));
                                Console.WriteLine(hash);
                                //Agregar usuario
                                _controlador.agregarCuenta(this.textBox_crear_nombre.Text, hash);
                                _controlador.IDCuentaLogeado = _controlador.verificarCuenta(this.textBox_crear_nombre.Text, hash);
                                app_access = true;
                                this.Close();
                            }
                            else
                                 MessageBox.Show("Nombre de usuario ya existente");
                        }
                    }                 
                }
            }
        }

        /// <summary>
        /// Iniciar la ventana principal o cerrar la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_iniciarFormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.app_access)
            {
                (new v_principal()).Show();
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
