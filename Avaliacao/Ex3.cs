using System;

namespace Avaliacao
{
    internal class Ex3
    {
        public static void WordAnalyzer()
        {
            Console.WriteLine("\n#### Analisador de Palavras ####\n");

            Console.Write("Digite uma frase: ");
            string ?sentence = Console.ReadLine();         

            int uppercases = 0;
            int lowercases = 0;
            int startingUppercase = 0;
            int startingLowercase = 0;
            int wordCount = 0;

            if (!String.IsNullOrEmpty(sentence))
            {
                string[] words = sentence.Split(' ');

                foreach (string word in words)
                {
                    if (word == word.ToUpper()) // Checks if word is uppercase 
                    {
                        uppercases++;
                    }
                    if (word == word.ToLower()) // Checks if word is lowercase
                    {
                        lowercases++;
                    }
                    if (char.IsUpper(word[0])) // Checks if word's first letter is uppercase
                    {
                        startingUppercase++;
                    }
                    if (char.IsLower(word[0])) // Checks if word's first letter is lowercase 
                    {
                        startingLowercase++;
                    }
                }

                wordCount = words.Length;
            }

            Console.WriteLine($"Palavras maiusculas: {uppercases}"); // Prints all counters
            Console.WriteLine($"Palavras minusculas: {lowercases}");
            Console.WriteLine($"Palavras com letra maiuscula inicial: {startingUppercase}");
            Console.WriteLine($"Palavras com letra minuscula inicial: {startingLowercase}");
            Console.WriteLine($"Total de palavras: {wordCount}");
        }
    }
}