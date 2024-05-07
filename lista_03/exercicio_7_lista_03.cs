using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário que digite um número inteiro positivo para calcular a soma
        Console.Write("Digite um número inteiro positivo para calcular a soma: ");
        // Lê o número fornecido pelo usuário e o converte para um inteiro
        int n = Convert.ToInt32(Console.ReadLine());

        // Verifica se o número fornecido pelo usuário é positivo
        if (n <= 0)
        {
            Console.WriteLine("O número deve ser positivo.");
        }
        else
        {
            // Inicializa a variável de soma
            double soma = 0.0;

            // Loop para calcular a soma dos inversos dos números naturais até o número fornecido
            for (int i = 1; i <= n; i++)
            {
                // Calcula o termo da série (o inverso do número natural)
                double termo = 1.0 / i;
                // Exibe o termo calculado
                Console.WriteLine($"Termo {i}: {termo:F}");
                // Adiciona o termo à soma
                soma += termo;
            }

            // Exibe o valor final da soma
            Console.WriteLine($"O valor final de S é: {soma:F}");
        }
    }
}
