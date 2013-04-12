using NUnit.Framework;

namespace SimpleTesting {
    [TestFixture]
    public class NUnitSampleTests {
        [Test]
        public void SomePassingTest() {
            Assert.AreEqual(5, 5);
        }

        [Test]
        public void SomeFailingTest() {
            Assert.Greater(5, 7);
        }

    }

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
            _ba1 = new BankAccount("Peter");
            _ba2 = new BankAccount("Jens", 100.0 );
            _ba3 = new BankAccount("Martin", 1000.0, 0.03);
        }



        [Test]
        public void InitialTest()
        {
            Assert.AreEqual("Peter", _ba1.AccountHolder);
            Assert.AreEqual(0.0, _ba1.Balance);
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
            Assert.AreEqual(_ba1.Deposit(500),500);
            Assert.AreEqual(_ba2.Deposit(100),200);
            Assert.AreEqual(_ba3.Deposit(1000),2000);
        }

        [Test]
        public  void WithDrawTest()
        {
            Assert.AreEqual(_ba1.WithDraw(10),-10);
            Assert.AreEqual(_ba1.WithDraw(10),-10);
            Assert.AreEqual(_ba3.WithDraw(400),600);

        }
    }

    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }


        public BankAccount(string accountHolder):this(accountHolder,0.0,0.0)
        {}

        public BankAccount(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public BankAccount(string accountHolder, double balance, double interestRate)
        {
            AccountHolder = accountHolder;
            Balance = balance;
            InterestRate = interestRate;
        }

        public double Deposit(double deposit)
        {
            return Balance + deposit;
        }

        public double WithDraw(double withDraw)
        {
            return Balance - withDraw;
        }
    }
}
