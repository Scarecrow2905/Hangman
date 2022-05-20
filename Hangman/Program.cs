using System;

namespace Hangman
{
    internal class Program
    {
        public static bool gameActive = true;

        static void Main(string[] args)
        {
            Random random = new Random();
            

            List<string> ListOfWords = new List<string>() { "word1", "word2", "word3", "word4", "word5", "word6", "word7" };



            string RandomWords = ListOfWords.Next(0, 8); // words som er et array blir randomisert og puttet inni en string som heter randomWord
            

            

            Console.ReadLine();


        }

        // Få Method'en til å fungere ordentlig og erstatt randomWord med et hiddenWord GET IT RIGHT, TOMMY 

        
    }
}