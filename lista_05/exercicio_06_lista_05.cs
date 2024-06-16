using System;

class Program
{
    static void Main(string[] args)
    {
        // Vetor para armazenar as temperaturas de outubro (31 dias)
        int[] temperaturas = new int[31];

        // Preencher o vetor com temperaturas hipotéticas entre 15°C e 40°C
        PreencherTemperaturas(temperaturas);

        // Calcular e imprimir a menor e a maior temperatura ocorrida
        int menorTemperatura = EncontrarMenorTemperatura(temperaturas);
        int maiorTemperatura = EncontrarMaiorTemperatura(temperaturas);

        Console.WriteLine($"Menor temperatura: {menorTemperatura}°C");
        Console.WriteLine($"Maior temperatura: {maiorTemperatura}°C");

        // Calcular e imprimir a temperatura média
        double temperaturaMedia = CalcularTemperaturaMedia(temperaturas);
        Console.WriteLine($"Temperatura média: {temperaturaMedia:F1}°C");

        // Contar e imprimir o número de dias com temperatura inferior à média
        int diasInferioresMedia = ContarDiasInferioresMedia(temperaturas, temperaturaMedia);
        Console.WriteLine($"Número de dias com temperatura inferior à média: {diasInferioresMedia}");
    }

    // Procedimento para preencher o vetor de temperaturas com valores entre 15 e 40 (inclusive)
    static void PreencherTemperaturas(int[] temperaturas)
    {
        Random random = new Random();

        for (int i = 0; i < temperaturas.Length; i++)
        {
            temperaturas[i] = random.Next(15, 41); // Números aleatórios entre 15 e 40 (inclusive)
        }
    }

    // Função para encontrar a menor temperatura no vetor
    static int EncontrarMenorTemperatura(int[] temperaturas)
    {
        int menor = temperaturas[0];

        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < menor)
            {
                menor = temperaturas[i];
            }
        }

        return menor;
    }

    // Função para encontrar a maior temperatura no vetor
    static int EncontrarMaiorTemperatura(int[] temperaturas)
    {
        int maior = temperaturas[0];

        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > maior)
            {
                maior = temperaturas[i];
            }
        }

        return maior;
    }

    // Função para calcular a temperatura média no vetor
    static double CalcularTemperaturaMedia(int[] temperaturas)
    {
        int soma = 0;

        foreach (int temperatura in temperaturas)
        {
            soma += temperatura;
        }

        return (double)soma / temperaturas.Length;
    }

    // Função para contar o número de dias com temperatura inferior à média
    static int ContarDiasInferioresMedia(int[] temperaturas, double temperaturaMedia)
    {
          int count = 0;

        foreach (int temperatura in temperaturas)
        {
            if (temperatura < temperaturaMedia)
            {
                count++;
            }
        }

        return count;
    }
}
