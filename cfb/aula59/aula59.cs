using System;
using System.Collections.Generic;

class Aula59
{
    static void Main()
    {
    
        //string[] vs={"Carro","Moto","Caminhão","Navio"};
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Caminhão");
        veiculos.Enqueue("Navio");

        Console.WriteLine("Tamanho da fila: " + veiculos.Count);
        Console.WriteLine("Primeiro da fila: " + veiculos.Peek());

        string v = "Avião";
        if(veiculos.Contains(v))
        {
            Console.WriteLine("Contem o " + v);
        }
        else
        {
            Console.WriteLine("Não contem o " + v);
        }

        while(veiculos.Count > 0)
        {
            Console.WriteLine("Removendo: " + veiculos.Dequeue());
        }

        foreach (string veic in veiculos)
        {
            Console.WriteLine(veic);
            v=veiculos.Dequeue();
            Console.WriteLine("Removendo: " + v);
        }

        foreach (string vs in veiculos)
        {
            Console.WriteLine(vs);
        }

        Console.WriteLine("Removendo: " + veiculos.Dequeue());

        Console.WriteLine("Tamanho da fila: " + veiculos.Count);

        veiculos.Clear();

        Console.WriteLine("Tamanho da fila: " + veiculos.Count);
    }
}
    