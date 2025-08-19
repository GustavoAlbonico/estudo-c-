
public class FonteDados
{
    public static int[] GetIdades()
    {
        var idades = new[] { 30, 44, 35, 20, 39, 30, 45, 33, 44, 90, 100, 50 };
        return idades;
    }

    public static string[] GetNomes()
    {
        var nomes = new[] { "Roberto", "ROBERTO", "Roberto", "Carla", "CARLA", "Maria", "JOSUE", "josue" };
        return nomes;
    }

    public static IEnumerable<Aluno> GetAlunos()
    {
        yield return new Aluno("Jose", 18);
        yield return new Aluno("Maria", 20);
        yield return new Aluno("Carlos", 22);
        yield return new Aluno("Fernanda", 19);
        yield return new Aluno("Ana", 21);
        yield return new Aluno("Ricardo", 23);
        yield return new Aluno("Juliana", 20);
        yield return new Aluno("Paulo", 24);
        yield return new Aluno("Sofia", 19);
        yield return new Aluno("Mateus", 22);
        yield return new Aluno("Bianca", 21);
    }

    public static IEnumerable<Aluno> GetTurmaA()
    {
        yield return new Aluno("Jose", 18, new DateTime(2007, 5, 12));
        yield return new Aluno("Maria", 20, new DateTime(2005, 3, 8));
        yield return new Aluno("Paulo", 22, new DateTime(2001, 4, 30));
        yield return new Aluno("Fernanda", 19, new DateTime(2003, 12, 5));
        yield return new Aluno("Bianca", 21, new DateTime(2004, 2, 28));
    }
    public static IEnumerable<Aluno> GetTurmaB()
    {
        yield return new Aluno("Ricardo", 23, new DateTime(2002, 6, 10));
        yield return new Aluno("Juliana", 20, new DateTime(2005, 9, 21));
        yield return new Aluno("Paulo", 24, new DateTime(2001, 4, 30));
        yield return new Aluno("Sofia", 19, new DateTime(2006, 8, 14));
        yield return new Aluno("Mateus", 22, new DateTime(2003, 12, 5));
        yield return new Aluno("Bianca", 21, new DateTime(2004, 2, 28));
    }

    public static IEnumerable<string> GetPaises1()
    {
        yield return "Brasil";
        yield return "USA";
        yield return "UK";
        yield return "Argentina";
        yield return "China";
    }
    public static IEnumerable<string> GetPaises2()
    {
        yield return "Brasil";
        yield return "uk";
        yield return "Argentina";
        yield return "França";
        yield return "Japão";
    }

    public static void ExibirLista<T>(IEnumerable<T> lista)
    {
        Console.WriteLine("\n");

        if (lista?.Count() < 1)
        {
            Console.WriteLine("Nenhum informação encontrada na lista");
            return;
        }

        foreach (var item in lista)
        {
            Console.WriteLine($"{item.ToString()} ");
        }
    }
}