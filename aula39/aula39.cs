using System;

abstract class Veiculo
{
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;

    public Veiculo()
    {
        ligado=false;
        velAtua=0;
    }

    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }

    abstract public void aceleracao(int mult);
}

class Carro : Veiculo
{
    public Carro()
    {
        velMaxima=120;
    }

    public override void aceleracao(int mult)
    {
        velAtual+=10*mult;
    }
}
class Aula39
{
    static void Main()
    {
        Carro carro = new Carro();
    }
}