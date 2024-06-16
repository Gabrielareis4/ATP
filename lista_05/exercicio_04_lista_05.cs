using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetorX = new int[10];
        int[] vetorY = new int[10];

        // Preenche os vetores X e Y com números aleatórios entre 1 e 100
        PreencherVetores(vetorX, vetorY);

        Console.WriteLine("Vetor X:");
        ExibirVetor(vetorX);

        Console.WriteLine("\nVetor Y:");
        ExibirVetor(vetorY);

        // Gera um novo vetor intercalando os elementos de X e Y
        int[] vetorInterpolado = InterpolarVetores(vetorX, vetorY);

        Console.WriteLine("\nVetor Interpolado:");
        ExibirVetor(vetorInterpolado);
    }

    // Procedimento para preencher os vetores X e Y com números aleatórios entre 1 e 100
    static void PreencherVetores(int[] vetorX, int[] vetorY)
    {
        Random random = new Random();

        for (int i = 0; i < vetorX.Length; i++)
        {
            vetorX[i] = random.Next(1, 101); // Números aleatórios entre 1 e 100
            vetorY[i] = random.Next(1, 101); // Números aleatórios entre 1 e 100
        }
    }

    // Procedimento para interpolar os elementos dos vetores X e Y em um novo vetor
    static int[] InterpolarVetores(int[] vetorX, int[] vetorY)
    {
        int[] vetorInterpolado = new int[vetorX.Length + vetorY.Length];
        int index = 0;

        for (int i = 0; i < vetorX.Length; i++)
        {
            vetorInterpolado[index] = vetorX[i]; // Elemento do vetor X nas posições ímpares do vetor interpolado
            index++;

            vetorInterpolado[index] = vetorY[i]; // Elemento do vetor Y nas posições pares do vetor interpolado
            index++;
        }

        return vetorInterpolado;
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
