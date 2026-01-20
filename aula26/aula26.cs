using System;

class Aula26
{
    static void Main()
    {
        int rest;
        int quoc = Divide(10, 3, out rest);
        Console.WriteLine("Quociente: " + quoc);
        Console.WriteLine("Resto: " + rest);
    }

    static int Divide(int dividendo, int divisor, out int resto)
    {
        resto = dividendo % divisor;
        return dividendo / divisor;
    }
}
