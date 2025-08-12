namespace Heranca;

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public Pessoa()
    {
        Console.WriteLine("Construtor da classe pessoa");
    }

    public Pessoa(string nome)
    {
        Nome = nome;

        Console.WriteLine("Construtor parametro da classe pessoa");
    }

    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }

    public string Saudacao() => $"Oi meu nome é {Nome}";

    public virtual void ExibirLocal(){
        Console.WriteLine("Eu estou andando");
    }   

}