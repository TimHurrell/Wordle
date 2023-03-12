using GameBoard;
using System.Collections.Generic;
using Xunit;

namespace TestGameBoard
{
    public class BoardTest
    {









        [Fact]
        public void GameBoardFirstRowIncorrectSecondRowCorrect()
        {
            Row _row1 = new Row();
            Board _board = new Board("PILOT",5);
            string guess = "FILES";
            _row1.Mark(guess, _board.Answer);


            _board.TakeGuess(guess, _row1);

            Assert.Single(_board.ListOfRows);
            //_board.ListOfRows[0].Mark(_board.Answer, guess);

            /*
            Assert.Equal(Mark.Wrong, _board.ListOfRows[0].MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[0].MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[0].MarkedGuess[2].Value);
            Assert.Equal(Mark.Wrong, _board.ListOfRows[0].MarkedGuess[3].Value);
            Assert.Equal(Mark.Wrong, _board.ListOfRows[0].MarkedGuess[4].Value);
            */

            Assert.False(_board.GuessCorrect);



            Row _row2 = new Row();
            guess = "PILOT";
            _row2.Mark(guess, _board.Answer);
            _board.TakeGuess(guess, _row2);
            Assert.Equal(2, _board.ListOfRows.Count);


/*
            Assert.Equal(Mark.Right, _board.ListOfRows[1].MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[1].MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[1].MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[1].MarkedGuess[3].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[1].MarkedGuess[4].Value);
*/

            Assert.True(_board.GuessCorrect);


        }

        [Fact]
        public void TooManyGoesOnlyAllowedOneGo()
        {
            Row _row1 = new Row();
            Board _board = new Board("PILOT",1);
            string guess = "FILES";
            _row1.Mark(guess, _board.Answer);
            _board.TakeGuess(guess, _row1);

            Assert.Single(_board.ListOfRows);
            //_board.ListOfRows[0].Mark(_board.Answer, guess);


            Row _row2 = new Row();
            guess = "PILOT";
            _row2.Mark(guess, _board.Answer);
            _board.TakeGuess(guess, _row2);

            Assert.True(_board.ExceededNumberOfGoes);
        }

        [Fact]
        public void OnlyAllowedTwoGoesOK()
        {
            Row _row1 = new Row();
            Board _board = new Board("PILOT", 2);
            string guess = "FILES";


            _board.TakeGuess(guess, _row1);

            Assert.Single(_board.ListOfRows);
            //_board.ListOfRows[0].Mark(_board.Answer, guess);



            Row _row2 = new Row();
            _board.TakeGuess("PILOT", _row2);

            Assert.False(_board.ExceededNumberOfGoes);

        }

 






    }

}



//