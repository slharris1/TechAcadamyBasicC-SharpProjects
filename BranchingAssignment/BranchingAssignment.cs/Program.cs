using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight.");
            string userWeight = Console.ReadLine();
            int packageWeight = Convert.ToInt32(userWeight);
            if (packageWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width");
            string userWidth = Console.ReadLine();
            int packageWidth = Convert.ToInt32(userWidth);

            Console.WriteLine("Please enter the package height");
            string userHeight = Console.ReadLine();
            int packageHeight = Convert.ToInt32(userHeight);

            Console.WriteLine("Please enter the package length");
            string userLength = Console.ReadLine();
            int packageLength = Convert.ToInt32(userLength);

            //math
            int packageDimensions = packageHeight * packageLength * packageWidth;
            int package = packageDimensions * packageWeight;
            int packageQuote = package / 100;
            
            if (packageDimensions > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Your total is : $" + packageQuote);
                Console.ReadLine();
            }
            
            
        }
    }
}
