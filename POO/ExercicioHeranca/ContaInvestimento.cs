public class ContaInvestimento : Conta
{
    public override double Juros { get; set; } = 0.009;
    public double Imposto { get; set; } = 0.001;

    public ContaInvestimento(int numero, string? nome) : base(numero, nome){}

    private decimal CalcularImposto(double imposto)
    {
        return Saldo * (decimal)imposto;
    }
    public override void Sacar(decimal valor)
    {

        if (Saldo >= valor)
        {
            Saldo = Saldo - valor - CalcularImposto(Imposto);
            Console.WriteLine($"Você sacou: {valor.ToString("c")}");
        }
        else
        {
            Console.WriteLine($"{valor.ToString("c")} excede o limite da conta para saque!");

        }
    }
}