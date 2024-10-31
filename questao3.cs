using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números: ");
        int N = int.Parse(Console.ReadLine());

        double[] numeros = new double[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("Digite o número na posição " + i + ": ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);

        double maiorNumero = numeros[N - 1];

        Console.WriteLine("Maior número: " + maiorNumero);
        Console.WriteLine("Posição do maior número na entrada original: " + Array.IndexOf(numeros, maiorNumero));
    }
}
