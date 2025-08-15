var caminhoDiretorio = @"d:\dados\MeuDiretorio";
string caminhoDestino = @"d:\dados\MeuDiretorioNovo";

try
{
    if (Directory.Exists(caminhoDiretorio))
    {
        // Directory.CreateDirectory(caminhoDiretorio);

        // Directory.Delete(caminhoDiretorio);

        // string[] subdiretorios = Directory.GetDirectories(caminhoDiretorio);
        // string[] subdiretorios = Directory.GetDirectories(@"d:\","p*");//iniciam com a letra p
        // foreach (var subdir in subdiretorios)
        //     Console.WriteLine(subdir);

        // string[] arquivos = Directory.GetFiles(caminhoDestino);
        // foreach (var arquivo in arquivos)
        //     Console.WriteLine(arquivo);

        Directory.Move(caminhoDiretorio, caminhoDestino);//como se tivese renomeado

        Console.WriteLine("Diretório renomeado com sucesso!");
    }
    else
    {
        Console.WriteLine($"O diretório  {caminhoDiretorio} não existe!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();