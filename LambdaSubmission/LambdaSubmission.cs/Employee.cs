using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission.cs
{
    class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;

        public string getEmployee()
        {
            return this.FirstName + " has an employee ID of " + this.Id;
        }
    }
}
