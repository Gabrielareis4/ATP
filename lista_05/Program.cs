using System;

class Program
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
                
            case 2:

        Exercicio_02_lista_05 exercicio_02_lista_05  = new Exercicio_02_lista_05();
        exercicio_02_lista_05.Rodar();
                break;

            case 3:

        Exercicio_03_lista_05 exercicio_03_lista_05  = new Exercicio_03_lista_05();
        exercicio_03_lista_05.Rodar();
                break;

            case 4:

        Exercicio_04_lista_05 exercicio_04_lista_05  = new Exercicio_04_lista_05();
        exercicio_04_lista_05.Rodar();
                break;

            case 5:

        Exercicio_05_lista_05 exercicio_05_lista_05  = new Exercicio_05_lista_05();
        exercicio_05_lista_05.Rodar();
                break;

            case 6:

        Exercicio_06_lista_05 exercicio_06_lista_05  = new Exercicio_06_lista_05();
        exercicio_06_lista_05.Rodar();
                break;

            case 7:

        Exercicio_07_lista_05 exercicio_07_lista_05  = new Exercicio_07_lista_05();
        exercicio_07_lista_05.Rodar();
                break;

            case 8:

        Exercicio_08_lista_05 exercicio_08_lista_05  = new Exercicio_08_lista_05();
        exercicio_08_lista_05.Rodar();
                break;

            case 9:

        Exercicio_09_lista_05 exercicio_09_lista_05  = new Exercicio_09_lista_05();
        exercicio_09_lista_05.Rodar();
                break;

            case 10:

        Exercicio_10_lista_05 exercicio_10_lista_05  = new Exercicio_10_lista_05();
        exercicio_10_lista_05.Rodar();
                break;
        }
    }

}
