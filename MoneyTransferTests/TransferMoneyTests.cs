using MoneyTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransferTests
{
    [TestClass]

    public class TransferMoneyTests
    {

        [TestMethod]
        public void TransferMoney_PersonOneTransfers50ToPersonTwo_PersonOneWalletDecrease50PersonTwoWalletIncrease50()
        {
            //Arrange
            Person personOne = new Person("Bingus", 100);
            Person personTwo = new Person("Mingus", 50);

            //Act
            personOne.TransferMoney(personTwo, 50);

            //Assert
            Assert.AreEqual(50, personOne.GetCashAmount());
            Assert.AreEqual(100, personTwo.GetCashAmount());
        }

        [TestMethod]
        public void TransferMoney_PersonOneOverTransfersMoney_WalletAmountsUnchanged()
        {
            //Arrange
            Person personOne = new Person("Bingus", 100);
            Person personTwo = new Person("Mingus", 50);

            //Act
            personOne.TransferMoney(personTwo, 500);

            //Assert
            Assert.AreEqual(100, personOne.GetCashAmount());
            Assert.AreEqual(50, personTwo.GetCashAmount());
        }
    }
}
