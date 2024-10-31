namespace Teste
{
    public class Teste
    {
        public static void Main()
        {
            double baseA;
            double ladoB;
            double alturaC;
            double pi = 3.14159;

            Console.Write("Digite o valor A: ");
            baseA = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            ladoB = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor c: ");
            alturaC = double.Parse(Console.ReadLine());

            double first = (baseA * alturaC) / 2;

            Console.WriteLine("A área do seu triângulo retângulo é {0}", first);

            double second = pi * Math.Pow(alturaC, 2);

            Console.WriteLine("A área do seu círculo é {0}", second);

            double third = ((baseA + ladoB) * alturaC) / 2;

            Console.WriteLine("A área do seu trapézio é {0}", third);

            double forth = Math.Pow(ladoB, 2);

            Console.WriteLine("A área do seu quadrado é {0}", forth);

            double fifth = baseA * ladoB;

            Console.WriteLine("A área do seu retângulo é {0}", fifth);



        }
    }
}
