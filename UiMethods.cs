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
        public static void CpuTurnMessage(string CpuLetter)
        {
            Console.WriteLine($"CPU: {CpuLetter} is placing it's Mark....");
        }
        public static void GameOverMessage()
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
        public static void PlacingCpuMarkOnGrid(string[,] Grid, string CpuMark)
        {
            bool isGridMarked = false;

            for (int rows = 0; rows < Grid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < Grid.GetLength(1); cols++)
                {
                    if (Grid[rows, cols] == " _ ")
                    {
                        Grid[rows, cols] = CpuMark;
                        isGridMarked = true;
                        Console.WriteLine($"DEBUG: CPU placed: {CpuMark} at ({rows},{cols})");
                        break; // so that it breaks out the loop when placed 
                    }
                }
                if (isGridMarked)
                {
                    break; // breaks out of the outer loop
                }
            }
            if (!isGridMarked)
            {
                Console.WriteLine("DEBUG: NO Empty Spaces Left for CPU to place a mark");
            }
            Console.WriteLine("CPU has placed its mark");
        }

        public static void DisplayUpdatedGameGrid(string[,] Grid)
        {
            for (int rows = 0; rows < Grid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < Grid.GetLength(1); cols++)
                {
                    Console.Write($" {Grid[rows, cols]} ");
                }
                Console.WriteLine();
            }
        }

        // the User will input the mark in this method
        public static string UserSelectedMark()
        {
            string userInput = Console.ReadLine(); // This is an input for selecting X's or O's
            return userInput;
        }

        public static string symbolOfWinnerMessage(string WinnerSymbol) // for this put in perhaps PLayersymbol method or the variable
        {
            Console.WriteLine($"{WinnerSymbol} is the winner");
            return WinnerSymbol;
        }

        // this will check what the user has put into the entry and will let the user know if valid or not
        public static string DecidePlayerSymbol(out string cpuSymbol)  // this prompts the user to select the mark: X or O
        {
            bool isTheSelectionValid = false;
            string PlayerEntryCheck = UiMethods.UserSelectedMark();
            cpuSymbol = "";

            do
            {
                if (PlayerEntryCheck == GameConstants.PLAYERCHOICE_X || PlayerEntryCheck == GameConstants.PLAYERCHOICE_O)
                {
                    isTheSelectionValid = true;
                    // this will assign CPU's symbol based on the players's choice
                    if (PlayerEntryCheck == GameConstants.PLAYERCHOICE_X)
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
                    Console.WriteLine(" ERROR Incorrect Entry! :please select either 'O' or 'X' mark");
                    PlayerEntryCheck = UiMethods.UserSelectedMark();
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




        ////////-----------------------------------------------------------------------------------////
        // this Method puts the User Entry on to the updated grid and checks to see if it is put on a valid space on the grid ///
        public static string PlacingUserMarkIntoGrid(string playerSymbol, string[,] gameGrid)
        {
            int gridPostion = UiMethods.ValidatePlayerInputIntoGrid(); //gets vaild position from the player
            (int rows, int cols) = MapPostionToGrid(gridPostion.ToString()); // converts the input to a string so thst it can placed into the "string" gameGrid

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
            return playerSymbol;
        }

        public static string GetUserInput()// this is for the validate method
        {
            Console.WriteLine("Please provide an input");
            string input = Console.ReadLine();
            return input;
        }
    }
}




