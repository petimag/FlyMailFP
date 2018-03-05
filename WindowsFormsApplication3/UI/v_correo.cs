﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace UI
{
    public partial class V_correo : Form
    {
        public V_correo()
        {
            InitializeComponent();
        }

        private Fachada _controlador = Fachada.Instancia;

        /// <summary>
        /// Método que le da formato a los campos de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void V_correo_Load(object sender, EventArgs e)
        {
            this.textBox_nombre.Text = "";
            this.comboBox1_nombre.Text = "";
            this.textBox_contraseña.Text = "";
            this.textBox_direccion.Text = "";
            this.comboBox_servicio.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_servicio.Items.Clear();
            this.comboBox1_nombre.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1_nombre.Items.Clear();
            this.label1.Text = "@ejemplo.com";
            if (this.Text == "Agregar Casilla")
            {
                this.label3.Visible = true;
                this.label2.Visible = true;
                this.comboBox1_nombre.Visible = false;
                this.textBox_nombre.Visible = true;
                this.button_verificar.Text = "Verificar";
                this.comboBox_servicio.Enabled = false;
                this.textBox_direccion.Enabled = false;
                this.textBox_contraseña.Enabled = false;
                this.comboBox_servicio.Visible = true;
                this.comboBox_servicio.DropDownStyle = ComboBoxStyle.DropDownList;
                this.textBox_direccion.Visible = true;
            }
            if (this.Text == "Modificar Casilla")
            {
                this.label3.Visible = true;
                this.label2.Visible = true;
                this.comboBox1_nombre.Visible = true;
                this.comboBox1_nombre.DropDownStyle = ComboBoxStyle.DropDownList;
                List<string> _listaNombres = new List<string>();
                _listaNombres = _controlador.ObtenerNombreCasillas();
                for (int i = 0; i < _listaNombres.Count; i++)
                    this.comboBox1_nombre.Items.Add(_listaNombres[i]);
                this.textBox_nombre.Visible = false;
                this.comboBox_servicio.Enabled = false;
                this.comboBox_servicio.Visible = true;
                this.comboBox_servicio.Text = string.Empty;
                this.button_verificar.Text = "Buscar";
                this.textBox_direccion.Visible = true;
                this.textBox_direccion.Enabled = false;
                this.textBox_contraseña.Enabled = false;
            }
        }

        /// <summary>
        /// Verifica si el nombre de correo aun no existe para dicha cuenta, habilitando los demás campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_verificar_Click(object sender, EventArgs e)
        {
            //Verifica que el nombre del correo no existe ya en esta cuenta
            if (button_verificar.Text=="Verificar")
            {
                if (this.textBox_nombre.Text != "")
                {
                    if (!_controlador.NombreExistenteCasilla(this.textBox_nombre.Text))
                    {
                        this.comboBox_servicio.Enabled = true;
                        List<string> _listaServicio = new List<string>();
                        _listaServicio = _controlador.ObtenerProveedorServicio();
                        this.comboBox_servicio.Items.Clear();
                        for (int i = 0; i < _listaServicio.Count; i++)
                            this.comboBox_servicio.Items.Add(_listaServicio[i]);
                        this.textBox_direccion.Enabled = true;
                        this.textBox_contraseña.Enabled = true;
                        this.textBox_contraseña.PasswordChar = '♦';
                        this.button_guardar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Nombre de Casilla ya existente");
                    }
                }
                
            }
            if (button_verificar.Text == "Buscar")
            {
                string _direccion = _controlador.ObtenerDireccionCasilla(this.comboBox1_nombre.Text);
                if (_direccion != String.Empty)
                {
                    this.textBox_direccion.Enabled = true;

                    this.textBox_direccion.Text = ObtenerNombreDireccion(_direccion);
                    this.label1.Text = ObtenerDominio(_direccion);
                    this.textBox_contraseña.Enabled = true;
                    this.textBox_contraseña.PasswordChar = '\0';
                    this.textBox_contraseña.Text = "Si desea realizar cambios";
                    this.button_guardar.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Formato del texto si esta en foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_contraseña_Focus(object sender, EventArgs e)
        {
            if (this.Text == "Modificar Casilla")
            {
                this.textBox_contraseña.Text = "";
                this.textBox_contraseña.ForeColor = Color.Black;
                this.textBox_contraseña.PasswordChar = '•';
            }
        }

        /// <summary>
        /// Formato del texto si deja de estar en foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_contraseña_noFocus(object sender, EventArgs e)
        {
            if ((this.textBox_contraseña.Text == "") && (this.Text == "Modificar Casilla"))
            {
                this.textBox_contraseña.PasswordChar = '\0';
                this.textBox_contraseña.Text = "Si desea realizar cambios";
                this.textBox_contraseña.ForeColor = Color.LightGray;
            }
        }

        /// <summary>
        /// Asigna los estados por defecto a la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void V_correo_FormClosing(object sender, FormClosingEventArgs e)
        {
            comboBox_servicio.Enabled = false;
            this.textBox_direccion.Enabled = false;
            this.textBox_contraseña.Enabled = false;
            this.Width = 300;
            this.Height = 279;
        }

        /// <summary>
        /// Guardar una casilla de correo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_guardar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Agregar Casilla")
            {
                string _direccion = String.Concat(this.textBox_direccion.Text, this.label1.Text);
                CasillaCorreo _casilla = new CasillaCorreo(this.textBox_nombre.Text,_direccion, this.textBox_contraseña.Text);
                int idServicio = _controlador.ObtenerIdServicio(comboBox_servicio.Text);

                // éxito
                if (_controlador.AgregarCasilla(_casilla, idServicio))
                {
                    MessageBox.Show("Casilla agregada con éxito", "FlyMail");
                    this.Close();
                }
                    
            }

            if (this.Text=="Modificar Casilla")
            {
                CasillaCorreo _casilla = new CasillaCorreo(this.comboBox1_nombre.Text, string.Concat(this.textBox_direccion.Text, label1.Text), this.textBox_contraseña.Text);
                if (this.textBox_contraseña.Text=="Si desea realizar cambios")
                {
                    _casilla.Contraseña = String.Empty;
                }

                // éxito
                if (_controlador.ModificarCasilla(_casilla))
                {
                    MessageBox.Show("Casilla modificada con éxito", "FlyMail");
                    this.Close();
                }
                
            }
            
        }

        private void TextBox_direccion_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button_guardar;
        }

        private void TextBox_contraseña_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button_guardar;
        }

        /// <summary>
        /// Asigna dominio de casilla a Label1 según el servicio seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_servicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label1.Text = "@"+ _controlador.ObtenerDominioServicio(this.comboBox_servicio.Text);
        }

        /// <summary>
        /// Devuelve el nombre de la dirección de casilla
        /// </summary>
        /// <param name="pDireccion">Dirección de casilla</param>
        /// <returns>Nombre de la dirección</returns>
        private string ObtenerNombreDireccion(string pDireccion)
        {
            string _nombre = "";
            int _i = 0;
            while (pDireccion[_i] != '@')
            {
                _nombre += pDireccion[_i];
                _i++;
            }
            return _nombre;
        }

        /// <summary>
        /// Devuelve el Dominio de una determinada casilla
        /// </summary>
        /// <param name="pDireccion">Dirección de la casilla</param>
        /// <returns>Dominio de casilla</returns>
        private string ObtenerDominio(string pDireccion)
        {
            string _dominio = "";
            int _i = 0;
            bool encontroDominio = false;
            while (_i< pDireccion.Length || !encontroDominio)
            {
                if (pDireccion[_i] == '@')
                {
                    encontroDominio = true;
                    _dominio = pDireccion.Substring(_i);
                }
                _i++;
            }
            return _dominio;
        }
    }
}