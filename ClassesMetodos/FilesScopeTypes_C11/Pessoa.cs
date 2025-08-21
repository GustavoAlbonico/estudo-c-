public class Pessoa
{
    public string? Nome { get; set; }
    public int GetIdentidade()
    {
        var identidade = new PessoaIdentidade();
        return identidade.GetCPF;
    }
}

file class PessoaIdentidade//so pode ser utilizada dentro do arquivo Pessoa.cs não pode ser instaciada fora daqui ou coisa do tipo
{
    public int GetCPF => 21321312;
}