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

                UiMethods.DisplayTicTacToeGrid(ticTacToeGrid); // this displays the grid (as a blank) KEEP!

            while (!nobodyHasWonTheGameCheck || !isWin)
            {
           
                
                //player's turn
                UiMethods.PlacingUserMarkIntoGrid(decidePlayerSymbol, ticTacToeGrid); // KEEP
                Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // KEEP

                isWin = Logic.CheckForWin(ticTacToeGrid, decidePlayerSymbol); //  Check win after User move 

                if (isWin)
                {
                    UiMethods.symbolOfWinnerMessage(decidePlayerSymbol);
                    break;
                }
                hasAllTheSpacesBeenFilled = Logic.CheckingIfAllSpacesFilled(ticTacToeGrid);
                if (hasAllTheSpacesBeenFilled)
                {
                    UiMethods.GameOverMessage();
                    break;
                }

                // Cpu's Turn
                UiMethods.CpuTurnMessage(cpuMark); // KEEP

                Logic.PlacingCpuMarkOnGrid(ticTacToeGrid, cpuMark); //KEEP
                Logic.DisplayUpdatedGameGrid(ticTacToeGrid); //KEEP

                Logic.CheckForWin(ticTacToeGrid, decidePlayerSymbol);

                isWin = Logic.CheckForWin(ticTacToeGrid, cpuMark); // check for wins after CPU move

                if (isWin)
                {
                    UiMethods.symbolOfWinnerMessage(cpuMark);
                    break; // this is for the while loop break
                }

                if (hasAllTheSpacesBeenFilled) // might have to update
                {
                    UiMethods.GameOverMessage();
                    break;
                }

            }

            UiMethods.PromptUserToClearScreen();
        
        
        }
    }
}
    



       





