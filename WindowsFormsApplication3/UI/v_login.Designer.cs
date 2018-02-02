namespace FlyMail
{
    partial class v_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_login));
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
            // 
            // textBox_iniciar_contraseña
            // 
            this.textBox_iniciar_contraseña.Location = new System.Drawing.Point(79, 52);
            this.textBox_iniciar_contraseña.Name = "textBox_iniciar_contraseña";
            this.textBox_iniciar_contraseña.Size = new System.Drawing.Size(212, 20);
            this.textBox_iniciar_contraseña.TabIndex = 1;
            this.textBox_iniciar_contraseña.UseSystemPasswordChar = true;
            // 
            // label_iniciar_nombre
            // 
            this.label_iniciar_nombre.AutoSize = true;
            this.label_iniciar_nombre.BackColor = System.Drawing.Color.Linen;
            this.label_iniciar_nombre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_iniciar_nombre.Location = new System.Drawing.Point(11, 29);
            this.label_iniciar_nombre.Name = "label_iniciar_nombre";
            this.label_iniciar_nombre.Size = new System.Drawing.Size(47, 13);
            this.label_iniciar_nombre.TabIndex = 2;
            this.label_iniciar_nombre.Text = "Nombre:";
            // 
            // label_iniciar_contraseña
            // 
            this.label_iniciar_contraseña.AutoSize = true;
            this.label_iniciar_contraseña.BackColor = System.Drawing.Color.Linen;
            this.label_iniciar_contraseña.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_iniciar_contraseña.Location = new System.Drawing.Point(11, 55);
            this.label_iniciar_contraseña.Name = "label_iniciar_contraseña";
            this.label_iniciar_contraseña.Size = new System.Drawing.Size(64, 13);
            this.label_iniciar_contraseña.TabIndex = 3;
            this.label_iniciar_contraseña.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.label_iniciar_contraseña);
            this.groupBox1.Controls.Add(this.button_iniciar);
            this.groupBox1.Controls.Add(this.label_iniciar_nombre);
            this.groupBox1.Controls.Add(this.textBox_iniciar_contraseña);
            this.groupBox1.Controls.Add(this.textBox_iniciar_nombre);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciar Sesión";
            // 
            // button_iniciar
            // 
            this.button_iniciar.BackColor = System.Drawing.Color.AliceBlue;
            this.button_iniciar.Location = new System.Drawing.Point(216, 78);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(75, 23);
            this.button_iniciar.TabIndex = 6;
            this.button_iniciar.Text = "Iniciar";
            this.button_iniciar.UseVisualStyleBackColor = false;
            this.button_iniciar.Click += new System.EventHandler(this.button_iniciar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.button_crear);
            this.groupBox2.Controls.Add(this.textBox_crear_repetir);
            this.groupBox2.Controls.Add(this.textBox_crear_contraseña);
            this.groupBox2.Controls.Add(this.textBox_crear_nombre);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(80, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 131);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Cuenta";
            // 
            // button_crear
            // 
            this.button_crear.BackColor = System.Drawing.Color.Linen;
            this.button_crear.Location = new System.Drawing.Point(143, 101);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(75, 23);
            this.button_crear.TabIndex = 7;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = false;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // textBox_crear_repetir
            // 
            this.textBox_crear_repetir.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_crear_repetir.Location = new System.Drawing.Point(6, 75);
            this.textBox_crear_repetir.Name = "textBox_crear_repetir";
            this.textBox_crear_repetir.Size = new System.Drawing.Size(212, 20);
            this.textBox_crear_repetir.TabIndex = 4;
            this.textBox_crear_repetir.Text = "Repetir Contraseña";
            this.textBox_crear_repetir.Click += new System.EventHandler(this.textBox_repetir_Click);
            // 
            // textBox_crear_contraseña
            // 
            this.textBox_crear_contraseña.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_crear_contraseña.Location = new System.Drawing.Point(6, 45);
            this.textBox_crear_contraseña.Name = "textBox_crear_contraseña";
            this.textBox_crear_contraseña.Size = new System.Drawing.Size(212, 20);
            this.textBox_crear_contraseña.TabIndex = 3;
            this.textBox_crear_contraseña.Text = "Contraseña";
            this.textBox_crear_contraseña.Click += new System.EventHandler(this.textBox_Contraseña_Click);
            // 
            // textBox_crear_nombre
            // 
            this.textBox_crear_nombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_crear_nombre.Location = new System.Drawing.Point(6, 19);
            this.textBox_crear_nombre.Name = "textBox_crear_nombre";
            this.textBox_crear_nombre.Size = new System.Drawing.Size(212, 20);
            this.textBox_crear_nombre.TabIndex = 2;
            this.textBox_crear_nombre.Text = "Nombre";
            this.textBox_crear_nombre.Click += new System.EventHandler(this.textBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 110);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // v_login
            // 
            this.AcceptButton = this.button_iniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(315, 272);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(331, 311);
            this.MinimumSize = new System.Drawing.Size(331, 311);
            this.Name = "v_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyMail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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