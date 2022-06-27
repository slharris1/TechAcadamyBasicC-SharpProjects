using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegerAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a list of integers. Ask the user for a number to divide each number in by the list.
            //Write a loop that takes each integer in th elist, divides it by the number the user entered and displays
            //The results to the screen.

            List<int> integers = new List<int>() { 300, 500, 70, 95, 110, 1300 };

            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());

                foreach (int item in integers)
                {
                    int result = item / numberOne;
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("This program has emerged from the try/catch block and continued on with the program execution");
            Console.ReadLine();
        }
    }
}
