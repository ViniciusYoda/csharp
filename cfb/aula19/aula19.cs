using System;

class Aula19
{
    static void Main()
    {
        int[] num=new int[10];

        for (int i = 1; i <= num.Length; i++)
        {
            num[i] = i;
            Console.WriteLine(num[i]);
        }
    }
}