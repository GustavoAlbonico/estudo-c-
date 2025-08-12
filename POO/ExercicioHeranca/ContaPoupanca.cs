public class ContaPoupanca : Conta
{
    public override double Juros { get; set; } = 0.005;

    public ContaPoupanca(int numero, string? nome) : base(numero, nome){}

    public override void Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Você sacou: {valor.ToString("c")}");
        }
        else
        {
            Console.WriteLine($"{valor.ToString("c")} excede o limite da conta para saque!");

        }
    }
}