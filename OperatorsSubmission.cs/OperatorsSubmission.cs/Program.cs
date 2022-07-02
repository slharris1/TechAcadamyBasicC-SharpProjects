using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sam";
            employee.LastName = "Test";
            employee.Id = 2;

            Employee employee2 = new Employee() { FirstName = "Tim", LastName = "Jones", Id = 8 };

            Console.WriteLine(employee == employee2);
            Console.ReadLine();
            
        }
    }
}
