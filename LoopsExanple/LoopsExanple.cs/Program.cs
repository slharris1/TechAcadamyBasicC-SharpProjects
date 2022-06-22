using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExanple.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a color?");
            string color = Console.ReadLine();

            bool isGuessed = color == "pink";
            do
            {
                switch (color)
                {
                    case "yellow":
                        Console.WriteLine("You guessed yellow. It's a nice color but is wrong. Try again");
                        Console.WriteLine("Guess a new color?");
                        color = Console.ReadLine();
                        break;
                    case "white":
                        Console.WriteLine("You guessed white. It's a nice color but is wrong.Try again.");
                        Console.WriteLine("Guess a new color?");
                        color = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed blue. It's a nice color but is wrong.Try again.");
                        Console.WriteLine("Guess a new color?");
                        color = Console.ReadLine();
                        break;
                    case "pink":
                        Console.WriteLine("You guessed the color pink. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a new color?");
                        color = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);
             
            Console.ReadLine();

        }
    }
}
