using System;
using tic_tac_toe;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ticTacToeGrid = new string[GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS]; // 3x3 2d grid

            UiMethods.DisplayWelcomeMessage();
            bool nobodyHasWonTheGameCheck = false;
            bool hasAllTheSpacesBeenFilled = Logic.CheckingIfAllSpacesFilled(ticTacToeGrid);

            string cpuMark; // used for save for cpu mark for DecidePlayersymbol.
            string decidePlayerSymbol = UiMethods.DecidePlayerSymbol(out cpuMark); // stores the Symbol selection in a variable, and will select opposite of player choice

            bool isWin = Logic.CheckForWin(ticTacToeGrid, decidePlayerSymbol);

            UiMethods.DisplayTicTacToeGrid(ticTacToeGrid); // this displays the grid (as a blank) 

            while (!nobodyHasWonTheGameCheck || !isWin)
            {
                //player's turn
                UiMethods.PlacingUserMarkIntoGrid(decidePlayerSymbol, ticTacToeGrid); 
                UiMethods.DisplayUpdatedGameGrid(ticTacToeGrid); 

                isWin = Logic.CheckForWin(ticTacToeGrid, decidePlayerSymbol); //  Check for win after User move 

                if (isWin)
                {
                    UiMethods.DisplaySymbolOfWinnerMessage(decidePlayerSymbol);
                    break;
                }
                hasAllTheSpacesBeenFilled = Logic.CheckingIfAllSpacesFilled(ticTacToeGrid);
                if (hasAllTheSpacesBeenFilled)
                {
                    UiMethods.DisplayGameOverMessage();
                    break;
                }

                // Cpu's Turn
                UiMethods.DisplayCpuTurnsMessage(cpuMark); 

                Logic.PlacingCpuMarkOnGrid(ticTacToeGrid, cpuMark); 
                UiMethods.DisplayUpdatedGameGrid(ticTacToeGrid); 

                Logic.CheckForWin(ticTacToeGrid, decidePlayerSymbol);

                isWin = Logic.CheckForWin(ticTacToeGrid, cpuMark); // check for wins after CPU move

                if (isWin)
                {
                    UiMethods.DisplaySymbolOfWinnerMessage(cpuMark);
                    break; 
                }

                if (hasAllTheSpacesBeenFilled) // might have to update
                {
                    UiMethods.DisplayGameOverMessage();
                    break;
                }

                if (Logic.CheckingIfAllSpacesFilled(ticTacToeGrid))
                {
                    UiMethods.DisplayGameTieMessage();
                }
            }
            
            UiMethods.PromptUserToClearScreen();
        }
    }
}










