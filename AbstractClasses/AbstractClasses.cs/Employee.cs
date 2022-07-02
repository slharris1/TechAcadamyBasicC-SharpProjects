using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.cs
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0}", firstName + " " + lastName);            
        }
        

        public void Quit()
        {
            throw new NotImplementedException();
        }
        
    }
}
 