using System.Text;

namespace DesafioArquivoWF
{
    public partial class FormAlternativa1 : System.Windows.Forms.Form
    {
        public FormAlternativa1()
        {
            InitializeComponent();

        }       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<Aluno> alunos = new List<Aluno>();
            if (checkBoxQtd.Checked)
            {
                Arquivo extrator = new Arquivo();
                (List<string> listagemAlunos, _) = extrator.ExtrairDados("arquivo.txt");
                foreach (var item in listagemAlunos)
                {    
                    textBoxAlunos.AppendText(item + Environment.NewLine);
                }
            }
            else
            {
                textBoxAlunos.Text = "";
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string senha = textBoxSenha.Text;
            
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
      
                MessageBox.Show("Precisa digitar um Login e Senha!", "Alerta");

            }
            else
            {
                checkBoxQtd.Enabled = true;
                checkBoxAlunos.Enabled = true;
                checkBoxLista.Enabled = true;
                textBoxQtd.Enabled = true;
                textBoxAlunos.Enabled = true;
                textBoxLista.Enabled = true;              
            }
        }       
        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            textBoxSenha.PasswordChar = '*';
        }  
        private void checkBoxQtd_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBoxQtd.Checked)
            {
                Arquivo extrator = new Arquivo();             
                (List<string> listagemAlunos, List<string> listagemPessoas) = extrator.ExtrairDados("arquivo.txt");
                foreach (var item in listagemPessoas)
                {
                    textBoxQtd.Text = $"Pessoas: {listagemPessoas.Count} - Alunos: {listagemAlunos.Count}";                  
                }
            }
            else
            {
                textBoxQtd.Text = "";
            }
        }
        
        private void textBoxAlunos_TextChanged(object sender, EventArgs e)
        {

        }      
        private void checkBoxLista_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLista.Checked)
            {
                Arquivo extrator = new Arquivo();               
                (_, List<string> listagemPessoas) = extrator.ExtrairDados("arquivo.txt");
       
                foreach (var item in listagemPessoas)
                {
                   
                    textBoxLista.AppendText(item + Environment.NewLine);
                }
            }
            else
            {
                textBoxLista.Text = "";
            }

        }

        private void labelSenha_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAlunos_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void labelMostrarObj_Click(object sender, EventArgs e)
        {

        }
    }
}