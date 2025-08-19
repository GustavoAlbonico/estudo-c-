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
var paises1 = FonteDados.GetPaises1();
var paises2 = FonteDados.GetPaises2();
var turmaA = FonteDados.GetTurmaA();
var turmaB = FonteDados.GetTurmaB();

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
Console.WriteLine("\n--------------- AVERAGE -------------------");
Console.WriteLine("\n--------------- COUNT -------------------");
Console.WriteLine("\n--------------- LONG COUNT -------------------");
Console.WriteLine("\n--------------- MAX -------------------");
Console.WriteLine("\n--------------- MAX BY -------------------");
Console.WriteLine("\n--------------- MIN -------------------");
Console.WriteLine("\n--------------- MIN BY -------------------");
Console.WriteLine("\n--------------- SUM -------------------");