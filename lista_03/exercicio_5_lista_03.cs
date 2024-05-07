using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        int num = 0, i = 0;
        double e = 1.0, fat = 1;

        // Solicita ao usuário que digite um número para calcular 'e'
        Console.WriteLine("Digite um número para calcular E: ");
        // Lê o número fornecido pelo usuário e o converte para um inteiro
        num = int.Parse(Console.ReadLine());

        // Verifica se o número fornecido pelo usuário é negativo
        if (num < 0)
        {
            Console.WriteLine("O número deve ser positivo.");
        }
        else
        {
            // Loop para calcular a aproximação de 'e' usando a série de Taylor
            for (i = 1; i <= num; i++)
            {
                // Calcula o fatorial de 'i'
                fat *= i;
                // Calcula o termo da série de Taylor e o adiciona à aproximação de 'e'
                e += 1.0 / fat;
            }

            // Exibe o valor aproximado de 'e' para o número fornecido
            Console.WriteLine($"O valor de E para N = " + num + " é: " + e);
        }
    }
}
