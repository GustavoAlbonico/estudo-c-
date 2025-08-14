EstrategiaDesconto descontoClienteRegular = DescontoClienteRegular;
EstrategiaDesconto descontoClienteVIP = DescontoClienteVIP;
EstrategiaDesconto descontoClienteNovo = DescontoClienteNovo;

// Cria pedidos com diferentes estratégias de desconto
Pedido pedido1 = new Pedido(1000, descontoClienteRegular);
Pedido pedido2 = new Pedido(1000, descontoClienteVIP);
Pedido pedido3 = new Pedido(1000, descontoClienteNovo);

// Calcula e exibe o valor final dos pedidos com desconto aplicado
Console.WriteLine("Valor final para cliente regular: " + pedido1.CalcularValorFinal());
Console.WriteLine("Valor final para cliente VIP: " + pedido2.CalcularValorFinal());
Console.WriteLine("Valor final para cliente novo: " + pedido3.CalcularValorFinal());


// Implementação das estratégias de desconto
static double DescontoClienteRegular(double valorTotal)
{
    return valorTotal * 0.95; // 5% de desconto
}

static double DescontoClienteVIP(double valorTotal)
{
    return valorTotal * 0.90; // 10% de desconto
}

static double DescontoClienteNovo(double valorTotal)
{
    return valorTotal * 0.97; // 3% de desconto
}