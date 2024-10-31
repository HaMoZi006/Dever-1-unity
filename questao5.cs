using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Digite os valores da matriz 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        bool ifQM = verQM(matriz);

        if (ifQM)
            Console.WriteLine("A matriz é um quadrado mágico!");
        else
            Console.WriteLine("A matriz não é um quadrado mágico.");
    }

    static bool verQM(int[,] matriz)
    {
        int somaMagica = 0;

        for (int j = 0; j < 3; j++)
        {
            somaMagica += matriz[0, j];
        }

        for (int i = 1; i < 3; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < 3; j++)
            {
                somaLinha += matriz[i, j];
            }
            if (somaLinha != somaMagica)
                return false;
        }

        for (int j = 0; j < 3; j++)
        {
            int somaColuna = 0;
            for (int i = 0; i < 3; i++)
            {
                somaColuna += matriz[i, j];
            }
            if (somaColuna != somaMagica)
                return false;
        }

        int somaDP = 0;
        for (int i = 0; i < 3; i++)
        {
            somaDP += matriz[i, i];
        }
        if (somaDP != somaMagica)
            return false;

        int somaD2 = 0;
        for (int i = 0; i < 3; i++)
        {
            somaD2 += matriz[i, 2 - i];
        }
        if (somaD2 != somaMagica)
            return false;

        return true;
    }
}
