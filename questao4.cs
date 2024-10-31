using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantas pessoas serão inseridas? ");
        int n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        int[] idades = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite o nome da pessoa " + (i + 1) + ": ");
            nomes[i] = Console.ReadLine();

            Console.Write("Digite a idade da pessoa " + (i + 1) + ": ");
            idades[i] = int.Parse(Console.ReadLine());
        }

        int idadeMaxima = idades[0];
        string nomeMaisVelho = nomes[0];

        for (int i = 1; i < n; i++)
        {
            if (idades[i] > idadeMaxima)
            {
                idadeMaxima = idades[i];
                nomeMaisVelho = nomes[i];
            }
        }
        Console.WriteLine("A pessoa mais velha é: " + nomeMaisVelho);
    }
}
