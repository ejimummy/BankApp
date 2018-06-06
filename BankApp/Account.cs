using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Account
    {
        //properties can be written by prop -tab-tab
        public int AccountNumber { get; set; }
        public char EmailAddress { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }
    }
}
