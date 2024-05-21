using System;

class Program
{
    // Método que realiza a coleta e processamento dos dados
    public static void pesquisa()
    {
        
        double salario = 0, totalSalario = 0, mediaSalario = 0;
        int numParticipantes = 0, numFilhos = 0;
        string continuar; // Variável para controlar o loop

        // Loop para continuar a coleta de dados até que se decida parar
        do
        {
            // Solicita e lê o valor do salário
            Console.WriteLine("Insira o valor do salário:");
            salario = double.Parse(Console.ReadLine());

            // Solicita e lê a quantidade de filhos
            Console.WriteLine("insira a quantidade de filhos");
            numFilhos = int.Parse(Console.ReadLine());

            // Pergunta ao usuário se deseja continuar
            Console.WriteLine("Deseja continuar(s/n)?");
            continuar = Console.ReadLine();

            // Incrementa o contador de participantes
            numParticipantes++;

            // Acumula o total dos salários
            totalSalario += salario;

        } while (continuar == "s"); // Condição de parada do loop

        // Calcula e exibe a média dos salários
        mediaSalario = totalSalario / numParticipantes;
        Console.WriteLine($"A média de salário da população é de: {mediaSalario:F2}");
    }

    // Método principal que executa o programa
    public static void Main(string[] args)
    {
        // Chama o método 'pesquisa' para iniciar a coleta de dados
        pesquisa();
    }
}
