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
    public partial class V_eliminarCasilla : Form
    {

        private Fachada _controlador = Fachada.Instancia;

        public V_eliminarCasilla()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa la ventana, agregando los Nombres de Casilla del usuario al ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void V_eliminarCasilla_Load(object sender, EventArgs e)
        {
            List<string> _listaNombres = new List<string>();
            _listaNombres = _controlador.ObtenerNombreCasillas();
            this.comboBox1_nombre.Items.Clear();
            this.comboBox1_nombre.Text = string.Empty;
            this.comboBox1_nombre.DropDownStyle = ComboBoxStyle.DropDownList;
            if (_listaNombres.Count == 0)
            {
                MessageBox.Show("No tiene Casilla de Correo agregadas");
            }
            else
            {
                for (int i = 0; i < _listaNombres.Count; i++)
                    this.comboBox1_nombre.Items.Add(_listaNombres[i]);
            }
            
        }

        /// <summary>
        /// Elimina una Casilla de Correo al hacer click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_guardar_Click(object sender, EventArgs e)
        {
            if (this.comboBox1_nombre.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (_controlador.EliminarCasilla(this.comboBox1_nombre.Text))
                    {
                        MessageBox.Show("Casilla eliminada con éxito", "FlyMail");
                        this.Close();
                    }
                    
                }
            }
        }
    }
}
