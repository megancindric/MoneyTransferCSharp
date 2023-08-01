using System;
using MoneyTransfer;
namespace MoneyTransferTests
{
    [TestClass]
    public class AcceptMoneyTests
    {
        [TestMethod]
        public void AcceptMoney_PersonStartsWith100_WalletMoneyIncreasedTo150()
        {
            //Arrange
            Person personOne = new Person("Bingus", 100);

            //Act
            personOne.AcceptMoney(50);

            //Assert
            Assert.AreEqual(150,personOne.GetCashAmount());
        }
    }
}