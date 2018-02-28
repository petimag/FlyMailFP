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
    public partial class V_login : Form
    {
        private bool app_access = false;

        private Fachada _controlador = Fachada.Instancia;

        public V_login()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_iniciarFormClosed);
        }

        /// <summary>
        /// Cambia el foco del botón Iniciar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_iniciar_Focus(object sender, EventArgs e)
        {
            this.AcceptButton = this.button_iniciar;
        }

        /// <summary>
        /// Asigna formato al campo "Nombre" para crear usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_crear_nombre_Focus(object sender, EventArgs e)
        {
            this.textBox_crear_nombre.Text = "";
            this.textBox_crear_nombre.ForeColor = Color.Black;
            this.AcceptButton = this.button_crear;
        }

        /// <summary>
        /// Asigna formato al campo "Nombre" cuando se pierde el foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_crear_nombre_noFocus(object sender, EventArgs e)
        {
            if (this.textBox_crear_nombre.Text == "")
            {
                this.textBox_crear_nombre.Text = "Nombre";
                this.textBox_crear_nombre.ForeColor = Color.LightGray;
            }

        }

        /// <summary>
        /// Asigna formato al campo "Contraseña" para crear usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Contraseña_Focus(object sender, EventArgs e)
        {
            this.textBox_crear_contraseña.Text = "";
            this.textBox_crear_contraseña.ForeColor = Color.Black;
            this.textBox_crear_contraseña.PasswordChar = '•';
        }

        /// <summary>
        /// Asigna formato al campo "Contraseña" cuando se pierde el foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Contraseña_noFocus(object sender, EventArgs e)
        {
            if (this.textBox_crear_contraseña.Text == "")
            {
                this.textBox_crear_contraseña.PasswordChar = '\0';
                this.textBox_crear_contraseña.Text = "Contraseña";
                this.textBox_crear_contraseña.ForeColor = Color.LightGray;
            }
        }

        /// <summary>
        /// Asigna formato al campo "Repetir contraseña" para crear usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_repetir_Focus(object sender, EventArgs e)
        {
            this.textBox_crear_repetir.Text = "";
            this.textBox_crear_repetir.ForeColor = Color.Black;
            this.textBox_crear_repetir.PasswordChar = '•';
        }

        /// <summary>
        /// Asigna formato al campo "Repetir" cuando se pierde el foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_repetir_noFocus(object sender, EventArgs e)
        {
            if (this.textBox_crear_repetir.Text == "")
            {
                this.textBox_crear_repetir.PasswordChar = '\0';
                this.textBox_crear_repetir.Text = "Repetir Contraseña";
                this.textBox_crear_repetir.ForeColor = Color.LightGray;
            }
        }

        /// <summary>
        /// Permite el inicio de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_iniciar_Click(object sender, EventArgs e)
        {
            //Verifica que se ingrese nombre de usuario
            if (this.textBox_iniciar_nombre.Text == "") 
            {
                MessageBox.Show("Falta ingresar Nombre");
            }
            else
            {
                //Verifica que se ingrese contraseña
                if (this.textBox_iniciar_contraseña.Text == "")
                {
                    MessageBox.Show("Falta ingresar Contraseña");
                }
                else
                {
                    string hash = Utilidades.Encriptar(string.Concat(this.textBox_iniciar_nombre.Text, this.textBox_iniciar_contraseña.Text));

                    //Verifica si el usuario esta en la bd
                    Cuenta _cuenta = new Cuenta(this.textBox_iniciar_nombre.Text, hash);
                    if (_controlador.VerificarCuenta(_cuenta) != -1)
                    {
                        _controlador.IDCuentaLogeado = _controlador.VerificarCuenta(_cuenta);
                        app_access = true;
                        this.Close();
                    }
                    else
                    {
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
        private void Button_crear_Click(object sender, EventArgs e)
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
                            if (!(_controlador.NombreExistenteCuenta(this.textBox_crear_nombre.Text)))
                            {
                                this.DialogResult = DialogResult.Yes;

                                string hash = Utilidades.Encriptar(string.Concat(this.textBox_crear_nombre.Text, this.textBox_crear_contraseña.Text));

                                //Agregar usuario
                                Cuenta _cuenta = new Cuenta(this.textBox_crear_nombre.Text, hash);
                                _controlador.AgregarCuenta(_cuenta);

                                _controlador.IDCuentaLogeado = _controlador.VerificarCuenta(_cuenta);
                                app_access = true;
                                this.Close();
                            }
                            else
                                 MessageBox.Show("El nombre de usuario ya existe");
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
                (new V_principal()).Show();
            }
            else
            {
                Application.Exit();
            }

        }

        /// <summary>
        /// Cambia el foco del botón Iniciar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_iniciar_Click(object sender, EventArgs e)
        {
            this.AcceptButton = this.button_iniciar;
        }

        /// <summary>
        /// Cambia el foco al botón crear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_crear_contraseña_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button_crear;
        }

        /// <summary>
        /// Cambia el foco al botón crear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_crear_repetir_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button_crear;
        }
    }
}
