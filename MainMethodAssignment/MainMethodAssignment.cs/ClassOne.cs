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
        public int Example (int num1)
        {
            int sum = num1 + 5;
            return sum;
        }

        //Step Two: Add a method to the class that will take in a decimal, create a different math operation for it then return the answer as an integer. 
        public int Example (decimal num1)
        {
            int sum = Convert.ToInt32(num1);
            int sum1 = (int)(sum - 5.2);
            return sum1;
        }
         

        //Step Three: Add a method that will take in a string, convert it to an integer (if possible), do a different math operationto it then return the answer as an integer. 
        public int Example (string num1)
        {
            int newOperation = Convert.ToInt32(num1);
            int sum = newOperation + 369;
            return sum;
        }
    }
}
