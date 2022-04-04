
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
        public List<KeyValuePair<char, Mark>> MarkedGuess { get; set; } = new List<KeyValuePair<char, Mark>>();


        public bool Mark(string word,string guess)
        //public void Mark(string word, string guess)
        {
            bool GuessCorrect = true;
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
                    GuessCorrect = false;
                    MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Partial));
                }



                else
                {
                    GuessCorrect = false;
                    MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Wrong));
                }


            }
            return GuessCorrect;

        }




    }



    public class Board
    {
        public string  Answer{ get; set; } 
        public List<string> Guess { get; set; } = new List<string>();
        public bool GuessCorrect { get; set; }
        //public Row Row { get; set; }
        public List<Row> ListOfRows { get; set; } = new List<Row>();


        public Board() { }
        public Board(string answer)
        {
            Answer = answer;
        }
        public void MarkGuess(string guess, Row rowfromrowclass)
        {
            if (Guess.Count < 5 && !GuessCorrect)
            {
                Guess.Add(guess);
                ListOfRows.Add(rowfromrowclass);
                GuessCorrect = ListOfRows[Guess.Count - 1].Mark(Answer, guess);
                    
            }
        }

    }
}


/* Your Row class

public List<KeyValuePair<char, Mark>> MarkedGuess { get; set; }

the set can be made private as you will not be modifying this externally. This improves encapsulation

 */



/* change


I don't think the method actually needs to return anything.
You can access MarkedGuess List to do this. */

