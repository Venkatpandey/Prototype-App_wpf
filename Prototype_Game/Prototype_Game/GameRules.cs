using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Game
{
    public class GameRules
    {
        List<string> playedWords = new List<string>();

        public string playedWord(string word)
        {
            if (playedWords.Contains(word))
            {
                 string repete = "Word Already Played...!";
                 return repete;
            }
            else
            {
                playedWords.Add(word);
            }
            return word;
        }

        public string wordPlayedByUser(string word)
        {
            string lastEntry = playedWords.Last();
            string lastAlphabet = lastEntry[lastEntry.Length - 1].ToString();

            if(word.StartsWith(lastAlphabet) == false)
            {
                string repete = "Invalid Word..!!";
                return repete;
            }

            else if (playedWords.Contains(word))
            {
                string repete = "Word Already Played...!";
                return repete;
               
            }
            else { playedWords.Add(word); }
            return word;
        }

       
    }
}
