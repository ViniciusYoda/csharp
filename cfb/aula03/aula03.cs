using System;

class Aula03
{
    static void Main()
    {
        int num = 0;
        char letra='c';
        float valor = 5.3f;
        byte n1 = 10; // 0 e 255
        string nome = "Maria";

        var aux = nome;

        Console.WriteLine("Valor de num: " + num);
        Console.WriteLine("Valor de letra: " + letra);
        Console.WriteLine("Valor de valor: " + valor);
        Console.WriteLine("Valor de n1: " + n1);
        Console.WriteLine("Valor de nome: " + nome);
        Console.WriteLine("Valor de aux: " + aux);

        int num1, num2, res;

        num1 = 10;
        num2 = 20;

        res = num1 + num2;

        Console.WriteLine("Resultado da soma: " + res);
    }
}