using System.Collections.ObjectModel;

var planetas = new List<string>()
{
    "Mercúrio", "Vênus", "Terra", "Marte"
};

var listaPlanetas = new ReadOnlyCollection<string>(planetas);
//var novaLista = planetas.AsReadOnly();

Console.WriteLine("\nPlanetas não gasosos do sistema solar:");
foreach (var planeta in listaPlanetas)
{
    Console.Write($"{planeta} ");
}

Console.WriteLine($"\n\nPlanetas na coleção : {listaPlanetas.Count}");

Console.Write("\nJúpiter esta na coleção ? ");
Console.WriteLine(listaPlanetas.Contains("Júpiter") ? "Sim" : "Não");

Console.WriteLine($"\nPlaneta de índice 3 : {listaPlanetas[3]}");

Console.WriteLine($"\nIndice do planeta Terra : {listaPlanetas.IndexOf("Terra")}");

Console.WriteLine("\nInserindo um novo elemento na Lista original (índice 4)");
planetas.Insert(4, "Plutão");
Console.WriteLine("\nExibindo o novo planeta na lista");
foreach (string planeta in listaPlanetas)
{
    Console.Write($"{planeta} ");
}

Console.WriteLine("\n\nCopiandos os elementos da coleção para um Array unidimensional");
string[] planetasArray = new string[listaPlanetas.Count + 2];
listaPlanetas.CopyTo(planetasArray, 1);
Console.WriteLine($"\nO Array copiado possui {planetasArray.Length} elementos");
foreach (string planeta in planetasArray)
{
    Console.WriteLine($"\"{planeta}\"");
}

Console.ReadKey();

//parte 2
var exoPlanetas = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());

//alterações não permitidas
//exoPlanetas[0]= "Kepler-442b";
//exoPlanetas[0] = new ExoPlaneta() { Nome = "Kepler-442b" };

exoPlanetas[0].Nome = "Kepler-442b";

Console.WriteLine("\nLista de exoplanetas : \n");
foreach (var item in exoPlanetas)
    Console.WriteLine(item.Nome);


Console.ReadKey();

class ExoPlaneta
{
    public string? Nome { get; set; }
    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
          new ExoPlaneta() { Nome = "Proxima Centauri b" },
          new ExoPlaneta() { Nome = "Kleper 186-f" },
          new ExoPlaneta() { Nome = "Gliesi 1061-c" },
        };
    }
}

//parte 3
public class GerenciaExoPlanetas
{
    private List<ExoPlaneta2>? exoPlanetas = ExoPlaneta2.GetExoPlanetas();

    public ReadOnlyCollection<ExoPlaneta2> ExoPlanetas
    {
        get { return exoPlanetas.AsReadOnly(); }
    }
    public void AdicionaPlaneta(ExoPlaneta2 planeta)
    {
        exoPlanetas.Add(planeta);
    }
}
public class ExoPlaneta2
{
    public string? Nome { get; set; }
    public static List<ExoPlaneta2> GetExoPlanetas()
    {
        return new List<ExoPlaneta2>()
        {
          new ExoPlaneta2() { Nome = "Proxima Centauri b" },
          new ExoPlaneta2() { Nome = "Kleper 186-f" },
          new ExoPlaneta2() { Nome = "Gliesi 1061-c" },
        };
    }
}

