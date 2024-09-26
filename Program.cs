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
            
         

            UI_Methods.playerSelection(PLAYER_CHOICE_X );

        }
    }
}
