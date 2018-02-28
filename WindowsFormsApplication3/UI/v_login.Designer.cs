namespace FlyMail
{
    partial class V_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_login));
            this.textBox_iniciar_nombre = new System.Windows.Forms.TextBox();
            this.textBox_iniciar_contraseña = new System.Windows.Forms.TextBox();
            this.label_iniciar_nombre = new System.Windows.Forms.Label();
            this.label_iniciar_contraseña = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_iniciar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_crear = new System.Windows.Forms.Button();
            this.textBox_crear_repetir = new System.Windows.Forms.TextBox();
            this.textBox_crear_contraseña = new System.Windows.Forms.TextBox();
            this.textBox_crear_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_iniciar_nombre
            // 
            this.textBox_iniciar_nombre.Location = new System.Drawing.Point(79, 26);
            this.textBox_iniciar_nombre.Name = "textBox_iniciar_nombre";
            this.textBox_iniciar_nombre.Size = new System.Drawing.Size(212, 20);
            this.textBox_iniciar_nombre.TabIndex = 0;
            this.textBox_iniciar_nombre.GotFocus += new System.EventHandler(this.TextBox_iniciar_Focus);
            // 
            // textBox_iniciar_contraseña
            // 
            this.textBox_iniciar_contraseña.Location = new System.Drawing.Point(79, 52);
            this.textBox_iniciar_contraseña.Name = "textBox_iniciar_contraseña";
            this.textBox_iniciar_contraseña.PasswordChar = '•';
            this.textBox_iniciar_contraseña.Size = new System.Drawing.Size(212, 20);
            this.textBox_iniciar_contraseña.TabIndex = 1;
            this.textBox_iniciar_contraseña.Click += new System.EventHandler(this.TextBox_iniciar_Click);
            // 
            // label_iniciar_nombre
            // 
            this.label_iniciar_nombre.AutoSize = true;
            this.label_iniciar_nombre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_iniciar_nombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_iniciar_nombre.Location = new System.Drawing.Point(11, 29);
            this.label_iniciar_nombre.Name = "label_iniciar_nombre";
            this.label_iniciar_nombre.Size = new System.Drawing.Size(47, 13);
            this.label_iniciar_nombre.TabIndex = 2;
            this.label_iniciar_nombre.Text = "Nombre:";
            // 
            // label_iniciar_contraseña
            // 
            this.label_iniciar_contraseña.AutoSize = true;
            this.label_iniciar_contraseña.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_iniciar_contraseña.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_iniciar_contraseña.Location = new System.Drawing.Point(11, 55);
            this.label_iniciar_contraseña.Name = "label_iniciar_contraseña";
            this.label_iniciar_contraseña.Size = new System.Drawing.Size(64, 13);
            this.label_iniciar_contraseña.TabIndex = 3;
            this.label_iniciar_contraseña.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.label_iniciar_contraseña);
            this.groupBox1.Controls.Add(this.button_iniciar);
            this.groupBox1.Controls.Add(this.label_iniciar_nombre);
            this.groupBox1.Controls.Add(this.textBox_iniciar_contraseña);
            this.groupBox1.Controls.Add(this.textBox_iniciar_nombre);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciar Sesión";
            // 
            // button_iniciar
            // 
            this.button_iniciar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_iniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_iniciar.Location = new System.Drawing.Point(216, 78);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(75, 23);
            this.button_iniciar.TabIndex = 2;
            this.button_iniciar.Text = "Iniciar";
            this.button_iniciar.UseVisualStyleBackColor = false;
            this.button_iniciar.Click += new System.EventHandler(this.Button_iniciar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.button_crear);
            this.groupBox2.Controls.Add(this.textBox_crear_repetir);
            this.groupBox2.Controls.Add(this.textBox_crear_contraseña);
            this.groupBox2.Controls.Add(this.textBox_crear_nombre);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(103, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 132);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Cuenta";
            // 
            // button_crear
            // 
            this.button_crear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_crear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_crear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_crear.Location = new System.Drawing.Point(121, 101);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(75, 23);
            this.button_crear.TabIndex = 6;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = false;
            this.button_crear.Click += new System.EventHandler(this.Button_crear_Click);
            // 
            // textBox_crear_repetir
            // 
            this.textBox_crear_repetir.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_crear_repetir.Location = new System.Drawing.Point(6, 71);
            this.textBox_crear_repetir.Name = "textBox_crear_repetir";
            this.textBox_crear_repetir.Size = new System.Drawing.Size(189, 20);
            this.textBox_crear_repetir.TabIndex = 5;
            this.textBox_crear_repetir.Text = "Repetir Contraseña";
            this.textBox_crear_repetir.TextChanged += new System.EventHandler(this.TextBox_crear_repetir_TextChanged);
            this.textBox_crear_repetir.GotFocus += new System.EventHandler(this.TextBox_repetir_Focus);
            this.textBox_crear_repetir.LostFocus += new System.EventHandler(this.TextBox_repetir_noFocus);
            // 
            // textBox_crear_contraseña
            // 
            this.textBox_crear_contraseña.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_crear_contraseña.Location = new System.Drawing.Point(6, 45);
            this.textBox_crear_contraseña.Name = "textBox_crear_contraseña";
            this.textBox_crear_contraseña.Size = new System.Drawing.Size(189, 20);
            this.textBox_crear_contraseña.TabIndex = 4;
            this.textBox_crear_contraseña.Text = "Contraseña";
            this.textBox_crear_contraseña.TextChanged += new System.EventHandler(this.TextBox_crear_contraseña_TextChanged);
            this.textBox_crear_contraseña.GotFocus += new System.EventHandler(this.TextBox_Contraseña_Focus);
            this.textBox_crear_contraseña.LostFocus += new System.EventHandler(this.TextBox_Contraseña_noFocus);
            // 
            // textBox_crear_nombre
            // 
            this.textBox_crear_nombre.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_crear_nombre.Location = new System.Drawing.Point(6, 19);
            this.textBox_crear_nombre.Name = "textBox_crear_nombre";
            this.textBox_crear_nombre.Size = new System.Drawing.Size(189, 20);
            this.textBox_crear_nombre.TabIndex = 3;
            this.textBox_crear_nombre.Text = "Nombre";
            this.textBox_crear_nombre.GotFocus += new System.EventHandler(this.TextBox_crear_nombre_Focus);
            this.textBox_crear_nombre.LostFocus += new System.EventHandler(this.TextBox_crear_nombre_noFocus);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // V_login
            // 
            this.AcceptButton = this.button_iniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(315, 272);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(331, 311);
            this.MinimumSize = new System.Drawing.Size(331, 311);
            this.Name = "V_login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyMail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_iniciar_nombre;
        private System.Windows.Forms.TextBox textBox_iniciar_contraseña;
        private System.Windows.Forms.Label label_iniciar_nombre;
        private System.Windows.Forms.Label label_iniciar_contraseña;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_iniciar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.TextBox textBox_crear_repetir;
        private System.Windows.Forms.TextBox textBox_crear_contraseña;
        private System.Windows.Forms.TextBox textBox_crear_nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}