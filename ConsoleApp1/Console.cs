using GameBoard;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp
{
    class Console
    {
        static void Main()
        {
            Console console = new Console();
            string continueGame = "y";
            while (continueGame == "y")
            {
                // creating list of words from the word text file

                WordFilePath wordsfilepathinstance = new WordFilePath(); // create string to read the source file
                CreateWordListFromFile createwordlistfromfileinstance = new CreateWordListFromFile(); // create instance of word list
                List<string> wordlistinstance = createwordlistfromfileinstance.CreateWordList(wordsfilepathinstance.GetWordFilePath()); // populate word list with file
                WordListGenerator wordListForGameBoard = new WordListGenerator(wordlistinstance, 5); // Create another list with this list of words (why?)
                wordListForGameBoard.RemoveWrongLength(); // remove any words that contain a number of letters other than the line above
                string answer = wordListForGameBoard.SelectAnswer(); // select an answer from the remaining words in the list
                Board newBoard = new Board(answer, 5); // create a game board which contains the answer and the number of attempts permitted
                while (newBoard.ExceededNumberOfGoes == false && newBoard.GuessCorrect == false )
                {
                    System.Console.Write("Answer is :\n " + newBoard.Answer + "\n");
                    Row game = new Row();
                    System.Console.Write("Enter guess :\n ");
                    string guess = System.Console.ReadLine();
                    game.Mark(newBoard.Answer, guess);
                    
                    System.Console.Write("1st letter is :\n " + game.MarkedGuess[0].Value + "\n");
                    System.Console.Write("2nd letter is :\n " + game.MarkedGuess[1].Value + "\n");
                    System.Console.Write("3rd letter is :\n " + game.MarkedGuess[2].Value + "\n");
                    System.Console.Write("4th letter is :\n " + game.MarkedGuess[3].Value + "\n");
                    System.Console.Write("5th letter is :\n " + game.MarkedGuess[4].Value + "\n");

                    newBoard.TakeGuess(guess, game);
                    System.Console.Write("Guess is :\n " + guess + "\n");
                    System.Console.Write("Result is :\n " + newBoard.GuessCorrect + "\n");
                    System.Console.Write("You have " + newBoard.ListOfRows.Count + "goes left \n");


                }



                
                continueGame = System.Console.ReadLine();
            }

        }
    }
   


}
