using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[10, 10];

        PreencherMatriz(matriz);

        Console.WriteLine("Matriz original:");
        ExibirMatriz(matriz);

        TrocarLinhas(matriz, 2, 8);
        Console.WriteLine("\nMatriz após trocar linha 2 com linha 8:");
        ExibirMatriz(matriz);

        TrocarColunas(matriz, 4, 10);
        Console.WriteLine("\nMatriz após trocar coluna 4 com coluna 10:");
        ExibirMatriz(matriz);

        TrocarDiagonais(matriz);
        Console.WriteLine("\nMatriz após trocar diagonal principal com diagonal secundária:");
        ExibirMatriz(matriz);

        TrocarLinhaComColuna(matriz, 5, 10);
        Console.WriteLine("\nMatriz após trocar linha 5 com coluna 10:");
        ExibirMatriz(matriz);
    }

    // Procedimento para preencher uma matriz 10x10 com números aleatórios entre 1 e 100
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

    // Procedimento para trocar duas linhas da matriz
    static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
    {
        for (int j = 0; j < matriz.GetLength(1); j++) // Colunas
        {
            int temp = matriz[linha1, j];
            matriz[linha1, j] = matriz[linha2, j];
            matriz[linha2, j] = temp;
        }
    }

    // Procedimento para trocar duas colunas da matriz
    static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
    {
        for (int i = 0; i < matriz.GetLength(0); i++) // Linhas
        {
            int temp = matriz[i, coluna1];
            matriz[i, coluna1] = matriz[i, coluna2];
            matriz[i, coluna2] = temp;
        }
    }

    // Procedimento para trocar a diagonal principal com a diagonal secundária da matriz
    static void TrocarDiagonais(int[,] matriz)
    {
        int tamanho = matriz.GetLength(0);

        for (int i = 0; i < tamanho; i++)
        {
            int temp = matriz[i, i];
            matriz[i, i] = matriz[i, tamanho - 1 - i];
            matriz[i, tamanho - 1 - i] = temp;
        }
    }

    // Procedimento para trocar uma linha com uma coluna da matriz
    static void TrocarLinhaComColuna(int[,] matriz, int linha, int coluna)
    {
        int tamanho = matriz.GetLength(0);

        for (int i = 0; i < tamanho; i++)
        {
            int temp = matriz[linha, i];
            matriz[linha, i] = matriz[i, coluna];
            matriz[i, coluna] = temp;
        }
    }
}
