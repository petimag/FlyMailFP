namespace WindowsFormsApplication3.UI
{
    partial class V_leerMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_leerMail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox_de = new System.Windows.Forms.ComboBox();
            this._fecha = new System.Windows.Forms.Label();
            this.label_de = new System.Windows.Forms.Label();
            this.label_para = new System.Windows.Forms.Label();
            this.button_guardar = new System.Windows.Forms.Button();
            this.label_asunto = new System.Windows.Forms.Label();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.textBox_para = new System.Windows.Forms.TextBox();
            this.textBox_asunto = new System.Windows.Forms.TextBox();
            this.richTextBox_texto = new System.Windows.Forms.RichTextBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_responder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.comboBox_de);
            this.groupBox1.Controls.Add(this._fecha);
            this.groupBox1.Controls.Add(this.label_de);
            this.groupBox1.Controls.Add(this.label_para);
            this.groupBox1.Controls.Add(this.button_guardar);
            this.groupBox1.Controls.Add(this.label_asunto);
            this.groupBox1.Controls.Add(this.button_eliminar);
            this.groupBox1.Controls.Add(this.textBox_para);
            this.groupBox1.Controls.Add(this.textBox_asunto);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 145);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(421, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CC/CCO";
            // 
            // comboBox_de
            // 
            this.comboBox_de.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_de.FormattingEnabled = true;
            this.comboBox_de.Items.AddRange(new object[] {
            "petimag@gmail.com",
            "petimag@yahoo.com"});
            this.comboBox_de.Location = new System.Drawing.Point(51, 19);
            this.comboBox_de.Name = "comboBox_de";
            this.comboBox_de.Size = new System.Drawing.Size(359, 21);
            this.comboBox_de.TabIndex = 1;
            // 
            // _fecha
            // 
            this._fecha.AutoSize = true;
            this._fecha.ForeColor = System.Drawing.SystemColors.Window;
            this._fecha.Location = new System.Drawing.Point(421, 20);
            this._fecha.Name = "_fecha";
            this._fecha.Size = new System.Drawing.Size(34, 13);
            this._fecha.TabIndex = 9;
            this._fecha.Text = "fecha";
            // 
            // label_de
            // 
            this.label_de.AutoSize = true;
            this.label_de.ForeColor = System.Drawing.SystemColors.Window;
            this.label_de.Location = new System.Drawing.Point(6, 22);
            this.label_de.Name = "label_de";
            this.label_de.Size = new System.Drawing.Size(24, 13);
            this.label_de.TabIndex = 0;
            this.label_de.Text = "De:";
            // 
            // label_para
            // 
            this.label_para.AutoSize = true;
            this.label_para.ForeColor = System.Drawing.SystemColors.Window;
            this.label_para.Location = new System.Drawing.Point(6, 51);
            this.label_para.Name = "label_para";
            this.label_para.Size = new System.Drawing.Size(32, 13);
            this.label_para.TabIndex = 1;
            this.label_para.Text = "Para:";
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_guardar.Image = ((System.Drawing.Image)(resources.GetObject("button_guardar.Image")));
            this.button_guardar.Location = new System.Drawing.Point(534, 99);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(40, 40);
            this.button_guardar.TabIndex = 6;
            this.button_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_guardar.UseVisualStyleBackColor = false;
            // 
            // label_asunto
            // 
            this.label_asunto.AutoSize = true;
            this.label_asunto.ForeColor = System.Drawing.SystemColors.Window;
            this.label_asunto.Location = new System.Drawing.Point(6, 80);
            this.label_asunto.Name = "label_asunto";
            this.label_asunto.Size = new System.Drawing.Size(43, 13);
            this.label_asunto.TabIndex = 2;
            this.label_asunto.Text = "Asunto:";
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("button_eliminar.Image")));
            this.button_eliminar.Location = new System.Drawing.Point(580, 99);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(40, 40);
            this.button_eliminar.TabIndex = 7;
            this.button_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_eliminar.UseVisualStyleBackColor = false;
            // 
            // textBox_para
            // 
            this.textBox_para.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_para.Location = new System.Drawing.Point(51, 48);
            this.textBox_para.Name = "textBox_para";
            this.textBox_para.Size = new System.Drawing.Size(359, 20);
            this.textBox_para.TabIndex = 2;
            // 
            // textBox_asunto
            // 
            this.textBox_asunto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_asunto.Location = new System.Drawing.Point(51, 77);
            this.textBox_asunto.Name = "textBox_asunto";
            this.textBox_asunto.Size = new System.Drawing.Size(359, 20);
            this.textBox_asunto.TabIndex = 3;
            // 
            // richTextBox_texto
            // 
            this.richTextBox_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_texto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox_texto.Location = new System.Drawing.Point(12, 163);
            this.richTextBox_texto.Name = "richTextBox_texto";
            this.richTextBox_texto.Size = new System.Drawing.Size(626, 307);
            this.richTextBox_texto.TabIndex = 11;
            this.richTextBox_texto.Text = "";
            // 
            // button_cancelar
            // 
            this.button_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("button_cancelar.Image")));
            this.button_cancelar.Location = new System.Drawing.Point(320, 476);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(102, 40);
            this.button_cancelar.TabIndex = 14;
            this.button_cancelar.Text = "    Cancelar";
            this.button_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_cancelar.UseVisualStyleBackColor = false;
            // 
            // button_responder
            // 
            this.button_responder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_responder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_responder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_responder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_responder.Image = ((System.Drawing.Image)(resources.GetObject("button_responder.Image")));
            this.button_responder.Location = new System.Drawing.Point(212, 475);
            this.button_responder.Name = "button_responder";
            this.button_responder.Size = new System.Drawing.Size(102, 40);
            this.button_responder.TabIndex = 13;
            this.button_responder.Text = " Responder";
            this.button_responder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_responder.UseVisualStyleBackColor = false;
            // 
            // v_leerMail
            // 
            this.AcceptButton = this.button_responder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.button_cancelar;
            this.ClientSize = new System.Drawing.Size(650, 528);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_responder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox_texto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "v_leerMail";
            this.Opacity = 0.9D;
            this.Text = "Leer Mail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox_de;
        private System.Windows.Forms.Label _fecha;
        private System.Windows.Forms.Label label_de;
        private System.Windows.Forms.Label label_para;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Label label_asunto;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.TextBox textBox_para;
        private System.Windows.Forms.TextBox textBox_asunto;
        private System.Windows.Forms.RichTextBox richTextBox_texto;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_responder;
    }
}