using GameBoard;
using System;
using Xunit;

namespace TestGameBoard
{
    public class UnitTest1
    {
        [Fact]
        public void TestWordingOnGameBoard()
        {

            //Board TestBoard = new Board();
            //TestBoard.row[0] = 'a';
            //TestBoard.row[1] = 'b';
            //TestBoard.row[2] = 'b';
            //TestBoard.row[3] = 'e';
            //TestBoard.row[4] = 'y';
            //Assert.Equal('e', TestBoard.row[3]);

        }

        [Fact]
        public void MarkRowAllWrong()
        {
            //using a constructor to create a Row object with a string of the answer we are looking for
            //Row row = new Row("PILOT");
            Board TestBoard = new Board("PILOT");

            //Mark is the method which contains our logic with the parameter of our guess
            TestBoard.Mark("AAAAA");

            //Assert that a particular letter has been marked
            Assert.False(TestBoard.Guess[0]);
            Assert.False(TestBoard.Guess[1]);
            Assert.False(TestBoard.Guess[2]);
            Assert.False(TestBoard.Guess[3]);
            Assert.False(TestBoard.Guess[4]);
            //Assert.Equal(Mark.Wrong, row.MarkedGuess[1].Value);
            //Assert.Equal(Mark.Wrong, row.MarkedGuess[2].Value);
            //Assert.Equal(Mark.Wrong, row.MarkedGuess[3].Value);
            //Assert.Equal(Mark.Wrong, row.MarkedGuess[4].Value);

            //check if the row is correct or not
            Assert.False(TestBoard.Correct);
        }

    }
}
