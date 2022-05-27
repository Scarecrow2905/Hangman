using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Word
    {
        public string text { get; set; }

        //public List<Words> WordList { get; set; }

        // Constructor
        public Word(string aWord)
        {
            text = aWord;
        }


    }
}
