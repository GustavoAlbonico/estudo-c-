
Console.Write("Digite um número : ");
double numero = Convert.ToDouble(Console.ReadLine());

Func<double, double> raizQuadrada = x => Math.Sqrt(x);

var resultado = raizQuadrada(numero);

Console.WriteLine("\nA raiz quadrada de " + numero + " é : " + resultado);

Console.ReadKey();

//pode ser passado de 0 a 16 parametros
//in T , out T -> Tipo de entrada e o tipo que vai ser retornado ao definir um delegate desse tipo

