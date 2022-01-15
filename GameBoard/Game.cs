using System;

namespace GameBoard
{
    public class Board
    {
        public bool Correct { get; set; } = true;
        public char[] Row = new char[5];
        public bool[] Guess = new bool[5];
        
        public Board (string word)
        {
            Row[0] = word[0];
            Row[1] = word[1];
            Row[2] = word[2];
            Row[3] = word[3];
            Row[4] = word[4];
        }

        public void Mark(string word)
        {
            for (int i = 0; i < 5; i++)
            {
                Guess[i] = word[0] == Row[0] ? Guess[i] = true : false;
                if (word[0] != Row[0])
                { Correct = false; }

            }

        }

    }
}
