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
            WordGenerator _word = new WordGenerator(wordList, 5);
            _word.RemoveWrongLength();



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
            WordGenerator _word = new WordGenerator(wordList, 5);
            _word.RemoveWrongLength();



            Assert.Equal("PILOTS", _word.wordList[0]);
            Assert.Equal("PILOTZ", _word.wordList[1]);

        }

    }

}



//