using System;

namespace tic_tac_toe
{
    class Logic
    {

        public static void PlacingCpuMarkOnGrid(string[,] grid, string cpuMark)
        {
            bool isGridMarked = false;

            for (int rows = 0; rows < grid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < grid.GetLength(1); cols++)
                {
                    if (grid[rows, cols] == " _ ")
                    {
                        grid[rows, cols] = cpuMark;
                        isGridMarked = true;
                        //Console.WriteLine($"DEBUG: CPU placed: {CpuMark} at ({rows},{cols})");
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
                // Console.WriteLine("DEBUG: NO Empty Spaces Left for CPU to place a mark");
            }
            // Console.WriteLine("CPU has placed its mark");
        }

        // this will make the Grid dynamic by not hard coding the elements and user selecting where to put their mark
        public static (int, int) MapPostionToGrid(string position)
        {
            if (int.TryParse(position, out int gridPosition))
            {
                int totalCells = GameConstants.NUMBER_OF_ROWS * GameConstants.NUMBER_OF_COLUMNS;

                if (gridPosition >= GameConstants.LOW && gridPosition <= totalCells) // used to make sure that the entry selection remains inbounds to the Grid array
                {
                    int rows = (gridPosition - GameConstants.LOW) / GameConstants.NUMBER_OF_ROWS; // the -1 is for the offset of the grid
                    int cols = (gridPosition - GameConstants.LOW) % GameConstants.NUMBER_OF_COLUMNS;
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

        /////////////////////////////////Checks for Player Or Cpu Position///////////////////////////////////////
        public static bool CheckForRowWin(string[,] grid)
        {
            for (int rows = 0; rows < grid.GetLength(0); rows++)
            {
                string checkPlayerMarkMatch = grid[rows, 0]; // this checks the 1st element of the rows

                if (checkPlayerMarkMatch == " _ ") // Ensures that it's not an empty space
                {
                    continue;
                }

                bool playerAllRowMatch = true;

                for (int cols = 1; cols < grid.GetLength(1); cols++) // starts at 1 and not at the first element
                {
                    if (grid[rows, cols] != checkPlayerMarkMatch)
                    {
                        playerAllRowMatch = false;
                        break;
                    }
                }

                if (playerAllRowMatch) //if PLayerAllMatch is true it then calls the method
                {
                    return true; // stop checking further rows since the game is already won.
                }
            }
            return false;
        }

        public static bool CheckForCenterLineWin(string[,] grid)
        {
            string firstCenterValue = grid[1, 0];
            bool centerArrayMatches = true;

            if (firstCenterValue == " _ ")
            {
                return false;
            }

            for (int i = 1; i < grid.GetLength(1); i++)
            {
                if (grid[1, i] != firstCenterValue)
                {
                    centerArrayMatches = false;
                    break;
                }
            }
            return centerArrayMatches; // returns true if all elements in the center line match
        }

        public static bool CheckForColumnsWin(string[,] grid)
        {
            for (int cols = 0; cols < grid.GetLength(1); cols++)
            {
                string checkEqualNUmbers = grid[0, cols];// the first element to compare to
                bool allMatched = true;

                for (int rows = 0; rows < grid.GetLength(0); rows++)
                {
                    if (grid[rows, cols] != checkEqualNUmbers || checkEqualNUmbers == " _ ")
                    {
                        allMatched = false;
                        break;
                    }
                }
                if (allMatched)

                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckForTopLeftDiagonalWin(string[,] grid)
        {
            string firstDiagonalValue = grid[0, 0];
            bool allDiagonalMatch = true;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                if (grid[i, i] != firstDiagonalValue || firstDiagonalValue == " _ ")
                {
                    allDiagonalMatch = false;
                    break;
                }
            }
            
            if (allDiagonalMatch) // testing if this will work to follow the same format as "check for column wins
            {
                return true;
            }
            return allDiagonalMatch;
        }
        public static bool CheckTopRightDiagonalWin(string[,] grid)
        {
            string firstDiagValue = grid[0, grid.GetLength(1) - 1]; // top-right element 
            bool allDiagMatch = true;

            for (int i = 0; i < grid.GetLength(0); i++)// loop through diagonal
            {
                if (grid[i, grid.GetLength(1) - 1 - i] != firstDiagValue || firstDiagValue == " _ ")
                {
                    allDiagMatch = false;
                    break;
                }
            }
            if (allDiagMatch)
            {
                return true;
            }
            return allDiagMatch;
        }

        public static bool CheckForWin(string[,] Grid)
        {
            return CheckForRowWin(Grid) || CheckForColumnsWin(Grid) || CheckForTopLeftDiagonalWin(Grid)
                    || CheckTopRightDiagonalWin(Grid) || CheckForCenterLineWin(Grid);
        }

        // The method checks if all the spaces are filled and the is not declared winner 
        // this will be set to false during the game, when it becomes true then the game will restart with no winners 
        public static bool CheckingIfAllSpacesFilled(string[,] grid) // will be used for a the Program "while" loop
        {
            for (int rows = 0; rows < grid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < grid.GetLength(1); cols++)
                {
                    if (grid[rows, cols] != GameConstants.PLAYERCHOICE_O && grid[rows, cols] != GameConstants.PLAYERCHOICE_X) // checks to see if the grid is filled with x's and o's
                    {
                        return false; // found and empty space grid not full yet
                    }
                }
            }
            return true; // grid is full
        }
    }
}