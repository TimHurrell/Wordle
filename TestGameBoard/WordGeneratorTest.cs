using GameBoard;
using System.Collections.Generic;
using Xunit;

namespace TestGameBoard
{
    public class WordGeneratorTest
    {


       




        [Fact]
        public void FiveLetterWordFromList()
        {
            List<string> wordList = new List<string>()
                    {
                        "PILOT",
                        "PILOTS"
                    };
            GameBoard.WordGenerator _word = new GameBoard.WordGenerator(wordList, 5);



            Assert.Equal(_word.lengthOfWordAllowed, _word.answer.Length);
            Assert.Equal("PILOT", _word.answer);

        }


        [Fact]
        public void ListContainsOnlyFiveLetterWords()
        {
            List<string> wordList = new List<string>()
                    {
                        "PILOT",
                        "PILOTS",
                        "PILOZ",
                        "PILOTZ"
                    };
            GameBoard.WordGenerator _word = new GameBoard.WordGenerator(wordList, 5);
            _word.RemoveWrongLength();



            Assert.Equal("PILOTS", _word.wordList[0]);
            Assert.Equal("PILOTZ", _word.wordList[1]);

        }

    }

}



//