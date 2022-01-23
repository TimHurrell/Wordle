using GameBoard;
using System;
using Xunit;

namespace TestGameBoard
{
    public class UnitTest1
    {


        //[Fact]
        //public void MarkRowAllWrong()
        //{
        //    //using a constructor to create a Row object with a string of the answer we are looking for
        //    //Row row = new Row("PILOT");
        //    Board TestBoard = new Board("PILOT");

        //    //Mark is the method which contains our logic with the parameter of our guess
        //    TestBoard.Mark("AAAAA");

        //    //Assert that a particular letter has been marked
        //    Assert.Equal(0, TestBoard.Guess[0]);
        //    Assert.Equal(0, TestBoard.Guess[1]);
        //    Assert.Equal(0, TestBoard.Guess[2]);
        //    Assert.Equal(0, TestBoard.Guess[3]);
        //    Assert.Equal(0, TestBoard.Guess[4]);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[1].Value);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[2].Value);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[3].Value);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[4].Value);

        //    //check if the row is correct or not
        //    Assert.False(TestBoard.Correct);
        //}


        //[Fact]
        //public void MarkRowWrongPlace()
        //{
        //    //using a constructor to create a Row object with a string of the answer we are looking for
        //    //Row row = new Row("PILOT");
        //    Board TestBoard = new Board("PILOT");

        //    //Mark is the method which contains our logic with the parameter of our guess
        //    TestBoard.Mark("TPILO");

        //    //Assert that a particular letter has been marked
        //    Assert.Equal(1, TestBoard.Guess[0]);
        //    Assert.Equal(1, TestBoard.Guess[1]);
        //    Assert.Equal(1, TestBoard.Guess[2]);
        //    Assert.Equal(1, TestBoard.Guess[3]);
        //    Assert.Equal(1, TestBoard.Guess[4]);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[1].Value);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[2].Value);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[3].Value);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[4].Value);

        //    //check if the row is correct or not
        //    Assert.False(TestBoard.Correct);
        //}


        //[Fact]
        //public void MarkRowAllCorrect()
        //{
        //    //using a constructor to create a Row object with a string of the answer we are looking for
        //    //Row row = new Row("PILOT");
        //    Board TestBoard = new Board("PILOT");

        //    //Mark is the method which contains our logic with the parameter of our guess
        //    TestBoard.Mark("PILOT");

        //    //Assert that a particular letter has been marked
        //    Assert.Equal(2, TestBoard.Guess[0]);
        //    Assert.Equal(2, TestBoard.Guess[1]);
        //    Assert.Equal(2, TestBoard.Guess[2]);
        //    Assert.Equal(2, TestBoard.Guess[3]);
        //    Assert.Equal(2, TestBoard.Guess[4]);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[1].Value);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[2].Value);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[3].Value);
        //    //Assert.Equal(Mark.Wrong, row.MarkedGuess[4].Value);

        //    //check if the row is correct or not
        //    Assert.True(TestBoard.Correct);

        //}


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

        // MarkedGuess is a List<KeyValuePair<char, Mark>> or in plain words a list of key value pairs of char and the enum Mark.

    }
}



//