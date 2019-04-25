using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            int side;
            int rollResult;
            string response = "y";

            Console.WriteLine("Welcome to Grand Circus Casino!");
            // for loop counter.  starts at 1 but never gets to 3. therefore, only happens twice.
            while(response == "y")
            {
                // prompting the user to roll the dice
                Console.WriteLine("How many sides would you like your 2 dice to have? ");
                // read users input
                side = int.Parse(Console.ReadLine());
                if(side > 3)
                {
                    Console.WriteLine("You rolled a dice that has 4 sides or more: ");
                    for(int count = 1; count < 3; count++)
                    {
                        Random roll = new Random();
                        rollResult = roll.Next(1, side + 1);             // make the random function choose any number: (a <= num < b) such that (a,b)
                        Console.WriteLine(rollResult);
                    }

                }
                else
                {
                    Console.WriteLine("There is no such thing as a 3 or less sided dice: ");
                }
                
                Console.WriteLine("Roll again? (y/n)");
                response = Console.ReadLine();
            }
            
            


        }
    }
}
