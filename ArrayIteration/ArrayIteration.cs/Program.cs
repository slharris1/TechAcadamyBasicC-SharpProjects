using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIteration.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "cat", "mouse", "dog", "hamster", "pig", "dolphin" };

            Console.WriteLine("Input your favorite color.");
            string colorSelection = Console.ReadLine();

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(colorSelection + " " + animals[i]);
                Console.WriteLine(animals[i]);
            }
            Console.ReadLine();

            //Console App Part Two Assignment: ininite Loop
            while (true)
            {
                Console.WriteLine("This is the loop that never ends.");
                Console.ReadLine();
                break;
            }

            //Console App Part Three Assignment: Create a comparison loop that is used to determine whether to continmue iterating through a loop
            List<int> testScores = new List<int>();
            testScores.Add(66);
            testScores.Add(72);
            testScores.Add(99);
            testScores.Add(92);
            testScores.Add(81);
            testScores.Add(75);
            testScores.Add(73);

            //loop that iterates through the list using the '> ' to determin if the loop will continue. 
            foreach (int score in testScores)
            {
                if (score > 80)
                {
                    Console.WriteLine("This is a pass: " + score);
                    Console.ReadLine();
                }
            }

            //loop that iterates through the list using the '<=' to determin if the loop will continue. 
            foreach (int score in testScores)
            {
                if (score <= 79)
                {
                    Console.WriteLine("This is a fail: " + score);
                    Console.ReadLine();
                }
            }

            //Console App Part Four Assignment: Create a list of strings where each item in the list is unique and create a loop that itterates through the list and then displays the index of the list that contains matching text onm the screen. 
            List<string> months = new List<string>() { "june", "july", "august" };

            Console.WriteLine("Please enter a month of the summer. ");
            string userMonth = Console.ReadLine();
           
             if (months.Contains(userMonth))
             { for (int s = 0; s < months.Count; s++)

                {
                    if (months[s] == userMonth)
                    {
                        Console.WriteLine(s);                        
                    }
                }  
            }
            else
            {
                Console.WriteLine("You did something wrong. Try again.");
            }
            Console.ReadLine();

            //Console App Part Five: A list of strings that has at least two identical strings and ask the user to select text to search for in the list. create a loop that iterates through the list then displays the indecies of the items. 
            List<string> names = new List<string>() { "James", "Travis", "Noah", "Travis", "Kyle" };
            Console.WriteLine("Enter the name Travis");
            string userResponse = Console.ReadLine();
            if (names.Contains(userResponse))
            {
                for (int n = 0; n < names.Count; n++)
                {
                    if (names[n] == userResponse)
                    {
                        Console.WriteLine(n);                     
                    }

                }
            }
            else
            {
                Console.WriteLine("You did something wrong. Try again.");                
            }
            Console.ReadLine();
            //Console App Part Six: 
            List<string> colors = new List<string>() { "blue", "lime", "pink", "blue" };
            List<string> pastelColors = new List<string>();

            foreach (string color in colors)
            {
                if (color == "blue")//states that if the list contains a duplicate color to print to the console. 
                {
                    pastelColors.Add(color);
                }
                else
                {
                    Console.WriteLine("This color is already listed.");
                    Console.ReadLine();
                }

                    
            }

            
            





        }
    }
}