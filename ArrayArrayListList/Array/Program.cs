//declaração do array
int[] numeros;

//aloquei na memória e atribui valores
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes1 = new string[5] { "Ana", "Maria", "Marta", "Paulo", "Carlos" };
string[] nomes2 = new string[] { "Ana", "Maria", "Marta", "Paulo", "Carlos" };
string[] nomes = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

//acessal um elemento
Console.WriteLine(nomes[2]);

int[] numeros1;
numeros1 = new int[3];//inicia todas as posições com valor default '0'

numeros1[0] = 1;
numeros1[1] = 2;
numeros1[2] = 3;

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

Array.Reverse(nomes);//reverte a ordem
Array.Sort(nomes); //ordena
Array.BinarySearch(nomes,"Ana"); //encontra o elemento e retornar o indece se nao encontrar retornar menor q 0