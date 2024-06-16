using System;

class Program
{
    static void Main(string[] args)
    {
        // Sorteia os 3 números aleatórios
        int[] numerosSorteados = SortearNumeros();

        Console.WriteLine("Tente adivinhar um dos números sorteados (entre 10 e 50):");

        // Procedimento para ler as tentativas do usuário até acertar
        LerTentativas(numerosSorteados);

        Console.WriteLine("Parabéns! Você acertou um dos números sorteados.");
    }

    // Função para sortear 3 números aleatórios entre 10 e 50 e retorná-los em um vetor
    static int[] SortearNumeros()
    {
        int[] numerosSorteados = new int[3];
        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            numerosSorteados[i] = random.Next(10, 51); // Números aleatórios entre 10 e 50
        }

        return numerosSorteados;
    }

    // Procedimento para ler as tentativas do usuário até acertar um dos números sorteados
    static void LerTentativas(int[] numerosSorteados)
    {
        bool acertou = false;

        while (!acertou)
        {
            Console.Write("Digite sua tentativa: ");
            int tentativa = int.Parse(Console.ReadLine());

            foreach (int numero in numerosSorteados)
            {
                if (tentativa == numero)
                {
                    acertou = true;
                    break;
                }
            }

            if (!acertou)
            {
                Console.WriteLine("Tente novamente.");
            }
        }
    }
}
