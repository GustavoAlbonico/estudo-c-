using Generics;

Teste teste = new();

int i1 = 10;
int i2 = 12;
teste.Comparar(i1, i2);

float f1 = 10;
float f2 = 12;
teste.Comparar(f1, f2);

string s1 = "10";
string s2 = "12";

TesteClassGenerics<int, int> teste1 = new();
teste1.Comparar(i1, i2);

TesteClassGenerics<float, float> teste2 = new();
teste2.Comparar(f1, f2);

//Exercio
ArrayGenerico<int> arrayGenericoInt = new();

arrayGenericoInt.Adicionar(10);
arrayGenericoInt.Adicionar(20);
arrayGenericoInt.Adicionar(30);
arrayGenericoInt.Adicionar(40);
arrayGenericoInt.Adicionar(50);

ArrayGenerico<string> arrayGenericoString = new();
arrayGenericoString.Adicionar("Roberto");
arrayGenericoString.Adicionar("Maria");
arrayGenericoString.Adicionar("Carlos");
arrayGenericoString.Adicionar("Jose");
arrayGenericoString.Adicionar("Lucia");

Console.WriteLine("\n");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{arrayGenericoInt[i]} ");
}
Console.WriteLine("\n");

for (int i = 0; i < 5; i++)
{
    Console.Write($"{arrayGenericoString[i]} ");
}


// --------------------------------
// TesteClassGenerics<string, string> teste3 = new(); //não pode pq struct é tipo por valor e string e tipo por referencia
// teste3.Comparar(s1, s2);
public class Teste
{
    public void Comparar<T>(T p1, T p2)
    {
        Console.WriteLine($"P1: {p1.GetType()} P2: {p2.GetType()}");
    }
}

public class TesteClassGenerics<T1, T2> where T1 : struct where T2 : struct
{
    public void Comparar(T1 p1, T2 p2)
    {
        Console.WriteLine($"P1: {p1.GetType()} P2: {p2.GetType()}");
    }
}


