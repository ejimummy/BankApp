using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    //share the bank across the program so we only need one instance
    static class Bank
    {
        #region Properties
        
        #endregion


        #region Methods
        //all members in a static class must be static
        public static Account CreateAccount(string emailAddress, decimal initialAmount = 0.0M, AccountType accountType = AccountType.Checking) //optional accountType defaults to Checking
        {
            var account = new Account
            { 
                EmailAddress = emailAddress,
                AccountType = accountType,
                };

            if (initialAmount > 0)
            {
                account.Deposit(initialAmount);
            }
            return account;
        }
        #endregion
    }
}
