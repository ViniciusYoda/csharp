using System;

class Aula06
{
    static void Main()
    {
        int n1,n2,n3;

        n1=10; n2=20; n3=30;
        Console.Write("n1={0}  n2={1} n3={2}",n1,n2,n3);

        double valorCompras = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda= valorCompras+(valorCompras*lucro);

        Console.WriteLine("Produto...........:{0,15}", produto);
        Console.WriteLine("Valor Compras....:{0,15:c}", valorCompras);
        Console.WriteLine("Valor Venda......:{0,15:c}", valorVenda);
        Console.WriteLine("Lucro............:{0,15:p}", lucro);


    }
}