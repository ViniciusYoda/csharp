using System;

class Aula10
{
    enum DiasSemana{Domingo,Segunda,Terca,Quarta,Quinta,Sexta,Sabado};

    static void Main()
    {
        DiasSemana ds = (DiasSemana)3;

        Console.WriteLine(ds);

        int d = (int)DiasSemana.Sexta;

        Console.WriteLine(d);
    }
}