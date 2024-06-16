using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetorX = new int[10];

        // Preenche o vetor X com números aleatórios
        PreencherVetorX(vetorX);

        Console.WriteLine("Vetor X preenchido:");
        ExibirVetor(vetorX);

        // Filtra os valores negativos para um novo vetor
        int[] vetorNegativos = FiltrarNegativos(vetorX);

        Console.WriteLine("\nValores negativos filtrados:");
        ExibirVetor(vetorNegativos);
    }

    // Procedimento para preencher o vetor X com números aleatórios
    static void PreencherVetorX(int[] vetor)
    {
        Random random = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(-20, 21);
        }
    }

    // Função para filtrar os valores negativos de um vetor e retornar um novo vetor com esses valores
    static int[] FiltrarNegativos(int[] vetor)
    {
        // Conta quantos valores negativos existem no vetor
        int countNegativos = 0;
        foreach (int valor in vetor)
        {
            if (valor < 0)
            {
                countNegativos++;
            }
        }

        // Cria um novo vetor para armazenar os valores negativos
        int[] vetorNegativos = new int[countNegativos];
        int index = 0;

        // Copia os valores negativos para o novo vetor
        foreach (int valor in vetor)
        {
            if (valor < 0)
            {
                vetorNegativos[index] = valor;
                index++;
            }
        }

        return vetorNegativos;
    }

    // Procedimento para exibir o conteúdo de um vetor
    static void ExibirVetor(int[] vetor)
    {
        foreach (int valor in vetor)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }
}