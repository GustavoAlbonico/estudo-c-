public class Pessoa
{
    public Pessoa(int id, string? nome, int enderecoId, int cursoId)
    {
        Id = id;
        Nome = nome;
        EnderecoId = enderecoId;
        CursoId = cursoId;
    }

    public int Id { get; set; }
    public string? Nome { get; set; }
    public int EnderecoId { get; set; }
    public int CursoId { get; set; }
}