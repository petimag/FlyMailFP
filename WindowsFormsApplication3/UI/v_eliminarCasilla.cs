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
    public partial class v_eliminarCasilla : Form
    {

        private Fachada _controlador = Fachada.Instancia;

        public v_eliminarCasilla()
        {
            InitializeComponent();
        }

        private void v_eliminarCasilla_Load(object sender, EventArgs e)
        {
            List<string> _listaNombres = new List<string>();
            _listaNombres = _controlador.obtenerNombreCasillas();
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

        private void button_guardar_Click(object sender, EventArgs e)
        {
            if (this.comboBox1_nombre.Text != String.Empty)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    this.Close();
                }
            }
        }
    }
}
