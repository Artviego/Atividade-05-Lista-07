using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário para inserir um número inteiro positivo
        Console.Write("Insira um número inteiro positivo: ");
        string input = Console.ReadLine();
        int numero;
     
        // Tenta converter a entrada para um número inteiro
        if (int.TryParse(input, out numero) && numero > 0)
        {
            Console.WriteLine("Números pares entre 0 e " + numero + ":");

            // Inicializa a variável de controle para o loop
            int i = 0;

            // Loop While para exibir números pares
            while (i <= numero)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++; // Incrementa o valor de i a cada iteração
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo válido.");
        }
        
        Console.ReadKey();
    }
}
