ContaCorrente contaCorrente = new(123, "Roberto");
Console.WriteLine($"{contaCorrente.Nome} - {contaCorrente.Numero} - {contaCorrente.Saldo}");
contaCorrente.Depositar(1000m);
contaCorrente.ExibirSaldo();
contaCorrente.Sacar(100m);
contaCorrente.ExibirSaldo();
contaCorrente.Sacar(2000m);
contaCorrente.ExibirSaldo();

Console.WriteLine("\n\n");

ContaPoupanca contaPoupanca = new(345, "Carla");
Console.WriteLine($"{contaPoupanca.Nome} - {contaPoupanca.Numero} - {contaPoupanca.Saldo}");
contaPoupanca.Depositar(1000m);
contaPoupanca.ExibirSaldo();
contaPoupanca.Sacar(100m);
contaPoupanca.ExibirSaldo();
contaPoupanca.Sacar(2000m);
contaPoupanca.ExibirSaldo();

Console.WriteLine("\n\n");

ContaInvestimento contaInvestimento = new(859, "Fernando");
Console.WriteLine($"{contaInvestimento.Nome} - {contaInvestimento.Numero} - {contaInvestimento.Saldo}");
contaInvestimento.Depositar(1000m);
contaInvestimento.ExibirSaldo();
contaInvestimento.Sacar(100m);
contaInvestimento.ExibirSaldo();
contaInvestimento.Sacar(2000m);
contaInvestimento.ExibirSaldo();