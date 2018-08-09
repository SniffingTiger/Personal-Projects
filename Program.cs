using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Items_Total
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program has the user input the price of 5 different items and then displays the subtotal, sales tax of 6%, and the total price.
            // I am working under the assumption that we are using USD

            // Declare 5 doubles that store the prices of 5 different items
            double item1, item2, item3, item4, item5;

            //  Write to the screen the title of the program
            Console.WriteLine("Total of 5 items\n\n");

            // These next five sections of code take the user's input and convert it into a double assigned to the respective item

            // Input the first item, convert it to a double, and assign that value to the double item1
            Console.WriteLine("Input the price of your first item here: ");
            item1 = Convert.ToDouble(Console.ReadLine());

            // Input the second item, convert it to a double, and assign that value to the double item2
            Console.WriteLine("\nInput the price of your second item here: ");
            item2 = Convert.ToDouble(Console.ReadLine());

            // Input the third item, convert it to a double, and assign that value to the double item3
            Console.WriteLine("\nInput the price of your third item here: ");
            item3 = Convert.ToDouble(Console.ReadLine());

            // Input the fourth item, convert it to a double, and assign that value to the double item4
            Console.WriteLine("\nInput the price of your fourth item here: ");
            item4 = Convert.ToDouble(Console.ReadLine());

            // Input the fifth item, convert it to a double, and assign that value to the double item5
            Console.WriteLine("\nInput the price of your fifth item here: ");
            item5 = Convert.ToDouble(Console.ReadLine());



            // Declare double subtotal and assign it the value of the sum of the prices of all five items
            double subtotal = item1 + item2 + item3 + item4 + item5;
            // Declare double salesTax and assign the value of subtotal multiplied by 6%
            double salesTax = subtotal * .06;
            // Declare double total and assign it the value of the sum of subtotal and salesTax
            double total = subtotal + salesTax;

            // Display the subtotal, sales tax, and total
            Console.WriteLine($"\n\nYour subtotal is: {String.Format("{0:C}", subtotal)}.");

            Console.WriteLine($"\n\nYour sales tax is: {String.Format("{0:C}", salesTax)}.");

            Console.WriteLine($"\n\nYour total price is: {String.Format("{0:C}", total)}.");

            // Wait for user input before terminating program
            Console.ReadLine();
        }
    }
}
