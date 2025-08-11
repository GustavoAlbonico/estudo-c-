using System.Collections;
using Exercicio;

//1-

string[] frutas = {
    "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"
};

//a
int tamanhoListaFrutas = frutas.Length;
for (int x = 0; x < tamanhoListaFrutas; x++)
{
    Console.Write($"{frutas[x]}, ");
}
Console.WriteLine($"\nTamanho da lista:{tamanhoListaFrutas}");


foreach (string fruta in frutas)
{
    Console.Write($"{fruta}, ");
}
Console.WriteLine($"\nTamanho da lista:{tamanhoListaFrutas}");

//b
Console.WriteLine($"Segundo item da lista:{frutas[1]}");
Console.WriteLine($"Penultimo item da lista:{frutas[tamanhoListaFrutas - 2]}");

//c
frutas[2] = "Kiwi";
frutas[tamanhoListaFrutas - 1] = "Caqui";

//d
Array.Sort(frutas);
foreach (string fruta in frutas)
{
    Console.Write($"{fruta}, ");
}

//e
Console.Write('\n');
Array.Reverse(frutas);
foreach (string fruta in frutas)
{
    Console.Write($"{fruta}, ");
}

//------------2-------------------
// Console.WriteLine("\n\n Exercio 2");

// Console.WriteLine("\nInforme o tamanho do Array:");
// int tamanhoArray = Convert.ToInt32(Console.ReadLine());
// var array = new int[tamanhoArray];

// for (int i = 0; i < tamanhoArray; i++)
// {
//     Console.WriteLine($"Informe o número da posição [{i + 1}] do array de tamanho {tamanhoArray}:");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }



// bool finalizarSistema = false;

// do
// {
//     Console.WriteLine("Informe um número para buscar no array:");
//     int numeroInformado = Convert.ToInt32(Console.ReadLine());
//     bool numeroInformadoExiste = Array.BinarySearch(array, numeroInformado) >= 0;

//     if (numeroInformadoExiste)
//     {
//         Console.WriteLine($"O número informado '{numeroInformado}' existe no array!");
//     }
//     else
//     {
//         Console.WriteLine($"O número informado '{numeroInformado}' não existe no array!");
//     }

//     Console.WriteLine("Digite 'fim' para finalizar o programa ou presione qualquer tecla para continuar");
//     finalizarSistema = Console.ReadLine() == "fim";
// }
// while (!finalizarSistema);

//-----------3-------------------
Console.WriteLine("\n\n Exercio 3");
float[,] alunos = new float[2, 5]{
    { 3.6f,4.6f,5.4f,9.5f,7.5f},
    { 7.56f,8.56f,9.67f,9.5f,2f}
};

for (int y = 0; y < alunos.GetLength(0); y++)
{
    float somaNotas = 0.0f;
    for (int z = 0; z < alunos.GetLength(1); z++)
    {
        somaNotas += alunos[y, z];
    }

    float mediaAritimetica = somaNotas / alunos.GetLength(1);
    Console.WriteLine($"Média do grupo{y + 1}: {Math.Round(mediaAritimetica, 1)}");
}


//-----------4-------------------
// Console.WriteLine("\n\n Exercio 4");

// ArrayList pessoas = new(3);
// for (int i = 0; i < pessoas.Capacity; i++)
// {
//     Console.WriteLine($"Informe o nome da {i + 1}ª pessoa:");
//     string nomePessoa = Console.ReadLine() ?? "Fulano";

//     Console.WriteLine($"Informe a idade da {i + 1}ª pessoa:");
//     int idadePessoa = Convert.ToInt32(Console.ReadLine());

//     pessoas.Add(new Pessoa(nome: nomePessoa, idade: idadePessoa));
// }
// ExibirListaPessoas(pessoas);

// pessoas.Add(new Pessoa(nome: "Carlinha", idade: 18));
// pessoas.Add(new Pessoa(nome: "Roberta", idade: 22));
// ExibirListaPessoas(pessoas);

// pessoas.RemoveAt(pessoas.Count - 1);
// ExibirListaPessoas(pessoas);

// static void ExibirListaPessoas(ArrayList pessoas)
// {
//     foreach (Pessoa pessoa in pessoas)
//     {
//         pessoa.Exibir();
//     }

//     Console.WriteLine("\n");
// }


//-----------5-------------------
Console.WriteLine("\n\n Exercio 5");

List<Produto> produtos = [
    new("Clips",3.95m),
    new("Caneta",5.99m),
    new("Lápis",4.15m),
    new("Estojo",6.99m),
    new("Caderno",7.55m),
];

//a
decimal somaPrecoProdutos = produtos.Sum(produto => produto.Preco);
decimal mediaPrecoProdutos = produtos.Average(produto => produto.Preco);

Console.WriteLine($"Soma preço total: {somaPrecoProdutos}");
Console.WriteLine($"Média preço: {Math.Round(mediaPrecoProdutos, 2)}");
Console.WriteLine($"Quantidade de produtos: {produtos.Count()}");
ExibirListaProdutos(produtos);

//b
produtos.Add(new(nome: "Mochila", preco: 22.44m));
ExibirListaProdutos(produtos);

//c
List<Produto> produtosOrdenados = produtos.OrderBy(produto => produto.Nome).ToList();
ExibirListaProdutos(produtosOrdenados);

//d
List<Produto> produtosFiltrados = produtos.FindAll(produto => produto.Preco < 5m);
ExibirListaProdutos(produtosFiltrados);

//e
int posicaoProdutoEncontrado = produtos.FindIndex(produto => produto.Nome.Equals("Estojo"));
Console.WriteLine($"Posição que foi encontrado o produto: {posicaoProdutoEncontrado}");


static void ExibirListaProdutos(List<Produto> produtos)
{
    Console.WriteLine("Produto | Preço");
    foreach (Produto produto in produtos)
    {
        Console.WriteLine($"{produto.Nome} | {produto.Preco.ToString("c")}");
    }

    Console.WriteLine("\n");
}

