using System;

namespace tic_tac_toe
{
    class Logic
    {




        /////////////////////////////////Checks for Player Or Cpu Position///////////////////////////////////////
        public static bool CheckForRowWin(string[,] Grid)
        {
            for (int rows = 0; rows < Grid.GetLength(0); rows++)
            {
                string checkPlayerMarkMatch = Grid[rows, 0]; // this checks the 1st element of the rows

                if (checkPlayerMarkMatch == " _ ") // Ensures that it's not an empty space
                {
                    continue;
                }

                bool PlayerAllRowMatch = true;

                for (int cols = 1; cols < Grid.GetLength(1); cols++) // starts at 1 and not at the first element
                {
                    if (Grid[rows, cols] != checkPlayerMarkMatch)
                    {
                        PlayerAllRowMatch = false;
                        break;
                    }
                }

                if (PlayerAllRowMatch) //if PLayerAllMatch is true it then calls the method
                {
                    return true; // stop checking further rows since the game is already won.
                }
            }
            return false;
        }

        public static bool CheckForCenterLineWin(string[,] Grid)
        {
            string firstCenterValue = Grid[1, 0];
            bool CenterArrayMatches = true;

            if (firstCenterValue == " _ ")
            {
                return false;
            }

            for (int i = 1; i < Grid.GetLength(1); i++)
            {
                if (Grid[1, i] != firstCenterValue)
                {
                    CenterArrayMatches = false;
                    break;
                }
            }
            return CenterArrayMatches; // returns true if all elements in the center line match
        }

        public static bool CheckForColumnsWin(string[,] Grid)
        {
            for (int cols = 0; cols < Grid.GetLength(1); cols++)
            {
                string checkEqualNUmbers = Grid[0, cols];// the first element to compare to
                bool allMatched = true;

                for (int rows = 0; rows < Grid.GetLength(0); rows++)
                {
                    if (Grid[rows, cols] != checkEqualNUmbers || checkEqualNUmbers == " _ ")
                    {
                        allMatched = false;
                        break;
                    }
                }
                if (allMatched)
                {
                    Console.WriteLine("The player has won"); // testing purposes:works when matched 
                    return true;
                }
            }
            return false;
        }

        public static bool CheckForTopLeftDiagonalWin(string[,] Grid)
        {
            string firstDiagonalValue = Grid[0, 0];
            bool allDiagonalMatch = true;

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                if (Grid[i, i] != firstDiagonalValue || firstDiagonalValue == " _ ")
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

        public static bool CheckTopRightDiagonalWin(string[,] Grid)
        {
            string firstDiagValue = Grid[0, Grid.GetLength(1) - 1]; // top-right element 
            bool allDiagMatch = true;

            for (int i = 0; i < Grid.GetLength(0); i++)// loop through diagonal
            {
                if (Grid[i, Grid.GetLength(1) - 1 - i] != firstDiagValue || firstDiagValue == " _ ")
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

        //------------------ WinCheck ------------------
        public static bool CheckingForGameWin(string winnerSymbol)
        {

            if (winnerSymbol == GameConstants.PLAYERCHOICE_X)
            {
                Console.WriteLine($"{winnerSymbol} has won");
                return true;
            }
            if (winnerSymbol == GameConstants.PLAYERCHOICE_O)
            {
                Console.WriteLine($"{winnerSymbol} has won");
                return true;
            }

            Console.WriteLine("The game is a Tie");
            return false;// if there are no winnner
        }

        // this method checks for win


        public static bool CheckForWin(string[,] Grid, string decidePlayerSymbol)
        {
            return CheckForRowWin(Grid) || CheckForColumnsWin(Grid) || CheckForTopLeftDiagonalWin(Grid)
                    || CheckTopRightDiagonalWin(Grid) || CheckForCenterLineWin(Grid);
        }

        // The method checks if all the spaces are filled and the is not declared winner 
        // this will be set to false during the game, when it becomes true then the game will restart with no winners 
        public static bool CheckingIfAllSpacesFilled(string[,] Grid) // will be used for a the Program "while" loop
        {
            for (int rows = 0; rows < Grid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < Grid.GetLength(1); cols++)
                {
                    if (Grid[rows, cols] != GameConstants.PLAYERCHOICE_O && Grid[rows, cols] != GameConstants.PLAYERCHOICE_X) // checks to see if the grid is filled with x's and o's
                    {
                        return false; // found and empty space grid not full yet
                    }
                }
            }

            Console.WriteLine("The Game is a Tie");
            return true; // grid is full
        }
        //-------------------------------------------------------------------------------


        public static void PreventOverrideOfMarks(string[,] Grid, int rowNum, int colsNum, string playerSymbol, string playerSymbol2) // this will use the updated game grid 
        {
            while (Grid[rowNum, colsNum] == playerSymbol || Grid[rowNum, colsNum] == playerSymbol2) // whether human player or CPU entry
            {
                Console.WriteLine("This space is already occupied, PLease select another space");

                int newEntry = UiMethods.ValidatePlayerInputIntoGrid(); // this will deal with selecting number to the grid

                rowNum = (newEntry - 1) / Grid.GetLength(1);
                colsNum = (newEntry - 1) % Grid.GetLength(1);
            }
        }


        //---------------------------------------
        public static void CpuWinGameChecks(string[,] Grid)
        {
            // Checking for win conditions after the cpu's move
            CheckForRowWin(Grid);
            CheckForCenterLineWin(Grid);
            CheckForColumnsWin(Grid);
            CheckForTopLeftDiagonalWin(Grid);
            CheckTopRightDiagonalWin(Grid);
        }

        public static void PlayerWinGameCheck(string[,] Grid)
        {
            // Checking for win conditions after the Player's move
            CheckForRowWin(Grid);
            CheckForCenterLineWin(Grid);
            CheckForColumnsWin(Grid);
            CheckForTopLeftDiagonalWin(Grid);
            CheckTopRightDiagonalWin(Grid);
        }
    }
}




