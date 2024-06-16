using System;

class Program
{
    public static void mediaTurma(double[] notas)
    {
        double soma = 0;
        int acimaDaMedia = 0;

        foreach(double n in notas)
        {
            soma += n;
        }

        double media = soma / notas.Length;

        foreach (double n in notas)
        {
            if (n > media)
            {
                acimaDaMedia++;
            }
        }

        Console.WriteLine($"\nMédia da turma: {media.ToString("F2")}");
        Console.WriteLine($"Alunos com nota acima da média: {acimaDaMedia}");
    }

    public static void receberNotas(double[] notas)
    {
        Console.WriteLine("Digite as notas dos 10 alunos:");
        for (int i = 0; i < 10; i++)
        {
            notas[i] = double.Parse(Console.ReadLine());
        }
    }

    public static void Main(string[] args)
    {
        double[] notas = new double[10];

        receberNotas(notas);

        mediaTurma(notas);
    }
}
