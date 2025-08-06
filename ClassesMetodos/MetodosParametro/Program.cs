System.Console.WriteLine("Métodos - Parâmetros");

Aluno aluno = new();
aluno.Consultar();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        var aluno = new Aluno();

        System.Console.WriteLine("Nome:");
        aluno.Nome = Console.ReadLine();
        System.Console.WriteLine("Idade:");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Sexo:");
        aluno.Sexo = Console.ReadLine();
        System.Console.WriteLine("Aprovado (S)im (N)ão: ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new();
        curso.Resultado(aluno);
    }
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        System.Console.WriteLine($"\nO aluno {aluno.Nome}, sexo {aluno.Sexo} com  {aluno.Idade} anos");

        if (aluno.Aprovado == "S")
            System.Console.WriteLine("\n foi Aprovado");
        else
            System.Console.WriteLine("\n foi Reprovado");
    }
}