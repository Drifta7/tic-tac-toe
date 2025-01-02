using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    class Logic
    {


        ///Updated Version of the Grid after Player marked on Grid/////
        public static string[,] DisplayUpdatedGameGrid(string[,] Grid)
        {
            for (int rows = 0; rows < Grid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < Grid.GetLength(1); cols++)
                {
                    Console.Write($"{Grid[rows, cols]}");
                }
                Console.WriteLine();
            }
            return Grid;
        }
        public static void ClearGridForNewInput() // should be placed under UiMethiods
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

        // this Method will check to see if the space on the grid is already occupied
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
            }
            if (Grid[rowNum, colNum] == "_") // checks where in the grid the 'placeHolder' is
            {
                Grid[rowNum, colNum] = PlayerMark; // this is line to place the player mark into the Grid (whether human or CPU)
                return false;
            }
            Console.WriteLine("Unexpected Error ");
            return true;
        }

        /// I will fix this when the other Logic Is done!!!! //////
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
                string checkPlayerMarkMatch = Grid[rows, 0]; // this checks the 1st element of the rows
                bool PlayerAllMatch = true;

                for (int cols = 0; cols < Grid.GetLength(1); cols++)
                {
                    if (Grid[rows, cols] != checkPlayerMarkMatch)
                    {
                        PlayerAllMatch = false;
                        break;
                    }
                }
                if (PlayerAllMatch) //if PLayerAllMatch is true
                {

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
        public static void CpuAI()
        {   // use a random "seed" for when there are no matches from the players mark ( namely the CPu)
            // when player selects mark place the Cpu's mark in this function for check when player has 2 makrs in a row or column ( a strategic block)
            // use call function to check if the space is not occupied 

            Random rng = new Random(); // random seed for the Cpu to place it's mark
            int cpuPlaceMarkInSpace = rng.Next(GameConstants.LOW, GameConstants.HIGH);

            RowsCheck(Logic.DisplayUpdatedGameGrid(Program.ticTacToeGrid)); // this might not work because this should be checking the " UPDATED GRID" (WIP)

            CenterLineCheck(Logic.DisplayUpdatedGameGrid(Program.ticTacToeGrid));
            ColoumnsCheck(Logic.DisplayUpdatedGameGrid(Program.ticTacToeGrid));

            TopLeftDiagonalCheck(Logic.DisplayUpdatedGameGrid(Program.ticTacToeGrid));
            TopRightDiaginalCheck(Logic.DisplayUpdatedGameGrid(Program.ticTacToeGrid));

            CheckForValidInputSymbolInGrid(Program.ticTacToeGrid, GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS, GameConstants.PLAYERCHOICE_X, GameConstants.PLAYERCHOICE_O, UiMethods.DecidePlayerSymbol());

            //if space is not occupied then put in the cpu mark on the grid
        }

    }
}