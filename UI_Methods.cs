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
        public static string DecidePlayerSymbol()  // this is when the useer selects the mark 
        {
            bool isTheSelectionValid = false;
            string PlayerEntryCheck = UI_Methods.UserSelectMark();
            do
            {

                if (PlayerEntryCheck == GameConstants.PLAYERCHOICE_X || PlayerEntryCheck == GameConstants.PLAYERCHOICE_O)
                {
                    isTheSelectionValid = true;
                    Console.WriteLine($"Player has selected {PlayerEntryCheck}");
                    Console.WriteLine();
                    break;
                }

                if (PlayerEntryCheck != GameConstants.PLAYERCHOICE_O || PlayerEntryCheck != GameConstants.PLAYERCHOICE_X)
                {
                    Console.WriteLine(" ERROR incorrect Entry :please select a mark");
                    isTheSelectionValid = false;
                    PlayerEntryCheck = UI_Methods.UserSelectMark();
                }
            }
            while (!isTheSelectionValid);

            return PlayerEntryCheck;
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
        public static void GridPositions(string[,] gridArrayPos) // this Method establishes the locations of where the player and cpu puts their marks
        {

            string getPlayerPosition = Console.ReadLine();

            gridArrayPos[0, 0] = ((int)playerPostion.topLeftCorner).ToString(); // this was cast with an (int) because of an error when inplementing the positions  =P
            gridArrayPos[0, 1] = ((int)playerPostion.topMiddleCorner).ToString();
            gridArrayPos[0, 2] = ((int)playerPostion.topRightConer).ToString();

            //////////////////////////////////////////////////////////////////////

            gridArrayPos[1, 0] = ((int)playerPostion.midLeft).ToString();
            gridArrayPos[1, 1] = ((int)playerPostion.midCenter).ToString();
            gridArrayPos[1, 2] = ((int)playerPostion.midRight).ToString();

            /////////////////////////////////////////////////////////////////////

            gridArrayPos[2, 0] = ((int)playerPostion.bottomLeftCorner).ToString();
            gridArrayPos[2, 1] = ((int)playerPostion.bottomMiddleCorner).ToString();
            gridArrayPos[2, 2] = ((int)playerPostion.bottomRightConer).ToString();

            ////// ///checks/////////
            if (getPlayerPosition == gridArrayPos[0, 0])
            {
                Console.WriteLine("the user had marked something on gridspace 1");// for testing purposes 
            }
            if (getPlayerPosition == gridArrayPos[0, 1])
            {
                Console.WriteLine("the user had marked something on gridspace 2");
            }

            if (getPlayerPosition == gridArrayPos[0, 2])
            {
                Console.WriteLine("the user had marked something on gridspace 3");
            }
            if (getPlayerPosition == gridArrayPos[1, 0])
            {
                Console.WriteLine("the user had marked something on gridspace 4");
            }
            if (getPlayerPosition == gridArrayPos[1, 1])
            {
                Console.WriteLine("the user had marked something on gridspace 5");
            }
            if (getPlayerPosition == gridArrayPos[1, 2])
            {
                Console.WriteLine("the user had marked something on gridspace 6");
            }
            if (getPlayerPosition == gridArrayPos[2, 0])
            {
                Console.WriteLine("the user had marked something on gridspace 7");
            }
            if (getPlayerPosition == gridArrayPos[2, 1])
            {
                Console.WriteLine("the user had marked something on gridspace 8");
            }
            if (getPlayerPosition == gridArrayPos[2, 2])
            {
                Console.WriteLine("the user had marked something on gridspace 9");
            }
           
        }

        public static void PlayerMarkPositionOnGrid(int[,] gridArrayPos)
        {

            // get the input to match up with the enums "something == something"
            // make something like where the player press a number on the keyboard and then his/her mark is selected put on the tic-tac-toe grid
            // or something within the lines of that
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
        //    if (UI_Methods.DecidePlayerSymbol() == PlayerPosition.playerPostion.topLeftCorner)
        //    {
        //        ArrayPos[0, 0] = userInput;
        //    }

        //    if (UI_Methods.DecidePlayerSymbol() == PlayerPosition.topMiddleCorner)
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

        //}
    }
}

