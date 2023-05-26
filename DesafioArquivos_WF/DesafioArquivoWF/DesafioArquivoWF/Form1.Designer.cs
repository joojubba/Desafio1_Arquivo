namespace DesafioArquivoWF
{
    partial class FormAlternativa1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTexto = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkBoxLista = new System.Windows.Forms.CheckBox();
            this.checkBoxAlunos = new System.Windows.Forms.CheckBox();
            this.checkBoxQtd = new System.Windows.Forms.CheckBox();
            this.labelMostrarObj = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxLista = new System.Windows.Forms.TextBox();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.textBoxAlunos = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEntrar.FlatAppearance.BorderSize = 0;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEntrar.Location = new System.Drawing.Point(16, 290);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(573, 52);
            this.buttonEntrar.TabIndex = 0;
            this.buttonEntrar.Text = "ENTRAR";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(16, 216);
            this.textBoxSenha.Multiline = true;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(573, 52);
            this.textBoxSenha.TabIndex = 2;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(16, 129);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(573, 52);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.Gray;
            this.labelLogin.Location = new System.Drawing.Point(16, 108);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(58, 18);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSenha.ForeColor = System.Drawing.Color.Gray;
            this.labelSenha.Location = new System.Drawing.Point(16, 195);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(58, 18);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha";
            this.labelSenha.Click += new System.EventHandler(this.labelSenha_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(28, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 726);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 726);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 589);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1110, 134);
            this.panel5.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesafioArquivoWF.Properties.Resources.password__1_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelTexto);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.labelLogin);
            this.panel3.Controls.Add(this.textBoxLogin);
            this.panel3.Controls.Add(this.labelSenha);
            this.panel3.Controls.Add(this.textBoxSenha);
            this.panel3.Controls.Add(this.buttonEntrar);
            this.panel3.Location = new System.Drawing.Point(430, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 390);
            this.panel3.TabIndex = 0;
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTexto.Location = new System.Drawing.Point(141, 360);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(343, 14);
            this.labelTexto.TabIndex = 19;
            this.labelTexto.Text = "Preencha o Login e Senha para acessar o arquivo!";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DesafioArquivoWF.Properties.Resources._lock;
            this.pictureBox5.Location = new System.Drawing.Point(525, 229);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DesafioArquivoWF.Properties.Resources.user__1_;
            this.pictureBox4.Location = new System.Drawing.Point(525, 139);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DesafioArquivoWF.Properties.Resources.password__4_;
            this.pictureBox2.Location = new System.Drawing.Point(190, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 40);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::DesafioArquivoWF.Properties.Resources.cancel__1_;
            this.pictureBox3.Location = new System.Drawing.Point(638, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // checkBoxLista
            // 
            this.checkBoxLista.AutoSize = true;
            this.checkBoxLista.Enabled = false;
            this.checkBoxLista.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxLista.Location = new System.Drawing.Point(42, 253);
            this.checkBoxLista.Name = "checkBoxLista";
            this.checkBoxLista.Size = new System.Drawing.Size(138, 20);
            this.checkBoxLista.TabIndex = 13;
            this.checkBoxLista.Text = "Lista Completa";
            this.checkBoxLista.UseVisualStyleBackColor = true;
            this.checkBoxLista.CheckedChanged += new System.EventHandler(this.checkBoxLista_CheckedChanged);
            // 
            // checkBoxAlunos
            // 
            this.checkBoxAlunos.AutoSize = true;
            this.checkBoxAlunos.Enabled = false;
            this.checkBoxAlunos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAlunos.Location = new System.Drawing.Point(42, 202);
            this.checkBoxAlunos.Name = "checkBoxAlunos";
            this.checkBoxAlunos.Size = new System.Drawing.Size(186, 20);
            this.checkBoxAlunos.TabIndex = 12;
            this.checkBoxAlunos.Text = "Alunos Matriculados ";
            this.checkBoxAlunos.UseVisualStyleBackColor = true;
            this.checkBoxAlunos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxQtd
            // 
            this.checkBoxQtd.AutoSize = true;
            this.checkBoxQtd.Enabled = false;
            this.checkBoxQtd.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxQtd.Location = new System.Drawing.Point(42, 151);
            this.checkBoxQtd.Name = "checkBoxQtd";
            this.checkBoxQtd.Size = new System.Drawing.Size(194, 20);
            this.checkBoxQtd.TabIndex = 14;
            this.checkBoxQtd.Text = "Quantidade de Objetos";
            this.checkBoxQtd.UseVisualStyleBackColor = true;
            this.checkBoxQtd.CheckedChanged += new System.EventHandler(this.checkBoxQtd_CheckedChanged);
            // 
            // labelMostrarObj
            // 
            this.labelMostrarObj.AutoSize = true;
            this.labelMostrarObj.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMostrarObj.Location = new System.Drawing.Point(42, 92);
            this.labelMostrarObj.Name = "labelMostrarObj";
            this.labelMostrarObj.Size = new System.Drawing.Size(178, 18);
            this.labelMostrarObj.TabIndex = 6;
            this.labelMostrarObj.Text = "Dados do Arquivo:";
            this.labelMostrarObj.Click += new System.EventHandler(this.labelMostrarObj_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DesafioArquivoWF.Properties.Resources.encrypted_data__1_;
            this.pictureBox6.Location = new System.Drawing.Point(90, 27);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.textBoxLista);
            this.panel7.Controls.Add(this.textBoxQtd);
            this.panel7.Controls.Add(this.textBoxAlunos);
            this.panel7.Location = new System.Drawing.Point(264, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(852, 339);
            this.panel7.TabIndex = 19;
            // 
            // textBoxLista
            // 
            this.textBoxLista.Enabled = false;
            this.textBoxLista.Location = new System.Drawing.Point(24, 200);
            this.textBoxLista.Multiline = true;
            this.textBoxLista.Name = "textBoxLista";
            this.textBoxLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLista.Size = new System.Drawing.Size(785, 120);
            this.textBoxLista.TabIndex = 16;
            this.textBoxLista.TextChanged += new System.EventHandler(this.textBoxLista_TextChanged);
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Enabled = false;
            this.textBoxQtd.Location = new System.Drawing.Point(24, 42);
            this.textBoxQtd.Multiline = true;
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQtd.Size = new System.Drawing.Size(785, 37);
            this.textBoxQtd.TabIndex = 9;
            // 
            // textBoxAlunos
            // 
            this.textBoxAlunos.Enabled = false;
            this.textBoxAlunos.Location = new System.Drawing.Point(24, 92);
            this.textBoxAlunos.Multiline = true;
            this.textBoxAlunos.Name = "textBoxAlunos";
            this.textBoxAlunos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlunos.Size = new System.Drawing.Size(785, 87);
            this.textBoxAlunos.TabIndex = 10;
            this.textBoxAlunos.TextChanged += new System.EventHandler(this.textBoxAlunos_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.labelMostrarObj);
            this.panel6.Controls.Add(this.checkBoxQtd);
            this.panel6.Controls.Add(this.checkBoxAlunos);
            this.panel6.Controls.Add(this.checkBoxLista);
            this.panel6.Location = new System.Drawing.Point(28, 415);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1116, 339);
            this.panel6.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel8.Location = new System.Drawing.Point(28, 418);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1116, 12);
            this.panel8.TabIndex = 20;
            // 
            // FormAlternativa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1173, 781);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1189, 820);
            this.MinimumSize = new System.Drawing.Size(1189, 820);
            this.Name = "FormAlternativa1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor de Arquivo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEntrar;
        private TextBox textBoxSenha;
        private TextBox textBoxLogin;
        private Label labelLogin;
        private Label labelSenha;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label labelTexto;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel5;
        private CheckBox checkBoxLista;
        private CheckBox checkBoxAlunos;
        private CheckBox checkBoxQtd;
        private Label labelMostrarObj;
        private PictureBox pictureBox6;
        private Panel panel7;
        private TextBox textBoxLista;
        private TextBox textBoxQtd;
        private TextBox textBoxAlunos;
        private Panel panel6;
        private Panel panel8;
    }
}