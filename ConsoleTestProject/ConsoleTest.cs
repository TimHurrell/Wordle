using System;
using Xunit;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GameBoard;

namespace ConsoleTestProject
{
    public class ConsoleTesting
    {
        readonly List<string> _listofwordsfromwordfile;
        public ConsoleTesting()
        {
            string Filepath = Path.Combine(AppContext.BaseDirectory, "words-english.txt");
            _listofwordsfromwordfile = File.ReadAllLines(Filepath).ToList();
        }

        [Fact]
        public void CheckWordListConstructor()
        {
            WordListGenerator wordlistinstance = new WordListGenerator(_listofwordsfromwordfile, 4);
            Assert.Equal("abut", wordlistinstance.wordList[12]);
        }
    
      


    }
}
