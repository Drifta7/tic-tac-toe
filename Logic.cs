using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    class Logic
    {
        public static string [,] DisplayTicTacToeGrid()
        {
            //////// this is to diplay the tic-tac-toe grid//////////////////////////
            string[,] ticTacToeGrid = new string[GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS]; // 3x3 2d grid 

            for (int rows = 0; rows < ticTacToeGrid.GetLength(0); rows++) // this is for 
            {
                for (int cols = 0; cols < ticTacToeGrid.GetLength(1); cols++)
                {
                    Console.Write(ticTacToeGrid[rows, cols] = " - ");
                }
                Console.WriteLine();
            }
            return ticTacToeGrid;
        }

        public static void ClearGridForNewInput()
        {
            Console.Clear();
            Console.WriteLine("Please hit Enter To Continue......");
            Console.ReadKey();

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

        // this Function will check to see if the space on the grid is already occupied
        public static void CheckForValidInputSymbolInGrid(string[,] Grid, int rowNum, int colNum, string Playersymbol, string Playersymbol2, string PlayerMark)
        {

            if (Grid[rowNum, colNum] == Playersymbol || Grid[rowNum, colNum] == Playersymbol2) // checks if the space is valid for playerMark entry 
            {
                Console.WriteLine("this space is already occupied, Please select another");
            }
            else
            {
                Grid[rowNum, colNum] = PlayerMark; // this is line is to place the player mark into the Grid (whether human or CPU)
            }
        }

        public static string SwitchPlayerAndCpuTurns(string userInput) //rewrite this over and make it make sense 
        {

            bool playerTurnSwitch = false; // put this into a while loop then figure out the logical flow or soemthing
            
            if (userInput == GameConstants.PLAYERCHOICE_X)
            {
                playerTurnSwitch = true;
                Console.WriteLine("It is the Player 1 turn");
            }
            else if (userInput != "x")
            {
                Console.WriteLine("it is the Computer's turn");
            }

            return userInput;
        }

        /////////////////////////////////Checks for Player Position///////////////////////////////////////
        public static void RowsCheck(string[,] Grid)
        {
            for (int rows = 0; rows < Grid.GetLength(0); rows++)
            {
                string checkPlayerMarkMatch = Grid[rows, 0];
                bool PlayerAllMatch = true;

                for (int cols = 0; cols < Grid.GetLength(1); cols++)
                {
                    if (Grid[rows, cols] != checkPlayerMarkMatch)
                    {
                        PlayerAllMatch = false;
                        break;
                    }
                }
            }
        }

        public static void CenterLineCheck(string[,] Grid)
        {
            string firstCenterValue = Grid[0, 1];
            bool CenterArrayMatches = true;

            for (int i = 0; i < Grid.GetLength(1); i++)
            {
                if (Grid[1, i] != firstCenterValue)
                {
                    CenterArrayMatches = false;
                    break;
                }

            }
        }

        public static void ColoumnsCheck(string[,] Grid)
        {
            bool numberHasMatched = false;
            for (int cols = 0; cols < Grid.GetLength(0); cols++)
            {
                string checkEqualNUmbers = Grid[0, cols];// the first element to compare to
                bool allMatched = true;

                for (int rows = 0; rows < Grid.GetLength(1); rows++)
                {
                    if (Grid[rows, cols] != checkEqualNUmbers)
                    {
                        allMatched = false;
                        break;
                    }
                }
            }
        }

        public static void TopLeftDiagonalCheck(string[,] Grid)
        {
            string firstDiagonalValue = Grid[0, 0]; // change into an int
            bool allDiagonalMatch = true;

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                if (Grid[i, i] != firstDiagonalValue)
                {
                    allDiagonalMatch = false;
                    break;
                }
            }
        }

        public static void TopRightDiaginalCheck(string[,] Grid)
        {
            string firstDiagValue = Grid[0, 0];
            bool allDiagMatch = true;

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                if (Grid[i, Grid.GetLength(1) - 1 - i] != firstDiagValue)
                {
                    allDiagMatch = false;
                    break;
                }

            }

        }
    }
}