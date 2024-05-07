using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor de L para calcular a soma dos elementos da série de Fibonacci menores que L: ");
        int L = Convert.ToInt32(Console.ReadLine());

        if (L <= 0)
        {
            Console.WriteLine("O valor de L deve ser positivo.");
        }
        else
        {
            // Inicializamos os dois primeiros elementos da sequência de Fibonacci
            int a = 0;
            int b = 1;

            int soma = 0;

            // Iteramos para calcular a soma dos elementos menores que L
            while (a < L)
            {
                soma += a;
                int proximo = a + b;
                a = b;
                b = proximo;
            }

            Console.WriteLine($"A soma dos elementos da série de Fibonacci menores que {L} é: {soma}");
        }
    }
}