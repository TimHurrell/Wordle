using System.Collections.Generic;
using System.Linq;

namespace GameBoard
{

    public class Board
    {

        public int NumberOfGoesAllowed;

        public string Answer { get; set; }
        public IList<string> Guess { get; set; } = new List<string>();
        //public bool GuessCorrect { get; set; } = false;
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

    public bool IsWon()
        {
            var lastRow = ListOfRows.LastOrDefault();

            return lastRow != null ? lastRow.GuessCorrect() : false;

        }


        public void TakeGuess(string guess, Row row)
        {
            if (!IsWon())
            {
                if (!TargetNumberOfGoes)
                {
                    Guess.Add(guess);
                    ListOfRows.Add(row);
                }
            }
        }

    }
}
