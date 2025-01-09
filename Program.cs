using System;
using tic_tac_toe;

namespace tic_tac_toe
{
    class Program
    {
        public static string[,] ticTacToeGrid = new string[GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS]; // 3x3 2d grid 
        static void Main(string[] args)
        {
            //while (!Logic.WinGameCheck() && !Logic.AllSpacesFilled(Logic.DisplayUpdatedGameGrid))
            UiMethods.DisplayWelcomeMessage();

            string playerSymbol = UiMethods.DecidePlayerSymbol();// stores the Symbol selection in a variable
            string[,] UpdatedGameGrid = Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // put this elsewhere so that it makes sense in the order of how the game is run

            UiMethods.DisplayTicTacToeGrid(ticTacToeGrid);// this displays the Tictactoe grid

            UiMethods.ValidatePlayerInput(ticTacToeGrid, playerSymbol); // testing DecidePLayerSymbol() method if not change it 
            //UiMethods.PlacingPlayerEntryOnGrid();

            Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // hopefully displays the updated grid. 
            
        
            Logic.ClearGridForNewInput(); // clears the grids

            Logic.CpuAI();

            Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

            Logic.AllSpacesFilled(UpdatedGameGrid); // the last method to be checked 

            // once the updated grid     is displayed CPU should then put it's mark into the grid //

            //////////__------------------- anything above this line works correctly ---------------------------------------------////


            // Logic.SwitchPlayerAndCpuTurns(UiMethods.UserSelectedMark()); // might have to change this later the: UserSelectMark()
            // Cpu check(s) will follow

            //Logic.CheckForValidInputSymbolInGrid(ticTacToeGrid, GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS, GameConstants.PLAYERCHOICE_X, GameConstants.PLAYERCHOICE_O, playerSymbol);

                                          // idea! = if  the usermakr for CheckForValidInputSymbolInGrid is true then use that to switch to the other user, then test it out

            if (!Logic.CheckForValidInputSymbolInGrid(UpdatedGameGrid, GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS, GameConstants.PLAYERCHOICE_X, GameConstants.PLAYERCHOICE_O, playerSymbol))
            {
                Console.WriteLine("Mark placed succesfully");
            }
            else
            {
                Console.WriteLine("Please select a different position");
            }

            while (true) ; // actual condition not implemented yet.

        }
    }
}
