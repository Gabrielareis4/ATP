using System;

class Program
{
    static void Main(String[] args)
    {
        // Declaração de variáveis
        int num = 0, fat = 1, cont = 0;
        
        // Solicita ao usuário que insira um número para calcular o fatorial
        Console.WriteLine("Insira um número para calcular o seu fatorial:");
        // Lê o número fornecido pelo usuário e o converte para um inteiro
        num = int.Parse(Console.ReadLine());

        // Verifica se o número é negativo
        if (num < 0)
        {
            Console.WriteLine("Não existe fatorial de número negativo.");
        }
        // Verifica se o número é 0 ou 1, pois o fatorial de 0 e 1 é 1
        else if ((num == 0) || (num == 1))
        {
            Console.WriteLine("O fatorial de " + num + " é 1.");
        }
        else
        {
            // Loop para calcular o fatorial do número
            for (cont = num; cont >= 1; cont--)
            {
                fat *= cont;
            }
            // Exibe o resultado do cálculo do fatorial
            Console.WriteLine("O fatorial de " + num + " é " + fat);
        }
    }
}
