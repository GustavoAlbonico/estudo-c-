int[,] arrayMultidimencional = {
            { 11, 22, 33 },
            { 44, 55, 66 },
            { 77, 88, 99 },
        };

for (int i = 0; i < arrayMultidimencional.GetLength(0); i++)
{
    for (int j = 0; j < arrayMultidimencional.GetLength(1); j++)
    {
        Console.WriteLine($"{arrayMultidimencional[i, j]}");
    }
}

foreach (int x in arrayMultidimencional)
{
    Console.WriteLine($"{x}");
}

//exercicio
string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int x = 0; x < alunos.GetLength(1); x++)
    {
        System.Console.WriteLine($"Informe o nome do aluno que corresponde a linha: {i + 1} coluna:{x + 1}");
        alunos[i, x] = Console.ReadLine() ?? "";
    }
}

Console.WriteLine("\n\n");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int x = 0; x < alunos.GetLength(1); x++)
    {
        Console.WriteLine($"linha: {i + 1} coluna:{x + 1} nome:{alunos[i, x]}");
    }
}