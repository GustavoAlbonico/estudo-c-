Console.WriteLine("## Strict DateTime");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//criar uma da especifica usa formato: aaaa,mm,dd
DateTime dataHoje = new DateTime(2025, 08, 04);
System.Console.WriteLine(dataHoje);

//definir as horas
DateTime dataHoraHoje = new DateTime(2025, 08, 04, 11, 25, 00);
System.Console.WriteLine(dataHoraHoje);

DateTime hoje = DateTime.Now;
System.Console.WriteLine($"hoje : {hoje}\n");

//extrair informações da data atual
System.Console.WriteLine(hoje.Year);
System.Console.WriteLine(hoje.Month);
System.Console.WriteLine(hoje.Day);
System.Console.WriteLine(hoje.Hour);
System.Console.WriteLine(hoje.Minute);
System.Console.WriteLine(hoje.Second);
System.Console.WriteLine(hoje.Millisecond);

//adicionando valores
System.Console.WriteLine(hoje.AddDays(30));
System.Console.WriteLine(hoje.AddMonths(1));
System.Console.WriteLine(hoje.AddHours(2));
System.Console.WriteLine(hoje.AddYears(5));

//obter o dia da semana e do ano
System.Console.WriteLine(hoje.DayOfWeek);
System.Console.WriteLine(hoje.DayOfYear);

//data no formato longo e curto
System.Console.WriteLine(hoje.ToLongDateString());
System.Console.WriteLine(hoje.ToShortDateString());

System.Console.WriteLine(hoje.ToLongTimeString());
System.Console.WriteLine(hoje.ToShortTimeString());

