namespace Aula29
{
    using System;

    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador(string nome)
        {
            energia = 100;
            vivo = true;
            this.nome = nome;
        }

        ~Jogador()
        {
            Console.WriteLine("Jogador foi destruido");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o nome do jogador");
            string nome = Console.ReadLine();
            Jogador j1 = new Jogador(nome);
            Console.WriteLine("Jogador é {0}", j1.nome);
        }
    }
}