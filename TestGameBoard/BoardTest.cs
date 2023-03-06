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
            Assert.Contains("FILES", _board.Guess[0]);



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
        public void OnlyAllowedTwoGoesOK()
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


        [Fact]
        public void OnlyAllowedTwoGoesChoicesSame()
        {
            Row _row1 = new Row();
            Board _board = new Board("PILOT", 2);
            string guess1 = "FILES";


            _board.TakeGuess(guess1, _row1);



            Row _row2 = new Row();
            string guess2 = "FILES";

            Assert.True(_board.SameAsPreviousGo(guess2));

        }

        [Fact]
        public void OnlyAllowedTwoGoesChoicesDifferent()
        {
            Row _row1 = new Row();
            Board _board = new Board("PILOT", 2);
            string guess1 = "FILES";



            _board.TakeGuess(guess1, _row1);
            Assert.Contains("FILES", _board.Guess[0]);


            Row _row2 = new Row();
            string guess2 = "PILOT";

            Assert.False(_board.SameAsPreviousGo(guess2));

        }
        [Fact]
        public void OnlyAllowedFourGoesChoicesDifferent()
        {
            Row _row1 = new Row();
            Board _board = new Board("PILOT", 2);
            string guess = "FILES";



            _board.TakeGuess(guess, _row1);



            Row _row2 = new Row();
            guess = "PILET";
            _board.TakeGuess(guess, _row2);

            Row _row3 = new Row();
            guess = "PILEE";
            _board.TakeGuess(guess, _row3);

            Row _row4 = new Row();
            guess = "PIEET";
 

            Assert.False(_board.SameAsPreviousGo(guess));

        }

        [Fact]
        public void OnlyAllowedFourGoesChoicesSame()
        {
            Row _row1 = new Row();
            Board _board = new Board("PILOT", 2);
            string guess = "FILES";



            _board.TakeGuess(guess, _row1);



            Row _row2 = new Row();
            guess = "PILET";
            _board.TakeGuess(guess, _row2);

            Row _row3 = new Row();
            guess = "PILEE";
            _board.TakeGuess(guess, _row3);

            Row _row4 = new Row();
            guess = "PILET";


            Assert.True(_board.SameAsPreviousGo(guess));

        }






    }

}



//