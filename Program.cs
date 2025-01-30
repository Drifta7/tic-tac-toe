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

            string decidePlayerSymbol = UiMethods.DecidePlayerSymbol(); // stores the Symbol selection in a variable

            // might have to change the it just to DecidePLayerSymbol
            string ValidatePLayerMark = UiMethods.ValidatePlayerInputIntoGrid((ticTacToeGrid), decidePlayerSymbol); // change userselect to DecidePLayerSymbol


            // use this for the save variable for CPu entry  
            string CpuMarkCheck = Logic.CpuCheck((ticTacToeGrid), decidePlayerSymbol);

            while (!Logic.WinGameCheck(GameConstants.PLAYERCHOICE_O, GameConstants.PLAYERCHOICE_X) && !Logic.allSpacesFilled(ticTacToeGrid) || !NobodyHasWonTheGameCheck)
            {
                string[,] updatedGameGrid = Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // NOTE: put this elsewhere so that it makes sense in the order of how the game is run

                bool checkIfAllSpacesAreFilled = Logic.allSpacesFilled(updatedGameGrid);

                UiMethods.DisplayTicTacToeGrid(ticTacToeGrid);// this displays the Tictactoe grid

                UiMethods.ValidatePlayerInputIntoGrid(ticTacToeGrid, decidePlayerSymbol); // testing DecidePLayerSymbol() method if not change it 
                UiMethods.PlacingPlayerSelectedEntryOnGrid(); //user enters the position on the grid
                Logic.PlayerWinCheck(ticTacToeGrid);// checks what where the player mark Matches

                Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // shows whats on the grid
                UiMethods.PromptUserToClearScreen(); // clears the grids

                Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // displays current game0
                Logic.CpusTurn(ticTacToeGrid);// cpu places mark


                UiMethods.PromptUserToClearScreen();
                Logic.DisplayUpdatedGameGrid(ticTacToeGrid);


                Logic.allSpacesFilled(updatedGameGrid); // the last method to be checked 

                if (checkIfAllSpacesAreFilled)
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




}

