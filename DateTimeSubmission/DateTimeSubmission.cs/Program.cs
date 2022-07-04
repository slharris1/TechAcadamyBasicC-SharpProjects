using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Please enter an number");
            int userResponse = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(dateTime.AddHours(userResponse));
            Console.ReadLine();
        }
    }
}
