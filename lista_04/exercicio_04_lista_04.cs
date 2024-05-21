using System;

class Program
{
    // Procedimento que recebe os valores do vetor e classifica o tipo de triângulo, exibindo o resultado.
    public static void classificacaoTriangulo(int[] lados)
    {
        // Verifica se os lados formam um triângulo
        if (lados[0] + lados[1] > lados[2] && lados[0] + lados[2] > lados[1] && lados[1] + lados[2] > lados[0])
        {
            // Verifica se o triângulo é equilátero
            if (lados[0] == lados[1] && lados[2] == lados[0])
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            // Verifica se o triângulo é isósceles
            else if (lados[0] == lados[1] || lados[0] == lados[2] || lados[1] == lados[2])
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            // Caso contrário, o triângulo é escaleno
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            // Se os lados não formam um triângulo
            Console.WriteLine("Os valores fornecidos não formam um triângulo");
        }
    }

    // Método principal que chama o procedimento de classificação
    public static void Main(string[] args)
    {
        string continuar;
        int[] lados = new int[3]; // vetor para armazenar os três lados do triângulo

        do
        {
            // Solicita ao usuário os valores dos três lados do triângulo
            Console.WriteLine("Digite o valor dos 3 lados do triângulo:");
            lados[0] = int.Parse(Console.ReadLine());
            lados[1] = int.Parse(Console.ReadLine());
            lados[2] = int.Parse(Console.ReadLine());

            // Chama o procedimento para classificar o triângulo
            classificacaoTriangulo(lados);

            // Pergunta ao usuário se deseja verificar outro triângulo
            Console.WriteLine("Deseja verificar outro triângulo (s/n)?");
            continuar = Console.ReadLine();
        } while (continuar.ToLower() == "s"); // Continua o loop se a resposta for "s"
    }
}
