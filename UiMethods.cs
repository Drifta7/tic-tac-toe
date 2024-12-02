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


        public static string UserSelectedMark()
        {

            string userInput = Console.ReadLine(); // will use this as an argument for playerSelection() method
            return userInput;
        }


        public static string DecidePlayerSymbol()  // this prompts the user to select the mark: X or O
        {
            bool isTheSelectionValid = false;
            string PlayerEntryCheck = UiMethods.UserSelectedMark();

            do
            {

                if (PlayerEntryCheck == GameConstants.PLAYERCHOICE_X || PlayerEntryCheck == GameConstants.PLAYERCHOICE_O)
                {
                    isTheSelectionValid = true;
                    Console.WriteLine($"Player has selected: {PlayerEntryCheck}");
                    Console.WriteLine();
                    break;
                }

                if (PlayerEntryCheck != GameConstants.PLAYERCHOICE_X && PlayerEntryCheck != GameConstants.PLAYERCHOICE_O)
                {
                    Console.WriteLine(" ERROR Incorrect Entry! :please select either 'O' or 'X' mark");
                    PlayerEntryCheck = UiMethods.UserSelectedMark();
                }
            }
            while (!isTheSelectionValid);

            return PlayerEntryCheck;
        }

        // this method should be established as when the user has put in their mark
        // and also when the user and the computer switch turns

        public static void PlacingPlayerEntryOnGrid() // entry for user on grid
        {
            Random rng = new Random(); // random seed
            int gridRange = rng.Next(GameConstants.LOW, GameConstants.HIGH);// this determines the range of the grid positions

            Console.WriteLine(" To place your mark in the game grid, use a value between 1-9"); // prompt the user to enter number for grid

            string placePlayerPosition = Console.ReadLine(); // user enters position on gamegrid
            bool isTheEntryWithinRange = false; // bool set to false 

            do
            {
                if (int.TryParse(placePlayerPosition, out gridRange)) // this will catch the Player input to see if the input is in range 
                {
                    if (gridRange >= GameConstants.LOW && gridRange <= GameConstants.HIGH)
                    {
                        Console.WriteLine("Entry is within range ,space has been selected "); // when this is called correctly working shorten the message
                        isTheEntryWithinRange = true;
                    }
                    
                    else
                    {
                        Console.WriteLine("this is not within the range of the grid, please try again");
                        placePlayerPosition = Console.ReadLine();
                    }
                }

            }
            while (!isTheEntryWithinRange);

            (int rows, int cols) = MapPostionToGrid(placePlayerPosition);

        }

        static (int, int) MapPostionToGrid(string position) // this will make the Grid dynamic by not hard coding the elements

        {
            if (int.TryParse(position, out int GridPosition))
            {
                int row = (GridPosition - 1) / GameConstants.NUMBER_OF_ROWS;
                int cols = (GridPosition - 1) % GameConstants.NUMBER_OF_COLUMNS; 
                return (row, cols);
            }
            else
            {
                throw new ArgumentException("Invaild Input, please enter a Vaild number");
            }
        }


        public static void CpuAI()
        {   // use a random "seed" for when there are no matches from the players mark
            // when player selects mark place the Cpu's mark in this function for check when player has 2 makrs in a row or column ( a block)
        }



        ////////////////////////////////////////////////////////////////////////
        public static int winGameCheck()
        {
            throw new NotImplementedException();
            // this will check if the user or the computer has won
            // if (user or computer )

        }
    }
}

