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


        public static string UserSelectMark()
        {

            string userInput = Console.ReadLine();// will use this as an argument for playerSelection() method
            return userInput;
        }
        public static void DisplayTicTacToeGrid()
        {
            //////// this is to diplay the tic-tac-toe grid//////////////////////////
            string[,] ticTacToeGrid = new string[GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS]; // 3x3 2d grid //use this for to display the chart

            for (int rows = 0; rows < ticTacToeGrid.GetLength(0); rows++) // this is for 
            {
                for (int cols = 0; cols < ticTacToeGrid.GetLength(1); cols++)
                {
                    Console.Write(ticTacToeGrid[rows, cols] = " - ");
                }
                Console.WriteLine();
            }
        }


        public static void ClearGridForNewInput()
        {
            Console.Clear();
            Console.WriteLine("Please hit Enter To Continue......");
            Console.ReadKey();

        }// clears grid
        public static string DecidePlayerSymbol()  // this prompts the user to select the mark: X or O
        {
            bool isTheSelectionValid = false;
            string PlayerEntryCheck = UiMethods.UserSelectMark();

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
                    PlayerEntryCheck = UiMethods.UserSelectMark();
                }
            }
            while (!isTheSelectionValid);
            
            return PlayerEntryCheck;
        }

        // this method should be established as when the user has put in their mark
        // and also when the user and the computer switch turns

        public static string switchPlayerTurnAndCpu(string userInput) //rewrite this over and make it make sense 
        {

            bool playerTurnSwitch = false; // put this into a while loop then figure out the logical flow or soemthing
            if (userInput == GameConstants.PLAYERCHOICE_X)
            {
                playerTurnSwitch = true;
                Console.WriteLine("It is the Player 2 turn");
            }
            else if (userInput != "x")
            {
                Console.WriteLine("it is the Computer's turn");
            }

            return userInput;
        }


        public static void PlacingPlayerEntryOnGrid() // this might have to replace the PlayerMarkPositionOnGrid() method 
        {
            Random rng = new Random(); // random seed
            int gridRange = rng.Next(GameConstants.LOW, GameConstants.HIGH);// this determines the range of the grid positions

            Console.WriteLine("Place your mark in the grid, use a value between 1-9"); // prompt the user to enter number for grid

            string placePlayerPosition = Console.ReadLine(); // user enters position on gamegrid
            bool isTheEntryWithinRange = false;

            do
            {
                if (int.TryParse(placePlayerPosition, out gridRange)) // this will catch the Player input to see if the input is in range 
                {
                    if (gridRange >= GameConstants.LOW && gridRange <= GameConstants.HIGH)
                    {
                        Console.WriteLine("Entry is within range ,space has been selected ");
                        isTheEntryWithinRange = true;
                    }
                    else
                        Console.WriteLine("this is not within the range of the grid, please try again");
                    placePlayerPosition = Console.ReadLine();
                }

            } while (!isTheEntryWithinRange);

        }


        //////// Method checks///////
        /// <summary>
        ///  This is to Check for Validation for player Entry in the Grid for TicTacToeDisplay
        /// </summary>
        /// <param name="Grid">Enter a string array</param>
        /// <param name="rowNum">Enter the NUMBEROFROWS from GameConstants</param>
        /// <param name="colNum">Enter the NUMBERORCOLOUMNS from GameConstants</param>
        /// <param name="Playersymbol"> Enter PLAYERCHOICE_X</param>
        /// <param name="Playersymbol2">Enter PLAYERCHOICE_O</param>
        /// <param name="PlayerMark"> Enter DecidePlayerSymbol() method</param>


        // this Function will check to see if the space on the grid is already occupi
        public static void CheckForValidInputSymbolInGrid(string[,] Grid, int rowNum, int colNum, string Playersymbol, string Playersymbol2, string PlayerMark)
        {

            if (Grid[rowNum, colNum] == Playersymbol || Grid[rowNum, colNum] == Playersymbol2) // checks if the space is valid for playerMark entry 
            {
                Console.WriteLine("this space is already occupied, Please select another");
            }
            else
            {
                Grid[rowNum, colNum] = PlayerMark; // this is line is to place the player mark into the Grid
            }
        }

        public static void CpuAI()
        {   // use a random "seed" for when there are no matches from the players mark
            // when player selects mark place the Cpu's mark in this function for check when player has 2 makrs in a row or column ( a block)
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
        ////////////////////////////////////////////////////////////////////////
        public static int winGameCheck()
        {
            throw new NotImplementedException();
            // this will check if the user or the computer has won
            // if (user or computer )
        }



    }
}

