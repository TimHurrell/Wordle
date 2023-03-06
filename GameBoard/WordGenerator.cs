using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameBoard
{
    public class WordGenerator
    {
        public string answer;
        public List<string> wordList;
        public int lengthOfWordAllowed;

        public WordGenerator(List<string> list, int permittedLengthOfWord)
        {
            wordList = list;
            lengthOfWordAllowed = permittedLengthOfWord;
        }

        public void RemoveWrongLength()
        {
            foreach (var i in wordList)
            {
                if (i.Length != lengthOfWordAllowed)
                {
                    wordList.Remove(i);
                }

            }
        }
    }
}
