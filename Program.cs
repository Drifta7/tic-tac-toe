using System;
using tic_tac_toe;

namespace tic_tac_toe
{
    class Program
    {// for functionality Ill leave the ticTactoe in Program class, but then will move it to the Main() function 
            public static string[,] ticTacToeGrid = new string[GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS]; // 3x3 2d grid 
        static void Main(string[] args)
        {
            UiMethods.DisplayWelcomeMessage();
            
            while (!Logic.WinGameCheck() && !Logic.AllSpacesFilled(Logic.DisplayUpdatedGameGrid(ticTacToeGrid)))
            {
                string DecidePlayerSymbol = UiMethods.DecidePlayerSymbol(); // stores the Symbol selection in a variable
                string[,] UpdatedGameGrid = Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // put this elsewhere so that it makes sense in the order of how the game is run

                bool CheckIfAllSpacesAreFilled = Logic.AllSpacesFilled(UpdatedGameGrid);

                UiMethods.DisplayTicTacToeGrid(ticTacToeGrid);// this displays the Tictactoe grid

                UiMethods.ValidatePlayerInput(ticTacToeGrid, DecidePlayerSymbol); // testing DecidePLayerSymbol() method if not change it 
                                                                                  //UiMethods.PlacingPlayerEntryOnGrid();

                Logic.DisplayUpdatedGameGrid(ticTacToeGrid); 

                Logic.ClearGridForNewInput(); // clears the grids

                Logic.CpusTurn();
                Logic.ClearGridForNewInput();

                Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

                Logic.AllSpacesFilled(UpdatedGameGrid); // the last method to be checked 

                if (CheckIfAllSpacesAreFilled)
                {
                    UiMethods.GameOverMessage();
                    break; 
                }

            }
        }
        // once the updated grid     is displayed CPU should then put it's mark into the grid //
    }

    //////////__------------------- anything above this line works correctly ---------------------------------------------////


    // Logic.SwitchPlayerAndCpuTurns(UiMethods.UserSelectedMark()); // might have to change this later the: UserSelectMark()
    // Cpu check(s) will follow

    //Logic.CheckForValidInputSymbolInGrid(ticTacToeGrid, GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS, GameConstants.PLAYERCHOICE_X, GameConstants.PLAYERCHOICE_O, playerSymbol);

    // idea! = if  the usermakr for CheckForValidInputSymbolInGrid is true then use that to switch to the other user, then test it out


    //while (true) ; // actual condition not implemented yet.

}

