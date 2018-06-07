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

            //another way to create the object with an overloading constructor
            var account = new Account
            {
                EmailAddress = "test.test.com",
                AccountType = "Checking"
            };

            account.Balance = 1000000000;

            Console.WriteLine($"AN: {account.AccountNumber}, Balance: {account.Balance}, EA: {account.EmailAddress}, TA: {account.AccountType}, CD: {account.CreatedDate}");

            var account2 = new Account("testing@test.com");
            Console.WriteLine($"Email: {account2.EmailAddress}");
            Console.Read();
        }
    }
}
