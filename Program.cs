using System;
using tic_tac_toe;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            // make these enums.
            const string PLAYER_CHOICE_X = "x"; // make these enums.
            const string PLayer_CHOICE_O = "o";
            UI_Methods.DisplayWelcomeMessage();

            UI_Methods.playerSelection(UI_Methods.userInput);

            string[,] ticTacToeGrid = new string[3, 3]; // 3x3 2d grid //use this for to display the chart

            for (int rows = 0; rows < ticTacToeGrid.GetLength(0); rows++)
            {
                for (int cols = 0; cols < ticTacToeGrid.GetLength(1); cols++)
                {
                    Console.Write((ticTacToeGrid[rows, cols] = " - ") + "");
                }
                Console.WriteLine();
            }



        }
    }
}
