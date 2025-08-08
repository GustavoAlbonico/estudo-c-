Console.WriteLine("## Propriedades ##\n");

Produto p1 = new();
p1.Nome = "Caderno Espiral";
p1.Preco = 4.99;
p1.EstoqueMinimo = 10;

p1.Exibir();

Console.ReadKey();