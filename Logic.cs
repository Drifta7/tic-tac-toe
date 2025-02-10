using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    class Logic
    {

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



        //////// Method checks///////
        /// <summary>
        ///  Checks for spaces on the grid that is already occupied on the TicTacToeDisplay.
        /// </summary>
        /// <param name="Grid">Enter a string array</param>
        /// <param name="rowNum">Enter the NUMBEROFROWS from GameConstants</param>
        /// <param name="colNum">Enter the NUMBERORCOLOUMNS from GameConstants</param>
        /// <param name="Playersymbol"> Enter PLAYERCHOICE_X</param>
        /// <param name="Playersymbol2">Enter PLAYERCHOICE_O</param>
        /// <param name="PlayerMark"> Enter DecidePlayerSymbol() method</param>

        // this Method will check to see if the space on the grid is already occupied || Note this most likely will be used by the CPU
        public static bool CheckForValidInputSymbolInGrid(string[,] Grid, int rowNum, int colNum, string Playersymbol, string Playersymbol2, string PlayerMark) // (originally void) boolean was already set to true
        {
            // this check that the userInput is in bounds of the Grid anything outside will cause an error
            if (rowNum < 0 || rowNum >= Grid.GetLength(0) || colNum < 0 || colNum >= Grid.GetLength(1))
            {
                Console.WriteLine("Invaild Position, Please select a vaild position");
                return true;
            }

            if (Grid[rowNum, colNum] == Playersymbol || Grid[rowNum, colNum] == Playersymbol2) // checks if the space is valid for playerMark entry 
            {
                Console.WriteLine("this space is already occupied, Please select another");
                //enter player input here not sure what exactly ???
            }
            if (Grid[rowNum, colNum] == " _ ") // checks where in the grid the 'placeHolder' is
            {
                Grid[rowNum, colNum] = PlayerMark; // this is line to place the player mark into the Grid (whether human or CPU) more so cpu
                return false;
            }
            Console.WriteLine("Unexpected Error ");
            return true;
        }
        // this checks if there is an empty space on the grid the Cpu will input its mark on it
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
            DisplayUpdatedGameGrid(Grid);
        }


        /////////////////////////////////Checks for Player Or Cpu Position///////////////////////////////////////
        public static void CheckForRowWin(string[,] Grid)
        {
            for (int rows = 0; rows < Grid.GetLength(0); rows++)
            {
                string checkPlayerMarkMatch = Grid[rows, 0]; // this checks the 1st element of the rows
                bool PlayerAllRowMatch = true;

                for (int cols = 0; cols < Grid.GetLength(1); cols++)
                {
                    if (Grid[rows, cols] != checkPlayerMarkMatch || checkPlayerMarkMatch == " _ ")
                    {
                        PlayerAllRowMatch = false;
                        break;
                    }
                }
                
                if (PlayerAllRowMatch) //if PLayerAllMatch is true
                {
                    WinGameCheck(checkPlayerMarkMatch);
                }
            }
        }

        public static void CheckForCenterLineWin(string[,] Grid)
        {
            string firstCenterValue = Grid[0, 1];
            bool CenterArrayMatches = true;

            for (int i = 0; i < Grid.GetLength(1); i++)
            {
                if (Grid[1, i] != firstCenterValue || firstCenterValue == " _ ")
                {
                    CenterArrayMatches = false;
                    break;
                }
            }
            if (CenterArrayMatches)
            {
                WinGameCheck(firstCenterValue);
            }
        }

        public static void CheckForColumnsWin(string[,] Grid)
        {
            for (int cols = 0; cols < Grid.GetLength(0); cols++)
            {
                string checkEqualNUmbers = Grid[0, cols];// the first element to compare to
                bool allMatched = true;

                for (int rows = 0; rows < Grid.GetLength(1); rows++)
                {
                    if (Grid[rows, cols] != checkEqualNUmbers || checkEqualNUmbers == " _ ")
                    {
                        allMatched = false;
                        break;
                    }
                }
                if (allMatched)
                {
                    WinGameCheck(checkEqualNUmbers);
                }
            }
        }

        public static void CheckForTopLeftDiagonalWin(string[,] Grid)
        {
            string firstDiagonalValue = Grid[0, 0]; // change into an int
            bool allDiagonalMatch = true;

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                if (Grid[i, i] != firstDiagonalValue || firstDiagonalValue == " _ ")
                {
                    allDiagonalMatch = false;
                    break;
                }
            }
            if (allDiagonalMatch)
            {
                WinGameCheck(firstDiagonalValue);
            }
        }

        public static void CheckTopRightDiagonalWin(string[,] Grid)
        {
            string firstDiagValue = Grid[0, Grid.GetLength(1) - 1];
            bool allDiagMatch = true;

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                if (Grid[i, Grid.GetLength(1) - 1 - i] != firstDiagValue || firstDiagValue == " _ ")
                {
                    allDiagMatch = false;
                    break;
                }

            }
            if (allDiagMatch)
            {
                WinGameCheck(firstDiagValue);
            }
        }
        //------------------ WinCheck ------------------
        public static bool WinGameCheck(string winnerSymbol)
        {
            bool winnerIsFound = false;
            if (winnerSymbol == GameConstants.PLAYERCHOICE_X)
            {
                Console.WriteLine($"{winnerSymbol} has won");
                winnerIsFound = true;
            }
            if (winnerSymbol == GameConstants.PLAYERCHOICE_O)
            {
                Console.WriteLine($"{winnerSymbol}... Please Try again");
                winnerIsFound = true;
            }
            else
            {
                Console.WriteLine("The game is a Tie");
            }
            return winnerIsFound;
            //throw new NotImplementedException();
            // this will check if the user or the computer has won
            // if (user or computer )

        }

        // The method checks if all the spaces are filled and the is not declared winner 
        // this will be set to false during the game, when it becomes true then the game will restart with no winners 
        public static bool allSpacesFilled(string[,] Grid) // will be used for a the Program "while" loop
        {
            string GridSpace = " _ ";
            bool blankspaceLeft = false;

            for (int rows = 0; rows < Grid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < Grid.GetLength(1); cols++)
                {
                    if (Grid[rows, cols] != GridSpace)
                    {
                        blankspaceLeft = true;
                        break;
                    }
                    if (blankspaceLeft)
                        break; //  break out of the outer loop
                }

                if (!blankspaceLeft)
                {
                    Console.WriteLine("The Game is a Tie");
                }
            }
            return !blankspaceLeft;
        }
        //-------------------------------------------------------------------------------


        public static void PreventOverrideOfMarks(string[,] Grid, int rowNum, int colsNum, string playerSymbol, string playerSymbol2) // this will use the updated game grid 
        {
            while (Grid[rowNum, colsNum] == playerSymbol || Grid[rowNum, colsNum] == playerSymbol2) // whether human player or CPU entry
            {
                Console.WriteLine("This space is already occupied, PLease select another space");

                int newEntry = UiMethods.PlacingPlayerSelectedEntryOnGrid(); // this will deal with selecting number to the grid

                rowNum = (newEntry - 1) / Grid.GetLength(1);
                colsNum = (newEntry - 1) % Grid.GetLength(1);
            }
        }


        //---------------------------------------
        public static void CpuWinGameChecks(string[,] Grid)
        {
            // Checking for win condition after the cpu's move
            CheckForRowWin(Grid);
            CheckForCenterLineWin(Grid);
            CheckForColumnsWin(Grid);
            CheckForTopLeftDiagonalWin(Grid);
            CheckTopRightDiagonalWin(Grid);
        }

        public static void PlayerWinGameCheck(string[,] Grid)
        {
            // Checking for win condition after the Player's move
            CheckForRowWin(Grid);
            CheckForCenterLineWin(Grid);
            CheckForColumnsWin(Grid);
            CheckForTopLeftDiagonalWin(Grid);
            CheckTopRightDiagonalWin(Grid);
        }
    }
}




