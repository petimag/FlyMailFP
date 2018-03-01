namespace UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_leerMail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_reenviar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.textBox_de = new System.Windows.Forms.TextBox();
            this.label_CCO = new System.Windows.Forms.Label();
            this.textBox_CCO = new System.Windows.Forms.TextBox();
            this.label_CC = new System.Windows.Forms.Label();
            this._fecha = new System.Windows.Forms.Label();
            this.textBox_CC = new System.Windows.Forms.TextBox();
            this.label_de = new System.Windows.Forms.Label();
            this.label_para = new System.Windows.Forms.Label();
            this.label_asunto = new System.Windows.Forms.Label();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.textBox_para = new System.Windows.Forms.TextBox();
            this.textBox_asunto = new System.Windows.Forms.TextBox();
            this.richTextBox_texto = new System.Windows.Forms.RichTextBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_responder = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.button_reenviar);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.textBox_fecha);
            this.groupBox1.Controls.Add(this.textBox_de);
            this.groupBox1.Controls.Add(this.label_CCO);
            this.groupBox1.Controls.Add(this.textBox_CCO);
            this.groupBox1.Controls.Add(this.label_CC);
            this.groupBox1.Controls.Add(this._fecha);
            this.groupBox1.Controls.Add(this.textBox_CC);
            this.groupBox1.Controls.Add(this.label_de);
            this.groupBox1.Controls.Add(this.label_para);
            this.groupBox1.Controls.Add(this.label_asunto);
            this.groupBox1.Controls.Add(this.button_eliminar);
            this.groupBox1.Controls.Add(this.textBox_para);
            this.groupBox1.Controls.Add(this.textBox_asunto);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 156);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // button_reenviar
            // 
            this.button_reenviar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_reenviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_reenviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_reenviar.Image = ((System.Drawing.Image)(resources.GetObject("button_reenviar.Image")));
            this.button_reenviar.Location = new System.Drawing.Point(524, 53);
            this.button_reenviar.Name = "button_reenviar";
            this.button_reenviar.Size = new System.Drawing.Size(40, 40);
            this.button_reenviar.TabIndex = 23;
            this.button_reenviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_reenviar, "Reenviar Mail");
            this.button_reenviar.UseVisualStyleBackColor = false;
            this.button_reenviar.Click += new System.EventHandler(this.Button_reenviar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(416, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CC/CCO";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_fecha.Location = new System.Drawing.Point(481, 17);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.Size = new System.Drawing.Size(129, 20);
            this.textBox_fecha.TabIndex = 21;
            // 
            // textBox_de
            // 
            this.textBox_de.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_de.Location = new System.Drawing.Point(51, 19);
            this.textBox_de.Name = "textBox_de";
            this.textBox_de.Size = new System.Drawing.Size(359, 20);
            this.textBox_de.TabIndex = 20;
            // 
            // label_CCO
            // 
            this.label_CCO.AutoSize = true;
            this.label_CCO.ForeColor = System.Drawing.SystemColors.Window;
            this.label_CCO.Location = new System.Drawing.Point(6, 132);
            this.label_CCO.Name = "label_CCO";
            this.label_CCO.Size = new System.Drawing.Size(32, 13);
            this.label_CCO.TabIndex = 18;
            this.label_CCO.Text = "CCO:";
            this.label_CCO.Visible = false;
            // 
            // textBox_CCO
            // 
            this.textBox_CCO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CCO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_CCO.Location = new System.Drawing.Point(51, 129);
            this.textBox_CCO.Name = "textBox_CCO";
            this.textBox_CCO.Size = new System.Drawing.Size(359, 20);
            this.textBox_CCO.TabIndex = 19;
            this.textBox_CCO.Visible = false;
            // 
            // label_CC
            // 
            this.label_CC.AutoSize = true;
            this.label_CC.ForeColor = System.Drawing.SystemColors.Window;
            this.label_CC.Location = new System.Drawing.Point(6, 106);
            this.label_CC.Name = "label_CC";
            this.label_CC.Size = new System.Drawing.Size(24, 13);
            this.label_CC.TabIndex = 16;
            this.label_CC.Text = "CC:";
            this.label_CC.Visible = false;
            // 
            // _fecha
            // 
            this._fecha.AutoSize = true;
            this._fecha.ForeColor = System.Drawing.SystemColors.Window;
            this._fecha.Location = new System.Drawing.Point(438, 20);
            this._fecha.Name = "_fecha";
            this._fecha.Size = new System.Drawing.Size(37, 13);
            this._fecha.TabIndex = 9;
            this._fecha.Text = "fecha:";
            // 
            // textBox_CC
            // 
            this.textBox_CC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_CC.Location = new System.Drawing.Point(51, 103);
            this.textBox_CC.Name = "textBox_CC";
            this.textBox_CC.Size = new System.Drawing.Size(359, 20);
            this.textBox_CC.TabIndex = 17;
            this.textBox_CC.Visible = false;
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
            this.button_eliminar.Location = new System.Drawing.Point(570, 53);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(40, 40);
            this.button_eliminar.TabIndex = 7;
            this.button_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_eliminar, "Eliminar Mail");
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.Button_eliminar_Click);
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
            this.richTextBox_texto.Location = new System.Drawing.Point(12, 174);
            this.richTextBox_texto.Name = "richTextBox_texto";
            this.richTextBox_texto.Size = new System.Drawing.Size(626, 296);
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
            this.button_cancelar.Click += new System.EventHandler(this.Button_cancelar_Click);
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
            this.button_responder.Click += new System.EventHandler(this.Button_responder_Click);
            // 
            // V_leerMail
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
            this.Name = "V_leerMail";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leer Mail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label _fecha;
        private System.Windows.Forms.Label label_de;
        private System.Windows.Forms.Label label_para;
        private System.Windows.Forms.Label label_asunto;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.TextBox textBox_para;
        private System.Windows.Forms.TextBox textBox_asunto;
        private System.Windows.Forms.RichTextBox richTextBox_texto;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_responder;
        private System.Windows.Forms.Label label_CCO;
        private System.Windows.Forms.TextBox textBox_CCO;
        private System.Windows.Forms.Label label_CC;
        private System.Windows.Forms.TextBox textBox_CC;
        private System.Windows.Forms.TextBox textBox_de;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_reenviar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}