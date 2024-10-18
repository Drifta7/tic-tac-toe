using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public static class UI_Methods
    {
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to The wonderful world of Tic-Tac-Toe");
            Console.WriteLine("Choose X's or O's ");
        } // generic display message


        public static string UserSelectMark() 
        {
            string userInput = Console.ReadLine();// will use this as an argument for playerSelection() method
            return userInput;
        }

        public static void ClearGridForNewInput()
        {
            Console.Clear();
            Console.WriteLine("Please hit Enter To Continue......");
            Console.ReadKey();

        }// clears grid
        public static string DecidePlayerSymbol(string userEntry)
        {
            bool isTheEntryCorrect = false;
            do
            {
                
                int wrongEntry;
                if (int.TryParse(UserSelectMark(), out wrongEntry))
                {
                    Console.WriteLine($"this is worked {UserSelectMark()} has been parsed"); // testing purposes
                    isTheEntryCorrect = true;
                }
                else
                {
                    Console.WriteLine("please enter a valid entry ");
                    UserSelectMark();
                }
            }
            while (!isTheEntryCorrect);
            
            if (userEntry == GameConstants.PLAYERCHOICE_X)
            {
                Console.WriteLine("Player has selected : x");
                Console.WriteLine();
            }

            if (userEntry == GameConstants.PLAYERCHOICE_O)
            {
                Console.WriteLine("player has selected : o ");
                Console.WriteLine();
            }
            else
                Console.WriteLine(" please select a mark");

            return userEntry;
        }

        // this method should be established as when the user has put in their mark
        // and also when the user and the computer switch turns

        public static string switchPlayerTurnAndCpu(string userInput) //rewrite this over and make it make sense 
        {

            bool playerTurnSwitch = false; // put this into a while loop then figure out the logical flow or soemthing
            if (userInput == "x")
            {
                playerTurnSwitch = true;
                Console.WriteLine("It is the Player 2 turn");
            }
            if (userInput != "x")
            {
                playerTurnSwitch = false;
                Console.WriteLine("it is the Computer's turn");
            }

            return userInput;
        }


        //public static bool MakeDescision()// probably will not use this
        //{
        //    Console.WriteLine("do you want to continue with this whatever?");
        //    if (Console.ReadLine() == "y")
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public static int winGameCheck()
        {
            throw new NotImplementedException();
            // this will check if the user or the computer has won
            // if (user or computer )
        }



        //public static void positionChecks(int userInput, int[,] ArrayPos)
        //{
        //    if (userPlay == PlayerPosition.topLeftCorner)
        //    {
        //        ArrayPos[0, 0] = userInput;
        //    }

        //    if (userPlay == PlayerPosition.topMiddleCorner)
        //    {
        //        ArrayPos[0, 1] = userInput;
        //    }
        //    if (userPlay == PlayerPosition.topRightConer)
        //    {
        //        ArrayPos[0, 2] = userInput;
        //    }
        //    if (userplay == PlayerPosition.midLeft)
        //    {
        //        ArrayPos[1, 0] = userInput;
        //    }

        //    if (userplay == PlayerPosition.midCenter)
        //    {
        //        ArrayPos[1, 1] = userInput;
        //    }
        //    if (userPlay == PlayerPosition.midRight)
        //    {
        //        ArrayPos[1, 2] = userInput;
        //    }
        //    if (userplay == PlayerPosition.bottomLeftCorner)
        //    {
        //        ArrayPos[2, 0] = userInput;
        //    }
        //    if (userPlay == PlayerPosition.bottomMiddleCorner)
        //    {
        //        ArrayPos[2, 1] = userInput;
        //    }

    }
}

