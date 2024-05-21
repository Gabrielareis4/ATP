using System;

class Program
{
    // Função que recebe a idade de um nadador e retorna a categoria
    static string CategoriaNadador(int idade)
    {
        if (idade >= 5 && idade <= 7)
        {
            return "F";
        }
        else if (idade >= 8 && idade <= 10)
        {
            return "E";
        }
        else if (idade >= 11 && idade <= 13)
        {
            return "D";
        }
        else if (idade >= 14 && idade <= 15)
        {
            return "C";
        }
        else if (idade >= 16 && idade <= 17)
        {
            return "B";
        }
        else if (idade >= 18)
        {
            return "A";
        }
        else
        {
            return "Idade inválida para classificação";
        }
    }

    // Método principal que lê a idade do nadador e imprime a categoria
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a idade do nadador:");
        int idade = int.Parse(Console.ReadLine()); // Lê a idade do nadador

        // Chama a função CategoriaNadador e armazena o resultado
        string categoria = CategoriaNadador(idade);

        // Exibe a categoria do nadador
        Console.WriteLine($"A categoria do nadador é: {categoria}");
    }
}
