using Enum;

Console.WriteLine("Enum \n");

Console.WriteLine(DiasDaSemana.Domingo);
Console.WriteLine(DiasDaSemana.Segunda);

int domingoOrdinal = (int)DiasDaSemana.Domingo;
int segundaOrdinal = (int)DiasDaSemana.Segunda;

Console.WriteLine($"{DiasDaSemana.Domingo} vale: {domingoOrdinal}");
Console.WriteLine($"{DiasDaSemana.Segunda} vale: {segundaOrdinal}");

Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

System.Console.WriteLine("\n Selecione a Categoria teclando o seu valor");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor;

System.Console.WriteLine($"Voçe selecionou a categoria: {nomeMembroEnum}");


