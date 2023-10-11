using System;

namespace Avaliacao
{
    internal class Ex2
    {
        public static void Calculator()
        {
            Console.WriteLine("\n#### Calculadora ####\n");

            Console.Write("Digite o primeiro numero: ");
            int n1 = ReadInt();

            Console.Write("Digite o segundo número: ");
            int n2 = ReadInt();
            Console.WriteLine();

            int product = 0; 
            int quotient = 0; 

            if (n1 == 0)
            {
                Console.WriteLine($"Multiplicacao: {product}");
                Console.WriteLine("A divisao por 0 e indefinida.");
            }
            else if (n2 == 0)
            {
                Console.WriteLine($"Multiplicacao: {product}");
                Console.WriteLine("Nao e possivel dividir por zero.");
            }
            else
            {
                for (int i = 0; i < n2; i++) // Calculate integer multiplication
                {
                    product += n1;
                }

                for (int i = n1; i >= n2; i -= n2) // Calculate integer division
                {
                    quotient++;
                }

                Console.WriteLine($"Multiplicacao: {product}");
                Console.WriteLine($"Divisao inteira: {quotient}");
            }
        }

        private static int ReadInt() // Verifies if user input is valid
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Valor invalido. Digite novamente: ");
            }
            return value;
        }
    }
}