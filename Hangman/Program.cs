using System;

namespace Hangman
{
    internal class Program
    {
        public static bool gameActive = true;

        static void Main(string[] args)
        {
            Random random = new Random();
            string[] words = new string[]
            {
                "Leif",
                //"Water",
                //"Bass",
                //"Joker",
                //"Microphone",
                //"Tommy",
                //"Christian",
                //"Tom",
                //"Frank",
            };

            string randomWord = words[random.Next(words.Length)].ToLower(); // words som er et array blir randomisert og puttet inni en string som heter randomWord
            Console.WriteLine("Dette skal være randomWord ikke skjult: " + randomWord);

            HideWord(randomWord);
            Console.WriteLine("Dette skal være randomWord som skjult: " + randomWord);

            randomWord = randomWord.Replace("leif", "____");
            Console.WriteLine("Dette skal være randomWord som skjult, men uten Method'en: " + randomWord);


        }

        // Få Method'en til å fungere ordentlig og erstatt randomWord med et hiddenWord GET IT RIGHT, TOMMY 

        static string HideWord(string randomWord)
        {


            randomWord = randomWord.Replace("leif", "____");


            //string hiddenWord = "";
            //foreach (char character in randomWord)
            //{
            //    randomWord += character;
            //    randomWord.Replace(' ', '_');
            //    randomWord = hiddenWord;

            //}
            
            return randomWord;
        }
    }
}