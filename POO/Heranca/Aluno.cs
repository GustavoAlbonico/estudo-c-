using Heranca;

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }

    public Aluno() : base() //chama o Construtor da classe base Pessoa
    {
        Console.WriteLine("Construtor da classe Aluno");
    }
    public Aluno(string nome) : base(nome)//chama o Construtor da classe base Pessoa
    {
        Console.WriteLine("Construtor parametro da classe Aluno");
    }

    //para utilizar não utilizar a ação do método da classe pai 'Pessoa' precisa coloca 'new' na frente
    public new string Saudacao() => $"Oi meu nome é {Nome} do curso {Curso}";

    //utilizar override para sobreescrever um método virtual que está no pai
    public override void ExibirLocal()
    {
        Console.WriteLine("Eu estou estudando");
    }
}