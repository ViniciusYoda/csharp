using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void Info()
    {
        Console.WriteLine("Método Info da classe Base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivada1");
    }

    override public void Info()
    {
        Console.WriteLine("Método Info da classe Derivada1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivada2");
    }

    override public void Info()
    {
        Console.WriteLine("Método Info da classe Derivada2");
    }
}
class Aula38
{
    static void Main()
    {
        Derivada2 derivada2 = new Derivada2();
        derivada2.Info();
        Derivada1 derivada1 = derivada2;
        derivada1.Info();
        Base baseRef = derivada2;
    }
}