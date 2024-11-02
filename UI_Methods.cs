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
        public static string DecidePlayerSymbol()  // this is when the user selects the mark 
        {
            bool isTheSelectionValid = false;
            string PlayerEntryCheck = UI_Methods.UserSelectMark();
            do
            {

                if (PlayerEntryCheck == GameConstants.PLAYERCHOICE_X || PlayerEntryCheck == GameConstants.PLAYERCHOICE_O)
                {
                    isTheSelectionValid = true;
                    Console.WriteLine($"Player has selected: {PlayerEntryCheck}");
                    Console.WriteLine();
                    break;
                }

                if (PlayerEntryCheck != GameConstants.PLAYERCHOICE_O || PlayerEntryCheck != GameConstants.PLAYERCHOICE_X)
                {
                    Console.WriteLine(" ERROR Incorrect Entry! :please select either 'O' or 'X' mark");
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
        public static void PlayerMarkPositionOnGrid(string[,] gridArrayPos, string playerMark) // this Method establishes the locations of where the player and cpu (maybe) puts their marks// change the name of method
        {
            Console.WriteLine("Place your mark in the grid");
            string getPlayerPosition = Console.ReadLine();

            //// this establishes the positions of the value of the enums and will match the vaules with user input to place the player mark//////
           
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

            /////////checks/////////
            if (getPlayerPosition == gridArrayPos[0, 0])
            {
                Console.WriteLine(playerMark);
                Console.WriteLine("the user had marked something on gridspace 1");// for testing purposes, replace these messages with player
            }
            if (getPlayerPosition == gridArrayPos[0, 1])
            {
                Console.WriteLine(playerMark);
                Console.WriteLine("the user had marked something on gridspace 2");
            }

            if (getPlayerPosition == gridArrayPos[0, 2])
            {
                Console.WriteLine(playerMark);
                Console.WriteLine("the user had marked something on gridspace 3");
            }
            if (getPlayerPosition == gridArrayPos[1, 0])
            {
                Console.WriteLine(playerMark);
                Console.WriteLine("the user had marked something on gridspace 4");
            }
            if (getPlayerPosition == gridArrayPos[1, 1])
            {
                Console.WriteLine(playerMark);
                Console.WriteLine("the user had marked something on gridspace 5");
            }
            if (getPlayerPosition == gridArrayPos[1, 2])
            {
                Console.WriteLine(playerMark);
                Console.WriteLine("the user had marked something on gridspace 6");
            }
            if (getPlayerPosition == gridArrayPos[2, 0])
            {
                Console.WriteLine(playerMark);
                Console.WriteLine("the user had marked something on gridspace 7");
            }
            if (getPlayerPosition == gridArrayPos[2, 1])
            {
                Console.WriteLine(playerMark);
                Console.WriteLine("the user had marked something on gridspace 8");
            }
            if (getPlayerPosition == gridArrayPos[2, 2])
            {
                Console.WriteLine(playerMark);
                Console.WriteLine("the user had marked something on gridspace 9");
            }

        }

        public static int winGameCheck()
        {
            throw new NotImplementedException();
            // this will check if the user or the computer has won
            // if (user or computer )
        }


       
    }
}

