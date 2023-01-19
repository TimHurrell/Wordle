using GameBoard;
using Xunit;

namespace TestGameBoard
{
    public class UnitTest1
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
            //Assert.False(test);
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
            //Assert.True(test);
        }


        [Fact]
        public void GameBoardFirstRowIncorrectSecondRowCorrect()
        {
            Row _row1 = new Row();
            Board _board = new Board("PILOT",5);
            string guess = "FILES";
            

           _board.TakeGuess(guess, _row1);

            Assert.Single(_board.Guess);
            _board.ListOfRows[0].Mark(_board.Answer, guess);


            Assert.Equal(Mark.Wrong, _board.ListOfRows[0].MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[0].MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[0].MarkedGuess[2].Value);
            Assert.Equal(Mark.Wrong, _board.ListOfRows[0].MarkedGuess[3].Value);
            Assert.Equal(Mark.Wrong, _board.ListOfRows[0].MarkedGuess[4].Value);

            _board.AssessGuess();
            bool test1 = _board.GuessCorrect;
            Assert.False(test1);



            Row _row2 = new Row();
            _board.TakeGuess("PILOT", _row2);
            _board.ListOfRows[1].Mark("PILOT", "PILOT");
            Assert.Equal(2, _board.Guess.Count);



            Assert.Equal(Mark.Right, _board.ListOfRows[1].MarkedGuess[0].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[1].MarkedGuess[1].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[1].MarkedGuess[2].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[1].MarkedGuess[3].Value);
            Assert.Equal(Mark.Right, _board.ListOfRows[1].MarkedGuess[4].Value);

            _board.AssessGuess();
            bool test2 = _board.GuessCorrect;
            Assert.True(test2);
            
        }

        [Fact]
        public void TooManyGoesOnlyAllowedOneGo()
        {
            Row _row1 = new Row();
            Board _board = new Board("PILOT",1);
            string guess = "FILES";


            _board.TakeGuess(guess, _row1);

            Assert.Single(_board.Guess);
            _board.ListOfRows[0].Mark(_board.Answer, guess);



            Row _row2 = new Row();
            _board.TakeGuess("PILOT", _row2);

            Assert.True(_board.ExceededNumberOfGoes);

        }

        [Fact]
        public void OnlyAllowedTwoGoes()
        {
            Row _row1 = new Row();
            Board _board = new Board("PILOT", 2);
            string guess = "FILES";


            _board.TakeGuess(guess, _row1);

            Assert.Single(_board.Guess);
            _board.ListOfRows[0].Mark(_board.Answer, guess);



            Row _row2 = new Row();
            _board.TakeGuess("PILOT", _row2);

            Assert.False(_board.ExceededNumberOfGoes);

        }

    }

}



//