using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example One:
            ClassOne math = new ClassOne(); // creating an instance of ClassOne                     
            Console.WriteLine("Please enter a number of your choosing.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            math.Example1(userNumber);
            Console.ReadLine();


            //Example Two: 
            ClassOne value = new ClassOne();
            int z = 1000;
            value.Value(out z);
            Console.ReadLine();

            //Example Three: 
            ClassOne overload = new ClassOne();
            int sum1 = overload.Multiply(10, 5);
            Console.WriteLine(sum1);
            Console.ReadLine();

            //Example Four:
            Console.WriteLine(Static.Example2());
            Console.ReadLine();
        }
    }
}
