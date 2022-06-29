using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number of your choosing.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            ClassOne math = new ClassOne(); // creating an instance of the class.

            //This code takes the obj math and passes through the userNumber to the methods.
            Console.WriteLine(math.Addition(userNumber));
            Console.WriteLine(math.Multiply(userNumber));
            Console.WriteLine(math.Division(userNumber));
            Console.ReadLine();


            
        }
    }
}
