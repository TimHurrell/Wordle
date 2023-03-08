
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
        public List<KeyValuePair<char, Mark>> MarkedGuess { get; set; } = new List<KeyValuePair<char, Mark>>();
        public bool GuessCorrect { get; set; } = true;

        public void Mark(string word, string guess)
        {
            
            MarkedGuess.Clear();
            for (int i = 0; i < guess.Length; i++)
            {
                char UppedCharacter = char.ToUpper(guess[i]);



                if (UppedCharacter == word[i])
                {
                    MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Right));
                }

                else if (word.Contains(UppedCharacter) && word[i] != UppedCharacter) 
                {
                   MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Partial));
                   GuessCorrect = false;
                }



                else
                {
                   MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Wrong));
                   GuessCorrect = false;
                }


            }
          
        }




    }




   
}


/* Your Row class

public List<KeyValuePair<char, Mark>> MarkedGuess { get; set; }

the set can be made private as you will not be modifying this externally. This improves encapsulation

 */


