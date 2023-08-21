using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math game");
            Console.WriteLine("\n");

            bool isGameOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine($@"What would you like play: 
        V - View Previous games
        A - Addition game
        S - Subtraction game 
        M - Multiplication game 
        D - Division game 
        Q - Quit the program");
                Console.WriteLine("--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

                var selection = Console.ReadLine();

                switch (selection.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        engine.Addition("Addition selected.");
                        break;
                    case "s":
                        engine.Subtraction("Subtractiong selected.");
                        break;
                    case "m":
                        
                        engine.Multiplication("Multiplication selected.");
                        break;
                    case "d":
                        engine.Division("Division selected");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye.");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (isGameOn == true);
        }


    }
}
