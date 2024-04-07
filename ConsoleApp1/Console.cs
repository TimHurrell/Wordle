using GameBoard;
using System.Collections.Generic;


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
                WordFilePath wordsfilepathinstance = new WordFilePath();
                CreateWordListFromFile createwordlistfromfileinstance = new CreateWordListFromFile(); 
                List<string> wordlistinstance = createwordlistfromfileinstance.CreateWordList(wordsfilepathinstance.GetWordFilePath()); 
                WordListGenerator wordListForGameBoard = new WordListGenerator(wordlistinstance, 5); // Create another list with this list of words (why?)
                Board newBoard = new Board(wordListForGameBoard.answer, 10); // create a game board which contains the answer and the number of attempts permitted
                while (newBoard.TargetNumberOfGoes == false && newBoard.IsWon() == false )
                {
                    Row _row = new Row();
                    System.Console.Write("Enter guess :\n \n");
                    string guess = System.Console.ReadLine();


                    _row.Mark(newBoard.Answer, guess);

                    if (!wordListForGameBoard.GuessExistsInWordList(guess))
                    {
                        System.Console.Write(" not a permitted word or already used \n");
                        System.Console.Write("YOU ARE DISQUALIFIED \n");
                    }

                    else
                    {
                        wordListForGameBoard.RemoveGuessFromWordList(guess);
                    }

                    newBoard.TakeGuess(guess, _row);
                    for (int i = 0; i < newBoard.Guess.Count; i++)
                    {
                        System.Console.Write("\n " + newBoard.ListOfRows[i].MarkedGuess[0].Value + " " + newBoard.ListOfRows[i].MarkedGuess[1].Value + " " + newBoard.ListOfRows[i].MarkedGuess[2].Value + " " + newBoard.ListOfRows[i].MarkedGuess[3].Value + " " + newBoard.ListOfRows[i].MarkedGuess[4].Value);
                        System.Console.Write("\n " + newBoard.Guess[i][0] + "     " + newBoard.Guess[i][1] + "     " + newBoard.Guess[i][2] + "     " + newBoard.Guess[i][3] + "     " + newBoard.Guess[i][4] + "\n ");
                    }

                    System.Console.Write("\n \n \n You have " + (newBoard.NumberOfGoesAllowed - newBoard.ListOfRows.Count) + " goes left \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n");


                }


                System.Console.Write("The correct word was ....." + wordListForGameBoard.answer + "... :\n ");
                System.Console.Write("Do you wish to continue? :\n ");
                continueGame = System.Console.ReadLine();
            }

        }
    }
   


}
