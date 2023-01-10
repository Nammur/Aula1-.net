using aula1;

namespace aula1
{
    public class Padaria
    {
        public string Nome; 
        public string cnpj;
        public List<Funcionario> funcionarios;

        public Padaria(string nome, string cnpj, List<Funcionario> funcionarios)
        {
            Nome = nome;
            this.cnpj = cnpj;
            this.funcionarios = funcionarios;
        }

    }
}
