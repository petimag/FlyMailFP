using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace UI
{
    public partial class V_ingresarPasswordCasilla : Form
    {
        /// <summary>
        /// Inicializa la ventana
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de usuario de casilla</param>
        public V_ingresarPasswordCasilla(string pNombreUsuario)
        {
            InitializeComponent();
            textBox2.Text = pNombreUsuario;
            textBox1.Text = string.Empty;
        }

        /// <summary>
        /// Aceptar los cambios realizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != string.Empty)
            {
                V_principal v_pri = (V_principal)this.Owner;
                v_pri.PasswordCasilla = this.textBox1.Text;
                if (this.checkBox1.Checked == true)
                    v_pri.GuardarPasswordCasilla = true;
            }
            this.Close();
        }
        
        /// <summary>
        /// Cancela la operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
