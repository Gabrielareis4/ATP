using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];

        PreencherMatriz(matriz);

        Console.WriteLine("Matriz gerada:");
        ExibirMatriz(matriz);

        // Calculando e exibindo as somas solicitadas
        Console.WriteLine($"Soma da linha 4: {SomaLinha(matriz, 4)}");
        Console.WriteLine($"Soma da coluna 2: {SomaColuna(matriz, 2)}");
        Console.WriteLine($"Soma da diagonal principal: {SomaDiagonalPrincipal(matriz)}");
        Console.WriteLine($"Soma da diagonal secundária: {SomaDiagonalSecundaria(matriz)}");
        Console.WriteLine($"Soma de todos os elementos da matriz: {SomaTotalMatriz(matriz)}");
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

    // Função para calcular a soma dos elementos de uma linha específica da matriz
    static int SomaLinha(int[,] matriz, int linha)
    {
        int soma = 0;

        for (int j = 0; j < matriz.GetLength(1); j++) // Percorre as colunas da linha especificada
        {
            soma += matriz[linha, j];
        }

        return soma;
    }

    // Função para calcular a soma dos elementos de uma coluna específica da matriz
    static int SomaColuna(int[,] matriz, int coluna)
    {
        int soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++) // Percorre as linhas da coluna especificada
        {
            soma += matriz[i, coluna];
        }

        return soma;
    }

    // Função para calcular a soma dos elementos da diagonal principal da matriz
    static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++) // Percorre a diagonal principal (mesma linha e coluna)
        {
            soma += matriz[i, i];
        }

        return soma;
    }

    // Função para calcular a soma dos elementos da diagonal secundária da matriz
    static int SomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        int tamanho = matriz.GetLength(0); // Tamanho da matriz (5 neste caso)

        for (int i = 0; i < tamanho; i++) // Percorre a diagonal secundária
        {
            soma += matriz[i, tamanho - 1 - i];
        }

        return soma;
    }

    // Função para calcular a soma de todos os elementos da matriz
    static int SomaTotalMatriz(int[,] matriz)
    {
        int soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++) // Linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // Colunas
            {
                soma += matriz[i, j];
            }
        }

        return soma;
    }
}
