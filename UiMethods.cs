using System;

namespace tic_tac_toe
{
    public static class UiMethods
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
        public static string DecidePlayerSymbol()  // this prompts the user to select the mark: X or O
        {
            bool isTheSelectionValid = false;
            string PlayerEntryCheck = UiMethods.UserSelectMark();

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
                    PlayerEntryCheck = UiMethods.UserSelectMark();
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
            if (userInput == GameConstants.PLAYERCHOICE_X)
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
            Console.WriteLine("Place your mark in the grid, use a value between 1-9"); // prompt the user 

            string placePlayerPosition = Console.ReadLine();

            int playerPositionInput = int.Parse(placePlayerPosition); // converts playerInput into an integer which will match up with enum values



            // potential Line  if([index] == GameConstants.PLAYERCHOICE_O || [index] == GameConstants.PLAYERCHOICE_X)
            //{
            // PLAYERWHATEEVR == [INDEX];
            //}
            //// this establishes the positions of the value of the enums and will match the vaules with user input to place the player mark//////

            gridArrayPos[0, 0] = ((int)playerPosition.topLeftCorner).ToString(); // this was cast with an (int) because of an error when inplementing the positions  =P
            gridArrayPos[0, 1] = ((int)playerPosition.topMiddleCorner).ToString();
            gridArrayPos[0, 2] = ((int)playerPosition.topRightConer).ToString();

            //////////////////////////////////////////////////////////////////////

            gridArrayPos[1, 0] = ((int)playerPosition.midLeft).ToString();
            gridArrayPos[1, 1] = ((int)playerPosition.midCenter).ToString();
            gridArrayPos[1, 2] = ((int)playerPosition.midRight).ToString();

            /////////////////////////////////////////////////////////////////////

            gridArrayPos[2, 0] = ((int)playerPosition.bottomLeftCorner).ToString();
            gridArrayPos[2, 1] = ((int)playerPosition.bottomMiddleCorner).ToString();
            gridArrayPos[2, 2] = ((int)playerPosition.bottomRightCorner).ToString();

            /////////checks/////////
            if (playerPositionInput == (int)playerPosition.topLeftCorner) // when player chooses 1 the player mark will be put into position
            {
                gridArrayPos[0, 0] = playerMark;
            }
            if (playerPositionInput == (int)playerPosition.topMiddleCorner)
            {
                gridArrayPos[0, 1] = playerMark;
            }
            if (playerPositionInput == (int)playerPosition.topRightConer)
            {
                gridArrayPos[0, 2] = playerMark;
            }
            if (playerPositionInput == (int)playerPosition.midLeft)
            {
                gridArrayPos[1, 0] = playerMark;
            }
            if (playerPositionInput == (int)playerPosition.midCenter)
            {
                gridArrayPos[1, 1] = playerMark;
            }
            if (playerPositionInput == (int)playerPosition.midRight)
            {
                gridArrayPos[1, 2] = playerMark;
            }
            if (playerPositionInput == (int)playerPosition.bottomLeftCorner)
            {
                gridArrayPos[2, 0] = playerMark;
            }
            if (playerPositionInput == (int)playerPosition.bottomMiddleCorner)
            {
                gridArrayPos[2, 1] = playerMark;
            }
            if (playerPositionInput == (int)playerPosition.bottomRightCorner)
            {
                gridArrayPos[2, 2] = playerMark;
            }
        }
        public static void PlacingPlayerEntryOnGrid() // this might have to replace the PlayerMarkPositionOnGrid() method 
        {
            Random rng = new Random(); // random seed
            int gridRange = rng.Next(GameConstants.LOW, GameConstants.HIGH);// this determines the range of the grid positions

            Console.WriteLine("Place your mark in the grid, use a value between 1-9"); // prompt the user to enter number for grid

            string placePlayerPosition = Console.ReadLine(); // user enters position on gamegrid
            bool isTheEntryWithinRange = false;

            do
            {
                if (int.TryParse(placePlayerPosition, out gridRange)) // this will catch the Player input to see if the input is in range 
                {
                    if (gridRange < GameConstants.HIGH || gridRange > GameConstants.LOW)
                    {
                        Console.WriteLine("Entry is within range ,space has been selected ");
                        isTheEntryWithinRange = true;
                    }
                    else
                        Console.WriteLine("this is not within the range of the grid, please try again");
                    placePlayerPosition = Console.ReadLine();
                }

            } while (!isTheEntryWithinRange);
        }

        public static int winGameCheck()
        {
            throw new NotImplementedException();
            // this will check if the user or the computer has won
            // if (user or computer )
        }



    }
}

