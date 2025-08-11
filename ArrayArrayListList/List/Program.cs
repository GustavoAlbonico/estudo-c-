using Lista;

List<int> lista;
lista = new List<int>();

List<int> lista1 = new List<int>();
var lista2 = new List<int>();
List<int> lista3 = new();

List<int> lista4 = new List<int>(5); //capacity 5
var lista5 = new List<int>(5);//capacity 5
List<int> lista6 = new(5);//capacity 5

List<string> lista7 = new();

lista7.Add("Paulo");
lista7.Add("Roberto");
lista7.Add("Carlos");
lista7.Add("Thiago");
lista7.Add("Rodrigo");
lista7.Add("Carla");

var lista8 = new List<string>() { "Paulo", "Paulo", "Carlos", "Thiago", "Rodrigo", "Carla" };

lista8.Add("Carlos");//adiciona ao final
lista8.Insert(2, "José");//adiciona na posição informada


var lista9 = new List<int>() { 7, 5, 8, 9 };

int[] array1 = { 1, 2, 3 };

lista9.AddRange(array1); //adicionando coleção vai ficar ["Maria", 5, true, 1 , 2, 3]
lista9.InsertRange(2, array1);

lista9.Remove(7);//'objeto'
lista9.RemoveAt(2); //indice
lista9.RemoveRange(2, 2); //inicio|quantidade 

var lista10 = new List<string>() { "Paulo", "Paulo", "Carlos", "Thiago", "Rodrigo", "Carla" };

var res1 = lista10.Contains("Maria");//verifica se possui o elelemto na lista
bool res2 = lista10.Contains("Carla");

var lista11 = new List<string>() { "Maria", "Roberto", "Ana Luiza", "Pitagoras", "Carlos" };

lista11.Sort();//ordena o arraylist
lista11.Clear();//limpa o arraylist
Console.WriteLine(lista11.Count); //verifica o tamnho do arraylist

//recomendado usar list atualmente e nao arraylist pelo desempenho não ser tão eficiente

//Expressões lambda com metodos find

List<string> frutas = new()
{
    "Banana", "Uva", "Maça", "Coco","Pera","Abacate","Morango","Laranja"
};

var fruta1 = frutas.Find(fruta => fruta.Contains('a')); //busca o primeiro que atende a condição
var fruta2 = frutas.FindLast(fruta => fruta.Contains('a'));
var fruta3 = frutas.FindIndex(fruta => fruta.Contains('a'));  //busca o primeiro que atende a condição
var fruta4 = frutas.FindLastIndex(fruta => fruta.Contains('a'));
var fruta5 = frutas.FindAll(fruta => fruta.Contains('a'));

var fruta6 = frutas.Find(Procurar);

static bool Procurar(string item)
{
    return item.Contains('n');
}

//Exercicio
var alunos = new List<Aluno>()
{
    new("Maria",8.75),
    new("Manoel",6.95),
    new("Amanda",7.25),
    new("Carlos",6.55),
    new("Jaime",8.50),
    new("Debora",5.95),
    new("Alicia",9.25),
    new("Sandra",5.55),
    new("Marta",7.85),
    new("Sueli",9.15),
};

ExibirListaAlunos(alunos);

Console.WriteLine("Adicionando");
alunos.Add(new("Bia", 7.75));
alunos.Add(new("Mario", 8.95));
ExibirListaAlunos(alunos);

Console.WriteLine("Ecnotrando e Removendo");
var alunoEncontrado = alunos.Find(aluno => aluno.Nome.Equals("Amanda"));
alunos.Remove(alunoEncontrado);
ExibirListaAlunos(alunos);

Console.WriteLine("Ordenando");
alunos = alunos.OrderBy(aluno => aluno.Nome).ToList();
ExibirListaAlunos(alunos);

Console.WriteLine(" > 8");
List<Aluno> alunosProdigios = alunos.FindAll(aluno => aluno.Nota >= 8);
ExibirListaAlunos(alunosProdigios);

static void ExibirListaAlunos(List<Aluno> alunos)
{

    double somaNotas = 0.0;
    foreach (Aluno aluno in alunos)
    {
        Console.WriteLine($"Aluno: {aluno.Nome} Nota: {aluno.Nota}");

        somaNotas += aluno.Nota;
    }

    double mediaNotas = somaNotas / alunos.Count();

    Console.WriteLine($"Média aritimética: {Math.Round(mediaNotas,2)}");
    Console.WriteLine($"Quantidade de Alunos: {alunos.Count}");

    Console.WriteLine("\n\n");
}