
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


        //you're not using this constructor, you can get rid of it.
        public Board() { }
        public Board(string answer, int numberOfGoesAllowed)
        {
            Answer = answer;
            NumberOfGoesAllowed = numberOfGoesAllowed;
        }

        //can you think of a better name than rowfromrowclass? Why not just row
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

        //you're already marking on the row class, no need to do it again on the board class
        //just have a bool property on the row which says correct or not
        public void AssessGuess()
        {
            if (!GuessCorrect)
            {
                //this works but what if we decide to make the game a different number of letters
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
        public List<string> wordList;
        public int len;

        //whats v2?
        //does it need to be a list, could it be some less specific
        public WordGenerator(List<string> list, int v2)
        {
            wordList = list;
            len = v2;
        }

        public void RemoveWrongLength()
        {
            foreach (var i in wordList)
            {
                if (i.Length != len)
                {
                    wordList.Remove(i);
                }

            }
        }

    }

}


/* Your Row class

public List<KeyValuePair<char, Mark>> MarkedGuess { get; set; }

the set can be made private as you will not be modifying this externally. This improves encapsulation

 */


