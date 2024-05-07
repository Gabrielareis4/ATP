using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração e inicialização das variáveis
        double totalCompra = 0;
        double totalVenda = 0;
        int lucroMenor10 = 0;
        int lucroEntre10e20 = 0;
        int lucroMaior20 = 0;

        // Solicita ao usuário que insira os preços de compra e venda de cada mercadoria
        Console.WriteLine("Digite o preço de compra e venda de cada mercadoria (digite 0 para encerrar):");

        // Loop para receber os preços de compra e venda até que o usuário digite 0 para encerrar
        while (true)
        {
            // Solicita ao usuário o preço de compra
            Console.Write("Preço de compra: ");
            // Lê o preço de compra fornecido pelo usuário e o converte para um número decimal
            double precoCompra = Convert.ToDouble(Console.ReadLine());

            // Verifica se o usuário digitou 0 para encerrar
            if (precoCompra == 0)
                break;

            // Solicita ao usuário o preço de venda
            Console.Write("Preço de venda: ");
            // Lê o preço de venda fornecido pelo usuário e o converte para um número decimal
            double precoVenda = Convert.ToDouble(Console.ReadLine());

            // Calcula o lucro percentual da mercadoria
            double lucro = (precoVenda - precoCompra) / precoCompra * 100;

            // Adiciona os preços de compra e venda aos totais
            totalCompra += precoCompra;
            totalVenda += precoVenda;

            // Classifica o lucro da mercadoria em uma das categorias
            if (lucro < 10)
                lucroMenor10++;
            else if (lucro <= 20)
                lucroEntre10e20++;
            else
                lucroMaior20++;
        }

        // Calcula o lucro total
        double lucroTotal = totalVenda - totalCompra;

        // Exibe as estatísticas
        Console.WriteLine($"Quantidade de mercadorias com lucro < 10%: {lucroMenor10}");
        Console.WriteLine($"Quantidade de mercadorias com 10% <= lucro <= 20%: {lucroEntre10e20}");
        Console.WriteLine($"Quantidade de mercadorias com lucro > 20%: {lucroMaior20}");
        Console.WriteLine($"Valor total de compra: {totalCompra:C}");
        Console.WriteLine($"Valor total de venda: {totalVenda:C}");
        Console.WriteLine($"Lucro total: {lucroTotal:C}");
    }
}
