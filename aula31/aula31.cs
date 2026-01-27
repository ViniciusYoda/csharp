using System;

static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;

    // Construtor padrão
    static Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Jogador1";
    }

    static public void Info()
    {
        Console.WriteLine("Nome {0}", nome);
        Console.WriteLine("Energia {0}", energia);
        Console.WriteLine("Vivo {0}", vivo);
    }

class Inimigo
    {
        static public bool alerta;
        public string nome;
        public Inimigo(string nome)
        {
            this.nome = nome;
            alerta = false;
        }

        public void Info()
        {
            Console.WriteLine("Nome {0}", nome);
            Console.WriteLine("Alerta {0}", alerta);
        }
    }


}
class Aula31
{
    static void Main()
    {
        Jogador j1 = new();
        Console.WriteLine("Nome: {0}, Energia: {1}, Vivo: {2}", j1.nome, j1.energia, j1.vivo);

        Inimigo i1 = new Inimigo("Zumbi");
        i1.Info();
        Inimigo.alerta = true;
        Inimigo i2 = new Inimigo("Vampiro");

    }
}