using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    public class Simulation
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
                    RunTransfer();
                }
                else if (userInput == "0")
                {
                    Console.WriteLine("Exit selected.");
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
        }

        public void RunTransfer()
        {
            Console.WriteLine("Who will be transferring money?");
            int transferrerIndex = DisplayPlayerChoices();
            Console.WriteLine($"Who will {players[transferrerIndex].name} be transferring to?");
            int receiverIndex = DisplayPlayerChoices();
            if(transferrerIndex == receiverIndex)
            {
                Console.WriteLine("Error: You cannot transfer money between the same person!");
            }
            else
            {
Console.WriteLine($"Initiating transfer from {players[transferrerIndex].name} to {players[receiverIndex].name}...");
            int transferAmount = DetermineTransferAmount();
            players[transferrerIndex].TransferMoney(players[receiverIndex],transferAmount);
            }
            
        }

        public int DisplayPlayerChoices()
        {
            int i = 0;
            foreach(Person person in players)
            {
                Console.WriteLine($"Press {i} to select {person.name}.");
                i++;
            }
            int user_choice = Int32.Parse(Console.ReadLine());
            while(user_choice >0 && user_choice >= players.Count)
            {
                Console.WriteLine("Invalid selection!  Please enter a choice from the menu above!");
                user_choice = Int32.Parse(Console.ReadLine());
            }
            return user_choice;
        }
        public int DetermineTransferAmount()
        {
            Console.WriteLine("Please enter the amount to be transferred: ");
            int amount = Int32.Parse(Console.ReadLine());
            return amount;
        }
    }
}
