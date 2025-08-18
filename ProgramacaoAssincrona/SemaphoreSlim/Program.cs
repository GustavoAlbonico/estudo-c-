


SemaphoreSlim semaphoreSlim = new(4);

for (int i = 0; i < 6; i++)
{
    string threadName = "Thread" + i;
    int espera = 2 + 2 * i;

    var thread = new Thread(() => AcessarBancoDados(threadName, espera));

    thread.Start();
}

void AcessarBancoDados(string nome, int seconds)
{
    Console.WriteLine($"{nome} aguarda para acessar o banco de dados...");
    semaphoreSlim.Wait();

    Console.WriteLine($"{nome} foi autorizado para acessar o banco de dados...");
    Thread.Sleep(TimeSpan.FromSeconds(seconds));

    Console.WriteLine($"{nome} foi concluido");
    semaphoreSlim.Release();
    
}
