using System;

class Program
{
    // Método para calcular o MDC usando o algoritmo de Euclides
    static int CalcularMDC(int a, int b)
    {
        while (b != 0)
        {
            int resto = a % b;
            a = b;
            b = resto;
        }
        return a;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        int mdc = CalcularMDC(num1, num2);
        Console.WriteLine($"O máximo divisor comum de {num1} e {num2} é {mdc}");
    }
}
