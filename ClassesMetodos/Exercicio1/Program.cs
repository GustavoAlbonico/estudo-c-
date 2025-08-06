

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine($"{chevrolet.Modelo} | {chevrolet.Montadora} | {chevrolet.Marca} | {chevrolet.Ano} | {chevrolet.Potencia}");
chevrolet.Acelerar();
Console.WriteLine($"Velocidade máxima: {chevrolet.VelocidadeMaxima()}km/h");

Console.WriteLine($"{ford.Modelo} | {ford.Montadora} | {ford.Marca} | {ford.Ano} | {ford.Potencia}");
ford.Acelerar();
Console.WriteLine($"Velocidade máxima: {ford.VelocidadeMaxima()}km/h");

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string modelo, string montadora)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
    }

    public Carro(string modelo, string montadora, string marca, int ano, int potencia) : this(modelo, montadora)
    {
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    public void Acelerar()
    {
        System.Console.WriteLine($"Acelerando... o meu {this.Marca}");
    }

    public double VelocidadeMaxima()
    {
        return this.Potencia * 1.75;
    }

}