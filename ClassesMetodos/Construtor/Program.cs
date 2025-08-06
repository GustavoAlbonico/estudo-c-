System.Console.WriteLine("Construtor");

Aluno aluno = new("Roberto", 30, "Masculino", "S");

System.Console.WriteLine(aluno.Nome ?? "null");
System.Console.WriteLine(aluno.Idade);
System.Console.WriteLine(aluno.Sexo ?? "null");
System.Console.WriteLine(aluno.Aprovado ?? "null");

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public Aluno(string nome) => Nome = nome;

    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }
}