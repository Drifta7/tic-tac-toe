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
        public static string DecidePlayerSymbol()
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
        public static void GridPositions(int[,] GridArrayPos) // this Method establishes the locations of where the player and cpu puts their marks
        {
            GridArrayPos[0, 0] = (int)PlayerPosition.playerPostion.topLeftCorner; // this was cast with an (int) because of an error when inplementing the positions  =P
            GridArrayPos[0, 1] = (int)PlayerPosition.playerPostion.topMiddleCorner;
            GridArrayPos[0, 2] = (int)PlayerPosition.playerPostion.topRightConer;

            //////////////////////////////////////////////////////////////////////

            GridArrayPos[1, 0] = (int)PlayerPosition.playerPostion.midLeft;
            GridArrayPos[1, 1] = (int)PlayerPosition.playerPostion.midCenter;
            GridArrayPos[1, 2] = (int)PlayerPosition.playerPostion.midRight;

            ///////////////////////////////////////////////////////////////////

            GridArrayPos[2, 0] = (int)PlayerPosition.playerPostion.bottomLeftCorner;
            GridArrayPos[2, 1] = (int)PlayerPosition.playerPostion.bottomMiddleCorner;
            GridArrayPos[2, 2] = (int)PlayerPosition.playerPostion.bottomRightConer;
        }

        public static void PlayerMarkPosition()
        {
            int getPlayerPosition = Convert.ToInt32(Console.ReadLine());// player inputs number for position... i think lol 
            //if (getPlayerPosition == UI_Methods.GridPositions())
            {
                
            }
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

