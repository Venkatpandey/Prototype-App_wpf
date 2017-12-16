using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prototype_Game
{
    public class Game
    {
        /// <summary>
        /// initiate dictionary loader 
        /// </summary>
        private LoadDictionary dictLoader = new LoadDictionary();

        /// <summary>
        /// this is systems turn to play now, based on user word
        /// </summary>
        /// <param name="userWord"></param>
        /// <returns></returns>
        public string getReply(string userWord)
        {
            char lastAlphabet = userWord[userWord.Length - 1];
            string pickedWord = wordPicker(lastAlphabet);
            return pickedWord;
        }

        /// <summary>
        /// system initiates the game from here
        /// </summary>
        /// <returns></returns>
        public string gameInitiator()
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            int i = r.Next(chars.Length);
            char randChar = chars[i];
            string rWord = wordPicker(randChar);
            return rWord;
        }

        /// <summary>
        /// this function allows system to pick a random word
        /// </summary>
        /// <param name="lastAlpha"></param>
        /// <returns></returns>
        private string wordPicker(char lastAlpha)
        {
            // dictionary initialization

            Random randNumber = new Random();
            string returnWord = null;

            List<string> letters = dictLoader.Entries(lastAlpha);
            int randPosition = randNumber.Next(letters.Count);
            returnWord = letters[randPosition];

            return returnWord;
        }



    }
}
