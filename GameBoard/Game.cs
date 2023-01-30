
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
                }



                else
                {
                   MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Wrong));
                }


            }
          
        }




    }



    public class Board
    {
        public bool ExceededNumberOfGoes { get; set; } = false;

        public int NumberOfGoesAllowed;

        public string  Answer{ get; set; } 
        public List<string> Guess { get; set; } = new List<string>();
        public bool GuessCorrect { get; set; } = false;
        public List<Row> ListOfRows { get; set; } = new List<Row>();


        public Board() { }
        public Board(string answer, int numberOfGoesAllowed)
        {
            Answer = answer;
            NumberOfGoesAllowed = numberOfGoesAllowed;
        }
        public void TakeGuess(string guess, Row rowfromrowclass)
        {
            if (Guess.Count < NumberOfGoesAllowed && !GuessCorrect)
            {
                Guess.Add(guess);
                ListOfRows.Add(rowfromrowclass);
            }
            else
            { ExceededNumberOfGoes = true; }
        }

        public void AssessGuess()
        {
            if (!GuessCorrect)
            {

                if (ListOfRows[Guess.Count - 1].MarkedGuess[0].Value == Mark.Right
                    && ListOfRows[Guess.Count - 1].MarkedGuess[1].Value == Mark.Right
                    && ListOfRows[Guess.Count - 1].MarkedGuess[2].Value == Mark.Right
                    && ListOfRows[Guess.Count - 1].MarkedGuess[3].Value == Mark.Right
                    && ListOfRows[Guess.Count - 1].MarkedGuess[4].Value == Mark.Right
                    )
                {
                    GuessCorrect = true;
                } 




            }
        }

        public bool SameAsPreviousGo(string guess)
        {
            return Guess.Any(s => s == guess);

        }
    }

    public class WordGenerator
    {
        public string answer;
        public int len;

        public WordGenerator(string v1, int v2)
        {
            answer = v1;
            len = v2;
        }
    }

}


/* Your Row class

public List<KeyValuePair<char, Mark>> MarkedGuess { get; set; }

the set can be made private as you will not be modifying this externally. This improves encapsulation

 */


