using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public static class UI_Methods
    {
        public static string userInput = Console.ReadLine();// will use this as an argument for playeSelection() method
        public static string playerSelection(string userEntry)
        {
            string playerChoice_X = "x";
            string playerChoice_O = "o";

            if (userEntry == playerChoice_X) 
            {
                Console.WriteLine($"Player has selected : x");
            }
            
            if (playerChoice_O == userEntry)
            {
                Console.WriteLine("player has selected : o ");

            }
            else
                Console.WriteLine(" please select a mark");
           
            return userEntry;

        }
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to The wonderful world of Tic-Tac-Toe");
            Console.WriteLine("Choose X's or O's ");
        } // generic display message
        public static bool MakeDescision()
        {
            Console.WriteLine("do you want to continue with this whatever?");
            if (Console.ReadLine() == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public static void positionChecks()
        //{
        //    if (userEntry)
        //}
    }
}
