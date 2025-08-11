namespace Exercicio;

public class Pessoa
{
    private string nome;
    private int idade;

    public string Nome { get => nome; set => nome = value; }
    public int Idade { get => idade; set => idade = value; }

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {this.nome} Idade:{this.idade}");
    }
}