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

        private bool _estado_cc_cco;

        private void v_mail_Load(object sender, EventArgs e)
        {
            this._estado_cc_cco = false;
            CambiarCC_CCO();
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
                Mail _mail = new Mail(this.textBox_direccion.Text, textBox_para.Text,textBox_asunto.Text, "","",Convert.ToString(DateTime.Today),this.richTextBox_texto.Text,Convert.ToString(MailBox.Enviados),true);
                _controlador.GuardarMail(_mail, idCasilla);
                string _contraseña = _controlador.ObtenerContraseñaCasilla(this.comboBox_de.Text);
                int idServicio = _controlador.ObtenerIdServicio(idCasilla);
                Servicio _servicio = _controlador.ObtenerServicio(idServicio,"smtp");
                //Console.WriteLine(this.textBox_direccion.Text+_contraseña+ _servicio.Ip+ _servicio.Puerto+ _servicio.SSL);
                ControladorSMTP _controladorSMTP = new ControladorSMTP(this.textBox_direccion.Text, _contraseña, _servicio.Ip, _servicio.Puerto, _servicio.SSL);
                _controlador.EnviarMail(_controladorSMTP, _mail);
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
            _estado_cc_cco = !_estado_cc_cco;
            CambiarCC_CCO();
        }

        private void comboBox_de_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox_direccion.Text = _controlador.ObtenerDireccionCasilla(this.comboBox_de.Text);
        }

        private void CambiarCC_CCO()
        {
            int _valorX = this.richTextBox_texto.Size.Width;
            if (_estado_cc_cco)
            {
                this.groupBox1.Height = 160;
                this.label_CC.Visible = true;
                this.textBox_CC.Visible = true;
                this.label_CCO.Visible = true;
                this.textBox_CCO.Visible = true;
                this.richTextBox_texto.Location = new System.Drawing.Point(12, 178);
                int _valorY = this.Height - this.richTextBox_texto.Location.Y-97;
                this.richTextBox_texto.Size = new System.Drawing.Size(_valorX, _valorY);
            }
            else
            {
                this.groupBox1.Height = 115;
                this.label_CC.Visible = false;
                this.textBox_CC.Visible = false;
                this.label_CCO.Visible = false;
                this.textBox_CCO.Visible = false;
                this.richTextBox_texto.Location = new System.Drawing.Point(12, 133);
                int _valorY = this.Height - this.richTextBox_texto.Location.Y - 97;
                this.richTextBox_texto.Size = new System.Drawing.Size(_valorX, _valorY);
            }
        }
    }
}
