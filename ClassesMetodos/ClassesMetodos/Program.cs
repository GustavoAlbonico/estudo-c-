System.Console.WriteLine("Classes e Métodos");


Pessoa p1 = new Pessoa();
p1.Nome = "Maria";
p1.Idade = 25;
p1.Sexo = "feminino";

System.Console.WriteLine($"{p1.Nome} {p1.Idade} {p1.Sexo}");

Pessoa p2 = new Pessoa();
p2.Nome = "Manoel";
p2.Idade = 25;
p2.Sexo = "masculino";

System.Console.WriteLine($"{p2.Nome} {p2.Idade} {p2.Sexo}");

class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? Sexo;

}