using System.ComponentModel.Design;

namespace logic_and_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables 
             string playerName = "adventurer";
            string userChoice = "NONE";


            Console.WriteLine("Welcome to the jungle\nWe got fun and games\nWe got everthing you want\nHoney, we know the name\n\n");
            Console.WriteLine("Wait ...I dont't actually know your name?");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            //grabbing user name
            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle " + playerName + "!");

            //Different strory
            Console.WriteLine(" " + "We approach a fork in the dungeon\n" + "There is a long tunnel to the right\n" + "And a large room to the left.\n");
            Console.WriteLine("Which path do you choose?");
            Console.WriteLine("Type 'left' to choose the large room path or type 'right' to choose the long tunnel path");

            //grabbing user input
            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice + "\n");

            //select path
            if (userChoice == "left")
            {
                Console.WriteLine("You choose the large room good luck!!!!");
            }
            else if (userChoice == "right")
            {
                Console.WriteLine("You chose the long tunnel get walking at least its safe!");
            }
            else if (userChoice == "up")
            {
                Console.WriteLine("You can go up even I did not know that well let's just leave");

            }
            else {

                Console.WriteLine("I guess we can just stay here if you want. I have no problem with it");
            }



        }
    }
}
