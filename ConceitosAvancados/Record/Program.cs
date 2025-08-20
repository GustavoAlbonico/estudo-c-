var usuario = new UsuarioRecord("João", "joão@email.com", 20);

Console.WriteLine($"\n Usuario original : {usuario}");

var usuarioCopia = usuario with { Email = "jose@email.com" };

Console.WriteLine(usuarioCopia);
Console.WriteLine($"Após alteração {usuario}");