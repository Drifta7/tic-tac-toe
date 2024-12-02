using System;
using tic_tac_toe;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            UiMethods.DisplayWelcomeMessage();

            string playerSymbol = UiMethods.DecidePlayerSymbol();// stores the Symbol selection in a variable

            do
            {
                Logic.DisplayTicTacToeGrid();

                UiMethods.PlacingPlayerEntryOnGrid();

                Logic.SwitchPlayerAndCpuTurns(UiMethods.UserSelectedMark()); // might have to change this later the: UserSelectMark()
                                                                           // Cpu check(s) will follow

                Logic.CheckForValidInputSymbolInGrid(Logic.DisplayTicTacToeGrid(),GameConstants.NUMBER_OF_ROWS,GameConstants.NUMBER_OF_COLUMNS,GameConstants.PLAYERCHOICE_X,GameConstants.PLAYERCHOICE_O,UiMethods.DecidePlayerSymbol());

                Logic.ClearGridForNewInput(); // clears the grids

            }
            while (true); // actual condition not implemented yet.

        }
    }
}
