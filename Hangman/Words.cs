using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Hangman
{
    public class Words
    {

        // Properties 
        public string Word { get; set; }
     
        public List<Word> WordList { get; set; }

        // Constructor
        public Words()
        {
            Word = "hei";
            WordList = new List<Word>();
            var word1 = new Word("test");
            var word2 = new Word("test2");
            WordList.Add(word1);
            WordList.Add(word2);
        }

        // Methods
        //public void ShowWordList()
        //{
        //    for (int i = 0; i < WordList.Count; i++)
        //    {
        //        Console.WriteLine(WordList[i]);
        //    }
        //}

    }
}

//public List<Pokemon> PokemonList { get; set; }


//public Player(string name)
//{
//    Name = name;
//    PokemonList = new List<Pokemon>(6);
//    PokemonList.Add(new Pokemon("Grass", "Weedle", int.MaxValue));
//}
