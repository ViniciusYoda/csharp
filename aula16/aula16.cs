using System;

class Aula15
{
    static void Main()
    {
        int tempo = 0;
        char escolha;

        inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        // Adicionei o ToLower() para aceitar letras maiúsculas também
        Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus ");

        // O char.ToLower garante que 'A' vire 'a', facilitando o switch
        escolha = char.ToLower(char.Parse(Console.ReadLine()));

        switch(escolha)
        {
            case 'a':
                tempo = 50;
                break;
            case 'c':
                tempo = 400;
                break;
            case 'o':
                tempo = 600;
                break;
            default:
                tempo = -1;
                break;
        }

        if (tempo < 0)
        {
            Console.WriteLine("Transporte inválido ou não reconhecido.");
        }
        else
        {
            // O erro estava aqui: deve ser {0} (índice zero), não {o} (letra o)
            Console.WriteLine("O tempo para o transporte escolhido é de {0} minutos.", tempo);
        }

        Console.WriteLine("Calcular outro: ");
        escolha = char.Parse(Console.ReadLine());

        if (escolha=='s' || escolha == 'S')
        {
            goto inicio;
        } else
        {
            Console.Clear();
            Console.WriteLine("Fim do progrma");
        }

    }
}