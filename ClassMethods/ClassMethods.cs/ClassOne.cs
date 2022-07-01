using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise that creates methods that specifically belong to a class and more on how to access those methods without creating an object of the class first. 
namespace ClassMethods.cs
{
    public class ClassOne
    {
        //Example One:
        public void Example1 (int num1)
        {
            int sum = num1 / 2;
            Console.WriteLine(sum);
        }

        //Example Two:
        public void Value(out int num1)
        {
            int randomeNumber = 369;
            num1 = randomeNumber;
            Console.WriteLine(num1);
        }

        //Example Three: 
        public int Multiply (int a, int b)
        {
            int sum1 = a * b;
            return sum1;
        }
        
    }


    static class Static
    {
        public static string Example2()
        {
            string phrase1 = "That is all folks";
            return phrase1;
        }
    }
    
}

//objects have state (properties) and behavior (they can do things)


