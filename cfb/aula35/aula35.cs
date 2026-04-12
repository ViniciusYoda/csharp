using System;

class Veiculo
{
    public int velMax;
    public bool ligado;
    public int rodas;

    public Veiculo()
    {
        velMax = 0;
        ligado = false;
        rodas = 0;
    }
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
        return (ligado ? "sim" : "nao");
    }

    public int getRodas()
    {
        return rodas;
    }

    public void setRodas(int rodas)
    {
        if(rodas < 0)
        {
            this.rodas = 0;
        }
        else
        {
            this.rodas = rodas;
        }
        this.rodas = rodas;
    }

}
class Carro : Veiculo
{
    string nome;
    string cor;    
    public Carro(string nome, string cor):base(4)
    {
        desligar();
        this.nome = nome;
        this.cor = cor;
        velMax = 120;
        ligado = false;
    }
    
}

class CarroCombate : Carro
{
    public int monicao;
    public CarroCombate():base("Carro de Combate", "Verde")
    {
        monicao = 100;
        rodas = 6;
        velMax = 200;
    }
}
class Aula35
{
    static void Main()
    {
        Carro c1 = new Carro("Fusca", "Azul");
        c1.ligar();
        CarroCombate cc1 = new CarroCombate();
        cc1.ligar();
    }
}