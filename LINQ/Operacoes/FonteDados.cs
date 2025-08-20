
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
    public static IEnumerable<Aluno> GetAlunos2()
    {
        yield return new Aluno("Jose", 18, new DateTime(2007, 5, 12), "Engenharia", 'M');
        yield return new Aluno("Maria", 20, new DateTime(2005, 3, 8), "Direito", 'F');
        yield return new Aluno("Carlos", 22, new DateTime(2003, 11, 25), "Medicina", 'M');
        yield return new Aluno("Fernanda", 19, new DateTime(2006, 7, 19), "Arquitetura", 'F');
        yield return new Aluno("Ana", 21, new DateTime(2004, 1, 30), "Psicologia", 'F');
        yield return new Aluno("Ricardo", 23, new DateTime(2002, 9, 14), "Administração", 'M');
        yield return new Aluno("Juliana", 20, new DateTime(2005, 4, 2), "Enfermagem", 'F');
        yield return new Aluno("Paulo", 24, new DateTime(2001, 6, 27), "Computação", 'M');
        yield return new Aluno("Sofia", 19, new DateTime(2006, 10, 5), "Design", 'F');
        yield return new Aluno("Mateus", 22, new DateTime(2003, 2, 18), "Engenharia", 'M');
        yield return new Aluno("Bianca", 21, new DateTime(2004, 12, 9), "Educação Física", 'F');
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

    public static IEnumerable<Pessoa> GetPessoas()
    {
        yield return new Pessoa(1, "Maria", 1, 10);
        yield return new Pessoa(2, "José", 2, 20);
        yield return new Pessoa(3, "Ana", 3, 30);
        yield return new Pessoa(4, "Carlos", 4, 10);
        yield return new Pessoa(5, "Fernanda", 5, 30);
        yield return new Pessoa(6, "Ricardo", 6, 40);
        yield return new Pessoa(7, "Juliana", 7, 10);
        yield return new Pessoa(8, "Paulo", 8, 40);
        yield return new Pessoa(9, "Sofia", 3, 20);
        yield return new Pessoa(10, "Mateus", 2, 30);
    }

    public static IEnumerable<Endereco> GetEnderecos()
    {
        yield return new Endereco(1, "Rua Fictícia 123");
        yield return new Endereco(2, "Avenida Central 456");
        yield return new Endereco(3, "Travessa das Flores 789");
        yield return new Endereco(4, "Rua dos Pinheiros 101");
        yield return new Endereco(5, "Alameda das Palmeiras 202");
        yield return new Endereco(6, "Rua das Acácias 303");
        yield return new Endereco(7, "Avenida Brasil 404");
        yield return new Endereco(8, "Praça da Liberdade 505");
    }
    public static IEnumerable<Curso> GetCursos()
    {
        yield return new Curso(10, "CSharp");
        yield return new Curso(20, "Node");
        yield return new Curso(30, "Java");
        yield return new Curso(40, "Phython");
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

    public static IEnumerable<int> GetDataNull()
    {
        return null;
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