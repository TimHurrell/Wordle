using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameBoard
{

    public class Board
    {

        public int NumberOfGoesAllowed;

        public string Answer { get; set; }
        public List<string> Guess { get; set; } = new List<string>();
        public bool GuessCorrect { get; set; } = false;
        public List<Row> ListOfRows { get; set; } = new List<Row>();
        public bool TargetNumberOfGoes { get; set; } = false;

        public Board(string answer, int numberOfGoesAllowed)
        {
            Answer = answer;
            NumberOfGoesAllowed = numberOfGoesAllowed;
        }

        public void TakeGuess(string guess, Row row)
        {
            if (!GuessCorrect)
            {
                if (!TargetNumberOfGoes)
                {
                    Guess.Add(guess);
                    ListOfRows.Add(row);
                    GuessCorrect = row.GuessCorrect;
                    TargetNumberOfGoes = ListOfRows.Count == NumberOfGoesAllowed;
                }
            }
        }


        //you're already marking on the row class, no need to do it again on the board class
        //just have a bool property on the row which says correct or not
        /* 
         * public void AssessGuess()
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
        */
    }
}
