
using System.Diagnostics.CodeAnalysis;

Pessoa teste = new("jose",12);


public class Pessoa
{
    public required string? Nome { get; set; }
    public required int Idade { get; set; }

    public Pessoa() { }

    [SetsRequiredMembers]
    public Pessoa(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}