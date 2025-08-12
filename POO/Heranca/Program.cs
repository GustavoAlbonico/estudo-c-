using Heranca;

Funcionario funci = new();
funci.Nome = "José";
funci.Email = "jose@hotmail.com";
funci.Empresa = "lta";
funci.Salario = 5000m;

Console.WriteLine($"{funci.Nome} {funci.Email}");
funci.Identificar();

Aluno aluno = new();
aluno.Nome = "Roberto";
aluno.Email = "roberto@hotmail.com";
aluno.Curso = "Matématica avançada";
aluno.Nota = 5;

Console.WriteLine($"{aluno.Nome} {aluno.Email}");
aluno.Identificar();


//base
Aluno aluno1 = new("José");
Aluno aluno2 = new();

//virtual|override
Pessoa pessoa = new();
pessoa.ExibirLocal();

Aluno aluno3 = new();
aluno3.ExibirLocal();