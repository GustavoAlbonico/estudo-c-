namespace Exercicio;
public class Produto
{
    private string nome;
    private decimal preco;

    public string Nome { get => nome; set => nome = value; }
    public decimal Preco { get => preco; set => preco = value; }

    public Produto(string nome, decimal preco)
    {
        this.nome = nome;
        this.preco = preco;
    }
}