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
            var account = new Account();
            account.AccountNumber = 12345;
            account.EmailAddress = "test.lisa@gmail.com";
            account.AccountType = "Checking";
            account.Balance = 1000000000;

            Console.WriteLine(account.Balance);
        }
    }
}
