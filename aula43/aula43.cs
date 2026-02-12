using System;

public interface Veiculo
{
    void ligar();
    void desligar();
    void info();
}

public interface Combate
{
    void disparar();
}

class Carro:Veiculo,Combate
{
    public bool ligado;
    public int municao;
    Carro()
    {
        
    }

    public void ligar()
    {
        this.ligado = true;
    }

    public void desligar()
    {
        this.ligado = false;
    }

    public void info()
    {
        
    }

    public void disparar()
    {
        this.municao = 100;
    }
}

class Aula43
{
    static void Main()
    {
        Carro c1 = new Carro();
    }
}