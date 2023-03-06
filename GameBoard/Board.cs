using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameBoard
{

    public class Board
    {
        public bool ExceededNumberOfGoes { get; set; } = false;

        public int NumberOfGoesAllowed;

        public string Answer { get; set; }
        public List<string> Guess { get; set; } = new List<string>();
        public bool GuessCorrect { get; set; } = false;
        public List<Row> ListOfRows { get; set; } = new List<Row>();


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
}
