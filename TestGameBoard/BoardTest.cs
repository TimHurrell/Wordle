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
            
            Assert.False(_board.IsWon());



            Row _row2 = new Row();
            guess = "PILOT";
            _row2.Mark(guess, _board.Answer);
            _board.TakeGuess(guess, _row2);
            Assert.Equal(2, _board.ListOfRows.Count);


            Assert.True(_board.IsWon());


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


            Row _row2 = new Row();
            guess = "LEAVE";
            _row2.Mark(guess, _board.Answer);
            _board.TakeGuess(guess, _row2);

            Assert.True(_board.TargetNumberOfGoes);
        }

        [Fact]
        public void OnlyAllowedTwoGoesOK()
        {
            Row _row1 = new Row();
            Board _board = new Board("GREAT", 2);
            string guess = "FILES";
            _row1.Mark(guess, _board.Answer);


            _board.TakeGuess(guess, _row1);

            Assert.Single(_board.ListOfRows);
            //_board.ListOfRows[0].Mark(_board.Answer, guess);


            Row _row2 = new Row();
            guess = "PILOT";
            _row2.Mark(guess, _board.Answer);
            _board.TakeGuess(guess, _row2);

            Assert.True(_board.TargetNumberOfGoes);



            Row _row3 = new Row();
            guess = "LEAVE";
            _row3.Mark(guess, _board.Answer);
            _board.TakeGuess(guess, _row3);

            Assert.True(_board.TargetNumberOfGoes);


        }

        [Fact]
        public void ReachedTwoGoesOK()
        {
            Row _row1 = new Row();
            Board _board = new Board("GREAT", 2);
            string guess = "FILES";
            _row1.Mark(guess, _board.Answer);


            _board.TakeGuess(guess, _row1);

            Assert.False(_board.TargetNumberOfGoes);
            //_board.ListOfRows[0].Mark(_board.Answer, guess);



            Row _row2 = new Row();
            guess = "PILOT";
            _row2.Mark(guess, _board.Answer);
            _board.TakeGuess(guess, _row2);

            Assert.True(_board.TargetNumberOfGoes);

        }


    }

}

