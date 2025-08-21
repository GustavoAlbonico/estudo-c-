public class Pessoa
{
    public string? Nome
    {
        get;
        set => field = value ?? throw new ArgumentException($"O {nameof(Nome)} não pode ser null.");
    }

    public int Idade { get; set; }


    public Pessoa() { }

    public Pessoa(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    [MeuAtributo(nameof(meuParametro))] //nameof estendido
    public void MeuMetodoComParametros(string meuParametro)
    {

    }
}