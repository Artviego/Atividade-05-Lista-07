using System;

public class Program
{
    public static void Main()
    {

        Console.Write("Insira um número inteiro: ");
        string input = Console.ReadLine();
        int numero;

        //Converte a entrada de dados para um inteiro
        if (int.TryParse(input, out numero))
        {
            Console.WriteLine("Tabuada de {0} até o número 10: ", numero);


            //Inicializa a variável de controle para o loop
            int i = 1;

            //Loop para exibir a tabuada
            do
            {
                Console.WriteLine(numero * i);

                i++;
            } while (i <= 10);


        }
        else
        {
            Console.WriteLine("Por favor, insira um número inteiro válido.");

        }

        Console.ReadKey(true);
    }
}