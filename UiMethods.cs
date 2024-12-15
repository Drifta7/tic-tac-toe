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

        // the User will input the mark in this method
        public static string UserSelectedMark()
        {

            string userInput = Console.ReadLine(); // will use this as an argument for playerSelection() method
            return userInput;
        }

        // this will check what the user has put into the entry and will let the user know if valid or not
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

        //------------------------------------------------------------------------------------------------------------------------//

        // this checks if the user enters anything (less or equal to) or (greater or equal) to within the range of 1-9
        public static void PlacingPlayerEntryOnGrid() // placing entry for user on grid
        {
            Random rng = new Random(); // random seed
            int gridRange = rng.Next(GameConstants.LOW, GameConstants.HIGH);// this determines the range of the grid positions

            Console.WriteLine(" To place your mark in the game grid, use a value between 1-9"); // prompt the user to enter number for grid

            string placingPlayerPositionOnGrid = Console.ReadLine(); // user enters position on gamegrid
            bool isTheEntryWithinRange = false; // bool set to false 

            do
            {
                if (int.TryParse(placingPlayerPositionOnGrid, out gridRange)) // this will catch the Player input to see if the input is in range 
                {
                    if (gridRange >= GameConstants.LOW && gridRange <= GameConstants.HIGH)
                    {
                        (int rows, int cols) = MapPostionToGrid(placingPlayerPositionOnGrid);
                        Console.WriteLine("Entry is within range ,space has been selected "); // when this is called correctly working shorten the message
                        isTheEntryWithinRange = true;
                    }

                    else
                    {
                        Console.WriteLine("this is not within the range of the grid, please try again");
                        placingPlayerPositionOnGrid = Console.ReadLine();
                    }
                }

            }
            while (!isTheEntryWithinRange);
        }
        //------------------------------------------------------------------------------------------------------------------//


        // this will make the Grid dynamic by not hard coding the elements and user selecting where to put their mark
        public static (int, int) MapPostionToGrid(string position)

        {
            if (int.TryParse(position, out int GridPosition))
            {
                int row = (GridPosition - 1) / GameConstants.NUMBER_OF_ROWS; // the -1 is for the offset of the grid
                int cols = (GridPosition - 1) % GameConstants.NUMBER_OF_COLUMNS;
                return (row, cols);
            }
            else
            {
                throw new ArgumentException("Invaild Input, please enter a Vaild number");
            }
        }


        public static void CpuAI()
        {   // use a random "seed" for when there are no matches from the players mark ( namely the CPu)
            // when player selects mark place the Cpu's mark in this function for check when player has 2 makrs in a row or column ( a strategic block)
            // use call function to check if the space is not occupied 

            Random rng = new Random(); // random seed for the Cpu to place it's mark
            int cpuPlaceMarkInSpace = rng.Next(GameConstants.LOW, GameConstants.HIGH);

            Logic.RowsCheck(Logic.DisplayUpdatedGameGrid()); // this might not work because this should be checking the " UPDATED GRID" (WIP)

            Logic.CenterLineCheck(Logic.DisplayTicTacToeGrid());
            Logic.ColoumnsCheck(Logic.DisplayTicTacToeGrid());

            Logic.TopLeftDiagonalCheck(Logic.DisplayTicTacToeGrid());
            Logic.TopRightDiaginalCheck(Logic.DisplayTicTacToeGrid());

            Logic.CheckForValidInputSymbolInGrid(Logic.DisplayTicTacToeGrid(), GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS, GameConstants.PLAYERCHOICE_X, GameConstants.PLAYERCHOICE_O, UiMethods.DecidePlayerSymbol());

            //if space is not occupied then put in the cpu mark on the grid
        }



        ////////////////////////////////////////////////////////////////////////
        public static int WinGameCheck()
        {
            throw new NotImplementedException();
            // this will check if the user or the computer has won
            // if (user or computer )

        }
    }
}

