using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
            
            Console.Write("What is your guess for the number?: ");           
            var userInput = int.Parse(Console.ReadLine());

            if (favNumber < userInput)
            {
                Console.WriteLine("You have guessed to high. ");
            }
            else if (favNumber > userInput)
            {
                Console.WriteLine("You have guessed to low. ");
            }
            else
            {
                Console.WriteLine("Congratulations. ");
            }
        }
    }
}
