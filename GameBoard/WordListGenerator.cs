using System;
using System.Collections.Generic;
using System.Linq;

namespace GameBoard
{
    public class WordListGenerator
    {
        public string answer;
        public IList<string> wordList;
        public int lengthOfWordAllowed;

        public WordListGenerator(IList<string> list, int permittedLengthOfWord)
        {
            lengthOfWordAllowed = permittedLengthOfWord;

            var toRemove = new List<string>();
            foreach (var i in list)
            {
                if (i.Length != lengthOfWordAllowed || char.IsUpper(i[0]))
                {
                    toRemove.Add(i);
                }

            }
            wordList = list.Except(toRemove).ToList();

            if (wordList.Count == 0)
            {
                throw new Exception("No words available");
            }

            // Select a random index
            var random = new Random();
            var index = random.Next(0, wordList.Count);

            // Get the word at the selected index
            answer = wordList[index];


        }

        public bool GuessExistsInWordList(string guess)
        {
            return wordList.Contains(guess);
        }


        public void RemoveGuessFromWordList(string guess)
        {
            wordList.Remove(guess);

        }
    }
}
