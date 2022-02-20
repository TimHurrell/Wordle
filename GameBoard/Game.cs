
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
        {
            bool GuessCorrect = true;
            MarkedGuess.Clear();
            for (int i = 0; i < 5; i++)
            {

                if (word.Contains(char.ToUpper(guess[i])) && word[i] != char.ToUpper(guess[i])) 
                {
                    GuessCorrect = false;
                    MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Partial));
                }

                else if (char.ToUpper(guess[i]) == word[i])
                {
                    MarkedGuess.Add(new KeyValuePair<char, Mark>(guess[i], global::Mark.Right));
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
        public Board(Row rowfromrowclass, string answer)
        {
            Answer = answer;
            ListOfRows.Add(rowfromrowclass);
        }
        public void MarkGuess(string guess)
        {
            if (Guess.Count < 6 && !GuessCorrect)
            {
                Guess.Add(guess);
                GuessCorrect = ListOfRows[Guess.Count - 1].Mark(Answer, guess);
                    
            }
        }

    }
}
