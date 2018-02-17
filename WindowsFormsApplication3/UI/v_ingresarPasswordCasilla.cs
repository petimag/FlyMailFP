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
    public partial class v_ingresarPasswordCasilla : Form
    {
        public v_ingresarPasswordCasilla()
        {
            InitializeComponent();
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != string.Empty)
            {
                v_principal v_pri = (v_principal)this.Owner;
                v_pri.PasswordCasilla = this.textBox1.Text;
                if (this.checkBox1.Checked == true)
                    v_pri.GuardarPasswordCasilla = true;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
