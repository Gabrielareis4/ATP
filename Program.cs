using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Escolha um exercicio da lista 5 (de um a 10):");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:

        Exercicio_01_lista_05 exercicio_01_lista_05  = new Exercicio_01_lista_05();
        exercicio_01_lista_05.Rodar();
                break;
        }
    }

}

