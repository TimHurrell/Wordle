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
                        "pilot",
                        "PILOTS"
                    };
            WordListGenerator _word = new WordListGenerator(wordList, 5);
            Assert.Single(_word.wordList);     

        }


        [Fact]
        public void ListContainsOnlyFiveLetterWords()
        {
            List<string> wordList = new List<string>()
                    {
                        "pilot",
                        "PILOTS",
                        "piloz",
                        "PILOTZ"
                    };
            WordListGenerator _word = new WordListGenerator(wordList, 5);

            Assert.Equal("pilot", _word.wordList[0]);
            Assert.Equal("piloz", _word.wordList[1]);
            Assert.Equal(2, _word.wordList.Count);

        }

        [Fact]
        public void ListExcludesProperNouns()
        {
            List<string> wordList = new List<string>()
                    {
                        "Jimmy",
                        "Roger",
                        "pilot",
                        "learn"
                    };
            WordListGenerator _word = new WordListGenerator(wordList, 5);

            Assert.Equal("pilot", _word.wordList[0]);
            Assert.Equal("learn", _word.wordList[1]);
            Assert.Equal(2, _word.wordList.Count);

        }


        [Fact]
        public void AnswerIsOneFromList()
        {
            List<string> wordList = new List<string>()
                    {
                        "pilot",
                        "spill",
                        "trims",
                        "lapel"
                    };
            WordListGenerator _word = new WordListGenerator(wordList, 5);
            Assert.Contains(wordList, w => _word.answer.Contains(w));

        }

        [Fact]
        public void GuessExistsInList()
        {
            List<string> wordList = new List<string>()
                    {
                        "pilot",
                        "spill",
                        "trims",
                        "lapel"
                    };
            WordListGenerator _word = new WordListGenerator(wordList, 5);
            string guess = "pilot";
            Assert.True(_word.GuessExistsInWordList(guess));
            guess = "pilos";
            Assert.False(_word.GuessExistsInWordList(guess));

        }
        [Fact]
        public void RemovedGuessFromList()
        {
            List<string> wordList = new List<string>()
                    {
                        "pilot",
                        "spill",
                        "trims",
                        "lapel"
                    };
            WordListGenerator _word = new WordListGenerator(wordList, 5);
            string guess = "pilot";
            _word.RemoveGuessFromWordList(guess);


            Assert.False(_word.GuessExistsInWordList(guess));
            guess = "spill";
            Assert.True(_word.GuessExistsInWordList(guess));

        }

    }

}
