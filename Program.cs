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

            UiMethods.DisplayTicTacToeGrid();

           

            UiMethods.switchPlayerTurnAndCpu(UiMethods.UserSelectMark()); // might have to change this later the: UserSelectMark()
            UiMethods.ClearGridForNewInput(); // clears the grids

            //UiMethods.PlayerMarkPositionOnGrid(DisplayTicTacToeGrid, playerSymbol); // the ticTacToeGridarray passes into the GridPositions() to substitute the "player mark" for the "-"

            string[,] TicTacToeSecondGrid;
            TicTacToeSecondGrid = new string[GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS];

            for (int rows = 0; rows < TicTacToeSecondGrid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < TicTacToeSecondGrid.GetLength(1); cols++)
                {
                    //Console.WriteLine((TicTacToeSecondGrid[rows,cols]= )); // in this line get reference from methos and store in a variable then put into this line 
                }
                Console.WriteLine();
            }


            // while () ;

            /// think about if this needs to be in a nested for loop or something else

        }
    }
}
