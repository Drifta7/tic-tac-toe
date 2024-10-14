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

        public static string userInput = Console.ReadLine();// will use this as an argument for playerSelection() method

        public static void clearGridForNewInput()
        {
            Console.Clear();
            Console.ReadKey();

            Console.WriteLine("Please hit Enter To Continue......");
        }
        public static string playerSelection(string userEntry)
        {
            string playerChoice_X = "x";
            string playerChoice_O = "o";

            if (userEntry == playerChoice_X)
            {
                Console.WriteLine("Player has selected : x");
                Console.WriteLine();
            }

            if (userEntry == playerChoice_O)
            {
                Console.WriteLine("player has selected : o ");
            }
            else
                Console.WriteLine(" please select a mark");

            return userEntry;
        }
        // this method should be established as when the user has put in their mark
        // and also when the user and the computer switch turns
        public static string switchPlayerTurnAndCpu(string userInput)
        {
            userInput = Console.ReadLine(); // 
            bool playerTurnSwitch = false;
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



        public static void positionChecks(int userInput, int[,] ArrayPos)
        {
            if (userPlay == Enums.playerPostion.topLeftCorner)
            {
                ArrayPos[0,0] = userInput;
            }

            if (userPlay == Enums.playerPostion.topMiddleCorner)
            {
                ArrayPos[0, 1] = userInput;
            }
            if (userPlay == Enums.playerPostion.topRightConer)
            {
                ArrayPos[0, 2] = userInput;
            }
            if (userplay == Enums.playerPostion.midLeft)
            {
                ArrayPos[1, 0] = userInput;
            }
            
            if (userplay == Enums.playerPostion.midCenter)
            {
                ArrayPos[1, 1] = userInput;
            }
            if (userPlay == Enums.playerPostion.midRight)
            {
                ArrayPos[1, 2] = userInput; 
            }
            if (userplay == Enums.playerPostion.bottomLeftCorner)
            {
                ArrayPos[2, 0] = userInput;
            }
            if (userPlay == Enums.playerPostion.bottomMiddleCorner)
            {
                ArrayPos[2, 1] = userInput;
            }

        }
    }
}
