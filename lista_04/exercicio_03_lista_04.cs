using System;

class Program
{
    // Procedimento para exibir três valores inteiros em ordem crescente
    static void ExibirEmOrdemCrescente(int a, int b, int c)
    {
        // Coloca os valores em um vetor
        int[] valores = new int[] { a, b, c };
        // Ordena o vetor
        Array.Sort(valores);
        // Exibe os valores ordenados
        Console.WriteLine($"Valores em ordem crescente: {valores[0]}, {valores[1]}, {valores[2]}");
    }

    static void Main(string[] args)
    {
        // Lê o número de conjuntos que o usuário deseja inserir
        Console.WriteLine("Digite o número de conjuntos de 3 valores que deseja inserir:");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            for (int i = 0; i < N; i++)
            {
                // Lê os três valores inteiros do usuário
                Console.WriteLine($"Conjunto {i + 1}:");
                Console.WriteLine("Digite o primeiro valor:");
                int valor1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor:");
                int valor2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o terceiro valor:");
                int valor3 = int.Parse(Console.ReadLine());

                // Chama o procedimento para exibir os valores em ordem crescente
                ExibirEmOrdemCrescente(valor1, valor2, valor3);
            }
        }
        else
        {
            Console.WriteLine("Número inválido. O programa será encerrado.");
        }
    }
}
