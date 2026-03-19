using System;
using System.Collections.Generic;

class Aula56
{
    static void Main()
    {
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");
        transp.AddLast("Bicliceta");

        LinkedListNode<string> no;
        no = transp.FindLast("Navio");
        transp.AddAfter(no, "Patinete");
    }
}