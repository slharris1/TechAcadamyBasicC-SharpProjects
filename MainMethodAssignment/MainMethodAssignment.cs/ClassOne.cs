using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment.cs
{
    public class ClassOne
    {
        //Step One: Create a method that will take in an integer, create a math operation for this integer, then return the answer as an integer.
        public int Addition(int num1)
        {
            int sum = num1 + 5;
            return sum;
        }

        //Step Two: Add a method to the class that will take in a decimal, create a different math operation for it then return the answer as an integer. 
        public int ExampleTwo (int num2)
        {             
            int sum = (int)(num2 - 6.0);
            int sum1= (int)Convert.ToDecimal(sum);
            return sum1;
        }
         

        //Step Three: Add a method that will take in a string, convert it to an integer (if possible), do a different math operationto it then return the answer as an integer. 
        public int ExampleThree (int num3)
        {
            int newOperation = Convert.ToInt32(num3);
            int sum = newOperation + 369;
            return sum;
        }
    }
}
