
SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson= new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

 //para pode acessar o metodo nã abstrato da interface é necessário istancia a classe que herda a interface dessa forma
ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();

Console.ReadKey();