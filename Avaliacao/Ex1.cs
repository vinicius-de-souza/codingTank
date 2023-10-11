using System;

namespace Avaliacao
{
    internal class Ex1
    {
        public static void Counter()
        {
            Console.WriteLine("\n#### Contador #####\n");

            int[] values = new int[5];
            int oddNumbers = 0, evenNumbers = 0, posNumbers = 0, negNumbers = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i+1}º valor: "); // User integers input
                values[i] = ReadInt();

                if (values[i] % 2 == 0)
                {
                    oddNumbers++;
                }
                else
                {
                    evenNumbers++;
                }

                if (values[i] > 0)
                {
                    posNumbers++;
                }
                else if (values[i] < 0)
                {
                    negNumbers++;
                }
            }

            Console.WriteLine($"\nQuantidade de valores pares: {oddNumbers}"); // All followring Write statements print amounts counted by the algorithm
            Console.WriteLine($"Quantidade de valores impares: {evenNumbers}");
            Console.WriteLine($"Quantidade de valores positivos: {posNumbers}");
            Console.WriteLine($"Quantidade de valores negativos: {negNumbers}");
        }

        private static int ReadInt() // Verifies user input
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Valor inválido, este programa só aceita valores inteiros. Digite novamente: ");
            }
            return value;
        }
    }
}