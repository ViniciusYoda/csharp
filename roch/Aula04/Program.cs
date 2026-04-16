namespace Aula04;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("--------CADASTRO DE USUÁRIO--------");

        Console.Write("Digite seu nome: ");
        string name = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("----------------------------");

        Console.WriteLine("Nome: " + name);
        Console.WriteLine("Idade: " + age);
    }
}