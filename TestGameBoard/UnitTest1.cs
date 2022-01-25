using GameBoard;
using System;
using Xunit;

namespace TestGameBoard
{
    public class UnitTest1
    {



        [Fact]
        public void MarkRowAllWrong()
        {
            Row _row = new Row();
            bool test = _row.Mark("PILOT", "ZZZZZ");

            Assert.Equal(Mark.Wrong, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[4].Value);
            Assert.False(test);
        }


        [Fact]
        public void MarkRowRightLetterWrongAndRightPosition()
        {
            Row _row = new Row();
            bool test = _row.Mark("PILOT", "TAAAT");

            Assert.Equal(Mark.Partial, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[4].Value);
            Assert.False(test);
        }


        [Fact]
        public void MarkRowAllCorrectBarOne()
        {
            Row _row = new Row();
            bool test = _row.Mark("PILOT", "PILOO");

            Assert.Equal(Mark.Right, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Partial, _row.MarkedGuess[4].Value);
            Assert.False(test);
        }


        [Fact]
        public void MarkRowAllCorrectBarOneLowerCase()
        {
            Row _row = new Row();
            bool test = _row.Mark("PILOT", "PILOt");

            Assert.Equal(Mark.Right, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[4].Value);
            Assert.True(test);
        }


        [Fact]
        public void MarkRowAllCorrect()
        {
            Row _row = new Row();
            bool test = _row.Mark("PILOT", "PILOT");


            Assert.Equal(Mark.Right, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[4].Value);
            Assert.True(test);
        }


        [Fact]
        public void GameBoardSecondRowCorrect()
        {
            Board _board = new Board();
            _board.Guess.Add("XXXXX");
            _board.Guess.Add("PILOT");
            _board.Answer = "PILOT";
            Row _row = new Row();
            bool test = _row.Mark(_board.Answer, _board.Guess[1]);


            Assert.True(test);
        }

    }

}



//