using System;

class Program {
  public static void Main (string[] args) {
    // Declaração e inicialização de variáveis para contar números negativos, zeros e positivos
    int contNegativos = 0, contZeros = 0, contPositivos = 0, numero; 
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
      
      // Pergunta ao usuário se deseja continuar inserindo números
      Console.WriteLine("Deseja continuar? (S/N)");
      // Lê a resposta do usuário
      opcao = Console.ReadLine();
    } while(opcao == "s" || opcao == "S"); // Continua o loop se a resposta for "s" ou "S"

    // Exibe o total de números negativos, zeros e positivos informados pelo usuário
    Console.WriteLine("Negativos informados: " + contNegativos);
    Console.WriteLine("Zeros informados: " + contZeros);
    Console.WriteLine("Positivos informados: " + contPositivos);
  }
}
