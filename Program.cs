using System;
using tic_tac_toe;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PLAYER_CHOICE_X = "x";
            const string PLayer_CHOICE_O = "o";
            UI_Methods.DisplayWelcomeMessage();

            UI_Methods.playerSelection(UI_Methods.userInput);

            //////// this is to diplay the tic-tac-toe grid//////////////////////////
            string[,] ticTacToeGrid = new string[gameConstants.NUMBER_OF_ROWS, gameConstants.NUMBER_OF_COLUMNS]; // 3x3 2d grid //use this for to display the chart

            for (int rows = 0; rows < ticTacToeGrid.GetLength(0); rows++) // this is for 
            {
                for (int cols = 0; cols < ticTacToeGrid.GetLength(1); cols++)
                {
                    Console.Write((ticTacToeGrid[rows, cols] = " - ") + "");
                }
                Console.WriteLine();
            }
           
            UI_Methods.clearGridForNewInput(); // clears the grids
            
            string[,] secondGrid;
            secondGrid = new string[gameConstants.NUMBER_OF_ROWS, gameConstants.NUMBER_OF_COLUMNS];
            /// think about if this needs to be in a nested for loop or something else
        }
    }
}
