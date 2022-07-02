using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.cs

{
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");
            string userDay = Console.ReadLine();
            DaysOfTheWeek day;

            try
            {
                bool checkParse = Enum.TryParse(userDay, out day);
                Console.WriteLine(checkParse);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }


        }

    }

    
}

