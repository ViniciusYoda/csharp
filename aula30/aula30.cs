class Jogador
{
    public int energia = 100;
    public bool vivo = true;
    public string nome;

    public Jogador() { }

    public Jogador(string nome)
    {
        this.nome = nome;
    }

    public Jogador(string nome, int energia)
    {
        this.nome = nome;
        this.energia = energia;
    }

    public Jogador(string nome, int energia, bool vivo)
    {
        this.nome = nome;
        this.energia = energia;
        this.vivo = vivo;
    }

    public void Info()
    {
        Console.WriteLine("Nome {0}", nome);
        Console.WriteLine("Energia {0}", energia);
        Console.WriteLine("Vivo {0}", vivo);
    }
}

class Aula30
{
    static void Main()
    {
        Jogador j1 = new();
        Jogador j2 = new("Bruno");
        Jogador j3 = new("Thep", 100);
        Jogador j4 = new("TEE", 43, false);

        j1.Info();
        j2.Info();
        j3.Info();
        j4.Info();
    }
}