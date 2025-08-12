public class Conta
{
    public int Numero { get; set; }
    public string? Nome { get; set; }
    public decimal Saldo { get; set; }
    public virtual double Juros { get; set; } = 0.00;

    public Conta(int numero, string? nome)
    {
        Numero = numero;
        Nome = nome;
        Saldo = 0m;
    }


    private decimal CalculaRemuneracao(double juros)
    {
        return Saldo * (decimal)juros;
    }

    public virtual void Sacar(decimal valor)
    {
        Saldo -= valor;

        Console.WriteLine($"Você sacou: {valor.ToString("c")}");
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
        Saldo = Saldo + CalculaRemuneracao(Juros);

        Console.WriteLine($"Você depositou: {valor.ToString("c")}");
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"O saldo atual da sua conta é {Saldo.ToString("c")}");
    }




}