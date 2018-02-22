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
    public partial class v_mail : Form
    {
        public v_mail()
        {
            InitializeComponent();
        }

        private Fachada _controlador = Fachada.Instancia;

        private void v_mail_Load(object sender, EventArgs e)
        {
            this.comboBox_de.Items.Clear();
            this.comboBox_de.Text = "Seleccionar";
            List<string> _listaNombres = new List<string>();
            _listaNombres = _controlador.ObtenerNombreCasillas();
            for (int i = 0; i < _listaNombres.Count; i++)
                this.comboBox_de.Items.Add(_listaNombres[i]);
            this.textBox_direccion.Text = "";
            this.textBox_para.Text = "";
            this.textBox_asunto.Text = "";
            this.richTextBox_texto.Text = "";
            this.button_guardar.Visible = false;
        }
        private void button_enviar_Click(object sender, EventArgs e)
        {
            //Verificar si se puede enviar
            if((this.comboBox_de.Text == String.Empty)||(this.textBox_para.Text == String.Empty)||(this.textBox_asunto.Text==String.Empty)||(this.richTextBox_texto.Text==String.Empty))
            {
                MessageBox.Show("Hay campos obligatorios nulos");
            }
            else
            {
                int idCasilla = _controlador.ObtenerIdCasilla(this.comboBox_de.Text);
                /*_controlador.GuardarMail();
                _controlador.enviarMail();*/
                MessageBox.Show("Mail Enviado");
                this.Close();
            }
            
        }



        private void v_mail_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Width = 666;
            this.Height = 567;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea descartar el mail?","Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void comboBox_de_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox_direccion.Text = _controlador.ObtenerDireccionCasilla(this.comboBox_de.Text);
        }
    }
}
