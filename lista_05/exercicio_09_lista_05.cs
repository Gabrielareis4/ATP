using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrizA = new int[4, 6];
        int[,] matrizB = new int[4, 6];

        // Preencher matrizes A e B com valores aleatórios
        PreencherMatriz(matrizA);
        PreencherMatriz(matrizB);

        Console.WriteLine("Matriz A:");
        ExibirMatriz(matrizA);

        Console.WriteLine("\nMatriz B:");
        ExibirMatriz(matrizB);

        // Calcular e exibir a matriz S (soma de A e B)
        int[,] matrizS = SomarMatrizes(matrizA, matrizB);
        Console.WriteLine("\nMatriz S (A + B):");
        ExibirMatriz(matrizS);

        // Calcular e exibir a matriz D (diferença de A e B)
        int[,] matrizD = SubtrairMatrizes(matrizA, matrizB);
        Console.WriteLine("\nMatriz D (A - B):");
        ExibirMatriz(matrizD);
    }

    // Procedimento para preencher uma matriz com números aleatórios entre 1 e 100
    static void PreencherMatriz(int[,] matriz)
    {
        Random random = new Random();

        for (int i = 0; i < matriz.GetLength(0); i++) // Linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // Colunas
            {
                matriz[i, j] = random.Next(1, 101); // Números aleatórios entre 1 e 100
            }
        }
    }

    // Procedimento para exibir uma matriz na tela
    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++) // Linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // Colunas
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Função para somar duas matrizes
    static int[,] SomarMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizS = new int[matrizA.GetLength(0), matrizA.GetLength(1)];

        for (int i = 0; i < matrizA.GetLength(0); i++) // Linhas
        {
            for (int j = 0; j < matrizA.GetLength(1); j++) // Colunas
            {
                matrizS[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }

        return matrizS;
    }

    // Função para subtrair duas matrizes (A - B)
    static int[,] SubtrairMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizD = new int[matrizA.GetLength(0), matrizA.GetLength(1)];

        for (int i = 0; i < matrizA.GetLength(0); i++) // Linhas
        {
            for (int j = 0; j < matrizA.GetLength(1); j++) // Colunas
            {
                matrizD[i, j] = matrizA[i, j] - matrizB[i, j];
            }
        }

        return matrizD;
    }
}
