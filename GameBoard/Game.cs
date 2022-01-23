using System;
using System.Collections.Generic;
using System.Linq;


public enum Mark
{
    Wrong,
    Partial,
    Right
}

namespace GameBoard
{
    public class Row
    {
        public bool Correct { get; set; } = true;
        public string WordAnswer { get; set; }
        //public char[] Row = new char[5];
        public int[] Guess = new int[5];
        public List<KeyValuePair<char, Mark>> MarkedGuess { get; set; } = new List<KeyValuePair<char, Mark>>();

        //public Board (string word)
        //{
        //    Row[0] = word[0];
        //    Row[1] = word[1];
        //    Row[2] = word[2];
        //    Row[3] = word[3];
        //    Row[4] = word[4];
        //    WordAnswer = word;
        //}

        //public Row()
        //{
        //}

        public void Mark(string word,string guess)
        {
            for (int i = 0; i < 5; i++)
            {
                //MarkedGuess[i].Key = , kvp.Value

                if (word.Contains(guess[i]) && word[i] != guess[i] ) 
                {
                    MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Partial));
                }

                else if (guess[i] == word[i])
                {
                    MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Right));
                }


                else
                {
                    Correct = false;
                    MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Wrong));
                }


            }

        }

    }
}
