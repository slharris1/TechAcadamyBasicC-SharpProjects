using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            IQuittable quitter = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            quitter.Quit();
            employee.SayName();
            Console.ReadLine();
        }
    }
}
