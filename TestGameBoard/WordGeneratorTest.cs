using GameBoard;
using System.Collections.Generic;
using Xunit;

namespace TestGameBoard
{
    public class WordGeneratorTest
    {


       




        [Fact]
        public void FiveLetterWordFromListOnlyOneMember()
        {
            List<string> wordList = new List<string>()
                    {
                        "PILOT",
                        "PILOTS"
                    };
            WordGenerator _word = new WordGenerator(wordList, 5);
            _word.RemoveWrongLength();



           Assert.Single(_word.wordList);
        //    Assert.Equal("PILOT", _word.answer);

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



            Assert.Equal("PILOT", _word.wordList[0]);
            Assert.Equal("PILOZ", _word.wordList[1]);

        }

    }

}



//