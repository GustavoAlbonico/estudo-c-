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

    public Aluno(string? nome, int idade, DateTime nascimento, string curso, char sexo) : this(nome, idade, nascimento)
    {
        Curso = curso;
        Sexo = sexo;
    }

    public string? Nome { get; set; }
    public int Idade { get; set; }
    public DateTime? Nascimento { get; set; }
    public string Curso { get; set; }
    public char Sexo { get; set; }

    public override string ToString()
    {
        return $"Aluno: {Nome} tem {Idade} anos que nasceu {Nascimento?.ToShortDateString()}";
    }

}