using System;

class Program
{
    static void Main(string[] args)
    {
        // Variáveis para armazenar os dados
        double salario;
        int numFilhos;
        double somaSalario = 0;
        int totalPessoas = 0;
        int totalFilhos = 0;
        double maiorSalario = double.MinValue;
        int pessoasSalarioAte100 = 0;

        // Loop para entrada dos dados
        while (true)
        {
            Console.WriteLine("Digite o salário (ou um valor negativo para encerrar): ");
            salario = Convert.ToDouble(Console.ReadLine());

            // Verifica se o salário é negativo para encerrar o loop
            if (salario < 0)
                break;

            Console.WriteLine("Digite o número de filhos: ");
            numFilhos = Convert.ToInt32(Console.ReadLine());

            // Atualiza as variáveis
            somaSalario += salario;
            totalPessoas++;
            totalFilhos += numFilhos;
            if (salario > maiorSalario)
                maiorSalario = salario;
            if (salario <= 100)
                pessoasSalarioAte100++;
        }

        // Verifica se foram inseridos dados antes de calcular as médias
        if (totalPessoas > 0)
        {
            // Calcula as médias
            double mediaSalario = somaSalario / totalPessoas;
            double mediaFilhos = (double)totalFilhos / totalPessoas;

            // Calcula o percentual de pessoas com salário até R$100,00
            double percentualSalarioAte100 = (double)pessoasSalarioAte100 / totalPessoas * 100;

            // Exibe os resultados
            Console.WriteLine($"a) Média do salário da população: {mediaSalario:C}");
            Console.WriteLine($"b) Média do número de filhos: {mediaFilhos:F}");
            Console.WriteLine($"c) Maior salário: {maiorSalario:C}");
            Console.WriteLine($"d) Percentual de pessoas com salário até R$100,00: {percentualSalarioAte100:F}%");
        }
        else
        {
            Console.WriteLine("Nenhum dado foi inserido.");
        }
    }
}

