using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public static class UI_Methods
    {
        public static string playerSelection(string userEntry)
        {
            string playerChoice = Console.ReadLine();
            
            if (playerChoice == userEntry) // might have to change this
            {
                Console.WriteLine($"Player has selected : x");
            }
            if (playerChoice == userEntry)
            {
                Console.WriteLine("player has selected : o ");
            }
            //throw new NotImplementedException();
            return playerChoice;
        }
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to The wonderful world of Tic-Tac-Toe");
            Console.WriteLine("Choose X's or O's ");
        }
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
    }
}
