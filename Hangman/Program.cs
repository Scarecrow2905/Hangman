using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Hangman
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Words HangMan = new Words("Test");

            //var Hang = new[] { new Words("Ord1"), new Words("Ord2"), new Words("Ord3") };

            var ListeAvTekst = new List<string>() { "test", "hallo", "ord" };


            var words = new Words();


            foreach (var word in words.WordList)
            {
                Console.WriteLine(word.text);
            }
            Console.ReadLine();

            //Console.WriteLine("Hang array " + Hang[1].Word);

            //for (int i = 0; i < Hang.Length; i++)
            //{
            //    Console.WriteLine(Hang[i].Word);
            //}
           
        }

        //public static void testWordList()
        //{
        //    var testWordList = new List<Words>();
        //    testWordList.Add(new Words("TestOrd1"));
        //    testWordList.Add(new Words("TestOrd2"));
        //    testWordList.Add(new Words("TestOrd3"));

        //    var random = new Random();
        //    int index = random.Next(0, testWordList.Count + 1);
        //    var randomWord = testWordList[index];

        //    Console.WriteLine(randomWord);
        //}

        
    }
}