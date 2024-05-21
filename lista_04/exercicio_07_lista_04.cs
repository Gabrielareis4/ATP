using System;

class Program
{
    // Procedimento que recebe a média final de um aluno e exibe o conceito
    static void ExibirConceito(double media)
    {
        if (media < 40)
        {
            Console.WriteLine("Conceito: F");
        }
        else if (media < 60)
        {
            Console.WriteLine("Conceito: E");
        }
        else if (media < 70)
        {
            Console.WriteLine("Conceito: D");
        }
        else if (media < 80)
        {
            Console.WriteLine("Conceito: C");
        }
        else if (media < 90)
        {
            Console.WriteLine("Conceito: B");
        }
        else
        {
            Console.WriteLine("Conceito: A");
        }
    }

    // Método principal que gerencia a leitura das médias e aciona o procedimento
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos alunos você deseja verificar?");
        int N = int.Parse(Console.ReadLine()); // Lê a quantidade de alunos

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Digite a média final do {i + 1}º aluno:");
            double media = double.Parse(Console.ReadLine()); // Lê a média do aluno

            // Chama o procedimento para exibir o conceito
            ExibirConceito(media);
        }
    }
}
