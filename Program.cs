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
            bool nobodyHasWonTheGameCheck = false; // This set to false if the AllSpaces are filled true then this will trigger


            string cpuMark; // used for save for cpu mark for DecidePlayersymbol.
            string decidePlayerSymbol = UiMethods.DecidePlayerSymbol(out cpuMark); // stores the Symbol selection in a variable, and will select opposite of player choice 

            while (!Logic.WinGameCheck(decidePlayerSymbol) && !Logic.allSpacesFilled(ticTacToeGrid) || !nobodyHasWonTheGameCheck)
            {
                UiMethods.DisplayTicTacToeGrid(ticTacToeGrid); // this displays the grid

                UiMethods.ValidatePlayerInputIntoGrid(decidePlayerSymbol, ticTacToeGrid);
                UiMethods.DisplayTicTacToeGrid(ticTacToeGrid);

                UiMethods.CpuTurnMessage(cpuMark);
                Logic.PlacingCpuMarkOnGrid(ticTacToeGrid, cpuMark);
                Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

                Logic.CpuWinGameChecks(ticTacToeGrid);
                Logic.PlayerWinGameCheck(ticTacToeGrid);

                Logic.allSpacesFilled(ticTacToeGrid);

                UiMethods.PromptUserToClearScreen();
            }

            //bool checkIfAllSpacesAreFilled = Logic.allSpacesFilled(Logic.DisplayUpdatedGameGrid(ticTacToeGrid)); // this is what the places the user mark on the grid and displays it








            //_---_---____------everything above this line is working correctly with the exception of the "game is a Tie" bug_---_-_-_-____-------//////

            Logic.CpuWinGameChecks(ticTacToeGrid);


            UiMethods.ValidatePlayerInputIntoGrid(decidePlayerSymbol, ticTacToeGrid); // testing DecidePLayerSymbol() method if not change it 
            Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // testing out placement of this method

            //UiMethods.PlacingPlayerSelectedEntryOnGrid(); //user enters the position on the grid
            Logic.PlayerWinGameCheck(ticTacToeGrid);// checks what where the player mark Matches

            Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // shows whats on the grid
            UiMethods.PromptUserToClearScreen(); // clears the grids

            Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // displays current game
            Logic.CpuWinGameChecks(ticTacToeGrid);// cpu places mark

            UiMethods.PromptUserToClearScreen();
            Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

            // the last method to be checked 

            //if (checkIfAllSpacesAreFilled)
            //{
            //    UiMethods.GameOverMessage();
            //    //break;
            //}

            //}
        }

        // once the updated grid     is displayed CPU should then put it's mark into the grid //
    }

    //////////__------------------- anything above this line works correctly ---------------------------------------------////


    // Logic.SwitchPlayerAndCpuTurns(UiMethods.UserSelectedMark()); // might have to change this later the: UserSelectMark()
    // Cpu check(s) will follow

    //Logic.CheckForValidInputSymbolInGrid(ticTacToeGrid, GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS, GameConstants.PLAYERCHOICE_X, GameConstants.PLAYERCHOICE_O, playerSymbol);

    // idea! = if  the usermakr for CheckForValidInputSymbolInGrid is true then use that to switch to the other user, then test it out




}

