﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace FlyMail
{
    public partial class V_principal : Form
    {
        public V_principal()
        {
            InitializeComponent();
        }

        private Fachada _controlador = Fachada.Instancia;

        private bool _cerrarSesion = false;

        private V_mail i_mail = new V_mail();

        private V_leerMail v_LeerMail;

        private V_correo i_correo = new V_correo();

        private V_login i_login = new V_login();

        private V_cuenta i_cuenta = new V_cuenta();

        private V_eliminarCasilla i_eliminarCasilla = new V_eliminarCasilla();

        private string i_passwordCasilla = string.Empty;
        private bool i_guardarPasswordCasilla = false;
        private List<Mail> _listaMail;

        /// <summary>
        /// Establece los valores por defecto a la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void V_principal_Load(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.LightSkyBlue;
            button_enviados.BackColor = Color.PowderBlue;
            button_papelera.BackColor = Color.PowderBlue;

            this.comboBox1.Items.Clear();
            this.comboBox1.Text = "Seleccionar";
            this.comboBox1.Items.Add("Todos");
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            List<string> _listaDirecciones = new List<string>();
            _listaDirecciones = _controlador.ObtenerNombreCasillas();
            for (int i = 0; i < _listaDirecciones.Count; i++)
                this.comboBox1.Items.Add(_listaDirecciones[i]);
        }

        /// <summary>
        /// Asignación de la contraseña a una determinada casilla
        /// </summary>
        public string PasswordCasilla
        {
            set { this.i_passwordCasilla = value; }
        }

        /// <summary>
        /// Variable para verificar si se desea guardar la contraseña 
        /// </summary>
        public bool GuardarPasswordCasilla
        {
            set { this.i_guardarPasswordCasilla = value; }
        }

        /// <summary>
        /// Lista los mail "Recibidos"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_recibidos_Click(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.LightSkyBlue;
            button_enviados.BackColor = Color.PowderBlue;
            button_papelera.BackColor = Color.PowderBlue;

            //listar en el dataGridView1 los mail recibidos
            RefrescarDataGrid(ConvertirMailBox(MailBox.Recibidos));
        }

        /// <summary>
        /// Lista los mail "Enviados"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_enviados_Click(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.PowderBlue;
            button_enviados.BackColor = Color.LightSkyBlue;
            button_papelera.BackColor = Color.PowderBlue;

            //listar en el dataGridView1 los mail enviados
            RefrescarDataGrid(ConvertirMailBox(MailBox.Enviados));
        }

        /// <summary>
        /// Lista los mail de la papelera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_papelera_Click(object sender, EventArgs e)
        {
            button_recibidos.BackColor = Color.PowderBlue;
            button_enviados.BackColor = Color.PowderBlue;
            button_papelera.BackColor = Color.LightSkyBlue;

            //listar en el dataGridView1 los mail de la papelera
            RefrescarDataGrid(ConvertirMailBox(MailBox.Papelera));
        }

        /// <summary>
        /// Actualiza y descarga los mails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            string tipoMailBox = "";
            if (button_recibidos.BackColor == Color.LightSkyBlue)
                tipoMailBox = ConvertirMailBox(MailBox.Recibidos);
            else if (button_enviados.BackColor == Color.LightSkyBlue)
                tipoMailBox = ConvertirMailBox(MailBox.Enviados);
            else if (button_papelera.BackColor == Color.LightSkyBlue)
                tipoMailBox = ConvertirMailBox(MailBox.Papelera);
            this.RefrescarDataGrid(tipoMailBox);
        }

        /// <summary>
        /// Permite redactar un nuevo mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_enviar_Click(object sender, EventArgs e)
        {
            this.i_mail.Text = "Enviar Mail";
            this.i_mail.ShowDialog(this);
        }

        /// <summary>
        /// Eliminar el mail de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            //    string pISBN = ((Libro)dataGridView1.CurrentRow.DataBoundItem).ISBN;
            //    this.iBiblioteca.BajaLibro(pISBN);
            //    this.refrescarDataGrid();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_responder_Click(object sender, EventArgs e)
        {
            this.i_mail.Text = "Enviar Mail";
            this.i_mail.ShowDialog(this);
        }

        /// <summary>
        /// Actualizar la lista de los mail
        /// </summary>
        private void RefrescarDataGrid(string pMailBox)
        {
            this.dataGridView1.Rows.Clear();
            if (this.comboBox1.Text == "Seleccionar")
            {
                MessageBox.Show("Debe seleccionar una casilla de correos");
            }
            else
            {
                if (this.comboBox1.Text == "Todos")
                {
                    List<string> nombres = _controlador.ObtenerNombreCasillas();
                    for (int i = 1; i < nombres.Count; i++)
                    {
                        ListarMail(nombres[i], pMailBox);
                    }
                }
                else
                {
                    ListarMail(this.comboBox1.Text, pMailBox);
                }
                dataGridView1.Refresh();
            }
        }

        #region Opciones del Menú principal
        /// <summary>
        /// Modificar el nombre de la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModificarNombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.i_cuenta.Text = "Modificar Nombre";
            this.i_cuenta.ShowDialog(this);
        }

        /// <summary>
        /// Modificar la contraseña de la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModificarContraseñaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.i_cuenta.Text = "Modificar Contraseña";
            this.i_cuenta.ShowDialog(this);
        }

        /// <summary>
        /// Agregar una nueva casilla de correo a la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.i_correo.Text = "Agregar Casilla";
            this.i_correo.ShowDialog(this);
        }

        /// <summary>
        /// Modificar los datos de la casilla de correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> _listaNombres = new List<string>();
            _listaNombres = _controlador.ObtenerNombreCasillas();
            if (_listaNombres.Count == 0)
            {
                MessageBox.Show("No tiene Casillas de Correo agregadas");
            }
            else
            {
                this.i_correo.Text = "Modificar Casilla";
                this.i_correo.ShowDialog(this);
            }
        }

        /// <summary>
        /// Eliminar una casilla de correo de la cuenta 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> _listaNombres = new List<string>();
            _listaNombres = _controlador.ObtenerNombreCasillas();
            if (_listaNombres.Count == 0)
            {
                MessageBox.Show("No tiene Casilla de Correo agregadas");
            }
            else
            {
                this.i_eliminarCasilla.Text = "Eliminar Casilla";
                this.i_eliminarCasilla.ShowDialog(this);
            }

        }

        /// <summary>
        /// Cerrar Sesión de la cuenta abierta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Cerrar Sesión?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this._cerrarSesion = true;
                this.Close();
            }
        }

        /// <summary>
        /// Salir de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Salir?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Información de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los íconos fueron tomados de http://dryicons.com");
        }
        #endregion

        /// <summary>
        /// Al cerrrar la ventana asigna los valores por defecto a la misma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void V_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._cerrarSesion)
            {
                (new V_login()).Show();
            }
            else
            {
                Application.Exit();
            }
            this.Width = 942;
            this.Height = 529;
        }

        /// <summary>
        /// Analiza que mail se desea listar teniendo encuenta la opción seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _user = this.comboBox1.Text;
            if (_user != "Todos")
            {
                ObtenerMails(_user);
            }
            else // Obtener Todos los mails
            {
                List<string> nombres = _controlador.ObtenerNombreCasillas();
                for (int i = 1; i < nombres.Count; i++)
                {
                    ObtenerMails(nombres[i]);
                }   
            }

        }

        /// <summary>
        /// Almacena la contraseña de una determinada casilla
        /// </summary>
        /// <param name="user">Nombre de usuario de casilla de correo</param>
        /// <param name="pass">Cotraseña de casilla de correo</param>
        private void AlmacenarPasswordCasilla(string user, string pass)
        {
            string dir = _controlador.ObtenerDireccionCasilla(user);
            CasillaCorreo _casilla = new CasillaCorreo(user, dir, pass);
            _controlador.ModificarCasilla(_casilla);
        }

        /// <summary>
        /// Crea un formato mail
        /// </summary>
        /// <param name="pMensaje">Mensaje obtenido</param>
        /// <returns></returns>
        private Mail CrearMail(OpenPop.Mime.Message pMensaje)
        {
            //Remiente del Mail
            string _remitente = pMensaje.Headers.From.Address;
            string _destinatario = String.Empty;
            //Si hay 1 o mas destinatarios
            if (pMensaje.Headers.To.Count >= 1)
            {
                //Recorre la lista para ir agregando los destinatarios separados por una coma
                for (int j = 0; j < pMensaje.Headers.To.Count; j++)
                    _destinatario += pMensaje.Headers.To[j].Address + ",";
            }

            //Fecha del Mail
            string _fecha = string.Empty;
            if (pMensaje.Headers.Date != null)
                _fecha = pMensaje.Headers.Date.ToString();

            string _cc = string.Empty;
            //Si hay 1 o mas CC
            if (pMensaje.Headers.Cc.Count >= 1)
            {
                //Recorre la lista para ir agregando los CC separados por una coma
                for (int j = 0; j < pMensaje.Headers.Cc.Count; j++)
                    _cc = pMensaje.Headers.Cc[j].Address+",";
            }

            string _cco = string.Empty;
            //Si hay 1 o mas CCO
            if (pMensaje.Headers.Bcc.Count >= 1)
            {
                //Recorre la lista para ir agregando los CCO separados por una coma
                for (int j = 0; j < pMensaje.Headers.Bcc.Count; j++)
                    _cco = pMensaje.Headers.Bcc[j].Address+",";
            }

            string _mensaje = string.Empty;
            //Verifica si el Mail tiene mas de una parte
            if (pMensaje.MessagePart.IsMultiPart)
            {
                foreach (MessagePart _msgPart in pMensaje.MessagePart.MessageParts)
                    _mensaje += _msgPart.GetBodyAsText();
            }
            else if (pMensaje.MessagePart.IsText)
            {
                foreach (MessagePart _msgPart in pMensaje.MessagePart.MessageParts)
                    _mensaje += _msgPart.GetBodyAsText();
            }
            

            //Asunto del mail
            string _asunto = pMensaje.Headers.Subject;

            string _mailBox = ConvertirMailBox(MailBox.Recibidos);
            Mail _mail = new Mail(_remitente, _destinatario,_asunto,_cc,_cco,_fecha,_mensaje,_mailBox,false);
            return _mail;
        }

        /// <summary>
        /// Analiza el tipo de mail y devuelve un string
        /// </summary>
        /// <param name="pMailBox"></param>
        /// <returns></returns>
        private string ConvertirMailBox(MailBox pMailBox)
        {
            if (pMailBox == MailBox.Recibidos)
            {
                return Convert.ToString(MailBox.Recibidos);
            }
            else if(pMailBox == MailBox.Enviados)
            {
                return Convert.ToString(MailBox.Enviados);
            }
            else if (pMailBox == MailBox.Borradores)
            {
                return Convert.ToString(MailBox.Borradores);
            }
            else
            {
                return Convert.ToString(MailBox.Papelera);
            }
        }

        /// <summary>
        /// Obtiene los mail nuevos que tiene una casilla de correo
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de Usuario</param>
        private void ObtenerMails(string pNombreUsuario)
        {
            int _idCasilla = _controlador.ObtenerIdCasilla(pNombreUsuario);
            string _direccion = _controlador.ObtenerDireccionCasilla(pNombreUsuario);
            string _contraseña = _controlador.ObtenerContraseñaCasilla(pNombreUsuario);

            if (_contraseña == "vacia")
            {
                (new V_ingresarPasswordCasilla(pNombreUsuario)).ShowDialog(this);
                _contraseña = this.i_passwordCasilla;
                if (this.i_guardarPasswordCasilla)
                    this.AlmacenarPasswordCasilla(pNombreUsuario, _contraseña);

                this.i_passwordCasilla = string.Empty;
                this.i_guardarPasswordCasilla = false;
            }

            int _idServicio = _controlador.ObtenerIdServicio(_idCasilla);
            Servicio _servicio = _controlador.ObtenerServicio(_idServicio,"pop");
            ControladorPOP3 _pop3 = new ControladorPOP3(_direccion, _contraseña, _servicio.Ip, _servicio.Puerto, _servicio.SSL);
            List<OpenPop.Mime.Message> _listaMensajes = new List<OpenPop.Mime.Message>();
            _listaMensajes = _controlador.ObtenerMail(_pop3);
            if (_listaMensajes.Count >= 1)
            {
                for (int i = 0; i < _listaMensajes.Count; i++)
                {
                    Mail _mail = CrearMail(_listaMensajes[i]);
                    _controlador.GuardarMail(_mail, _idCasilla);
                }
            }

            RefrescarDataGrid(ConvertirMailBox(MailBox.Recibidos));
        }

        /// <summary>
        /// Lista los mail almacenados
        /// </summary>
        /// <param name="pNombreUsuario">Nombre de Usuario</param>
        /// <param name="pMailBox">Tipo de Mail</param>
        private void ListarMail(string pNombreUsuario, string pMailBox)
        {
            int _idCasilla = _controlador.ObtenerIdCasilla(pNombreUsuario);
            _listaMail = _controlador.ListarMail(_idCasilla, pMailBox);
            this.dataGridView1.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            foreach (var _mail in _listaMail)
            {
                if (_mail != null)
                {
                    String[] row = new String[] { Convert.ToString(false), _mail.Remitente, _mail.Asunto, _mail.Fecha };
                    this.dataGridView1.Rows.Add(row);
                    if (!_mail.Leido)
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle = columnHeaderStyle;
                    }
                }
            }
        }

        /// <summary>
        /// Método que se activa al seleccionar una o varias filas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex != 0)
            {
                Mail _mail = new Mail(_listaMail[e.RowIndex].IdMail, _listaMail[e.RowIndex].Remitente, _listaMail[e.RowIndex].Destinatario, _listaMail[e.RowIndex].Asunto, _listaMail[e.RowIndex].CC, _listaMail[e.RowIndex].CCO, _listaMail[e.RowIndex].Fecha, _listaMail[e.RowIndex].Mensaje, _listaMail[e.RowIndex].TipoMail, _listaMail[e.RowIndex].Leido);
                v_LeerMail = new V_leerMail(_mail);
                if (!_mail.Leido)
                    _controlador.ModificarEstadoLeido(_mail.IdMail);
                this.v_LeerMail.Show();
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(((DataGridViewCheckBoxCell)dataGridView1.CurrentCell).Value) == true)
                {
                    this.button_eliminar.Enabled = true;
                }
                
            }
        }
    }
}
