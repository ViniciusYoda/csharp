using System;

class Aula13
{
    static void Main()
    {
        int n1,n2,n3,n4 = 0;
        
        string resultado = "Reprovado";

        Console.Write("Nota 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Nota 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Nota 3: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Nota 4: ");
        n4 = int.Parse(Console.ReadLine());
        
        int nota = (n1+n2+n3+n4) / 4;

        if (nota >= 7)
        {
            resultado = "Aprovado";
        }
        else if(nota >= 5 & nota < 7)
        {
            resultado = "Recuperacao";
        }

        Console.WriteLine("Resultado {0}", resultado);

    }
}