namespace FlyMail
{
    partial class v_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_principal));
            this.picture_main = new System.Windows.Forms.PictureBox();
            this.button_recibidos = new System.Windows.Forms.Button();
            this.button_enviados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Remitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_papelera = new System.Windows.Forms.Button();
            this.button_enviar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_responder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarNombreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarContraseñaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_main
            // 
            this.picture_main.Image = ((System.Drawing.Image)(resources.GetObject("picture_main.Image")));
            this.picture_main.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture_main.InitialImage")));
            this.picture_main.Location = new System.Drawing.Point(-24, 266);
            this.picture_main.Name = "picture_main";
            this.picture_main.Size = new System.Drawing.Size(155, 212);
            this.picture_main.TabIndex = 0;
            this.picture_main.TabStop = false;
            // 
            // button_recibidos
            // 
            this.button_recibidos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_recibidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_recibidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_recibidos.Image = ((System.Drawing.Image)(resources.GetObject("button_recibidos.Image")));
            this.button_recibidos.Location = new System.Drawing.Point(12, 89);
            this.button_recibidos.Name = "button_recibidos";
            this.button_recibidos.Size = new System.Drawing.Size(115, 30);
            this.button_recibidos.TabIndex = 1;
            this.button_recibidos.Text = "Recibidos";
            this.button_recibidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_recibidos, "Mails Recibidos");
            this.button_recibidos.UseVisualStyleBackColor = false;
            this.button_recibidos.Click += new System.EventHandler(this.button_recibidos_Click);
            // 
            // button_enviados
            // 
            this.button_enviados.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_enviados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_enviados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_enviados.Image = ((System.Drawing.Image)(resources.GetObject("button_enviados.Image")));
            this.button_enviados.Location = new System.Drawing.Point(12, 125);
            this.button_enviados.Name = "button_enviados";
            this.button_enviados.Size = new System.Drawing.Size(115, 30);
            this.button_enviados.TabIndex = 3;
            this.button_enviados.Text = "Enviados";
            this.button_enviados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_enviados, "Mails Enviados");
            this.button_enviados.UseVisualStyleBackColor = false;
            this.button_enviados.Click += new System.EventHandler(this.button_enviados_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(133, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 390);
            this.panel1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.panel1, "Actualizar Página");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Remitente,
            this.Asunto,
            this.Fecha});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(781, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Check.FillWeight = 1F;
            this.Check.HeaderText = "";
            this.Check.MinimumWidth = 50;
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            this.Check.Width = 50;
            // 
            // Remitente
            // 
            this.Remitente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Remitente.HeaderText = "Remitente";
            this.Remitente.MinimumWidth = 150;
            this.Remitente.Name = "Remitente";
            this.Remitente.ReadOnly = true;
            this.Remitente.Width = 150;
            // 
            // Asunto
            // 
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.MinimumWidth = 150;
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            this.Asunto.Width = 300;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 100;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 200;
            // 
            // button_papelera
            // 
            this.button_papelera.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_papelera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_papelera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_papelera.Image = ((System.Drawing.Image)(resources.GetObject("button_papelera.Image")));
            this.button_papelera.Location = new System.Drawing.Point(12, 161);
            this.button_papelera.Name = "button_papelera";
            this.button_papelera.Size = new System.Drawing.Size(115, 30);
            this.button_papelera.TabIndex = 5;
            this.button_papelera.Text = "Papelera";
            this.button_papelera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_papelera, "Mails Eliminados");
            this.button_papelera.UseVisualStyleBackColor = false;
            this.button_papelera.Click += new System.EventHandler(this.button_papelera_Click);
            // 
            // button_enviar
            // 
            this.button_enviar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_enviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_enviar.Image = ((System.Drawing.Image)(resources.GetObject("button_enviar.Image")));
            this.button_enviar.Location = new System.Drawing.Point(206, 32);
            this.button_enviar.Name = "button_enviar";
            this.button_enviar.Size = new System.Drawing.Size(66, 51);
            this.button_enviar.TabIndex = 6;
            this.button_enviar.Text = "Enviar";
            this.button_enviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button_enviar, "Enviar Mail");
            this.button_enviar.UseVisualStyleBackColor = false;
            this.button_enviar.Click += new System.EventHandler(this.button_enviar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_eliminar.Enabled = false;
            this.button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("button_eliminar.Image")));
            this.button_eliminar.Location = new System.Drawing.Point(278, 32);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(67, 51);
            this.button_eliminar.TabIndex = 7;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button_eliminar, "Eliminar Mail");
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_actualizar
            // 
            this.button_actualizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_actualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("button_actualizar.Image")));
            this.button_actualizar.Location = new System.Drawing.Point(133, 32);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(67, 51);
            this.button_actualizar.TabIndex = 8;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button_actualizar, "Actualizar Página");
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_responder
            // 
            this.button_responder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_responder.Enabled = false;
            this.button_responder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_responder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_responder.Image = ((System.Drawing.Image)(resources.GetObject("button_responder.Image")));
            this.button_responder.Location = new System.Drawing.Point(351, 32);
            this.button_responder.Name = "button_responder";
            this.button_responder.Size = new System.Drawing.Size(67, 51);
            this.button_responder.TabIndex = 9;
            this.button_responder.Text = "Responder";
            this.button_responder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button_responder, "Responder Mail");
            this.button_responder.UseVisualStyleBackColor = false;
            this.button_responder.Click += new System.EventHandler(this.button_responder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasToolStripMenuItem,
            this.agregarCorreoToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarNombreToolStripMenuItem1,
            this.modificarContraseñaToolStripMenuItem1});
            this.cuentasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cuentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cuentasToolStripMenuItem.Image")));
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // modificarNombreToolStripMenuItem1
            // 
            this.modificarNombreToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.modificarNombreToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modificarNombreToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("modificarNombreToolStripMenuItem1.Image")));
            this.modificarNombreToolStripMenuItem1.Name = "modificarNombreToolStripMenuItem1";
            this.modificarNombreToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modificarNombreToolStripMenuItem1.Text = "Modificar Nombre";
            this.modificarNombreToolStripMenuItem1.Click += new System.EventHandler(this.modificarNombreToolStripMenuItem1_Click);
            // 
            // modificarContraseñaToolStripMenuItem1
            // 
            this.modificarContraseñaToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.modificarContraseñaToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modificarContraseñaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("modificarContraseñaToolStripMenuItem1.Image")));
            this.modificarContraseñaToolStripMenuItem1.Name = "modificarContraseñaToolStripMenuItem1";
            this.modificarContraseñaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modificarContraseñaToolStripMenuItem1.Text = "Modificar Contraseña";
            this.modificarContraseñaToolStripMenuItem1.Click += new System.EventHandler(this.modificarContraseñaToolStripMenuItem1_Click);
            // 
            // agregarCorreoToolStripMenuItem
            // 
            this.agregarCorreoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.agregarCorreoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.agregarCorreoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agregarCorreoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarCorreoToolStripMenuItem.Image")));
            this.agregarCorreoToolStripMenuItem.Name = "agregarCorreoToolStripMenuItem";
            this.agregarCorreoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.agregarCorreoToolStripMenuItem.Text = "Casillas de Correo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.agregarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agregarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem.Image")));
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cerrarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesiónToolStripMenuItem.Image")));
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem});
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.informaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.informaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informaciónToolStripMenuItem.Image")));
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.informaciónToolStripMenuItem.Text = "Información";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(663, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(542, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mostrar correos de:";
            // 
            // v_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(926, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_responder);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_enviar);
            this.Controls.Add(this.picture_main);
            this.Controls.Add(this.button_papelera);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_enviados);
            this.Controls.Add(this.button_recibidos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(850, 270);
            this.Name = "v_principal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyMail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.v_principal_FormClosing);
            this.Load += new System.EventHandler(this.v_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_main;
        private System.Windows.Forms.Button button_recibidos;
        private System.Windows.Forms.Button button_enviados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_papelera;
        private System.Windows.Forms.Button button_enviar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_responder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem agregarCorreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarNombreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarContraseñaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}

