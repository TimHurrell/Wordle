using GameBoard;
using System.Collections.Generic;
using Xunit;

namespace TestGameBoard
{
    public class RowTest
    {



        [Fact]
        public void MarkRowAllWrong()
        {
            Row _row = new Row();
            //bool test = _row.Mark("PILOT", "AHEAD");
            _row.Mark("PILOT", "AHEAD");

            Assert.Equal(Mark.Wrong, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[4].Value);
            //Assert.False(GuessCorrect(_row));
        }


        [Fact]
        public void MarkRowRightLetterWrongAndRightPosition()
        {
            Row _row = new Row();
            _row.Mark("PILOT", "TIMER");

            Assert.Equal(Mark.Partial, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[4].Value);

        }


        [Fact]
        public void MarkRowAllCorrectBarOne()
        {
            Row _row = new Row();
            _row.Mark("FILES", "Filed");

            Assert.Equal(Mark.Right, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[4].Value);
            Assert.False(_row.GuessCorrect);
        }


        [Fact]
        public void MarkRowAllCorrectBarOneLowerCase()
        {
            Row _row = new Row();
            _row.Mark("PILOT", "PILOt");

            Assert.Equal(Mark.Right, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[4].Value);
            Assert.True(_row.GuessCorrect);
            //Assert.True(test);
        }


        [Fact]
        public void MarkRowAllCorrect()
        {
            Row _row = new Row();
            _row.Mark("PILOT", "PILOT");


            Assert.Equal(Mark.Right, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[4].Value);
            Assert.True(_row.GuessCorrect);
            //Assert.True(test);
        }



        [Fact]
        public void MarkRowAllCorrectLowerCase()
        {
            Row _row = new Row();
            _row.Mark("pilot", "PILOT");


            Assert.Equal(Mark.Right, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[4].Value);
            Assert.True(_row.GuessCorrect);
            //Assert.True(test);
        }



    }

}



//