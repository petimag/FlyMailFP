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
    public partial class V_leerMail : Form
    {
        public V_leerMail(Mail pMail)
        {
            InitializeComponent();
            this.textBox_de.Text = pMail.Remitente;
            this.textBox_de.ReadOnly = true;
            this.textBox_para.Text = pMail.Destinatario;
            this.textBox_para.ReadOnly = true;
            this.textBox_asunto.Text = pMail.Asunto;
            this.textBox_asunto.ReadOnly = true;
            this.richTextBox_texto.Text = pMail.Asunto;
            this.richTextBox_texto.ReadOnly = true;
            if ((pMail.CC == string.Empty)&&(pMail.CCO == string.Empty))
            {
                this.label_CC.Visible = false;
                this.textBox_CC.Visible = false;
                this.label_CCO.Visible = false;
                this.textBox_CCO.Visible = false;
            }
            else
            {
                this.label_CC.Visible = true;
                this.textBox_CC.Visible = true;
                this.textBox_CC.Text = pMail.CC;
                this.label_CCO.Visible = true;
                this.textBox_CCO.Visible = true;
                this.textBox_CCO.Text = pMail.CCO;
            }
        }

        private void Button_responder_Click(object sender, EventArgs e)
        {

        }
    }
}
