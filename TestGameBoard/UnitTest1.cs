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
            _row.Mark("PILOT", "ZZZZZ");

            Assert.Equal(Mark.Wrong, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[4].Value);
            Assert.False(_row.Correct);
        }


        [Fact]
        public void MarkRowRightLetterWrongAndRightPosition()
        {
            Row _row = new Row();
            _row.Mark("PILOT", "TAAAT");

            Assert.Equal(Mark.Partial, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Wrong, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[4].Value);
            Assert.False(_row.Correct);
        }


        [Fact]
        public void MarkRowAllCorrectBarOne()
        {
            Row _row = new Row();
            _row.Mark("PILOT", "PILOO");

            Assert.Equal(Mark.Right, _row.MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _row.MarkedGuess[3].Value);
            Assert.Equal(Mark.Partial, _row.MarkedGuess[4].Value);
            Assert.False(_row.Correct);
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
            Assert.True(_row.Correct);
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
            Assert.True(_row.Correct);
        }

    }
}



//