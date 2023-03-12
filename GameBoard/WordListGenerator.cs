using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameBoard
{
    public class WordListGenerator
    {
        public string answer;
        public List<string> wordList;
        public int lengthOfWordAllowed;

        //does it need to be a list, could it be some less specific
        public WordListGenerator(List<string> list, int permittedLengthOfWord)
        {
            wordList = list;
            lengthOfWordAllowed = permittedLengthOfWord;
        }

        public void RemoveWrongLength()
        {
            var toRemove = new List<string>();


            foreach (var i in wordList)
            {
                if (i.Length != lengthOfWordAllowed)
                {
                    toRemove.Add(i);
                }

            }
            wordList = wordList.Except(toRemove).ToList();

        }

        public string SelectAnswer()
        {
             {
                if (wordList.Count == 0)
                {
                    throw new Exception("No words available");
                }

                // Select a random index
                var random = new Random();
                var index = random.Next(0, wordList.Count);

                // Get the word at the selected index
                var answer = wordList[index];

                return answer;
            }

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
