using aula1;

var func1 = new Funcionario("Leo", 25, "00000", true);
var func2 = new Funcionario("Gustavo", 20, "00001", true);
var func3 = new Funcionario("Edna", 22, "00002", false);

List<Funcionario> funcionarios = new List<Funcionario>();

funcionarios.Add(func1);
funcionarios.Add(func2);
funcionarios.Add(func3);

var padaria1 = new Padaria("Padoca", "0000222203400", funcionarios);
var padaria2 = new Padaria("Paozin Quentin", "245h34ui534", new List<Funcionario>());

Console.WriteLine(padaria1.funcionarios[2].Nome + " é um funcionario da " + padaria1.Nome);

if (padaria2.funcionarios.Count > 0)
{
    Console.WriteLine(padaria2.funcionarios[0].Nome + " é um funcionario da " + padaria2.Nome);
}
else
{
    Console.WriteLine("não existe funcionario na " + padaria2.Nome);
}

foreach (var func in padaria2.funcionarios)
{
    Console.WriteLine(func.Nome);
}

var i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}

string? leitura = "";
leitura = Console.ReadLine();

Console.WriteLine(leitura);