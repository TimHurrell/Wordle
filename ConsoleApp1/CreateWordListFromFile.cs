using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ConsoleApp
{
    public class CreateWordListFromFile
    {


        public List<string> CreateWordList (String filepath)
        {
            List<string> _listofwordsfromwordfile;
            _listofwordsfromwordfile = File.ReadAllLines(filepath).ToList();
            return _listofwordsfromwordfile;
        }
    }
}
