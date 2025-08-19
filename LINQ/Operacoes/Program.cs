using System.Runtime.CompilerServices;

var listas = new List<List<int>> {
    new List<int> {1, 2, 3},
    new List<int> {16},
    new List<int> {12, 50, 40, 22},
    new List<int> {90, 10, 10, 10, 59},
};

IEnumerable<int> resultado = listas.SelectMany(lista => lista.Distinct());//jutan todas os IEnumerable em um só

foreach (var item in resultado)
{
    Console.Write($"{item} ");
}

//base de dados
var idades = FonteDados.GetIdades();
var nomes = FonteDados.GetNomes();
var alunos = FonteDados.GetAlunos();
var alunos2 = FonteDados.GetAlunos2();
var paises1 = FonteDados.GetPaises1();
var paises2 = FonteDados.GetPaises2();
var turmaA = FonteDados.GetTurmaA();
var turmaB = FonteDados.GetTurmaB();
var pessoas = FonteDados.GetPessoas();
var enderecos = FonteDados.GetEnderecos();
var cursos = FonteDados.GetCursos();

//------------------------CONJUNTO-----------------------------//

Console.WriteLine("\n---------------DISTINCT-------------------");
var idadesDistintas = idades.Distinct();
FonteDados.ExibirLista(idadesDistintas);

var nomesDistintos = nomes.Distinct(StringComparer.OrdinalIgnoreCase);
FonteDados.ExibirLista(nomesDistintos);

Console.WriteLine("\n---------------DISTINCT BY-------------------");
var alunosIdadesDistintas = alunos.DistinctBy(a => a.Idade);
FonteDados.ExibirLista(alunosIdadesDistintas);

Console.WriteLine("\n---------------EXCEPT-------------------");//esta presente da fonte X e nao está na Y
var resultadoExcept = paises1.Except(paises2);
FonteDados.ExibirLista(resultadoExcept);

var resultadoExceptIgnoreCase = paises1.Except(paises2, StringComparer.OrdinalIgnoreCase);
FonteDados.ExibirLista(resultadoExceptIgnoreCase);

Console.WriteLine("\n---------------EXCEPT BY-------------------");//esta presente da fonte X e nao está na Y
var alunosReprovadosExcept = alunos.Where(aluno => aluno.Idade < 22)
                             .Select(aluno => aluno.Nome);

var alunosAprovadosExcept = alunos.ExceptBy(alunosReprovadosExcept, aluno => aluno.Nome);
FonteDados.ExibirLista(alunosAprovadosExcept);

Console.WriteLine("\n---------------INTERSECT-------------------");//esta presente em ambas as fontes
var resultadoIntersect = turmaA.Select(p => p.Nascimento?.Year).Intersect(turmaB.Select(p => p.Nascimento?.Year));
FonteDados.ExibirLista(resultadoIntersect);

var resultadoIntersectIgnoreCase = turmaA.Select(p => p.Nome).Intersect(turmaB.Select(p => p.Nome), StringComparer.OrdinalIgnoreCase);
FonteDados.ExibirLista(resultadoIntersectIgnoreCase);

Console.WriteLine("\n---------------INTERSECT BY-------------------");//esta presente em ambas as fontes

var alunosDaTurmaAComMesmoAnoNascimentoTurmaB = turmaA.IntersectBy(turmaB.Select(p => p.Nascimento?.Year), p => p.Nascimento?.Year);
FonteDados.ExibirLista(alunosDaTurmaAComMesmoAnoNascimentoTurmaB);

Console.WriteLine("\n---------------UNION -------------------");//Une ambas as fontes
var resultadoUnion = paises1.Union(paises2);
FonteDados.ExibirLista(resultadoUnion);

var resultadoUnionIgnoreCase = paises1.Union(paises2, StringComparer.OrdinalIgnoreCase);
FonteDados.ExibirLista(resultadoUnionIgnoreCase);

Console.WriteLine("\n---------------UNION BY-------------------");//Une ambas as fontes
var alunosTurmaATurmaBJuntas = turmaA.UnionBy(turmaB, p => p.Nome);
FonteDados.ExibirLista(alunosTurmaATurmaBJuntas);

//------------------------ORDENAÇÃO-----------------------------//
Console.WriteLine("\n--------------- ORDER BY | ORDER BY ASCENDING | THEN BY | THEN BY ASCENDING -------------------");
var alunosOrdenados = alunos.OrderBy(aluno => aluno.Nome);
var alunosOrdenadosDecrescente = alunos.OrderByDescending(aluno => aluno.Nome);

var alunosOrdenadosThen = alunos.OrderBy(aluno => aluno.Nome)
                                .ThenBy(aluno => aluno.Nascimento?.Year)
                                .ThenBy(aluno => aluno.Idade);

var alunosOrdenadosDecrescenteThen = alunos.OrderBy(aluno => aluno.Nome)
                                .ThenByDescending(aluno => aluno.Nascimento?.Year);

Console.WriteLine("\n--------------- REVERSE -------------------");

IEnumerable<int> idadesInvetidasIEnumerable = idades.AsEnumerable().Reverse();
IQueryable<int> idadesInvetidasIQueryable = idades.AsQueryable().Reverse();

//------------------------AGREGAÇÃO-----------------------------//
Console.WriteLine("\n--------------- AGGREGATE -------------------");
Console.WriteLine("------------1ª sobrecarga--------------");

var nomesSeparadosPorVirgula = nomes.Aggregate((nome1, nome2) => nome1 + ", " + nome2);
Console.WriteLine(nomesSeparadosPorVirgula);

var totalIdade = idades.Aggregate((idade1, idade2) => idade1 + idade2);
Console.WriteLine(totalIdade);

Console.WriteLine("\n------------2ª sobrecarga--------------");
var nomesAlunos = alunos.Aggregate("Nomes : ", (semente, aluno) => semente += aluno.Nome + ", ");
int indice = nomesAlunos.LastIndexOf(",");
nomesAlunos = nomesAlunos.Remove(indice);
Console.WriteLine(nomesAlunos);

Console.WriteLine("\n------------3ª sobrecarga--------------");
var nomesAlunos1 = alunos.Aggregate(
    "Nomes : ",
    (semente, aluno) => semente += aluno.Nome + ", ",
    resultado => resultado.Substring(0 , resultado.Length - 2)
    // resultado => resultado[..^2] //OU
);
Console.WriteLine(nomesAlunos1);

Console.WriteLine("\n--------------- AVERAGE -------------------");
var mediaIdades = alunos.Average(aluno => aluno.Idade);

Console.WriteLine("\n--------------- COUNT -------------------");//se for null lança exceção in32 tamanho limite
Console.WriteLine("------------1ª sobrecarga--------------");
var quantidadeNomes = nomes.Count();

Console.WriteLine("\n------------2ª sobrecarga--------------");
var quantidadeNomes1 = nomes.Count(nome => nome.Contains('c'));

Console.WriteLine("\n--------------- LONG COUNT -------------------");//se for null lança exceção
Console.WriteLine("------------1ª sobrecarga--------------");
var quantidadeNomes2 = nomes.LongCount();

Console.WriteLine("\n------------2ª sobrecarga--------------");
var quantidadeNomes3 = nomes.LongCount(nome => nome.Contains('c'));

Console.WriteLine("\n--------------- SUM -------------------");
var somaIdades = idades.Sum();

var somaIdades2 = idades.Sum(idade =>
{
    if (idade > 20)
        return idade;
    else
        return 0;
});

var somaIdades3 = idades.Sum(idade => idade > 20 ? idade : 0);

Console.WriteLine("\n--------------- MAX -------------------");
var maiorIdade = alunos.Max(aluno => aluno.Idade);
var maiorIdade2 = alunos.Max(aluno => aluno.Idade > 20 ? aluno.Idade : 0);

Console.WriteLine("\n--------------- MAX BY -------------------");
Aluno? maisVelho = alunos.MaxBy(aluno => aluno.Nascimento?.Year);

Console.WriteLine("\n--------------- MIN -------------------");
var menorIdade = alunos.Min(aluno => aluno.Idade);
var menorIdade2 = alunos.Min(aluno => aluno.Idade > 20 ? aluno.Idade : 0);

Console.WriteLine("\n--------------- MIN BY -------------------");
Aluno? maisNovo = alunos.MinBy(aluno => aluno.Nascimento?.Year);

//------------------------QUANTIFICAÇÃO-----------------------------//
Console.WriteLine("\n--------------- ALL -------------------");
bool todosSaoPares = idades.All(idade => idade % 2 == 0);
bool todosSaoMaiorIdade= alunos.All(aluno => aluno.Idade > 18);

Console.WriteLine("\n--------------- ANY -------------------");
bool existeAlgumPar = idades.Any(idade => idade % 2 == 0);
bool existeAlgumMaiorIdade = alunos.Any(aluno => aluno.Idade > 18);

Console.WriteLine("\n--------------- CONTAINS -------------------");
bool existePar = idades.Contains(10);

//------------------------AGRUPAMENTO-----------------------------//
Console.WriteLine("\n--------------- GROUP BY -------------------");
var alunosAgrupadosPorIdade = alunos.GroupBy(aluno => aluno.Idade);
var grupo = alunos2.GroupBy(x => new { x.Curso, x.Sexo })
                  .OrderBy(g => g.Key.Curso)
                  .ThenBy(g => g.Key.Sexo)
                  .Select(g => new
                  {
                      g.Key.Curso,
                      g.Key.Sexo,
                      Alunos = g.OrderBy(x => x.Nome),
                  });

Console.WriteLine("\n--------------- TO LOOK UP -------------------");
var alunosAgrupadosPorIdade2 = alunos.ToLookup(aluno => aluno.Idade); //ele ja faz a pesquisa na hora

