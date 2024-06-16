using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];

        PreencherMatriz(matriz);

        Console.WriteLine("Matriz gerada:");
        ExibirMatriz(matriz);

        Console.WriteLine("\nElementos da diagonal principal:");
        ExibirDiagonalPrincipal(matriz);

        int somaElementosAbaixoDiagonal = CalcularSomaAbaixoDiagonal(matriz);
        Console.WriteLine($"\nSoma dos elementos abaixo da diagonal principal: {somaElementosAbaixoDiagonal}");
    }

    // Procedimento para preencher a matriz com números aleatórios entre 1 e 100
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

    // Procedimento para exibir a matriz na tela
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

    // Procedimento para exibir os elementos da diagonal principal da matriz
    static void ExibirDiagonalPrincipal(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++) // Linhas
        {
            Console.Write(matriz[i, i] + " ");
        }
        Console.WriteLine();
    }

    // Função para calcular a soma dos elementos abaixo da diagonal principal
    static int CalcularSomaAbaixoDiagonal(int[,] matriz)
    {
        int soma = 0;

        for (int i = 1; i < matriz.GetLength(0); i++) // Linhas abaixo da diagonal
        {
            for (int j = 0; j < i; j++) // Colunas abaixo da diagonal
            {
                soma += matriz[i, j];
            }
        }

        return soma;
    }
}
