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

        private void button_enviar_Click(object sender, EventArgs e)
        {
            //Verificar si se puede enviar
            MessageBox.Show("Mail Enviado");
            this.Close();
        }

        private void v_mail_Load(object sender, EventArgs e)
        {
            if (this.Text == "Enviar Mail")
            {
                this.button_eliminar.Visible = false;
                this.button_enviar.Visible = true;
                this.button_guardar.Visible = false;
                this.button_responder.Visible = false;
            }

            if (this.Text == "Leer Mail")
            {
                this.button_eliminar.Visible = true;
                this.button_enviar.Visible = false;
                this.button_guardar.Visible = false;
                this.button_responder.Visible = true;
            }
        }

        private void v_mail_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Width = 588;
            this.Height = 439;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea descartar el mail?","Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();

        }
    }
}
