using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário que digite o número de elementos da sequência de Fibonacci a serem impressos
        Console.Write("Digite o número de elementos da sequência de Fibonacci a serem impressos: ");
        // Lê o número fornecido pelo usuário e o converte para um inteiro
        int L = Convert.ToInt32(Console.ReadLine());

        // Verifica se o número fornecido pelo usuário é positivo
        if (L <= 0)
        {
            Console.WriteLine("O número de elementos deve ser positivo.");
        }
        else
        {
            // Inicializa os dois primeiros elementos da sequência de Fibonacci
            int a = 0;
            int b = 1;

            // Imprime os dois primeiros elementos da sequência de Fibonacci
            Console.WriteLine("Sequência de Fibonacci:");
            Console.Write($"{a}, {b}");

            // Itera para calcular e imprimir os próximos elementos da sequência
            for (int i = 2; i < L; i++)
            {
                int proximo = a + b;
                Console.Write($", {proximo}");
                // Atualiza os valores de 'a' e 'b' para os próximos cálculos
                a = b;
                b = proximo;
            }

            Console.WriteLine(); // Imprime uma nova linha para melhorar a formatação da saída
        }
    }
}
