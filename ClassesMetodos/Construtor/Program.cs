System.Console.WriteLine("Construtor");

Aluno aluno = new("Roberto", 30, "Masculino", "S");

System.Console.WriteLine(aluno.Nome ?? "null");
System.Console.WriteLine(aluno.Idade);
System.Console.WriteLine(aluno.Sexo ?? "null");
System.Console.WriteLine(aluno.Aprovado ?? "null");

System.Console.WriteLine(Aluno.Cpf);

public class Aluno
{
    public static string Cpf;
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public Aluno(string nome) => Nome = nome;

    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome)
    {
        System.Console.WriteLine("Executando construtor parametrizado");

        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    static Aluno()//contrutor estatico é inicializado antes do contrutor 'normal' e junto
    {
        System.Console.WriteLine("Executando construtor estático");
        
        Cpf = "07823547896";
    }
}