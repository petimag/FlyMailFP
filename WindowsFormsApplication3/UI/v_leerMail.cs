﻿using System;
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
        private Mail _mail;

        private bool _estado_cc_cco;

        public V_leerMail(Mail pMail)
        {
            InitializeComponent();
            _mail = pMail;
            this._estado_cc_cco = false;
            CambiarCC_CCO();
            this.textBox_de.Text = _mail.Remitente;
            this.textBox_de.ReadOnly = true;
            this.textBox_para.Text = _mail.Destinatario;
            this.textBox_para.ReadOnly = true;
            this.textBox_asunto.Text = _mail.Asunto;
            this.textBox_asunto.ReadOnly = true;
            this.richTextBox_texto.Text = _mail.Asunto;
            this.richTextBox_texto.ReadOnly = true;
            if ((_mail.CC == string.Empty)&&(_mail.CCO == string.Empty))
            {
                this.linkLabel1.Visible = false;
                this.label_CC.Visible = false;
                this.textBox_CC.Visible = false;
                this.label_CCO.Visible = false;
                this.textBox_CCO.Visible = false;
            }
            else
            {
                this.linkLabel1.Visible = true;
                this.label_CC.Visible = true;
                this.textBox_CC.Visible = true;
                this.textBox_CC.Text = _mail.CC;
                this.label_CCO.Visible = true;
                this.textBox_CCO.Visible = true;
                this.textBox_CCO.Text = _mail.CCO;
            }
        }

        private void Button_responder_Click(object sender, EventArgs e)
        {
            V_mail v_mail = new V_mail(_mail.Remitente,_mail.Destinatario);
            v_mail.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _estado_cc_cco = !_estado_cc_cco;
            CambiarCC_CCO();
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
                int _valorY = this.Height - this.richTextBox_texto.Location.Y - 97;
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
