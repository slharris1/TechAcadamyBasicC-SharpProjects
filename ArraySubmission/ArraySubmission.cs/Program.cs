using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmission.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a one-dimensionial Array of strings. Ask the user to select an index of the Array and then display
            //the integer at that index on the screen. 
            string[] stringArray = { "apple", "banana", "grape", "orange" };
            Console.WriteLine("Please select an index of the String Array");
            int userString= Convert.ToInt32(Console.ReadLine());

            if (userString <4)
            {
                Console.WriteLine(stringArray[userString]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That index does not exist. Please try again.");
                Console.ReadLine();
            }

            //Create a one-dimensionial Array of integers. Ask the user to select an index of the Array and then display
            //the integer at that index on the screen. 
            int[] intArray = { 2, 3, 9, 78, 600 };
            Console.WriteLine("Please select an index of the Integer Array.");
            int userInt = Convert.ToInt32(Console.ReadLine());
            if (userInt < 5)
            {
                Console.WriteLine(intArray[userInt]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That index does not exist. Please try again.");
                Console.ReadLine();
            }

            //Create a list of strings. Ask the user to select an index of the list and then display the content at that 
            //index on the screen. 
            List<string> stringList = new List<string>();
            stringList.Add("John");
            stringList.Add("Cindy");
            stringList.Add("Taylor");
            stringList.Add("Amy");
            stringList.Add("Steve");
            stringList.Add("Louis");
            Console.WriteLine("Please select an index of the String List.");
            int indexList = Convert.ToInt32(Console.ReadLine());
            if (indexList < 6)
            {
                Console.WriteLine(stringList[indexList]);
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("That index does not exist. Please try again.");
                Console.ReadLine();
            }



        }
    }
}
