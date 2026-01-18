using System;

class Aula24
{
    static void Main()
    {
        int v1,v2;
        Console.WriteLine("V1");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("V2");
        v2 = int.Parse(Console.ReadLine());
        Soma(v1, v2);
    }

    static void Soma(int n1, int n2)
    {
        int res = n1 + n2;
        Console.WriteLine("A SOMA DE {0} E {1} É: {2}", n1, n2, res);
    }
}
