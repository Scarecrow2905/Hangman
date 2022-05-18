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
        public List<Words> guessWords { get; } = new List<Words>(); 
        public string HiddenWord { get; set; }
        public string Word;
        public int Points { get; set; }

        // Constructor
        public Words(string aWord)
        {
            string word = aWord;
            
        }
    }
}
