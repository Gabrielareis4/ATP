using System;

class Program
{
    // Função que verifica se um número é positivo
    // Retorna true se o número for positivo, false caso contrário
    static bool VerificarPositivo(int numero)
    {
        return numero >= 0;
    }

    // Método principal que gerencia a leitura de números e exibe as mensagens apropriadas
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos números você deseja verificar?");
        int N = int.Parse(Console.ReadLine()); // Lê a quantidade de números que o usuário deseja verificar

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número:");
            int numero = int.Parse(Console.ReadLine()); // Lê o número fornecido pelo usuário

            // Chama a função VerificarPositivo e armazena o resultado
            bool ePositivo = VerificarPositivo(numero);

            // Exibe a mensagem com base no valor retornado pela função
            if (ePositivo)
            {
                Console.WriteLine("O número é positivo.");
            }
            else
            {
                Console.WriteLine("O número é negativo.");
            }
        }
    }
}
