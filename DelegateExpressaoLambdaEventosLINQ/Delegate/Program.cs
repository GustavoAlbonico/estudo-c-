var resultado = Calculadora.Somar(10, 40);
Console.WriteLine(resultado);

DelegateCalculadora calc = Calculadora.Somar;
var resultado1 = calc(20, 30);
Console.WriteLine($"Soma = {resultado1}");

calc = Calculadora.Dividir;
var resultado2 = calc(20, 30);
Console.WriteLine($"Dividir = {resultado2}");

calc = Calculadora.Subtrair;
var resultado3 = calc(20, 30);
Console.WriteLine($"Subtrair = {resultado3}");

calc = Calculadora.Multiplicar;
var resultado4 = calc(20, 30);
Console.WriteLine($"Multiplicar = {resultado4}");

//DELEGATE MULTICAST
MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);
delegateMulticast += Metodo2;
delegateMulticast += Metodo3;

delegateMulticast("Olá, multicasta delegate!");

delegateMulticast -= Metodo3;
delegateMulticast("O Metodo3 foi removido...");

Console.ReadKey();
static void Metodo1(string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}
static void Metodo2(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}
static void Metodo3(string mensagem)
{
    Console.WriteLine("Método 3: " + mensagem);
}

//DELEGATES
public delegate float DelegateCalculadora(float x, float y);
public delegate void MeuDelegate(string mensagem);
