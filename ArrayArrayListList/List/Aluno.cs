namespace Lista;
public class Aluno
{
    private string nome;
    private double nota;

    public string Nome { get => nome; set => nome = value; }

    public double Nota { get => nota; set => nota = value; }

    public Aluno(string nome, double nota)
    {
        this.nome = nome;
        this.nota = nota;
    }
}