using System;

class Jogador
{
    private int energia;
    private string nome;
    public Jogador(string nome)
    {
        this.nome = nome;
        energia = 100;
    }

    public int getEnergia()
    {
        return energia;
    }

    public string getNome()
    {
        return nome;
    }

    public void setEnergia(int energia)
    {
        if(energia <0)
        {
            if(this.energia-energia <0)
            {
                this.energia = 0;
                return;
            }else
            {
                this.energia -= energia;
                return;
            }
        } else if(energia >100)
        {
            this.energia = 100;
            return;
        }
        this.energia = energia;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }


}
class Aula33
{
    static void Main()
    {
        Jogador j1 = new Jogador("Carlos");
        Jogador j2 = new Jogador("Ana");

        j1.setEnergia(80);
        j2.setEnergia(90);

        j1.getEnergia();
        j2.getEnergia();
        Console.WriteLine("Jogador: {0} - Energia: {1}", j1.getNome(), j1.getEnergia());
        Console.WriteLine("Jogador: {0} - Energia: {1}", j2.getNome(), j2.getEnergia());
    }
}