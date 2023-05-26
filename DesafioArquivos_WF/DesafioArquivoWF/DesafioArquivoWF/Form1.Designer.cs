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
            this.labelMostrarObj = new System.Windows.Forms.Label();
            this.labelQtd = new System.Windows.Forms.Label();
            this.labelAlunos = new System.Windows.Forms.Label();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.textBoxAlunos = new System.Windows.Forms.TextBox();
            this.checkBoxAlunos = new System.Windows.Forms.CheckBox();
            this.checkBoxLista = new System.Windows.Forms.CheckBox();
            this.checkBoxQtd = new System.Windows.Forms.CheckBox();
            this.labelLista = new System.Windows.Forms.Label();
            this.textBoxLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(67, 97);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(75, 23);
            this.buttonEntrar.TabIndex = 0;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(67, 61);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(100, 23);
            this.textBoxSenha.TabIndex = 2;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(67, 24);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 23);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(23, 24);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(37, 15);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(23, 64);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(39, 15);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha";
            // 
            // labelMostrarObj
            // 
            this.labelMostrarObj.AutoSize = true;
            this.labelMostrarObj.Location = new System.Drawing.Point(23, 189);
            this.labelMostrarObj.Name = "labelMostrarObj";
            this.labelMostrarObj.Size = new System.Drawing.Size(105, 15);
            this.labelMostrarObj.TabIndex = 6;
            this.labelMostrarObj.Text = "Dados do Arquivo:";
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Location = new System.Drawing.Point(617, 32);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(132, 15);
            this.labelQtd.TabIndex = 7;
            this.labelQtd.Text = "Quantidade de Objetos:";
            // 
            // labelAlunos
            // 
            this.labelAlunos.AutoSize = true;
            this.labelAlunos.Location = new System.Drawing.Point(617, 155);
            this.labelAlunos.Name = "labelAlunos";
            this.labelAlunos.Size = new System.Drawing.Size(122, 15);
            this.labelAlunos.TabIndex = 8;
            this.labelAlunos.Text = "Alunos Matriculados :";
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Enabled = false;
            this.textBoxQtd.Location = new System.Drawing.Point(460, 56);
            this.textBoxQtd.Multiline = true;
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQtd.Size = new System.Drawing.Size(317, 64);
            this.textBoxQtd.TabIndex = 9;
            // 
            // textBoxAlunos
            // 
            this.textBoxAlunos.Enabled = false;
            this.textBoxAlunos.Location = new System.Drawing.Point(460, 186);
            this.textBoxAlunos.Multiline = true;
            this.textBoxAlunos.Name = "textBoxAlunos";
            this.textBoxAlunos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlunos.Size = new System.Drawing.Size(317, 70);
            this.textBoxAlunos.TabIndex = 10;
            this.textBoxAlunos.TextChanged += new System.EventHandler(this.textBoxAlunos_TextChanged);
            // 
            // checkBoxAlunos
            // 
            this.checkBoxAlunos.AutoSize = true;
            this.checkBoxAlunos.Enabled = false;
            this.checkBoxAlunos.Location = new System.Drawing.Point(23, 252);
            this.checkBoxAlunos.Name = "checkBoxAlunos";
            this.checkBoxAlunos.Size = new System.Drawing.Size(138, 19);
            this.checkBoxAlunos.TabIndex = 12;
            this.checkBoxAlunos.Text = "Alunos Matriculados ";
            this.checkBoxAlunos.UseVisualStyleBackColor = true;
            this.checkBoxAlunos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxLista
            // 
            this.checkBoxLista.AutoSize = true;
            this.checkBoxLista.Enabled = false;
            this.checkBoxLista.Location = new System.Drawing.Point(23, 287);
            this.checkBoxLista.Name = "checkBoxLista";
            this.checkBoxLista.Size = new System.Drawing.Size(105, 19);
            this.checkBoxLista.TabIndex = 13;
            this.checkBoxLista.Text = "Lista Completa";
            this.checkBoxLista.UseVisualStyleBackColor = true;
            this.checkBoxLista.CheckedChanged += new System.EventHandler(this.checkBoxLista_CheckedChanged);
            // 
            // checkBoxQtd
            // 
            this.checkBoxQtd.AutoSize = true;
            this.checkBoxQtd.Enabled = false;
            this.checkBoxQtd.Location = new System.Drawing.Point(23, 221);
            this.checkBoxQtd.Name = "checkBoxQtd";
            this.checkBoxQtd.Size = new System.Drawing.Size(148, 19);
            this.checkBoxQtd.TabIndex = 14;
            this.checkBoxQtd.Text = "Quantidade de Objetos";
            this.checkBoxQtd.UseVisualStyleBackColor = true;
            this.checkBoxQtd.CheckedChanged += new System.EventHandler(this.checkBoxQtd_CheckedChanged);
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Location = new System.Drawing.Point(650, 287);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(89, 15);
            this.labelLista.TabIndex = 15;
            this.labelLista.Text = "Lista Completa:";
            // 
            // textBoxLista
            // 
            this.textBoxLista.Enabled = false;
            this.textBoxLista.Location = new System.Drawing.Point(460, 311);
            this.textBoxLista.Multiline = true;
            this.textBoxLista.Name = "textBoxLista";
            this.textBoxLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLista.Size = new System.Drawing.Size(317, 127);
            this.textBoxLista.TabIndex = 16;
            // 
            // FormAlternativa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLista);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.checkBoxQtd);
            this.Controls.Add(this.checkBoxLista);
            this.Controls.Add(this.checkBoxAlunos);
            this.Controls.Add(this.textBoxAlunos);
            this.Controls.Add(this.textBoxQtd);
            this.Controls.Add(this.labelAlunos);
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.labelMostrarObj);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.buttonEntrar);
            this.Name = "FormAlternativa1";
            this.Text = "Leitor de Arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEntrar;
        private TextBox textBoxSenha;
        private TextBox textBoxLogin;
        private Label labelLogin;
        private Label labelSenha;
        private Label labelMostrarObj;
        private Label labelQtd;
        private Label labelAlunos;
        private TextBox textBoxQtd;
        private TextBox textBoxAlunos;
        private CheckBox checkBoxAlunos;
        private CheckBox checkBoxLista;
        private CheckBox checkBoxQtd;
        private Label labelLista;
        private TextBox textBoxLista;
    }
}