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

                UiMethods.DisplayTicTacToeGrid();

                // place here the function when the player selects the a spot on the grid

                UiMethods.switchPlayerTurnAndCpu(UiMethods.UserSelectMark()); // might have to change this later the: UserSelectMark()
                 // Cpu check(s) will follow

                UiMethods.ClearGridForNewInput(); // clears the grids
            }
            while (true); // actual condition not implemented yet

          


        }
    }
}
