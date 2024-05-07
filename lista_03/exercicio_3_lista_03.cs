using System;

class Program
{
    public static void Main(string[] args)
    {
        // Declaração e inicialização de variáveis para contar números divisíveis por 3 e 9, por 2, por 5 e o total de números digitados
        int num = 0, divpor3e9 = 0, divpor2 = 0, divpor5 = 0, total = 0;
      
        // Loop para solicitar ao usuário 10 números
        do
        {
            // Solicita ao usuário que digite um número
            Console.WriteLine("Digite 10 números: ");
            // Lê o número fornecido pelo usuário e o converte para um inteiro
            num = int.Parse(Console.ReadLine());

            // Verifica se o número é divisível por 3 e por 9
            if (num % 3 == 0 && num % 9 == 0)
                divpor3e9++;
            // Verifica se o número é divisível por 2
            else if (num % 2 == 0)
                divpor2++;
            // Verifica se o número é divisível por 5
            else if (num % 5 == 0)
                divpor5++;
            // Caso o número não seja divisível por nenhum dos valores especificados
            else
                Console.WriteLine("Número não é divisível pelos valores");

            // Incrementa o total de números digitados
            total++;

        } while (total < 10); // Continua o loop enquanto o total de números digitados for menor que 10
      
        // Exibe o total de números divisíveis por 3 e 9, por 2 e por 5
        Console.WriteLine("Total de números divisíveis por 3 e 9: " + divpor3e9);
        Console.WriteLine("Total de números divisíveis por 2: " + divpor2);
        Console.WriteLine("Total de números divisíveis por 5: " + divpor5);
    }
}
