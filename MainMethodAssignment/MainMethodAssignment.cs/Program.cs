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
            Console.WriteLine(math.Addition(userInput1));
            Console.ReadLine();

            //Step Two:
            Console.WriteLine("Please enter a number of your choosing.");
            int stepTwo = (int)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(math.ExampleTwo(stepTwo));
            Console.ReadLine();

            //Step Three:
            Console.WriteLine("Please enter a number of your choosing.");
            string userInput = Console.ReadLine();
            int stepThree = Convert.ToInt32(userInput);
            Console.WriteLine(math.ExampleThree(stepThree));
            Console.ReadLine();
        }

    }
}
