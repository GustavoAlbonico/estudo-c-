public delegate double EstrategiaDesconto(double valorTotal);
 
public class Pedido
{
    public double ValorTotal { get; set; }
    public EstrategiaDesconto EstrategiaDesconto { get; set; }
 
    public Pedido(double valorTotal, EstrategiaDesconto estrategiaDesconto)
    {
        ValorTotal = valorTotal;
        EstrategiaDesconto = estrategiaDesconto;
    }
 
    public double CalcularValorFinal()
    {
        return EstrategiaDesconto(ValorTotal);
    }
}