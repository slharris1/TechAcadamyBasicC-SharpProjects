using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            List<Employee> names = new List<Employee>();
            names.Add( new Employee());
            names[0].FirstName = "Joe";
            names[0].LastName = "Long";
            names[0].Id = 1;

            names.Add(new Employee());
            names[1].FirstName = "Tim";
            names[1].LastName = "Wilson";
            names[1].Id = 2;

            names.Add(new Employee());
            names[2].FirstName = "Lonnie";
            names[2].LastName = "James";
            names[2].Id = 2;

            names.Add(new Employee());
            names[3].FirstName = "Joe";
            names[3].LastName = "Washington";
            names[3].Id = 4;

            names.Add(new Employee());
            names[4].FirstName = "Tina";
            names[4].LastName = "Balcher";
            names[4].Id = 5;

            names.Add(new Employee());
            names[5].FirstName = "Jimmy";
            names[5].LastName = "Pesto";
            names[5].Id = 6;

            names.Add(new Employee());
            names[6].FirstName = "Marshmellow";
            names[6].LastName = "Toms";
            names[6].Id = 7;

            names.Add(new Employee());
            names[7].FirstName = "Tammy";
            names[7].LastName = "Larson";
            names[7].Id = 8;

            names.Add(new Employee());
            names[8].FirstName = "Bob";
            names[8].LastName = "Belcher";
            names[8].Id = 9;

            names.Add(new Employee());
            names[9].FirstName = "Naruto";
            names[9].LastName = "Uzamachi";
            names[9].Id = 10;
                   

            foreach (Employee employee1 in names)
            {
                if (employee1.FirstName == "Joe")

                {
                    Console.WriteLine(employee1.getEmployee());
                    Console.ReadLine();
                }
            }

            List<Employee> employees = names.Where(x => x.Id > 5).ToList();
        }
    }
}
