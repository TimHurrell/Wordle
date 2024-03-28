﻿using GameBoard;
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

                WordFilePath wordsfilepathinstance = new WordFilePath();
                CreateWordListFromFile createwordlistfromfileinstance = new CreateWordListFromFile(); 
                List<string> wordlistinstance = createwordlistfromfileinstance.CreateWordList(wordsfilepathinstance.GetWordFilePath()); 
                WordListGenerator wordListForGameBoard = new WordListGenerator(wordlistinstance, 5); // Create another list with this list of words (why?)
                Board newBoard = new Board(wordListForGameBoard.answer, 5); // create a game board which contains the answer and the number of attempts permitted
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
                        System.Console.Write("\n " + newBoard.ListOfRows[i].MarkedGuess[0].Value + " " + newBoard.ListOfRows[i].MarkedGuess[1].Value + " " + newBoard.ListOfRows[i].MarkedGuess[2].Value + " " + newBoard.ListOfRows[i].MarkedGuess[3].Value + " " + newBoard.ListOfRows[i].MarkedGuess[4].Value + " " + newBoard.Guess[i].ToUpper());
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

/*
1) Put the enums in their own file DONE

2) Rename the file Game.cs to the Row.cs so it matches the class name DONE


3) public List<KeyValuePair<char, Mark>> MarkedGuess { get; set; }
the set can be made private as you will not be modifying this externally. This improves encapsulation DONE

4) Change List<KeyValuePair<char, Mark>> to IList<KeyValuePair<char, Mark>> in order to make the reference as general as possible.
This is good practive and makes your code more flexible. DONE



5) public bool GuessCorrect { get; set; } = true;
Not ideal to default to true. If there is a bug somewhere in your code then its going to fail so that the guess is correct.
Again the setter is public. It should be private for better encapsulation.
Also GuessCorrect could actually be calculated rather than a set property which would be neater. DONE



On public class Board

public List<string> Guess { get; set; } = new List<string>();
should be public IList<string> Guess { get; set; } = new List<string>();
As above
See Liskov substitution principle DONE


You have lots of properities with public setters.This means if someone was using your code they could set this properities externally which could cause it the fail in unexpected ways. You should hide as much logic as you possible can.

Also these properities could calculate themselves rather than be set by some other peice of logic. This would make them easier to test which would be a good thing.


Tidying.

Get rid of all superfluous comments, white space and unused usings. Make your code look neat.
If you need those comments they will be accessible in the git history.

*/
