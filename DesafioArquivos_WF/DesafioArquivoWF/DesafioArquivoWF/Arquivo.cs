using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesafioArquivoWF
{
    public class Arquivo
    {
        public (List<string>, List<string>) ExtrairDados(string arquivo)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            List<Aluno> alunos = new List<Aluno>();
            List<string> listagemAlunos = new List<string>();
            List<string> listagemPessoas = new List<string>();

            StreamReader leitor = new StreamReader(arquivo);

                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    if (linha.StartsWith("X"))
                    {
                        continue;
                    }
                    else if (linha.StartsWith("Z"))
                    {
                        string[] vetorPessoa = linha.Split('-');
                        var nome = vetorPessoa[1];
                        var telefone = vetorPessoa[2];
                        var cidade = vetorPessoa[3];
                        var rg = vetorPessoa[4];
                        var cpf = vetorPessoa[5];

                        pessoas.Add(new Pessoa(nome, telefone, cidade, rg, cpf));
                    }

                    else if (linha != null && linha.StartsWith("Y"))
                    {
                        string[] vetorAluno = linha.Split('-');
                        var matricula = vetorAluno[1];
                        var codigoDoCurso = vetorAluno[2];
                        var nomeDoCurso = vetorAluno[3];

                        var p = pessoas[pessoas.Count - 1];
                        alunos.Add(new Aluno(p.Nome, p.Telefone, p.Cidade, p.RG, p.CPF,
                            matricula, codigoDoCurso, nomeDoCurso));
                    }
                }
                leitor.Close();
            foreach (var aluno in alunos)
            {
                listagemAlunos.Add($"Aluno: {aluno.Nome} e curso: {aluno.NomeDoCurso}");
            }
            foreach (var pessoa in pessoas)
            {
                listagemPessoas.Add($"Nome: {pessoa.Nome} - Telefone: {pessoa.Telefone} - Cidade: {pessoa.Cidade} - RG: {pessoa.RG} - CPF: {pessoa.CPF}");
            }

           return (listagemAlunos, listagemPessoas);
        }
    }
}
