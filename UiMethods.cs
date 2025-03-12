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

        // this is just a generic message for UI purposes 
        public static void DisplayCpuTurnsMessage(string CpuLetter)
        {
            Console.WriteLine($"CPU: {CpuLetter} is placing it's Mark....");
        }

        public static void DisplayGameTieMessage()
        {
            Console.WriteLine("The Game is a Tie");
        }
        public static void DisplayGameOverMessage()
        {
            Console.WriteLine("There are no more Spaces on the grid GameOver");
        }

        public static void DisplayTicTacToeGrid(string[,] Grid)
        {
            //////// this is to diplay the tic-tac-toe grid//////////////////////////

            for (int rows = 0; rows < Grid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < Grid.GetLength(1); cols++)
                {
                    Console.Write(Grid[rows, cols] = " _ ");
                }
                Console.WriteLine();
            }

        }

        public static void DisplayUpdatedGameGrid(string[,] grid)
        {
            for (int rows = 0; rows < grid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < grid.GetLength(1); cols++)
                {
                    Console.Write($" {grid[rows, cols]} ");
                }
                Console.WriteLine();
            }
        }

        // the User will input the mark in this method
        public static string SelectGameMark()
        {
            string userInput = Console.ReadLine(); // This is an input for selecting X's or O's
            return userInput;
        }

        public static string DisplaySymbolOfWinnerMessage(string winnerSymbol)
        {
            Console.WriteLine($"{winnerSymbol} is the winner");
            return winnerSymbol;
        }

        // this will check what the user has put into the entry and will let the user know if valid or not
        public static string DecidePlayerSymbol(out string cpuSymbol)  // this prompts the user to select the mark: X or O
        {
            bool isTheSelectionValid = false;
            string PlayerEntryCheck = UiMethods.SelectGameMark();
            cpuSymbol = "";

            do
            {
                if (PlayerEntryCheck == GameConstants.PLAYERCHOICE_X || PlayerEntryCheck == GameConstants.PLAYERCHOICE_O)
                {
                    isTheSelectionValid = true;

                    if (PlayerEntryCheck == GameConstants.PLAYERCHOICE_X)  // this will assign CPU's symbol based on the players's choice
                    {
                        cpuSymbol = GameConstants.PLAYERCHOICE_O;
                    }

                    else
                    {
                        cpuSymbol = GameConstants.PLAYERCHOICE_X;
                    }
                    // confirmation of selection(s) 
                    Console.WriteLine($"Player has selected: {PlayerEntryCheck}");
                    Console.WriteLine($"CPU will play as {cpuSymbol}");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine($"ERROR Incorrect Entry! Please select either '{GameConstants.PLAYERCHOICE_X}' or '{GameConstants.PLAYERCHOICE_O}' mark");
                    PlayerEntryCheck = UiMethods.SelectGameMark();
                }
            }
            while (!isTheSelectionValid);

            return PlayerEntryCheck;
        }

        public static void PromptUserToClearScreen() // should be placed under UiMethiods
        {
            Console.Clear();
            Console.WriteLine("Please hit Enter To Continue......");
            Console.ReadKey();
        }
        //------------------------------------------------------------------------------------------------------------------------//

        // this checks if the user enters anything (less or equal to) or (greater or equal) to within the range of 1-9
        public static int ValidatePlayerInputIntoGrid() // placing entry for user on grid
        {
            var range = (GameConstants.LOW, GameConstants.HIGH); // LOW == 1, HIGH == 10
            int numberPositionOnGrid;

            Console.WriteLine("To place your mark in the game grid, use a value between 1-9"); // prompt the user to enter number for grid

            string placingPlayerPositionOnGrid = Console.ReadLine(); // user number enters position on gamegrid
            bool isTheEntryWithinRange = false;

            do
            {
                if (int.TryParse(placingPlayerPositionOnGrid, out numberPositionOnGrid)) // this will catch the Player input to see if the input is in range 
                {
                    if (numberPositionOnGrid >= range.LOW && numberPositionOnGrid <= range.HIGH)
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

        // this Method puts the User Entry on to the updated grid and checks to see if it is put on a valid space on the grid ///
        public static void PlacingUserMarkIntoGrid(string playerSymbol, string[,] gameGrid)
        {
            int gridPostion = UiMethods.ValidatePlayerInputIntoGrid(); //gets vaild position from the player
            (int rows, int cols) = Logic.MapPostionToGrid(gridPostion.ToString()); // converts the input to a string so thst it can placed into the "string" gameGrid

            if (gameGrid[rows, cols] == " _ ") // checks if there is an empty space 
            {
                gameGrid[rows, cols] = playerSymbol; // inputs player symbol into space
                Console.WriteLine($"You selected a grid position {gridPostion}, on row: {rows} and col: {cols}"); // used for testing purposes
            }
            else
            {
                Console.WriteLine("That Position is already occupied please try again");
                PlacingUserMarkIntoGrid(playerSymbol, gameGrid); // prompt user in case input isn't valid
            }

        }
    }
}
