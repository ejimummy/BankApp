﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Account
    {
        #region Properties
        //properties can be written by prop -tab-tab

        /// <summary>
        /// unique acount number
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Email address associated with the user
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Account balance
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// Type of account
        /// </summary>
        public string AccountType { get; set; }
        /// <summary>
        /// Date account was created
        /// </summary>
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into the account
        /// </summary>
        /// <param name="amount">Deposit amount</param>
        /// <returns>New balance</returns>
        public decimal Deposit(decimal amount)
        {
            return Balance += amount;
        }

        /// <summary>
        /// Withdraw money from account
        /// </summary>
        /// <param name="amount">Withdraw amount</param>
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        #endregion
    }
}