using System;

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string cor, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
}

class Aula44
{
    static void Main()
    {
        Carro c1;

        c1.marca = "VW";
        c1.modelo = "Golg";
        c1.cor = "Azuç";
    }
}