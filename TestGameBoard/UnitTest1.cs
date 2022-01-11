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

            Board TestBoard = new Board();
            TestBoard.row[0] = 'a';
            TestBoard.row[1] = 'b';
            TestBoard.row[2] = 'b';
            TestBoard.row[3] = 'e';
            TestBoard.row[4] = 'y';
            Assert.Equal('e', TestBoard.row[3]);

        }
    }
}
