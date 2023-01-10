using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1
{
    public class Funcionario
    {
        public string Nome;
        public int Idade;
        public string Cpf;
        public bool IsHomem;

        public Funcionario(string nome, int idade, string cpf, bool isHomem)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            IsHomem = isHomem;
        }
    }

    
    
}
