using System;

public class Program
{

    public static void Main()
    {
        int i = 0;
        int soma = 0;
        string input;
        int numero;

        Console.WriteLine("Digite uma sequência de 5 números inteiros. ");

        do
        {
            Console.Write("Digite um número: ");
            input = Console.ReadLine();

            // Tenta converter a entrada para um número inteiro
            if (int.TryParse(input, out numero))
            {
                soma += numero;

            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro");

            }

            i++;
        } while (i < 5);

        Console.WriteLine("\nA soma dos números inseridos é: {0}", soma);
        Console.ReadKey(true);
    }
}