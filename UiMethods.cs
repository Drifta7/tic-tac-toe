using System;

namespace tic_tac_toe
{
    public static class UiMethods
    {
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to The wonderful world of Tic-Tac-Toe");
            Console.WriteLine($"Choose {GameConstants.PLAYERCHOICE_X} or {GameConstants.PLAYERCHOICE_O}");
        } // generic display message


        public static string[,] DisplayTicTacToeGrid(string[,] Grid)
        {
            //////// this is to diplay the tic-tac-toe grid//////////////////////////

            for (int rows = 0; rows < Grid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < Grid.GetLength(1); cols++)
                {
                    Console.Write(Grid[rows, cols] = " - ");
                }
                Console.WriteLine();
            }
            return Grid;
        }


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
            string cpuChoiceSymbol = "";

            do
            {

                if (PlayerEntryCheck == GameConstants.PLAYERCHOICE_X || PlayerEntryCheck == GameConstants.PLAYERCHOICE_O)
                {
                    isTheSelectionValid = true;

                    if (PlayerEntryCheck == GameConstants.PLAYERCHOICE_X)
                    {
                        cpuChoiceSymbol = GameConstants.PLAYERCHOICE_O;
                    }

                    else
                    {
                        cpuChoiceSymbol = GameConstants.PLAYERCHOICE_X;
                    }

                    Console.WriteLine($"Player has selected: {PlayerEntryCheck}");
                    Console.WriteLine($"CPU will play as {cpuChoiceSymbol}");
                    Console.WriteLine();
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
        public static int PlacingPlayerEntryOnGrid() // placing entry for user on grid
        {
            Random rng = new Random(); // random seed
            int numberPositionOnGrid = rng.Next(GameConstants.LOW, GameConstants.HIGH);// this determines the range of the grid positions

            Console.WriteLine("To place your mark in the game grid, use a value between 1-9"); // prompt the user to enter number for grid

            string placingPlayerPositionOnGrid = Console.ReadLine(); // user number enters position on gamegrid
            bool isTheEntryWithinRange = false; // bool set to false 

            do
            {
                if (int.TryParse(placingPlayerPositionOnGrid, out numberPositionOnGrid)) // this will catch the Player input to see if the input is in range 
                {
                    if (numberPositionOnGrid >= GameConstants.LOW && numberPositionOnGrid <= GameConstants.HIGH)
                    {
                        Console.WriteLine("Space has been selected ");
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
            return numberPositionOnGrid; // returns value of numberPositionOnGrid
        }
        //------------------------------------------------------------------------------------------------------------------//


        // this will make the Grid dynamic by not hard coding the elements and user selecting where to put their mark
        public static (int, int) MapPostionToGrid(string position)

        {
            if (int.TryParse(position, out int GridPosition))
            {
                int totalCells = GameConstants.NUMBER_OF_ROWS * GameConstants.NUMBER_OF_COLUMNS;

                if (GridPosition >= 1 && GridPosition <= totalCells) // used to make sure that the entry selection remains inbounds to the Grid array
                {
                    int rows = (GridPosition - 1) / GameConstants.NUMBER_OF_ROWS; // the -1 is for the offset of the grid
                    int cols = (GridPosition - 1) % GameConstants.NUMBER_OF_COLUMNS;
                    return (rows, cols);
                }

                else
                {
                    throw new ArgumentException("Invaild Input, please enter a Vaild number");
                }
            }

            else
            {
                throw new ArgumentException("Invaild input");
            }
        }

        ////////////////////////////////////////////////////////////////////////
        public static int WinGameCheck()
        {
            throw new NotImplementedException();
            // this will check if the user or the computer has won
            // if (user or computer )

        }

        ////////-----------------------------------------------------------------------------------////
        // might be an issue with this method ///
        public static void ValidatePlayerInput(string[,] gameGrid, string playerSymbol)
        {
            int gridPostion = UiMethods.PlacingPlayerEntryOnGrid(); //gets vaild position from the player
            (int rows, int cols) = MapPostionToGrid(gridPostion.ToString()); // converts the input to a string

            if (gameGrid[rows, cols] == " - ") // checks if there is an empty space 
            {
                gameGrid[rows, cols] = playerSymbol; // input player symbol into space
                Console.WriteLine($"You selected a grid position {gridPostion}, on row: {rows} and col: {cols}");
            }
            else
            {
                Console.WriteLine("That Position ius already occupied PLease try again");
                ValidatePlayerInput(gameGrid, playerSymbol); // prompt user in case input isn't valid
            }
        }
    }
}




