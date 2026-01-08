using System;

class Aula08
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Nome: {0}", nome);

        Console.Write("Digite o v1: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o v2: ");
        v2 = int.Parse(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("A soma é {0}", soma);

    }
}