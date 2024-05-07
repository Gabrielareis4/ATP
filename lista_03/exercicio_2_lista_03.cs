using System;

class Program {
  public static void Main (string[] args) {
    // Declaração e inicialização de variáveis
    int contNegativos = 0, contZeros = 0, contPositivos = 0, numero;
    double mediapositivos = 0, mediazeros = 0, medianegativos = 0, total = 0;
    string opcao;

    // Loop principal do programa
    do {
      // Solicita ao usuário que informe um número
      Console.WriteLine("Informe o número: ");
      // Lê o número fornecido pelo usuário e o converte para um inteiro
      numero = int.Parse(Console.ReadLine());

      // Verifica se o número é positivo, zero ou negativo e incrementa o contador apropriado
      if(numero > 0)
        contPositivos++;
      else if(numero == 0)
        contZeros++;
      else
        contNegativos++;
      total++;
      
      // Pergunta ao usuário se deseja continuar inserindo números
      Console.WriteLine("Deseja continuar? (S/N)");
      // Lê a resposta do usuário
      opcao = Console.ReadLine();
    } while(opcao == "s" || opcao == "S"); // Continua o loop se a resposta for "s" ou "S"

    // Calcula as médias de positivos, zeros e negativos
    mediapositivos = (contPositivos * 100) / total;
    mediazeros = (contZeros * 100) / total;
    medianegativos = (contNegativos * 100) / total;

    // Exibe o total de números positivos, zeros e negativos informados pelo usuário
    Console.WriteLine("Positivos informados: " + contPositivos);
    Console.WriteLine("Zeros informados: " + contZeros);
    Console.WriteLine("Negativos informados: " + contNegativos);
        
    // Exibe a porcentagem de positivos, zeros e negativos em relação ao total de números informados
    Console.WriteLine("Do total de números informados: " + mediapositivos + "% são positivos, " + mediazeros + "% são zeros e " + medianegativos + "% são negativos ");
  }
}