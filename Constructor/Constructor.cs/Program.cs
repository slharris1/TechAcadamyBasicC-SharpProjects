using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            const string projectName = "This is a constructor Assignment";

            Console.WriteLine(projectName);

            var age = 27;
            Console.WriteLine(age + 6);                             
        }

        public string name;
        public int location;

        public Program () : this("Troy", 0)
        {

        }
        public Program (string name, int location)
        {
            this.name = name;
            this.location = location;
        }
        public Program(string name) : this(name, 0)
        {

        }
        public Program(int location) : this("Troy", location)
        {

        }


    }
}
