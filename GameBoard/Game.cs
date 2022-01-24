
using System.Collections.Generic;



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
        public bool Correct { get; set; }
        public List<KeyValuePair<char, Mark>> MarkedGuess { get; set; } = new List<KeyValuePair<char, Mark>>();


        public void Mark(string word,string guess)
        {
            Correct = true;
            for (int i = 0; i < 5; i++)
            {

                if (word.Contains(guess[i]) && word[i] != guess[i] ) 
                {
                    Correct = false;
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
