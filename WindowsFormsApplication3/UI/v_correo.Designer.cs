namespace FlyMail
{
    partial class v_correo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_correo));
            this.button_guardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_verificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1_nombre = new System.Windows.Forms.ComboBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_contraseña = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.comboBox_servicio = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_guardar.Enabled = false;
            this.button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_guardar.Image = ((System.Drawing.Image)(resources.GetObject("button_guardar.Image")));
            this.button_guardar.Location = new System.Drawing.Point(188, 210);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 25);
            this.button_guardar.TabIndex = 0;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_guardar, "Guardar correo");
            this.button_guardar.UseVisualStyleBackColor = false;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button_verificar
            // 
            this.button_verificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_verificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_verificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_verificar.Image = ((System.Drawing.Image)(resources.GetObject("button_verificar.Image")));
            this.button_verificar.Location = new System.Drawing.Point(178, 48);
            this.button_verificar.Name = "button_verificar";
            this.button_verificar.Size = new System.Drawing.Size(75, 23);
            this.button_verificar.TabIndex = 4;
            this.button_verificar.Text = "Verificar";
            this.button_verificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_verificar, "Verifica si el nombre de correo ya existe");
            this.button_verificar.UseVisualStyleBackColor = false;
            this.button_verificar.Click += new System.EventHandler(this.button_verificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Servicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.comboBox1_nombre);
            this.groupBox1.Controls.Add(this.textBox_nombre);
            this.groupBox1.Controls.Add(this.button_verificar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(10, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre de Casilla";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1_nombre
            // 
            this.comboBox1_nombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox1_nombre.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1_nombre.FormattingEnabled = true;
            this.comboBox1_nombre.Location = new System.Drawing.Point(9, 22);
            this.comboBox1_nombre.Name = "comboBox1_nombre";
            this.comboBox1_nombre.Size = new System.Drawing.Size(243, 21);
            this.comboBox1_nombre.TabIndex = 0;
            this.comboBox1_nombre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_nombre_SelectedIndexChanged);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_nombre.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_nombre.Location = new System.Drawing.Point(9, 22);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(244, 20);
            this.textBox_nombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Controls.Add(this.textBox_contraseña);
            this.groupBox2.Controls.Add(this.textBox_direccion);
            this.groupBox2.Controls.Add(this.comboBox_servicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(10, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 101);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // textBox_contraseña
            // 
            this.textBox_contraseña.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_contraseña.Enabled = false;
            this.textBox_contraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_contraseña.Location = new System.Drawing.Point(90, 73);
            this.textBox_contraseña.Name = "textBox_contraseña";
            this.textBox_contraseña.PasswordChar = '♦';
            this.textBox_contraseña.Size = new System.Drawing.Size(163, 20);
            this.textBox_contraseña.TabIndex = 8;
            this.textBox_contraseña.TextChanged += new System.EventHandler(this.textBox_contraseña_TextChanged);
            this.textBox_contraseña.GotFocus += new System.EventHandler(this.textBox_contraseña_Focus);
            this.textBox_contraseña.LostFocus += new System.EventHandler(this.textBox_contraseña_noFocus);
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_direccion.Enabled = false;
            this.textBox_direccion.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_direccion.Location = new System.Drawing.Point(90, 45);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(162, 20);
            this.textBox_direccion.TabIndex = 7;
            this.textBox_direccion.TextChanged += new System.EventHandler(this.textBox_direccion_TextChanged);
            // 
            // comboBox_servicio
            // 
            this.comboBox_servicio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox_servicio.Enabled = false;
            this.comboBox_servicio.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox_servicio.FormattingEnabled = true;
            this.comboBox_servicio.Location = new System.Drawing.Point(90, 18);
            this.comboBox_servicio.Name = "comboBox_servicio";
            this.comboBox_servicio.Size = new System.Drawing.Size(163, 21);
            this.comboBox_servicio.TabIndex = 6;
            // 
            // v_correo
            // 
            this.AcceptButton = this.button_verificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_guardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 280);
            this.MinimumSize = new System.Drawing.Size(300, 280);
            this.Name = "v_correo";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.v_correo_FormClosing);
            this.Load += new System.EventHandler(this.v_correo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_verificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_contraseña;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.ComboBox comboBox_servicio;
        private System.Windows.Forms.ComboBox comboBox1_nombre;
    }
}