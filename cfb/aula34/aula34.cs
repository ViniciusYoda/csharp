using System;

class Veiculo
{
    public int velMax;
    public bool ligado;
    public int rodas;
    public void ligar()
    {
        ligado = true;
    }

    public void desligar()
    {
        ligado = false;
    }

    public bool getLigado()
    {
        return ligado;
    }
}
class Carro : Veiculo
{
    string nome;
    string cor;    
    public Carro(string nome, string cor)
    {
        desligar();
        this.nome = nome;
        this.cor = cor;
        rodas = 4;
        velMax = 120;
        ligado = false;
    }
    
}
class Aula34
{
    static void Main()
    {
        Carro c1 = new Carro("Fusca", "Azul");
        c1.ligar();
        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Cor: {0}", c1.cor);
    }
}