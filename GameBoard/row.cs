
using System;
using System.Collections.Generic;
using System.Linq;


namespace GameBoard
{
    public class Row
    {
        public IList<KeyValuePair<char, Mark>> MarkedGuess { get; set; } = new List<KeyValuePair<char, Mark>>();
        
        /*public bool GuessCorrect
        {
            get => MarkedGuess.All(pair => pair.Value == global::Mark.Right); private set { }
        }
        */


        public void Mark(string word, string guess)
        {
            
            MarkedGuess.Clear();
            for (int i = 0; i < guess.Length; i++)
            {
                char UppedCharacterG = char.ToUpper(guess[i]);
                char UppedCharacterA = char.ToUpper(word[i]);
                word = word.ToUpper();



                if (UppedCharacterG == UppedCharacterA)
                {
                    MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Right));
                }

                else if (word.Contains(UppedCharacterG) && UppedCharacterA != UppedCharacterG) 
                {
                   MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Partial));
                  // GuessCorrect = false;
                }



                else
                {
                   MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Wrong));
                   // GuessCorrect = false;
                }


            }


        }

        public bool GuessCorrect()
        {
            return MarkedGuess.All(pair => pair.Value == global::Mark.Right);

        }




    }




   
}


/* Your Row class

public List<KeyValuePair<char, Mark>> MarkedGuess { get; set; }

the set can be made private as you will not be modifying this externally. This improves encapsulation

 */


