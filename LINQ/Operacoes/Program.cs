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
    resultado => resultado.Substring(0, resultado.Length - 2)
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
bool todosSaoMaiorIdade = alunos.All(aluno => aluno.Idade > 18);

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

//------------------------JUNÇÃO-----------------------------//
Console.WriteLine("\n--------------- JOIN -------------------");
Console.WriteLine("------------INNER--------------"); //tem em ambas as fontes

/*
var innerJoin = contexto.Funcionarios           //Outer data source
.Join(
    contexto.Setores,                           //Inner data source
        funcionario => funcionario.SetorId,     //Inner Key Selector
        setor => setor.SetorId,                 //Outer Key Selector
        (funcionario, setor) => new             //Projetando os dados em um conjunto
        {
            NomeFuncionario = funcionario.FuncionarioNome,
            NomeSetor = setor.SetorNome,
            CargoFuncionario = funcionario.FuncionarioCargo
        }).toList();
*/

Console.WriteLine("------------LEFT--------------"); //todas da primeira fonte e o que são iguais em ambas fontes
/*
var leftJoin = (from f in contexto.Funcionarios
                join s in contexto.Setores
                on f.SetorId equals s.SetorId
                into funciSetorGrupo
                from setor in funciSetorGrupo.DefaultIfEmpty()
                select new
                {
                    NomeFuncionario = f.FuncionarioNome,
                    CargoFuncionario = f.FuncionarioCargo,
                    NomeSetor = setor.SetorNome
                }).toList();
*/


Console.WriteLine("------------RIGHT--------------"); //todas da segunda fonte e o que são iguais em ambas fontes
//como não possui suporte apenas precisa inverter as tabelas

/*
var rightJoin = (from f in contexto.Setores
                join s in contexto.Funcionarios
                on f.SetorId equals s.SetorId
                into SetorFunciGrupo
                from setor in SetorFunciGrupo.DefaultIfEmpty()
                select new
                {
                    NomeFuncionario = f.FuncionarioNome,
                    CargoFuncionario = f.FuncionarioCargo,
                    NomeSetor = setor.SetorNome
                }).toList();
*/

Console.WriteLine("------------FULL--------------"); //todas da primeira fonte e da segunda fonte
//como não possui suporte apenas precisa utilizar o left e right e juntar os resultados

/*
var leftJoin = (from f in contexto.Funcionarios
                join s in contexto.Setores
                on f.SetorId equals s.SetorId
                into funciSetorGrupo
                from setor in funciSetorGrupo.DefaultIfEmpty()
                select new
                {
                    NomeFuncionario = f.FuncionarioNome,
                    CargoFuncionario = f.FuncionarioCargo,
                    NomeSetor = setor.SetorNome
                }).toList();

var rightJoin = (from f in contexto.Setores
                join s in contexto.Funcionarios
                on f.SetorId equals s.SetorId
                into SetorFunciGrupo
                from setor in SetorFunciGrupo.DefaultIfEmpty()
                select new
                {
                    NomeFuncionario = f.FuncionarioNome,
                    CargoFuncionario = f.FuncionarioCargo,
                    NomeSetor = setor.SetorNome
                }).toList();


var fullJoin = leftJoin.Union(rightJoin);
*/

Console.WriteLine("------------CROSS--------------"); //faz a junção de duas coleções para obter uma nova coleção onde cada par combinado esta presentado
                                                      //EX  A = {a , b}
                                                      //    B = {1 , 2, 3}  
                                                      //RESULTADO = A x B ={(a,1),(a,2),(a,3),(b,1),(b,2),(b,3)}

/*
var crossJoin = from f in contexto.Funcionarios
                from s in contexto.Setores
                select new
                {
                    Nome = f.FuncionarioNome,
                    Cargo = f.FuncionarioCargo,
                    Setor = s.SetorNome
                };
*/

Console.WriteLine("\n--------------- GROUP JOIN -------------------"); //retorna um resultado em grupo com base na chave de grupo
/*
var groupJoin = contexto.Setores                         //Outer data source
                .GroupJoin(contexto.Funcionarios ,       //Inner data source
                setor => setor.SetorId,                  //Outer Key Selector
                funcionario => funcionario.SetorId,      //Inner Key Selector
                (funcionario, funcionariosGrupo) => new  //Projetando os dados em um conjunto
                {
                    Funcionarios = funcionariosGrupo,
                    NomeSetor = funcionario.SetorNome,
                }).toList();
*/

Console.WriteLine("\n--------------- JOIN EXEMPLO ALEATORIO MAIS COMPLEXO-------------------");

var consulta = from pessoa in pessoas
               join endereco in enderecos
               on pessoa.EnderecoId equals endereco.Id
               join curso in cursos
               on pessoa.CursoId equals curso.Id
               select new
               {
                   ID = pessoa.Id,
                   PessoaNome = pessoa.Nome,
                   CursoNome = curso.Nome,
                   EnderecoLocal = endereco.Local,
               };

FonteDados.ExibirLista(consulta);

//------------------------ELEMENTO-----------------------------//
Console.WriteLine("\n--------------- ELEMENT AT-------------------");//retorna um elemento no indice ENVIADO | SE DER ERRO Exception
var elementAt = nomes.ElementAt(2);
var elementAt2 = alunos.ElementAt(5);

Console.WriteLine("\n--------------- ELEMENT AT OR DEFAULT-------------------");//retorna um elemento no indice ENVIADO | SE DER ERRO RETORNA null ou 0 depende o tipo de referencia
var elementAtOrDefault = nomes.ElementAtOrDefault(2);
var elementAtOrDefault2 = alunos.ElementAtOrDefault(5);

Console.WriteLine("\n--------------- FIRST-------------------");
var primeiro = nomes.First();
var primeiro2 = alunos.First(aluno => aluno.Idade > 10);

Console.WriteLine("\n--------------- FIRST OR DEFAULT-------------------");
var primeiroOrDefault = nomes.FirstOrDefault();
var primeiroOrDefault2 = alunos.FirstOrDefault();

Console.WriteLine("\n--------------- LAST-------------------");
var ultimo = nomes.Last();
var ultimo2 = alunos.Last(aluno => aluno.Idade > 10);

Console.WriteLine("\n--------------- LAST OR DEFAULT-------------------");
var ultimoOrDefault = nomes.LastOrDefault();
var ultimoOrDefault2 = alunos.LastOrDefault();

Console.WriteLine("\n--------------- SINGLE-------------------");//retorna APENAS 1 elemento, SE retornar menos que UM OU MAIS da 'erro'
var single = nomes.Single();//vai dar erro pq tem mais de 1 na lista
var single2 = alunos.Single(aluno => aluno.Idade > 10);//vai dar erro pq tem mais de 1 na lista que atende a condição

Console.WriteLine("\n--------------- SINGLE OR DEFAULT-------------------");//se o resultado tiver mais que um elemento continua lançando a excecao
var singleOrDefault = nomes.SingleOrDefault();//vai dar erro pq tem mais de 1 na lista
var singleOrDefault2 = alunos.SingleOrDefault(aluno => aluno.Idade > 10);//vai dar erro pq tem mais de 1 na lista que atende a condição

Console.WriteLine("\n--------------- DEFAULT IF EMPTY-------------------"); //sempre me retornar uma LISTA (IEnumerable)
var defaultIfEmpty = idades.DefaultIfEmpty(); //se tiver vazio o retorno vai 0 ja que é int caso contrario retorna a lista
var defaultIfEmpty2 = idades.DefaultIfEmpty(5); //se tiver vazio o retorno vai 5 ja que é int caso contrario retorna a lista

var alunoMaisVelho = alunos.Where(aluno => aluno.Idade > 100) //como não existe aluno com esse filtro
                            .DefaultIfEmpty(maisVelho) //me retorna esse aluno como padrao
                            .First();//para pegar 1 somente

//------------------------CONVERSÃO-----------------------------// 
Console.WriteLine("\n---------------TO LIST-------------------");
//IEnumerable  = readyonly é lido em tempo de execução
//List  = pode alterar e carrega todos os itens em memoria e tem métodos a mais
var listaPaises = paises1.ToList();

Console.WriteLine("\n---------------TO ARRAY-------------------");
var arrayPaises = listaPaises.ToArray();

Console.WriteLine("\n---------------TO DICTIONARY-------------------");
var dicionarioPessoas = pessoas.ToDictionary<Pessoa, int>(pessoa => pessoa.Id);

foreach (var chave in dicionarioPessoas.Keys)
{
    Console.WriteLine($"Chave: {chave}, Valor: {(dicionarioPessoas[chave] as Pessoa).Nome}");
}

Console.WriteLine("\n---------------TO LOOK UP-------------------");//um Look Up pode ter chaves (Key) com valores iguais 
var lookUpPessoas = pessoas.ToLookup(pessoa => pessoa.CursoId);//parece um group by po cursoId


foreach (var lookup in lookUpPessoas)
{
    Console.WriteLine(lookup.Key);
    foreach (var pessoa in lookUpPessoas[lookup.Key])
    {
       Console.WriteLine($"\t{pessoa.Nome}");
    }
}