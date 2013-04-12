namespace SimpleTesting.Classess
{
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
            return (Balance - withDraw > 0) ? Balance - withDraw : Balance;
        }
    }
}