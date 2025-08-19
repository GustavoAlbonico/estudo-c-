public class Aluno
{
    public Aluno() { }
    public Aluno(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public Aluno(string? nome, int idade, DateTime nascimento) : this(nome, idade)
    {
        Nascimento = nascimento;
    }

    public string? Nome { get; set; }
    public int Idade { get; set; }
    public DateTime? Nascimento { get; set; }

    public override string ToString()
    {
        return $"Aluno: {Nome} tem {Idade} anos que nasceu {Nascimento?.ToShortDateString()}";
    }

}