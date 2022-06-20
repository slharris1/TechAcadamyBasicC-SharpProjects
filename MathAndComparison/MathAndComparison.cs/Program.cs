using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparison.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();


            Console.WriteLine("Person 1");
            Console.ReadLine();

            //print person 1 and get the following details from the user input: Hourly rate and Hours worked per week. 
            Console.WriteLine("Hourly rate?");
            string personOneRate = Console.ReadLine();
            int personRateOne= Convert.ToInt32(personOneRate);

            Console.WriteLine("Hours worked per week?");
            string personOneHours = Console.ReadLine();
            int personHoursOne = Convert.ToInt32(personOneHours);

            Console.WriteLine("Person Two");
            Console.ReadLine();

            //print person 1 and get the following details from the user input: Hourly rate and Hours worked per week. 
            Console.WriteLine("Hourly rate?");
            string personTwoRate = Console.ReadLine();
            int personRateTwo= Convert.ToInt32(personTwoRate);
     
            Console.WriteLine("Hours worked per week?");
            string personTwoHours = Console.ReadLine();
            int personHoursTwo = Convert.ToInt32(personTwoHours);
            
            //annual salary of person one
            int weekRateOne = personHoursOne * personRateOne;
            int annualSalaryOne = weekRateOne * 52;
            Console.WriteLine("Annual salary of person One is: " + annualSalaryOne);
            Console.ReadLine();

            //annual salary of person two
            int weekRateTwo = personHoursTwo * personRateTwo;
            int annualSalaryTwo = weekRateTwo * 52;
            Console.WriteLine("Annual salary of person Two is: " + annualSalaryTwo);
            Console.ReadLine();

            Console.WriteLine("Does Person One make more money than Person 2?");
            bool salary = annualSalaryOne > annualSalaryTwo;
            Console.WriteLine(salary);
            Console.ReadLine();











            Console.ReadLine();
        }
    }
}
