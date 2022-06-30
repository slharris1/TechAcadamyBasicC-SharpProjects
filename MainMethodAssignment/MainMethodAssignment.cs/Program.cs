using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step One:
            Console.WriteLine("Please enter a number of your choosing.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            ClassOne math = new ClassOne();
            Console.WriteLine(math.Example(userInput1));
            Console.ReadLine();

            //Step Two:
            Console.WriteLine("Please enter a number of your choosing.");
            decimal stepTwo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(math.Example(stepTwo));
            Console.ReadLine();

            //Step Three:
            Console.WriteLine("Please enter a number of your choosing.");
            string userInput = Console.ReadLine();
            Console.WriteLine(math.Example(userInput));
            Console.ReadLine();
        }

    }
}
