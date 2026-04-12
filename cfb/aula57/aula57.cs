using System;
using System.Collections.Generic;
class Aula57
{
    static void Main()
    {
        List<string> carros = new List<string>();
        string[] carros2 = new string[10];


        carros.Add("Golf");
        carros.Add("Civic");
        carros.Add("Corolla");
        carros.Add("Focus");

        //carros2.AddRange(carros);

        //carros2.Clear();
        if(carros.Contains("Golf"))
        {
            Console.WriteLine("Contem o Golf");
        }
        else
        {
            Console.WriteLine("Não contem o Golf");
        }

        carros.CopyTo(carros2,2);

        foreach (string c in carros2)
        {
            Console.WriteLine(c);
        }

        string ca = "HRV";
        int pos = 0;
        pos = carros.IndexOf(ca);
        if(pos != -1)
        {
            Console.WriteLine("Carro encontrado na posição: " + pos);
        }
        else
        {
            Console.WriteLine("Carro não encontrado");
        }
    }
}