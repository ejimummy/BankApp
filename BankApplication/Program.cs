using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object, instance of a class, instantiation

            var account = Bank.CreateAccount("test@test.com", 100.00M, AccountType.Savings); //M indicates it's money

            account.Balance = 1000000000;

            Console.WriteLine($"AN: {account.AccountNumber}, Balance: {account.Balance}, EA: {account.EmailAddress}, TA: {account.AccountType}, CD: {account.CreatedDate}");

            var account2 = Bank.CreateAccount("testing@test.com");
            Console.WriteLine($"Email: {account2.EmailAddress}");

  
            Console.Read();
        }
    }
}
