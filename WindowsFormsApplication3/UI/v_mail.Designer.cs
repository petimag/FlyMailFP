namespace FlyMail
{
    partial class v_mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_mail));
            this.label_de = new System.Windows.Forms.Label();
            this.label_para = new System.Windows.Forms.Label();
            this.label_asunto = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_enviar = new System.Windows.Forms.Button();
            this.textBox_para = new System.Windows.Forms.TextBox();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_responder = new System.Windows.Forms.Button();
            this.richTextBox_texto = new System.Windows.Forms.RichTextBox();
            this.textBox_asunto = new System.Windows.Forms.TextBox();
            this.comboBox_de = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this._fecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_de
            // 
            this.label_de.AutoSize = true;
            this.label_de.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_de.Location = new System.Drawing.Point(21, 20);
            this.label_de.Name = "label_de";
            this.label_de.Size = new System.Drawing.Size(24, 13);
            this.label_de.TabIndex = 0;
            this.label_de.Text = "De:";
            // 
            // label_para
            // 
            this.label_para.AutoSize = true;
            this.label_para.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_para.Location = new System.Drawing.Point(21, 50);
            this.label_para.Name = "label_para";
            this.label_para.Size = new System.Drawing.Size(32, 13);
            this.label_para.TabIndex = 1;
            this.label_para.Text = "Para:";
            // 
            // label_asunto
            // 
            this.label_asunto.AutoSize = true;
            this.label_asunto.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_asunto.Location = new System.Drawing.Point(21, 81);
            this.label_asunto.Name = "label_asunto";
            this.label_asunto.Size = new System.Drawing.Size(43, 13);
            this.label_asunto.TabIndex = 2;
            this.label_asunto.Text = "Asunto:";
            // 
            // button_enviar
            // 
            this.button_enviar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_enviar.BackColor = System.Drawing.Color.Linen;
            this.button_enviar.ForeColor = System.Drawing.Color.Brown;
            this.button_enviar.Image = ((System.Drawing.Image)(resources.GetObject("button_enviar.Image")));
            this.button_enviar.Location = new System.Drawing.Point(179, 340);
            this.button_enviar.Name = "button_enviar";
            this.button_enviar.Size = new System.Drawing.Size(102, 40);
            this.button_enviar.TabIndex = 5;
            this.button_enviar.Text = "Enviar";
            this.button_enviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_enviar, "Enviar Mail");
            this.button_enviar.UseVisualStyleBackColor = false;
            this.button_enviar.Click += new System.EventHandler(this.button_enviar_Click);
            // 
            // textBox_para
            // 
            this.textBox_para.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_para.Location = new System.Drawing.Point(67, 47);
            this.textBox_para.Name = "textBox_para";
            this.textBox_para.Size = new System.Drawing.Size(359, 20);
            this.textBox_para.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox_para, "Destinatario del Mail");
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.Linen;
            this.button_eliminar.ForeColor = System.Drawing.Color.Brown;
            this.button_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("button_eliminar.Image")));
            this.button_eliminar.Location = new System.Drawing.Point(515, 62);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(40, 40);
            this.button_eliminar.TabIndex = 7;
            this.button_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_eliminar, "Eliminar mail");
            this.button_eliminar.UseVisualStyleBackColor = false;
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.Color.Linen;
            this.button_guardar.Image = ((System.Drawing.Image)(resources.GetObject("button_guardar.Image")));
            this.button_guardar.Location = new System.Drawing.Point(469, 62);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(40, 40);
            this.button_guardar.TabIndex = 6;
            this.button_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_guardar, "Guardar Mail");
            this.button_guardar.UseVisualStyleBackColor = false;
            // 
            // button_responder
            // 
            this.button_responder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_responder.BackColor = System.Drawing.Color.Linen;
            this.button_responder.ForeColor = System.Drawing.Color.Brown;
            this.button_responder.Image = ((System.Drawing.Image)(resources.GetObject("button_responder.Image")));
            this.button_responder.Location = new System.Drawing.Point(179, 340);
            this.button_responder.Name = "button_responder";
            this.button_responder.Size = new System.Drawing.Size(102, 40);
            this.button_responder.TabIndex = 5;
            this.button_responder.Text = " Responder";
            this.button_responder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_responder, "Responder Mail");
            this.button_responder.UseVisualStyleBackColor = false;
            // 
            // richTextBox_texto
            // 
            this.richTextBox_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_texto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox_texto.Location = new System.Drawing.Point(17, 108);
            this.richTextBox_texto.Name = "richTextBox_texto";
            this.richTextBox_texto.Size = new System.Drawing.Size(538, 226);
            this.richTextBox_texto.TabIndex = 4;
            this.richTextBox_texto.Text = "";
            // 
            // textBox_asunto
            // 
            this.textBox_asunto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_asunto.Location = new System.Drawing.Point(67, 78);
            this.textBox_asunto.Name = "textBox_asunto";
            this.textBox_asunto.Size = new System.Drawing.Size(359, 20);
            this.textBox_asunto.TabIndex = 3;
            // 
            // comboBox_de
            // 
            this.comboBox_de.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_de.FormattingEnabled = true;
            this.comboBox_de.Items.AddRange(new object[] {
            "petimag@gmail.com",
            "petimag@yahoo.com"});
            this.comboBox_de.Location = new System.Drawing.Point(67, 17);
            this.comboBox_de.Name = "comboBox_de";
            this.comboBox_de.Size = new System.Drawing.Size(359, 21);
            this.comboBox_de.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(294, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "    Cancelar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _fecha
            // 
            this._fecha.AutoSize = true;
            this._fecha.Location = new System.Drawing.Point(437, 11);
            this._fecha.Name = "_fecha";
            this._fecha.Size = new System.Drawing.Size(34, 13);
            this._fecha.TabIndex = 9;
            this._fecha.Text = "fecha";
            this.toolTip1.SetToolTip(this._fecha, "Fecha del mail");
            // 
            // v_mail
            // 
            this.AcceptButton = this.button_enviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(572, 400);
            this.Controls.Add(this._fecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_responder);
            this.Controls.Add(this.button_enviar);
            this.Controls.Add(this.comboBox_de);
            this.Controls.Add(this.textBox_asunto);
            this.Controls.Add(this.textBox_para);
            this.Controls.Add(this.richTextBox_texto);
            this.Controls.Add(this.label_asunto);
            this.Controls.Add(this.label_para);
            this.Controls.Add(this.label_de);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 340);
            this.Name = "v_mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.v_mail_FormClosing);
            this.Load += new System.EventHandler(this.v_mail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_de;
        private System.Windows.Forms.Label label_para;
        private System.Windows.Forms.Label label_asunto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox_texto;
        private System.Windows.Forms.TextBox textBox_para;
        private System.Windows.Forms.TextBox textBox_asunto;
        private System.Windows.Forms.ComboBox comboBox_de;
        private System.Windows.Forms.Button button_enviar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_responder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _fecha;
    }
}