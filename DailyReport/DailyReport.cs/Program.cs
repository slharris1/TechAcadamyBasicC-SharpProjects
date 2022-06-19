using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will be displayed first as the name of the console app
            Console.WriteLine("THE TECH ACADEMY");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //Asks the student name and returns back with a message. 
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Welcome back, " + yourName);
            Console.ReadLine();

            //asks what course the student is on and returns back with a message. 
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Awesome work on " + yourCourse);
            Console.ReadLine();

            //Asks the student what number they are on and displays it back to them. 
            Console.WriteLine("What page number are you on??");
            string pageNumber = Console.ReadLine();
            int yourPage = Convert.ToInt32(pageNumber);
            Console.WriteLine("Keep up the good work! Nice progress to page " + pageNumber);
            Console.ReadLine();
            
            //Asks the student if they need help. 
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            string studentHelp = Console.ReadLine();
            bool value = Convert.ToBoolean(studentHelp);
            Console.WriteLine("Thank you for your response.");
            Console.ReadLine();

            //Asks the student if they want to include any positive experiences.
            Console.WriteLine("Were there any positive experiences? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("That is wonderful to hear, " + yourName +"!");
            Console.ReadLine();

            //Asks the student if they have any other feedback.
            Console.WriteLine("Is there any other feedback that you would like to provide? Please be specific. ");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("Thank you for the feedback!");
            Console.ReadLine();

            //Asks the student how many hours studied. 
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int learningHours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
