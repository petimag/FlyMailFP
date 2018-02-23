namespace FlyMail
{
    partial class V_mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_mail));
            this.label_de = new System.Windows.Forms.Label();
            this.label_para = new System.Windows.Forms.Label();
            this.label_asunto = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_enviar = new System.Windows.Forms.Button();
            this.textBox_para = new System.Windows.Forms.TextBox();
            this.button_guardar = new System.Windows.Forms.Button();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.richTextBox_texto = new System.Windows.Forms.RichTextBox();
            this.textBox_asunto = new System.Windows.Forms.TextBox();
            this.comboBox_de = new System.Windows.Forms.ComboBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label_CC = new System.Windows.Forms.Label();
            this.textBox_CC = new System.Windows.Forms.TextBox();
            this.label_CCO = new System.Windows.Forms.Label();
            this.textBox_CCO = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // button_enviar
            // 
            this.button_enviar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_enviar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_enviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_enviar.Image = ((System.Drawing.Image)(resources.GetObject("button_enviar.Image")));
            this.button_enviar.Location = new System.Drawing.Point(218, 476);
            this.button_enviar.Name = "button_enviar";
            this.button_enviar.Size = new System.Drawing.Size(102, 40);
            this.button_enviar.TabIndex = 5;
            this.button_enviar.Text = "Enviar";
            this.button_enviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_enviar, "Enviar Mail");
            this.button_enviar.UseVisualStyleBackColor = false;
            this.button_enviar.Click += new System.EventHandler(this.Button_enviar_Click);
            // 
            // textBox_para
            // 
            this.textBox_para.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_para.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_para.Location = new System.Drawing.Point(51, 48);
            this.textBox_para.Name = "textBox_para";
            this.textBox_para.Size = new System.Drawing.Size(359, 20);
            this.textBox_para.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox_para, "Destinatario del Mail");
            // 
            // button_guardar
            // 
            this.button_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_guardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_guardar.Image = ((System.Drawing.Image)(resources.GetObject("button_guardar.Image")));
            this.button_guardar.Location = new System.Drawing.Point(580, 69);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(40, 40);
            this.button_guardar.TabIndex = 11;
            this.button_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_guardar, "Guardar Mail");
            this.button_guardar.UseVisualStyleBackColor = false;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_direccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_direccion.Location = new System.Drawing.Point(206, 20);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.ReadOnly = true;
            this.textBox_direccion.Size = new System.Drawing.Size(414, 20);
            this.textBox_direccion.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox_direccion, "Destinatario del Mail");
            // 
            // richTextBox_texto
            // 
            this.richTextBox_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_texto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox_texto.Location = new System.Drawing.Point(12, 178);
            this.richTextBox_texto.Name = "richTextBox_texto";
            this.richTextBox_texto.Size = new System.Drawing.Size(626, 292);
            this.richTextBox_texto.TabIndex = 4;
            this.richTextBox_texto.Text = "";
            // 
            // textBox_asunto
            // 
            this.textBox_asunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_asunto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_asunto.Location = new System.Drawing.Point(51, 77);
            this.textBox_asunto.Name = "textBox_asunto";
            this.textBox_asunto.Size = new System.Drawing.Size(359, 20);
            this.textBox_asunto.TabIndex = 3;
            // 
            // comboBox_de
            // 
            this.comboBox_de.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_de.FormattingEnabled = true;
            this.comboBox_de.Location = new System.Drawing.Point(51, 19);
            this.comboBox_de.Name = "comboBox_de";
            this.comboBox_de.Size = new System.Drawing.Size(145, 21);
            this.comboBox_de.TabIndex = 1;
            this.comboBox_de.SelectedIndexChanged += new System.EventHandler(this.ComboBox_de_SelectedIndexChanged);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("button_cancelar.Image")));
            this.button_cancelar.Location = new System.Drawing.Point(326, 476);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(102, 40);
            this.button_cancelar.TabIndex = 6;
            this.button_cancelar.Text = "    Cancelar";
            this.button_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.Button_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.textBox_direccion);
            this.groupBox1.Controls.Add(this.button_guardar);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.comboBox_de);
            this.groupBox1.Controls.Add(this.label_de);
            this.groupBox1.Controls.Add(this.label_para);
            this.groupBox1.Controls.Add(this.label_asunto);
            this.groupBox1.Controls.Add(this.textBox_para);
            this.groupBox1.Controls.Add(this.textBox_asunto);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(421, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CC/CCO";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label_CC
            // 
            this.label_CC.AutoSize = true;
            this.label_CC.ForeColor = System.Drawing.SystemColors.Window;
            this.label_CC.Location = new System.Drawing.Point(18, 118);
            this.label_CC.Name = "label_CC";
            this.label_CC.Size = new System.Drawing.Size(24, 13);
            this.label_CC.TabIndex = 12;
            this.label_CC.Text = "CC:";
            this.label_CC.Visible = false;
            // 
            // textBox_CC
            // 
            this.textBox_CC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_CC.Location = new System.Drawing.Point(63, 115);
            this.textBox_CC.Name = "textBox_CC";
            this.textBox_CC.Size = new System.Drawing.Size(359, 20);
            this.textBox_CC.TabIndex = 13;
            this.textBox_CC.Visible = false;
            // 
            // label_CCO
            // 
            this.label_CCO.AutoSize = true;
            this.label_CCO.ForeColor = System.Drawing.SystemColors.Window;
            this.label_CCO.Location = new System.Drawing.Point(18, 144);
            this.label_CCO.Name = "label_CCO";
            this.label_CCO.Size = new System.Drawing.Size(32, 13);
            this.label_CCO.TabIndex = 14;
            this.label_CCO.Text = "CCO:";
            this.label_CCO.Visible = false;
            // 
            // textBox_CCO
            // 
            this.textBox_CCO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CCO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_CCO.Location = new System.Drawing.Point(63, 141);
            this.textBox_CCO.Name = "textBox_CCO";
            this.textBox_CCO.Size = new System.Drawing.Size(359, 20);
            this.textBox_CCO.TabIndex = 15;
            this.textBox_CCO.Visible = false;
            // 
            // v_mail
            // 
            this.AcceptButton = this.button_enviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.button_cancelar;
            this.ClientSize = new System.Drawing.Size(650, 528);
            this.Controls.Add(this.label_CCO);
            this.Controls.Add(this.textBox_CCO);
            this.Controls.Add(this.label_CC);
            this.Controls.Add(this.textBox_CC);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_enviar);
            this.Controls.Add(this.richTextBox_texto);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 340);
            this.Name = "v_mail";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo";
            this.Load += new System.EventHandler(this.V_mail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button button_cancelar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Label label_CC;
        private System.Windows.Forms.TextBox textBox_CC;
        private System.Windows.Forms.Label label_CCO;
        private System.Windows.Forms.TextBox textBox_CCO;
    }
}