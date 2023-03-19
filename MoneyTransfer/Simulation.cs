using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
       
        List<Person> players = new List<Person>();
        public Simulation() {
            Person personOne = new Person("Bingus", 500);
            Person personTwo = new Person("Mingus", 300);
            Person personThree = new Person("Bringus", 1000);
            players.Add(personOne);
            players.Add(personTwo);
            players.Add(personThree);
        }

        public void RunSimulation()
        {
            Console.WriteLine("Beginning simulation...\n");

            DisplayMenu();

            Console.WriteLine("Simulation completed!");
            Console.ReadLine();
        }

        public void DisplayMenu()
        {
            string userInput = "";
            while(userInput != "0")
            {
            Console.WriteLine("Press 1 to see all user information\nPress 2 to begin a new transfer\nPress 0 to exit!");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    DisplayPlayerInfo();
                }
                else if (userInput == "2")
                {

                }
                else if (userInput == "0")
                {

                }
                else
                {
                    Console.WriteLine("Invalid input, please try your selection again!");
                }
            }

        }

        public void DisplayPlayerInfo()
        {
            foreach(Person person in players)
            {
                person.DisplayInfo();
            }
            Console.ReadLine();
        }
    }
}
