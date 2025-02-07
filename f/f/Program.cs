using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Insira um número inteiro positivo: ");
        string input = Console.ReadLine();
        int numero;

        if (int.TryParse(input, out numero))
        {
            Console.WriteLine("Números pares entre 0 e {0}: ", numero);

            int i = 0;

            // Exibe todos os números pares entre 0 e o número inserido pelo usuário
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;

            } while (i <= numero);

        }
        else
        {
            Console.WriteLine("Por favor, insira um número positivo válido.");
        }

        Console.ReadKey(true);
    }
}