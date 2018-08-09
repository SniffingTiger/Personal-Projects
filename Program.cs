using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
            Console.ReadLine();
        }

        // Below is the main menu method
        static void MainMenu()
        {
            Console.WriteLine("Welcome to Exercise 1A for ISTA 220, Location CL2.\n\n" +
                "Input one of the following numbers in order to start the formula:\n\n" +
                "1] Area and cirumference of a circle\n" +
                "2] Volume of a hemisphere\n" +
                "3] Area of a triangle given the length of the sides\n" +
                "4] Solving a quadratic equation\n");

            int menuItem;
            menuItem = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (menuItem < 1 || menuItem > 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("The number you entered does not match any menu item. Try again!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nThe following error has occured: \"{0}\"\nTry again!", ex.Message);
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }

            switch (menuItem)
            {
                // Initiates the Area and Circumference of a circle formula
                case (1):
                    Console.Clear();
                    Console.WriteLine("Input the radius of your circle here: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    double area = CircleArea(radius);
                    double circumference = CircleCircumference(radius);

                    Console.WriteLine($"\nThe area of your circle is {area} square units.\nThe circumference of your circle is {circumference} units");

                    Console.WriteLine("\nPress any key to return to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                // Initiates the Volume of a Hemisphere formula
                case (2):
                    Console.Clear();
                    Console.WriteLine("Input the radius of your hemisphere here: ");
                    double hemisphereRadius = Convert.ToDouble(Console.ReadLine());

                    double hemisphereVolume = HemisphereVolume(hemisphereRadius);

                    Console.WriteLine($"\nThe volume of your hemisphere is {hemisphereVolume} cube units.\n");

                    Console.WriteLine("\nPress any key to return to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                // Initiates the Area of a Triangle formula
                case (3):
                    Console.Clear();
                    Console.WriteLine("You will need to input the lengths of all three sides of your triangle.\nInput side A of your triangle here: ");
                    double inputsideA = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nInput side B of your triangle here: ");
                    double inputsideB = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nInput side C of your triangle here: ");
                    double inputsideC = Convert.ToDouble(Console.ReadLine());

                    double triangleArea = TriangleArea(inputsideA, inputsideB, inputsideC);
                    Console.WriteLine($"\n\nThe area of your triangle is {triangleArea} square units.\n");
                    Console.WriteLine("Press any key to return to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                // Initiates the Quadratic equation formula
                case (4):
                    Console.Clear();
                    Console.WriteLine("You will need to input all three coefficients of your quadratic equation. Ensure that they are not negative numbers.\nInput coefficient 'a' here: ");
                    double inputCoeff_a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nInput coefficient 'b' here: ");
                    double inputCoeff_b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nInput coefficient 'c' here: ");
                    double inputCoeff_c = Convert.ToDouble(Console.ReadLine());

                    double quadraticSolution = QuadraticSolution(inputCoeff_a, inputCoeff_b, inputCoeff_c);

                    Console.WriteLine($"The solution to your quadratic equation is 'x = {quadraticSolution}'.\n");
                    Console.WriteLine("Press any key to return to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                default:
                    Console.WriteLine("Enter a number from 1-4 according to your desired menu item.\n\nPress any key to return to the main menu.");
                    Console.ReadLine();
                    MainMenu();
                    break;
            }
        }

        // Below are the different methods for the different formulas

        static double CircleArea(double radiusUser)
        {
            double result = radiusUser * radiusUser * Math.PI;
            return result;
        }

        static double CircleCircumference(double radius)
        {
            double result = 2 * radius * Math.PI;
            return result;
        }

        static double HemisphereVolume(double radius)
        {
            double volume = ((4 / 3) * Math.PI * (radius * radius * radius)) / 2;
            return volume;
        }

        static double TriangleArea(double sideA, double sideB, double sideC)
        {
            double p = ((sideA + sideB + sideC) / 2);
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return area;
        }

        static double QuadraticSolution(double a, double b, double c)
        {
            double x;
            x = (-b +- (Math.Sqrt((b * b) - (4 * a * c))) ) / (2 * a);
            return x;
        }
    }

}
