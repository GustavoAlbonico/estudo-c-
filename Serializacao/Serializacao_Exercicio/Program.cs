using Serializacao_Exercicio;
using System.Text.Json;
using System.Xml.Serialization;

//cria lista de alunos
List<Aluno> alunos = new()
{
    new Aluno { Id=1, Nome="Maria", Email= "maria@email.com", Idade=16},
    new Aluno { Id=2, Nome="Carlos", Email= "carlos@email.com", Idade=17},
    new Aluno { Id=3, Nome="Silvia", Email= "silvia@email.com", Idade=15},
};

Console.WriteLine("\nRealizando a serialização JSON\n");

//serialização JSON
var listaJson = JsonSerializer.Serialize(alunos);

Console.WriteLine(listaJson);

var caminhoArquivoJSON = @"d:\dados\Serializados\listaAlunos.json";

using (FileStream stream = new FileStream(caminhoArquivoJSON, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, alunos);
}

Console.WriteLine("\nSerialização JSON concluída. Tecle algo para continuar...");

Console.ReadKey();

Console.WriteLine("\nRealizando a serialização XML\n");

var caminhoArquivoXML = @"d:\dados\Serializados\listaAlunos.xml";

var listaSerializer = new XmlSerializer(typeof(List<Aluno>));
using (var writer = new StreamWriter(caminhoArquivoXML))
{
    listaSerializer.Serialize(writer, alunos);
}

Console.WriteLine("\nSerialização XML concluída. Tecle algo para encerrar...");

Console.ReadKey();