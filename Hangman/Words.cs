using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Words
    {

        // Properties 
        public string HiddenWord;
        public string Word;
        public int Points;
        public char Guess;
        public List<string> ListOfWords { get; } = new List<string>();

        // Constructor
        public Words(string aWord)
        {
            string Word = aWord;
        }

        // Methods
        public void HideWord(string aWord)
        {

            
        }
    }
}
