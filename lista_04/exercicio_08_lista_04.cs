using System;

class Program
{
    // Função que calcula o valor de S segundo a fórmula dada
    static double CalcularS(int N)
    {
        double S = 0.0;

        // Loop para calcular cada termo da soma
        for (int i = 1; i <= N; i++)
        {
            S += (Math.Pow(i, 2) + 1) / (i + 3);
        }

        return S;
    }

    // Método principal que lê o valor de N e imprime o valor de S
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor inteiro e positivo para N:");
        int N = int.Parse(Console.ReadLine());

        // Verifica se N é positivo
        if (N > 0)
        {
            double resultado = CalcularS(N);
            Console.WriteLine($"O valor de S para N = {N} é {resultado:F2}");
        }
        else
        {
            Console.WriteLine("O valor de N deve ser um inteiro positivo.");
        }
    }
}
