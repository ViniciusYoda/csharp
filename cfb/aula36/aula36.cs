using System;

class Veiculo
{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax)
    {
        this.velMax = velMax;
        ligado = false;
        velAtual = 0;
    }

    public bool getLigado()
    {
        return ligado;
    }
}

class Carro : Veiculo
{
    public string nome;
    public Carro(string nome, int velMax) : base(velMax)
    {
        this.nome = nome;
        ligado = false;
    }
}
class Aula36
{
    static void Main()
    {
        Carro c1 = new Carro("Fusca", 120);
        c1.ligado = true; // Erro de compilação
        Console.WriteLine("Nome: {0}", c1.nome);
    }
}