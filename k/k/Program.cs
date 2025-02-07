using System;

public class Program
{

    public static void Main()
    {
        int soma = 0;
        int numero;

        Console.WriteLine("Digite números inteiros, quando um número negativo for inserido, o programa exibirá a soma dos números positivos. ");

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                break;
            }
            else
            {
                soma += numero;
            }
        } while (true);

        Console.WriteLine("\nA soma dos números inseridos, excluindo o número negativo, é: {0}", soma);
        Console.ReadKey(true);
    }
}