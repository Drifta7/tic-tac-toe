using System;
using tic_tac_toe;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            UI_Methods.DisplayWelcomeMessage();

            string playerSymbol = UI_Methods.DecidePlayerSymbol();// stores the Symbol selection in a variable

            

            //////// this is to diplay the tic-tac-toe grid//////////////////////////
            string[,] ticTacToeGrid = new string[GameConstants.NUMBER_OF_ROWS, GameConstants.NUMBER_OF_COLUMNS]; // 3x3 2d grid //use this for to display the chart

            for (int rows = 0; rows < ticTacToeGrid.GetLength(0); rows++) // this is for 
            {
                for (int cols = 0; cols < ticTacToeGrid.GetLength(1); cols++)
                {
                    Console.Write((ticTacToeGrid[rows, cols] = " - ") + "");
                }
                Console.WriteLine();
            }
           
            UI_Methods.switchPlayerTurnAndCpu(UI_Methods.UserSelectMark()); // might have to change this later the: UserSelectMark()
            UI_Methods.ClearGridForNewInput(); // clears the grids
            
            UI_Methods.GridPositions(ticTacToeGrid); // the ticTacToeGridarray passes into the GridPositions() to substitute the "player mark" for the "-"
            
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
            int playerMarker;
            int cpuMarker;
            bool isPlayerTurn = false;

           // while () ;

            /// think about if this needs to be in a nested for loop or something else
            
        }
    }
}
