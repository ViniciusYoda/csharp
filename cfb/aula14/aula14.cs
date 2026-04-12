class Aula14
{
    static void Main()
    {
        int n1, n2, n3, n4;
        
        Console.Write("Nota 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Nota 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Nota 3: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Nota 4: ");
        n4 = int.Parse(Console.ReadLine());
        
        int nota = (n1 + n2 + n3 + n4) / 4;

        string resultado;

        if (nota >= 9)
        {
            resultado = "Aprovado com louvor";
        }
        else if (nota >= 7)
        {
            resultado = "Aprovado";
        }
        else if (nota >= 5)
        {
            resultado = "Recuperacao";
        }
        else
        {
            resultado = "Reprovado";
        }

        Console.WriteLine("Resultado {0}", resultado);
    }
}
