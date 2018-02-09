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
        public v_eliminarCasilla()
        {
            InitializeComponent();
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
