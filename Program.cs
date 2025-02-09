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
            bool nobodyHasWonTheGameCheck = false; // this has to be a global bool for the while loop

            string cpuMark; // used for save for cpu mark for DecidePlayersymbol.

            string decidePlayerSymbol = UiMethods.DecidePlayerSymbol(out cpuMark); // stores the Symbol selection in a variable, and will select opposite of player choice 
            string[,] updatedGameGrid = UiMethods.DisplayTicTacToeGrid(ticTacToeGrid); // this displays the grid


            // might have to change the it just to DecidePLayerSymbol
            //string ValidatePLayerMark = UiMethods.ValidatePlayerInputIntoGrid(decidePlayerSymbol, ticTacToeGrid); //<----- check if this deciced the CPu mark

            UiMethods.CpuTurnMessage(cpuMark);
            Console.WriteLine($"DEBUG: CPU Mark is {cpuMark}");
            Console.WriteLine("Before CPU places its mark");
            Logic.DisplayUpdatedGameGrid(ticTacToeGrid);



            Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

            Console.WriteLine("DEBUG: CPU is making it's move....");
            Logic.CheckForEmptySpaceToPutCpuMark(ticTacToeGrid, cpuMark);

            Logic.DisplayUpdatedGameGrid(ticTacToeGrid);
            UiMethods.ValidatePlayerInputIntoGrid(decidePlayerSymbol, ticTacToeGrid);

            Logic.CheckForEmptySpaceToPutCpuMark(updatedGameGrid, cpuMark);
            Logic.DisplayUpdatedGameGrid(ticTacToeGrid);


            // use this for the save variable for CPu entry  
            //string CpuMarkCheck = Logic.CpuCheck((ticTacToeGrid), decidePlayerSymbol);

            // while (!Logic.WinGameCheck(decidePlayerSymbol) && !Logic.allSpacesFilled(ticTacToeGrid) || !NobodyHasWonTheGameCheck)
            //}

            //bool checkIfAllSpacesAreFilled = Logic.allSpacesFilled(Logic.DisplayUpdatedGameGrid(ticTacToeGrid)); // this is what the places the user mark on the grid and displays it

            //UiMethods.DisplayTicTacToeGrid(Logic.DisplayUpdatedGameGrid(ticTacToeGrid));// this displays the Tictactoe grid

            //Logic.CheckForEmptySpaceToPutCpuMark(updatedGameGrid, decidePlayerSymbol);// pass the tuple into this so that cpu can input into the grid.//******8*************
            //Logic.CpusTurn(Logic.DisplayUpdatedGameGrid(ticTacToeGrid));

            //UiMethods.PlacingPlayerSelectedEntryOnGrid(); // the missing link?


            // next instructions is to Clear the screen, then either put Cpu entry or something//

            //_---_---____------everything above this line is working correctly with the exception of the "game is a Tie" bug_---_-_-_-____-------//////

            Logic.CpusTurn(updatedGameGrid);


            UiMethods.ValidatePlayerInputIntoGrid(decidePlayerSymbol, ticTacToeGrid); // testing DecidePLayerSymbol() method if not change it 
            Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // testing out placement of this method

            //UiMethods.PlacingPlayerSelectedEntryOnGrid(); //user enters the position on the grid
            Logic.PlayerWinCheck(ticTacToeGrid);// checks what where the player mark Matches

            Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // shows whats on the grid
            UiMethods.PromptUserToClearScreen(); // clears the grids

            Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // displays current game0
            Logic.CpusTurn(ticTacToeGrid);// cpu places mark

            UiMethods.PromptUserToClearScreen();
            Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

            Logic.allSpacesFilled(updatedGameGrid); // the last method to be checked 

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

