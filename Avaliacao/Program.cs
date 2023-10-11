// QUESTÃO 4: LETRA C
//
// Avaliando a expressao dada, o resultado exibido sera 1. Utilizando a logica formal, podemos
// chamar a proposicao 21 > 21 de B. A expressão "!(21 > 21)" eh equivalente a ¬B (negacao)
// de B, logo, B era inicialmente falso, porem sua negacao a tornou verdadeira. O metodo
// "Convert.ToInt16()" torna essa verdade em inteiro, de true, para 1. Apesar da variavel ser 
// int32 e a conversao ser int16, nao haveria problema pela natureza do valor a ser convertido. 
// Como a variavel final tem capacidade de armazenamento maior, também conseguiria receber o 
// maior valor possível de int16.

// QUESTÃO 5: LETRA E
// Condicao: enquanto i for menor igual a 7.
//
// Primeira iteracao i = -5. Loop continua, -5 eh impresso.
// Segunda iteracao i = -2. Loop continua, -2 eh impresso.
// Terceira interacao i = 1. Loop continua, 1 eh impresso.
// Quarta iteracao i = 4. Loop continua, 4 eh impresso.
// Quinta iteracao i = 7. Loop continua, 7 eh impresso.
// Sexta iteracao i = 10. Loop para.
// Final: -5, -2, 1, 4, 7.

// OBS: Professores, deixei o codigo e comentarios em en-us pensando no cenario de que uma equipe de devs 
// pode ser composta por estrangeiros (intercionalizacao do codigo) e mensagens impressas
// na tela em pt-br, ja que o cliente, nesse caso, seria brasileiro.

namespace Avaliacao
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();

                char choice = Console.ReadKey().KeyChar; // Read user input
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        Ex1.Counter();
                        break;

                    case '2':
                        Ex2.Calculator();
                        break;

                    case '3':
                        Ex3.WordAnalyzer();
                        break;

                    case '0':
                        return; // Exit the program if the user chooses to quit

                    default:
                        Console.WriteLine("Opção invalida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine("\n#######################");
            Console.WriteLine("#######  MENU  ########");
            Console.WriteLine("#######################\n");
            Console.WriteLine("1. Exercicio - Contador");
            Console.WriteLine("2. Exercicio - Calculadora");
            Console.WriteLine("3. Exercicio - Analisador de Palavras");
            Console.WriteLine("0. Sair");
            Console.Write("\nEscolha uma opcao: ");
        }
    } 
}