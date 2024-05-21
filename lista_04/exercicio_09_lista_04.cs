using System;
using System.Collections.Generic;

class Program
{
    // Função que lê as notas dos alunos e calcula a média das notas dos alunos aprovados
    static double CalcularMediaAprovados(int numAlunos)
    {
        List<double> notas = new List<double>(); // Lista para armazenar as notas
        double somaAprovados = 0.0; // Variável para somar as notas dos alunos aprovados
        int contadorAprovados = 0; // Contador de alunos aprovados

        for (int i = 0; i < numAlunos; i++)
        {
            Console.WriteLine($"Digite a nota do {i + 1}º aluno:");
            double nota = double.Parse(Console.ReadLine()); // Lê a nota do aluno
            notas.Add(nota);

            // Verifica se o aluno está aprovado
            if (nota >= 6.0)
            {
                somaAprovados += nota;
                contadorAprovados++;
            }
        }

        // Calcula a média das notas dos alunos aprovados
        if (contadorAprovados > 0)
        {
            return somaAprovados / contadorAprovados;
        }
        else
        {
            return 0.0; // Se nenhum aluno foi aprovado, retorna 0.0
        }
    }

    // Método principal que gerencia a leitura do número de alunos e exibe a média dos aprovados
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de alunos:");
        int numAlunos = int.Parse(Console.ReadLine());

        if (numAlunos > 0)
        {
            double mediaAprovados = CalcularMediaAprovados(numAlunos);
            Console.WriteLine($"A média das notas dos alunos aprovados é {mediaAprovados:F2}");
        }
        else
        {
            Console.WriteLine("O número de alunos deve ser maior que zero.");
        }
    }
}
