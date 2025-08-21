var conta = new ContaBancaria(100);

//dessa forma ele faz que cada thred so possa sacar uma por vez evitando conflito
Parallel.For(0, 10, _ =>
{
    conta.Sacar(20);
});