using SerializacaoJSON;
using System.Text.Json;

Aluno aluno1 = new Aluno(10, "Maria", "maria@yahoo.com", 17);

var caminhoArquivo = @"d:\dados\Serializados\AlunoSerializado.json";

using (FileStream stream = new FileStream(caminhoArquivo,
                                          FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, aluno1);
}

Console.WriteLine("Objeto serializado para JSON com sucesso!");

Console.ReadKey();
