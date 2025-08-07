//REF

/*Console.WriteLine("## Passando argumentos por referência ##\n");

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por valor " + x);

Calculo calc = new();
calc.Dobrar(ref x);

Console.WriteLine("\nValor do argumento x depois de passar por valor " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2; //y=y*2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
    }
}
*/

//OUT
Console.WriteLine("## Argumentos por referência - out");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double perimetro = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine("Perímetro da Circunferencia " + perimetro);
Console.WriteLine("Área da Circunferência : " + area);

Console.ReadKey();

public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio,2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
