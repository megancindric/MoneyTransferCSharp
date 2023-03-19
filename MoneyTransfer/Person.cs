using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Person
    {
        public string name;
        private Wallet wallet;

        public Person(string name, int cash)
        {
            this.name = name;
            wallet = new Wallet(cash);

        }

        internal void DisplayInfo()
        {
            Console.WriteLine($"{name} currently has ${wallet.money} available in their wallet!\n");
        }

        internal void AcceptMoney(int cash)
        {
            Console.WriteLine($"{name} has received ${cash}!");
            wallet.money += cash;
            Console.WriteLine($"{name} now has ${cash} available in their wallet!");
            Console.ReadLine();
        }

        internal void TransferMoney(Person receiver, int transferAmount)
        {
            if(transferAmount < wallet.money)
            {
                Console.WriteLine($"Insufficient funds!  You cannot transfer ${transferAmount} as you only have ${wallet.money} available!");
            }
            else
            {
                Console.WriteLine($"{name} is transferring ${transferAmount} to {receiver.name}...\n");
                wallet.money -= transferAmount;
                Console.WriteLine($"{name} transfered ${transferAmount} and has ${wallet.money} available!");
                receiver.AcceptMoney(transferAmount);
            }
        }
    }
}
