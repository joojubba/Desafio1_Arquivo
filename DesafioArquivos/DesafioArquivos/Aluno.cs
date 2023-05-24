using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioArquivos
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string CodigoDoCurso { get; set; }
        public string NomeDoCurso { get; set; }

        public Aluno(string nome, string telefone, string cidade, string rg, string cpf,
            string matricula, string codigoDoCurso, string nomeDoCurso) : base(nome, telefone, cidade, rg, cpf)
        {
            Matricula = matricula;
            CodigoDoCurso = codigoDoCurso;
            NomeDoCurso = nomeDoCurso;
        }
    }
}
