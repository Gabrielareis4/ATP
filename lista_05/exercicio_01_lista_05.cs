using System;

class Program{
    public static void LerVetor()
    {
        int[] vetorN = new int[20];
        Console.WriteLine("Digite 20 números:");

        for(int i = 0; i < vetorN.Length; i++)
        {
            vetorN[i] = int.Parse(Console.ReadLine());
        }
        
        int menorE = vetorN[0];
        int posicaoMenorE = 0;
        
        for(int i = 1 ; i < vetorN.Length; i++)
        {
         if(vetorN[i] < menorE)
         {
            menorE = vetorN[i];
            posicaoMenorE = i;
         }
        }
        Console.WriteLine($"O menor elemento de N é: {menorE} e sua posição é a: {posicaoMenorE}");
    }

    public static void Main(string[] args)
    {
        LerVetor();
    }
}