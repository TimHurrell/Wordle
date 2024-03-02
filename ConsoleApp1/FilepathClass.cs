
using System;
using System.IO;


namespace ConsoleApp
{

    public class WordFilePath
    {

        public string GetWordFilePath()
        {
            string filename = "words-english.txt";
            string filepath = Path.Combine(AppContext.BaseDirectory, filename);
            return filepath;
        }
    }



    

}
