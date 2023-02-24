/******************************************************************************
* PROGRAM CS FILE
******************************************************************************/


/*********************************
* PROGRAM CLASS 
* Main program
* Summary: Display a menu with 4 options to choose from
*********************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        int _userInput = 0;

        while (_userInput != 4)
        {
            /*********************************
            * DISPLAY MENU
            * Summary: Allow the user to choose an activity or simply quit the program
            *********************************/
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity \n  2. Start reflecting activity \n  3. Start listing activity \n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            _userInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (_userInput == 1)
            {
                // Class objects
                Breathing breathing = new Breathing();
                breathing.RunBreathing();
            }

            else if (_userInput == 2)
            {
                // Class objects
                Reflection reflection = new Reflection();
                reflection.RunReflection();
            }

            else if (_userInput == 3)
            {
                // Class objects
                Listing listing = new Listing();
                listing.RunListing();
            }

            else if (_userInput == 4)
            {
                break;
            }  
        }
    }
}