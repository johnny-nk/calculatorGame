

using static ConsoleApp2.Models.Game;

namespace ConsoleApp2
{
    internal class GameEngine
    {
        internal void Division(string msg)
        {
            Console.WriteLine(msg);
            var score = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine(msg);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("You are correct! Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 2)
                {
                    Console.WriteLine($"Game over. You scored {score} points. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void Multiplication(string msg)
        {
            Console.WriteLine(msg);
            var score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 3; i++)
            {

                Console.Clear();
                Console.WriteLine(msg);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("You are correct! Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 2)
                {
                    Console.WriteLine($"Game over. You scored {score} points. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void Subtraction(string msg)   
        {
            Console.WriteLine(msg);
            var score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 3; i++)
            {

                Console.Clear();
                Console.WriteLine(msg);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("You are correct! Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 2)
                {
                    Console.WriteLine($"Game over. You scored {score} points. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Subtraction);
        }
        internal void Addition(string msg)
        {
            Console.WriteLine(msg);
            var score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 3; i++)
            {

                Console.Clear();
                Console.WriteLine(msg);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("You are correct! Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 2)
                {
                    Console.WriteLine($"Game over. You scored {score} points. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Addition);
        }






    }
}
