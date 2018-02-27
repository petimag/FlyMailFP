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
    public partial class V_mail : Form
    {
        private Mail _mail;

        private Fachada _controlador = Fachada.Instancia;

        private bool _estado_cc_cco;

        private int idCasilla = -1;

        private bool _responder;

        private bool _reenviar;

        /// <summary>
        /// Inicializador de la ventana para enviar un mail
        /// </summary>
        public V_mail()
        {
            InitializeComponent();
            _responder = false;
            _reenviar = false;
        }

        /// <summary>
        /// Inicializador de la ventana para responder un mail
        /// </summary>
        /// <param name="pDestinatario"></param>
        /// <param name="pRemitente"></param>
        public V_mail(string pDestinatario, string pAsunto)
        {
            InitializeComponent();
            _responder = true;
            _reenviar = false;
            _mail = new Mail("", pDestinatario,pAsunto, "", "", "", "", "", true);
        }

        public V_mail(Mail pMail)
        {
            InitializeComponent();
            _responder = false;
            _reenviar = true;
            _mail = new Mail("","", "Fwd: " + pMail.Asunto, "", "", "", "-*-*-*-*- Mensaje Reenviado -*-*-*-*- \n De: " + pMail.Remitente + "\n Fecha: " + pMail.Fecha + "\n Asunto: "+ pMail.Asunto + "\n Para: " +pMail.Destinatario + "\n \n" + pMail.Mensaje,"", true);
        }
        /// <summary>
        /// Establece los valores por defecto de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void V_mail_Load(object sender, EventArgs e)
        {
            this.Width = 666;
            this.Height = 567;
            this._estado_cc_cco = false;
            CambiarCC_CCO();

            if (_responder)
            {
                this.textBox_para.Text = _mail.Destinatario;
                this.textBox_para.ReadOnly = true;
                this.textBox_asunto.Text = _mail.Asunto;
                this.richTextBox_texto.Text = "";
            }
            else if (_reenviar)
            {
                this.textBox_asunto.Text = _mail.Asunto;
                this.richTextBox_texto.Text = _mail.Mensaje;
            }
            else
            {             
                this.textBox_para.Text = "";
                this.textBox_asunto.Text = "";
                this.richTextBox_texto.Text = "";
            }
            ListarNombresCasillas();
            this.textBox_direccion.ReadOnly = true;
            this.textBox_direccion.Text = "";
            
        }

        /// <summary>
        /// Lista los nombre de la casilla
        /// </summary>
        private void ListarNombresCasillas()
        {
            this.comboBox_de.Items.Clear();
            this.comboBox_de.Text = "Seleccionar";
            List<string> _listaNombres = new List<string>();
            _listaNombres = _controlador.ObtenerNombreCasillas();
            for (int i = 0; i<_listaNombres.Count; i++)
                this.comboBox_de.Items.Add(_listaNombres[i]);
        }

        /// <summary>
        /// Método para enviar el mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_enviar_Click(object sender, EventArgs e)
        {
            //Verificar si se puede enviar
            if((this.textBox_direccion.Text == String.Empty)||(this.textBox_para.Text == String.Empty)||(this.textBox_asunto.Text==String.Empty)||(this.richTextBox_texto.Text==String.Empty))
            {
                MessageBox.Show("Hay campos obligatorios nulos");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea enviar el mail?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    idCasilla = _controlador.ObtenerIdCasilla(this.comboBox_de.Text);
                    Mail _mail = CrearMail(MailBox.Enviados);
                    _controlador.GuardarMail(_mail, idCasilla);
                    string _contraseña = _controlador.ObtenerContraseñaCasilla(this.comboBox_de.Text);
                    int idServicio = _controlador.ObtenerIdServicio(idCasilla);
                    Servicio _servicio = _controlador.ObtenerServicio(idServicio, "smtp");
                    ControladorSMTP _controladorSMTP = new ControladorSMTP(this.textBox_direccion.Text, _contraseña, _servicio.Ip, _servicio.Puerto, _servicio.SSL);
                    _controlador.EnviarMail(_controladorSMTP, _mail);
                    MessageBox.Show("Mail Enviado");
                    this.Close();
                }
            }   
        }

        /// <summary>
        /// Método que cancela el envío de mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_cancelar_Click(object sender, EventArgs e)
        {
            if ((this.textBox_direccion.Text == String.Empty) & (this.textBox_para.Text == String.Empty) & (this.textBox_asunto.Text == String.Empty) & (this.richTextBox_texto.Text == String.Empty))
            {
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea guardar el mail en la papelera?", "Confirmación", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    Mail _mail = CrearMail(MailBox.Papelera);
                    _controlador.GuardarMail(_mail, idCasilla);
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            
        }

        /// <summary>
        /// Activa o desactiva la opción de CC y CCO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _estado_cc_cco = !_estado_cc_cco;
            CambiarCC_CCO();
        }

        /// <summary>
        /// Método que muestra la dirección de mail de la cuenta seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_de_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox_direccion.Text = _controlador.ObtenerDireccionCasilla(this.comboBox_de.Text);
        }

        /// <summary>
        /// Oculta o muestra las opciones CCC/CCO y cambia el formato de la ventana 
        /// </summary>
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

        /// <summary>
        /// Crea un Mail a enviar o almacenar en la papelera
        /// </summary>
        /// <param name="_mailBox">Tipo de mail</param>
        /// <returns></returns>
        private Mail CrearMail(MailBox _mailBox)
        {
            Mail _mail;
            if (_estado_cc_cco)
            {
                _mail = new Mail(this.textBox_direccion.Text, textBox_para.Text, textBox_asunto.Text, this.textBox_CC.Text, this.textBox_CCO.Text, Convert.ToString(DateTime.Today), this.richTextBox_texto.Text, Convert.ToString(_mailBox), true);
            }
            else
            {
                _mail = new Mail(this.textBox_direccion.Text, textBox_para.Text, textBox_asunto.Text, "", "", Convert.ToString(DateTime.Today), this.richTextBox_texto.Text, Convert.ToString(_mailBox), true);
            }
            return _mail;
        }
    }
}