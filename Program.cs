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
            bool nobodyHasWonTheGameCheck = false; // This set to false if the AllSpaces are filled true then this will trigger
            bool hasAllTheSpacesBeenFilled = Logic.CheckingIfAllSpacesFilled(ticTacToeGrid);

            string cpuMark; // used for save for cpu mark for DecidePlayersymbol.
            string decidePlayerSymbol = UiMethods.DecidePlayerSymbol(out cpuMark); // stores the Symbol selection in a variable, and will select opposite of player choice 

            bool isWin = Logic.CheckForWin(ticTacToeGrid, decidePlayerSymbol);

            string winMessage = UiMethods.symbolOfWinnerMessage(decidePlayerSymbol);

            //string userInput = UiMethods.GetUserInput(); 
            //invoke a method that will validate input
            //if (!Logic.ValidateInput(userInput))
            //{
            //    Console.WriteLine("Input is not valid");
            //}

            while (!nobodyHasWonTheGameCheck || !isWin)
            {
                UiMethods.DisplayTicTacToeGrid(ticTacToeGrid); // this displays the grid (as a blank)

                UiMethods.PlacingUserMarkIntoGrid(decidePlayerSymbol, ticTacToeGrid);
                Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

                UiMethods.CpuTurnMessage(cpuMark);
                Logic.PlacingCpuMarkOnGrid(ticTacToeGrid, cpuMark);
                Logic.DisplayUpdatedGameGrid(ticTacToeGrid);


                UiMethods.PlacingUserMarkIntoGrid(decidePlayerSymbol, ticTacToeGrid);
                Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

                Logic.CpuWinGameChecks(ticTacToeGrid); // This runs all the checks for the CPU
                Logic.PlayerWinGameCheck(ticTacToeGrid);// This runs all the checks for the player

                UiMethods.CpuTurnMessage(cpuMark);
                Logic.PlacingCpuMarkOnGrid(ticTacToeGrid, cpuMark);
                Logic.DisplayUpdatedGameGrid(ticTacToeGrid);


                UiMethods.PlacingUserMarkIntoGrid(decidePlayerSymbol, ticTacToeGrid);
                Logic.DisplayUpdatedGameGrid(ticTacToeGrid);
                Logic.PlayerWinGameCheck(ticTacToeGrid);// This runs all the checks for the player

                UiMethods.CpuTurnMessage(cpuMark);
                Logic.PlacingCpuMarkOnGrid(ticTacToeGrid, cpuMark);
                Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

                Logic.CheckForWin(ticTacToeGrid, decidePlayerSymbol);

                if (isWin)
                {
                    UiMethods.symbolOfWinnerMessage(decidePlayerSymbol);
                    break; // this is for the while loop break
                }
                if (hasAllTheSpacesBeenFilled) // might have to update
                {
                    UiMethods.GameOverMessage();
                    break;
                }

                if (nobodyHasWonTheGameCheck)
                {
                    break;
                }

            }                //if (Logic.CheckingForGameWin(decidePlayerSymbol) || Logic.CheckingForGameWin(cpuMark))
                             //{
                             //    break; // exits the loop
                             //}

            //if (Logic.CheckingIfAllSpacesFilled(ticTacToeGrid)) // if this is true
            //{
            //    nobodyHasWonTheGameCheck = true;
            //    UiMethods.GameOverMessage();
            //    break; // breaks out of the loop 
            //}

            //if (isWin)
            //{
            //    UiMethods.symbolWinnerMessage(decidePlayerSymbol);
            //    //invoke the method that prints the message
            //    // which could be the message that in WinCheck
            //}
            //else
            //    continue;

            UiMethods.PromptUserToClearScreen();


        }

        //bool checkIfAllSpacesAreFilled = Logic.allSpacesFilled(Logic.DisplayUpdatedGameGrid(ticTacToeGrid)); // this is what the places the user mark on the grid and displays it








        ////_---_---____------everything above this line is working correctly with the exception of the "game is a Tie" bug_---_-_-_-____-------//////

        //Logic.CpuWinGameChecks(ticTacToeGrid);


        //UiMethods.PlacingUserMarkIntoGrid(decidePlayerSymbol, ticTacToeGrid); // testing DecidePLayerSymbol() method if not change it 
        //Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // testing out placement of this method

        ////UiMethods.PlacingPlayerSelectedEntryOnGrid(); //user enters the position on the grid
        //Logic.PlayerWinGameCheck(ticTacToeGrid);// checks what where the player mark Matches

        //Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // shows whats on the grid
        //UiMethods.PromptUserToClearScreen(); // clears the grids

        //Logic.DisplayUpdatedGameGrid(ticTacToeGrid); // displays current game
        //Logic.CpuWinGameChecks(ticTacToeGrid);// cpu places mark

        //UiMethods.PromptUserToClearScreen();
        //Logic.DisplayUpdatedGameGrid(ticTacToeGrid);

        //// the last method to be checked 

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









