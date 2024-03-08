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
                while (newBoard.TargetNumberOfGoes == false && newBoard.GuessCorrect == false )
                {
                    Row game = new Row();
                    System.Console.Write("Enter guess :\n \n");
                    string guess = System.Console.ReadLine();
                    game.Mark(newBoard.Answer, guess);

                    if (!wordListForGameBoard.GuessExistsInWordList(guess))
                    {
                        System.Console.Write(" not a permitted word or already used \n");
                        System.Console.Write("YOU ARE DISQUALIFIED \n");
                    }

                    else
                    {
                        wordListForGameBoard.RemoveGuessFromWordList(guess);
                    }

                    newBoard.TakeGuess(guess, game);
                    for (int i = 0; i < newBoard.Guess.Count; i++)
                    {
                        System.Console.Write("\n " + newBoard.ListOfRows[i].MarkedGuess[0].Value + " " + newBoard.ListOfRows[i].MarkedGuess[1].Value + " " + newBoard.ListOfRows[i].MarkedGuess[2].Value + " " + newBoard.ListOfRows[i].MarkedGuess[3].Value + " " + newBoard.ListOfRows[i].MarkedGuess[4].Value + " " + newBoard.Guess[i].ToUpper());
                    }

                    System.Console.Write("\n \n \n You have " + (newBoard.NumberOfGoesAllowed - newBoard.ListOfRows.Count) + " goes left \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n");


                }


                System.Console.Write("The correct word was ....." + answer + "... :\n ");
                System.Console.Write("Do you wish to continue? :\n ");
                continueGame = System.Console.ReadLine();
            }

        }
    }
   


}
