using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the title of the application
            Console.WriteLine("PICK A NUMBER!\nPick the correct number between 1 and 10 to win!");

            //This method starts the number game
            RandomNumberGame();

            //This runs after the 'esc' key is pressed and the RandomNumberGame() method returns control to the Main method
            //Environment.Exit(0);
            return;
        }

        public static void RandomNumberGame()
        {
            // This initializes the random number using the GetRandomNum() method
            int randomNum = GetRandomNum();
            // This compares the user's guess against the random number
            CompareNum(randomNum);

            //This code runs only after the number guessed is correct
            Console.WriteLine("\nCongratulations!\nPress the 'Enter' key to play again.\nPress the 'esc' key to close.");
            Console.ResetColor();

            while (true)
            {
                Console.ReadKey();
                EscEnter();
            }
        }

        // This method reads the user's input and makes sure that it is a valid integer between 1 and 10
        public static int GetUserNum()
        {
            int userNum = 0;
            Console.WriteLine("\nEnter your number here: ");

            // This try-catch ensures that the user's input will be the correct format of an integer
            try
            {
                userNum = int.Parse(Console.ReadLine());

                // This if-else-if statement ensures that the user's guess is between 1 and 10
                {
                    if (userNum < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("The number you entered is less than 1. Try again!");
                        Console.ResetColor();
                        GetUserNum();
                    }
                    else if (userNum > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("The number you entered is more than 10. Try again!");
                        Console.ResetColor();
                        GetUserNum();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nThe following error has occured: \"{0}\"\nTry again, retard!", ex.Message);
                Console.ResetColor();
                GetUserNum();
            }

            return userNum;
        }

        // This method creates a random number between 1 and 10 using an instance of the System.Random class
        public static int GetRandomNum(int min = 1, int max = 10)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static void CompareNum(int random)
        {
            //Initialize the user's integer guess variable by using the GetUserNum() method
            int userNum = GetUserNum();
            //This if-else statement compares the user's input against the random number and displays the results
            if (userNum == random)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The number you picked is correct! You're straight!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The number you picked is incorrect, so you're probably gay. Try again!");
                Console.ResetColor();
                CompareNum(random);
            }
        }

        static void EscEnter()
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("PICK A NUMBER!\nPick the correct number between 1 and 10 to win!");
                RandomNumberGame();
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                Environment.Exit(0);
            else
                return;
        }
    }
}