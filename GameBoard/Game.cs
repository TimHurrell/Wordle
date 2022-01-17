using System;

namespace GameBoard
{
    public class Board
    {
        public bool Correct { get; set; } = true;
        public string WordAnswer { get; set; }
        public char[] Row = new char[5];
        public int[] Guess = new int[5];
        
        public Board (string word)
        {
            Row[0] = word[0];
            Row[1] = word[1];
            Row[2] = word[2];
            Row[3] = word[3];
            Row[4] = word[4];
            WordAnswer = word;
        }

        public void Mark(string word)
        {
            for (int i = 0; i < 5; i++)
            {
                if (WordAnswer.Contains(word[i]) && word[i] != Row[i] ) 
                { 
                  Guess[i] = 1;
                  Correct = false;
                }

                else if (word[i] == Row[i])
                { 
                    Guess[i] = 2;              
                }


                else
                {
                    Correct = false;
                    Guess[i] = 0;             
                }


            }

        }

    }
}
