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
    public partial class v_principal : Form
    {
        public v_principal()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_ventaEntradaFormClosed);
        }

        private bool _salir = true;

        private v_mail i_mail = new v_mail();

        private v_correo i_correo = new v_correo();

        //        private v_login i_login = new v_login();

        private void UI_ventaEntradaFormClosed(object sender, FormClosedEventArgs e)
        {
            if (this._salir)
                Application.Exit();
        }

        private void button_recibidos_Click(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.LightSkyBlue;
            button_borradores.BackColor = Color.PowderBlue;
            button_enviados.BackColor = Color.PowderBlue;
            button_papelera.BackColor = Color.PowderBlue;
        }

        private void button_borradores_Click(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.PowderBlue;
            button_borradores.BackColor = Color.LightSkyBlue;
            button_enviados.BackColor = Color.PowderBlue;
            button_papelera.BackColor = Color.PowderBlue;
        }

        private void button_enviados_Click(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.PowderBlue;
            button_borradores.BackColor = Color.PowderBlue;
            button_enviados.BackColor = Color.LightSkyBlue;
            button_papelera.BackColor = Color.PowderBlue;
        }

        private void button_papelera_Click(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.PowderBlue;
            button_borradores.BackColor = Color.PowderBlue;
            button_enviados.BackColor = Color.PowderBlue;
            button_papelera.BackColor = Color.LightSkyBlue;
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los íconos fueron tomados de http://dryicons.com");
        }

        private void button_enviar_Click(object sender, EventArgs e)
        {
            this.i_mail.Text = "Enviar Mail";
            this.i_mail.ShowDialog(this);
        }

        private void button_responder_Click(object sender, EventArgs e)
        {
            this.i_mail.Text = "Enviar Mail";
            this.i_mail.ShowDialog(this);
        }

        private void refrescarDataGrid()
        {
  //          dataGridView1.DataSource = this.iCorreo.Libros;
            dataGridView1.Refresh();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            this.i_mail.Text = "Leer Mail";
            this.i_mail.ShowDialog(this);
        //    string pISBN = ((Libro)dataGridView1.CurrentRow.DataBoundItem).ISBN;
        //    this.iBiblioteca.BajaLibro(pISBN);
        //    this.refrescarDataGrid();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            this.refrescarDataGrid();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.i_correo.Text = "Nuevo correo";
            this.i_correo.ShowDialog(this);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.i_correo.Text = "Modificar correo";
            this.i_correo.ShowDialog(this);
        }

        private void v_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Width = 942;
            this.Height = 529;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            this.Close();
//            this.i_login.ShowDialog(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
