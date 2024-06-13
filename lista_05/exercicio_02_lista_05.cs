using System;

class Program
{
    public static void LerVetor()
    {

    }

    public static void Main(string[] args)
    {
        double[] notas = new double[10];
        Console.WriteLine("Digite a notas dos 10 alunos:");
        for (int i = 0; i < 10; i++)
        {
            notas[i] = double.Parse(Console.ReadLine());
        }
    }
}