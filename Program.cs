using System;
using tic_tac_toe;

namespace tic_tac_toe
{
    class Program
    {// for functionality Ill leave the ticTactoe in Program class, but then will move it to the Main() function 
        static void Main(string[] args)
        {
                string[,] ticTacToeGrid = new string[GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS]; // 3x3 2d grid 
            UiMethods.DisplayWelcomeMessage();
            bool NobodyHasWonTheGameCheck = false; // this has to be a global bool for the while loop

            // might have to change the it just to DecidePLayerSymbol
            string ValidatePLayerMark = UiMethods.ValidatePlayerInput(Logic.DisplayUpdatedGameGrid(ticTacToeGrid), UiMethods.DecidePlayerSymbol()); // change userselect to DecidePLayerSymbol

            // use this for the save variable for CPu entry 
            string CpuMarkCheck = Logic.CpuCheck(Logic.DisplayUpdatedGameGrid(ticTacToeGrid), UiMethods.DecidePlayerSymbol());

            while (!Logic.WinGameCheck() && !Logic.AllSpacesFilled(Logic.DisplayUpdatedGameGrid(ticTacToeGrid)) || !NobodyHasWonTheGameCheck)
            {
                string DecidePlayerSymbol = UiMethods.DecidePlayerSymbol(); // stores the Symbol selection in a variable
                string[,] UpdatedGameGrid = Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // NOTE: put this elsewhere so that it makes sense in the order of how the game is run



                bool CheckIfAllSpacesAreFilled = Logic.AllSpacesFilled(UpdatedGameGrid);

                UiMethods.DisplayTicTacToeGrid(ticTacToeGrid);// this displays the Tictactoe grid

                UiMethods.ValidatePlayerInput(ticTacToeGrid, DecidePlayerSymbol); // testing DecidePLayerSymbol() method if not change it 
                                                                                  //UiMethods.PlacingPlayerEntryOnGrid();

                Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

                Logic.ClearGridForNewInput(); // clears the grids

                Logic.CpusTurn(ticTacToeGrid);
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

