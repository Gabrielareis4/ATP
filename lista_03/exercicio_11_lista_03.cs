using System;

class Program
{
    static void Main(string[] args)
    {
        // Array para armazenar os votos de cada candidato (índices de 0 a 3) e duas variáveis para votos nulos e em branco
        int[] votosCandidatos = new int[4];
        int votosNulos = 0;
        int votosBranco = 0;

        // Solicita ao usuário que informe o código do candidato, 5 para voto nulo, 6 para voto em branco, ou 0 para encerrar
        Console.WriteLine("Informe o código do candidato (1, 2, 3, 4), 5 para voto nulo, 6 para voto em branco, ou 0 para encerrar:");

        // Loop para receber os votos até que o usuário digite 0 para encerrar
        while (true)
        {
            // Solicita ao usuário o código do candidato
            Console.Write("Código do candidato (ou 0 para encerrar): ");
            // Lê o código fornecido pelo usuário e o converte para um número inteiro
            int codigo = Convert.ToInt32(Console.ReadLine());

            // Verifica se o usuário digitou 0 para encerrar
            if (codigo == 0)
                break;

            // Switch case para processar o voto de acordo com o código fornecido pelo usuário
            switch (codigo)
            {
                case 1:
                    votosCandidatos[0]++; // Incrementa o contador de votos para o candidato 1
                    break;
                case 2:
                    votosCandidatos[1]++; // Incrementa o contador de votos para o candidato 2
                    break;
                case 3:
                    votosCandidatos[2]++; // Incrementa o contador de votos para o candidato 3
                    break;
                case 4:
                    votosCandidatos[3]++; // Incrementa o contador de votos para o candidato 4
                    break;
                case 5:
                    votosNulos++; // Incrementa o contador de votos nulos
                    break;
                case 6:
                    votosBranco++; // Incrementa o contador de votos em branco
                    break;
                default:
                    Console.WriteLine("Código inválido."); // Caso o código fornecido seja inválido
                    break;
            }
        }

        // Exibe o total de votos para cada candidato
        Console.WriteLine("Total de votos para cada candidato:");
        for (int i = 0; i < votosCandidatos.Length; i++)
        {
            Console.WriteLine($"Candidato {i + 1}: {votosCandidatos[i]} votos");
        }

        // Exibe o total de votos nulos e em branco
        Console.WriteLine($"Total de votos nulos: {votosNulos}");
        Console.WriteLine($"Total de votos em branco: {votosBranco}");
    }
}
