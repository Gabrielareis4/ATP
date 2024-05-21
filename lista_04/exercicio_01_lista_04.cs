using System;

class Program
{
    // Método calcular a média aritmética
    static void calcularMediaAritimetica(int[] notas)
    {
        // Calcula e exibe a média aritmética
        double mediaAritimetica = (notas[0] + notas[1] + notas[2]) / 3.0;
        Console.WriteLine($"Média Aritimética: {mediaAritimetica:F2}");
    }

    // Método calcular a média ponderada
    static void calcularMediaPonderada(int[] notas)
    {
        // Calcula e exibe a média ponderada
        double mediaPonderada = (notas[0] * 5 + notas[1] * 3 + notas[2] * 2) / 10.0;
        Console.WriteLine($"Média Ponderada: {mediaPonderada:F2}");
    }

    // Método principal que executa o programa
    static void Main(string[] args)
    {
        string continuar; // Variável para controlar o loop

        do
        {
            int[] notas = new int[3]; // Cria um vetor para armazenar as três notas

            // Solicita ao usuário que digite as três notas
            Console.WriteLine("Digite as 3 notas:");
            for (int i = 0; i < 3; i++)
            {
                // Lê cada nota e armazena no vetor
                notas[i] = int.Parse(Console.ReadLine());
            }

            // Solicita ao usuário que escolha o tipo de média a calcular
            Console.WriteLine("Para calcular a média aritmética das notas digite 'a'");
            Console.WriteLine("Para calcular a Média ponderada digite 'p'");
            string proc = Console.ReadLine();

            // Decide qual média calcular com base na escolha do usuário
            switch (proc)
            {
                case "a":
                    // Chama o método para calcular a média aritmética
                    calcularMediaAritimetica(notas);
                    break;

                case "p":
                    // Chama o método para calcular a média ponderada
                    calcularMediaPonderada(notas);
                    break;

                default:
                    // Informa ao usuário que a opção escolhida é inválida
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            // Pergunta ao usuário se deseja continuar para o próximo aluno
            Console.WriteLine("Deseja continuar para o próximo aluno (s/n)");
            continuar = Console.ReadLine();
        } while (continuar == "s"); // O loop continua enquanto o usuário digitar 's'
    }
}
