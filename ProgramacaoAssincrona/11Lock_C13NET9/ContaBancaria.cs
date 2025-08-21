public class ContaBancaria
{
    private readonly Lock _lock = new();
    public decimal Saldo { get; set; }
    public ContaBancaria(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("Valor do saque deve ser positivo");

        using (_lock.EnterScope())
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saaque de {valor} realizado com sucesso. Novo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}