using System;

namespace k173669_Lab1_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Console.WriteLine($"Account.Balance(): {account.Balance()}");

            Amount amount = new Amount();
            Console.WriteLine($"Amount.Balance(): {amount.Balance()}");
        }
    }

    class Account
    {
        public virtual int Balance()
        {
            return 5;
        }
    }

    class Amount: Account
    {
        public override int Balance()
        {
            return 10;
        }
    }

}
