using System;

public class Program
{
    public static void Main()
    {
        string senhaCorreta = "1234"; // Define a senha correta
        string senhaInserida;
        int tentativas = 0;
        int maxTentativas = 3;

        Console.WriteLine("Bem vindo! Você tem até 3 tentativas para inserir a senha correta. ");

        do
        {
            Console.Write("Digite a senha: ");
            senhaInserida = Console.ReadLine();


            // Verifica se a senha inserida está correta
            if (senhaInserida == senhaCorreta)
            {
                Console.WriteLine("\nSenha correta! Acesso permitido.");
                return; // Encerra o programa
            }
            else
            {
                tentativas++;
                int tentativasRestantes = maxTentativas - tentativas;
                Console.WriteLine("Senha incorreta. Você tem {0} tentativas.", tentativasRestantes);
            }
        } while (tentativas < maxTentativas);

        Console.WriteLine("\nNúmero máximo de tentativas atingido. Tente novamente mais tarde.");
        Console.ReadKey(true);
    }
}
