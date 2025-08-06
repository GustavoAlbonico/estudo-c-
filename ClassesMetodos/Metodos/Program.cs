System.Console.WriteLine("Métodos");

MinhaClasse minhaClasse = new();
minhaClasse.Saudacao();
minhaClasse.SaudacaoParametro("Jose", DateTime.Now.ToShortDateString());

class MinhaClasse
{
    public void Saudacao()
    {
        System.Console.WriteLine("Bem-vindo");
        ExibirDataAtual();
    }

    public void ExibirDataAtual() => System.Console.WriteLine(DateTime.Now.ToShortDateString());

    public void SaudacaoParametro(string nome, string data)
    {
        System.Console.WriteLine(nome);
        System.Console.WriteLine(data);
    }
}