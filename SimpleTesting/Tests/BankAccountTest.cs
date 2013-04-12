using NUnit.Framework;
using SimpleTesting.Classess;

namespace SimpleTesting.Tests
{
    [TestFixture]
    public class BankAccountTest
    {
        private BankAccount _ba1;
        private BankAccount _ba2;
        private BankAccount _ba3;
        const double tol = 0.000001;

        [SetUp]
        public void Init()
        {
            _ba1 = new BankAccount("Peter", 50);
            _ba2 = new BankAccount("Jens", 100.0 );
            _ba3 = new BankAccount("Martin", 1000.0, 0.03);
        }



        [Test]
        public void InitialTest()
        {
            Assert.AreEqual("Peter", _ba1.AccountHolder);
            Assert.AreEqual(50.0, _ba1.Balance);
            Assert.AreEqual(0.0, _ba1.InterestRate);

            Assert.AreEqual("Jens", _ba2.AccountHolder);
            Assert.AreEqual(100.0, _ba2.Balance);
            Assert.AreEqual(0.0, _ba2.InterestRate);

            Assert.AreEqual("Martin", _ba3.AccountHolder);
            Assert.AreEqual(1000.0, _ba3.Balance);
            Assert.AreEqual(0.03, _ba3.InterestRate);

        }

        [Test]
        public void DepositTest()
        {
            Assert.AreEqual(_ba1.Deposit(500),550);
            Assert.AreEqual(_ba2.Deposit(100),200);
            Assert.AreEqual(_ba3.Deposit(1000),2000);
        }

        [Test]
        public  void WithDrawTest()
        {
            Assert.AreEqual(_ba1.WithDraw(10),40);
            Assert.AreEqual(_ba2.WithDraw(10),90);
            Assert.AreEqual(_ba3.WithDraw(400),600);

        }

        [Test]
        public void ShouldBeAbleToWithdrawOnlyIfAvailableBalanceIsGreaterThanZero()
        {
            Assert.AreEqual(_ba1.WithDraw(60), 50);
        }
    }
}