using System;

class Galinha
{

    private string nome;
    private int numOvo;
    public Galinha(string nome, int numOvo){
        this.nome = nome;
        this.numOvo = 0;
    }

    public Ovo botar()
    {
        numOvo++;
        return new Ovo();
    }
}

class Ovo
{
    public int numOvo;
    public string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha)
    {
        this.minhaGalinha = minhaGalinha;
        this.numOvo = numOvo;
        Console.WriteLine("Ovo criado {0} - {1}", this.numOvo, this.minhaGalinha);
    }
}

class Aula46
{
    static void Main()
    {
        Galinha g1 = new Galinha("Maria");
        Galinha g2 = new Galinha("Zilda");
        Galinha g3 = new Galinha("Luiza");

        g1.botar();
        g2.botar();
        g3.botar();
    }
}