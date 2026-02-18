using System;

struct Carro
{

    public string modelo;
    public string cor;

    public void info()
    {
        Console.WriteLine("Carro modelo {0}", modelo);
        Console.WriteLine("cARROS COR {0}", cor);
    }
}

class Aula45
{
    static void Main()
    {
        int[] numeros = new int[10];
        Carro[] carros = new Carro[5];

        carros[0].modelo = "HRV";
        carros[0].cor = "Azul";

        carros[1].modelo = "Gol";
        carros[1].cor = "Pretos";

        for (int i = 0; i < carros.Length; i++)
        {
            carros[i].info();
        }


       
    }
}