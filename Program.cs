using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemoFA2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a var to store user input
            //application that suggests recipes based on what's in your fridge
            string userInput;

            //prompt the user to tell us what fruit they have in their fridge
            Console.WriteLine("Name a fruit that oyu have in your fridge:");

            userInput = Console.ReadLine();

            //perform conditional branching by using a switch statement
            switch (userInput)
            {

                case "apple":
                    Console.WriteLine("\nYou can bake an apple pie.");
                    break;

                case "banana":
                    Console.WriteLine("\nYou can bake a banana bread.");
                    break;

                case "peach":
                    Console.WriteLine("\nYou can brew peach iced tea.");
                    break;

                case "kiwi":
                    Console.WriteLine("\nYou can make a fruit salad.");
                    break;

                default:
                    Console.WriteLine($"You typed {userInput}. Not sure what to do with that ingredient.");
                    break;
            
            }

            Console.ReadLine();





        }
    }
}
