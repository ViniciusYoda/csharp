using System;
using System.Collections.Generic;

class Aula55
{
    static void Main()
    {
        Dictionary <int,string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10,"Carro");
        veiculos.Add(5, "Aviao");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15,"Patitente");

        // veiculos.Clear();
        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
        int chave=20;
        if (veiculos.ContainsKey(20))
        {
            Console.WriteLine("A chave {0} esta na colecao", chave);
        } else
        {
            Console.WriteLine("A chave {0} nao esta na colecao", chave);
        }

        foreach(KeyValuePair<int,string> v in veiculos)
        {
            Console.WriteLine(v.Value);
        }
    }
}