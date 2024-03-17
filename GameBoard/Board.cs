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
        public IList<string> Guess { get; set; } = new List<string>();
        public bool GuessCorrect { get; set; } = false;
        public IList<Row> ListOfRows { get; set; } = new List<Row>();
        public bool TargetNumberOfGoes
        {
            get => ListOfRows.Count == NumberOfGoesAllowed; private set { }
        }


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
                }
            }
        }

    }
}
