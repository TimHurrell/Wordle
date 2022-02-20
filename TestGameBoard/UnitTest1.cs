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
            bool test = _row.Mark("PILOT", "AHEAD");

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
            bool test = _row.Mark("PILOT", "TIMER");

            Assert.Equal(Mark.Partial, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[4].Value);
            Assert.False(test);
        }


        [Fact]
        public void MarkRowAllCorrectBarOne()
        {
            Row _row = new Row();
            bool test = _row.Mark("FILES", "Filed");

            Assert.Equal(Mark.Right, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[4].Value);
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
        public void GameBoardFirstRowIncorrectSecondRowCorrect()
        {
            Row _row = new Row();
            Board _board = new Board(_row, "PILOT");

            _board.MarkGuess("FILES");
            bool test1 = _board.GuessCorrect;
            Assert.False(test1);

            Assert.Equal(Mark.Wrong, _board.ListOfRows[0].MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[0].MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[0].MarkedGuess[2].Value);
            Assert.Equal(Mark.Wrong, _board.ListOfRows[0].MarkedGuess[3].Value);
            Assert.Equal(Mark.Wrong, _board.ListOfRows[0].MarkedGuess[4].Value);

            //_board.MarkGuess("PILOT");
            //bool test2 = _board.GuessCorrect;




            //Assert.Equal(Mark.Right, _board.Row.MarkedGuess[0].Value);
            //Assert.Equal(Mark.Right, _board.Row.MarkedGuess[1].Value);
            //Assert.Equal(Mark.Right, _board.Row.MarkedGuess[2].Value);
            //Assert.Equal(Mark.Right, _board.Row.MarkedGuess[3].Value);
            //Assert.Equal(Mark.Right, _board.Row.MarkedGuess[4].Value);
            // Assert.True(test2);
            //Assert.Equal(2, _board.Guess.Count);
        }

    }

}



//