﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    /// <summary>
    /// this class provides defination for a Bedrock account
    /// </summary>
    class Account
    {
        #region Variables
        /// <summary>
        /// Shared memory for storing the
        /// last account number 
        /// and initialize it to 0
        /// </summary>
        private static int lastAccountNumber = 0;

        #endregion
        #region Properties
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account number
        /// </summary>
        public int AccountNumber { get;
            private set; }
        /// <summary>
        /// Current balance in the account
        /// </summary>
        public decimal Balance { get;
            private set; }
        #endregion

        #region Methods
        /// <summary>
        /// deposit money into your account
        /// </summary>
        /// <param name="amount">Money to deposit</param>
        /// <returns>new balance</returns>
        public decimal Deposit(decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
            return Balance;
                   
        }
        /// <summary>
        /// Withdraw money from your account
        /// </summary>
        /// <param name="amount">Amount to withdraw</param>
        /// <returns></returns>
        /// <exception>ArgumentException</exception>
        public decimal Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentNullException("Amount cannot be less than $1");
            }
            if (amount > Balance)
            {
                throw new ArgumentException("Insufficient Funds");
            }
            Balance -= amount;
            return Balance;

        }
        #endregion
        #region Constructors
        /// <summary>
        /// default constructor - no parameters
        /// </summary>
        public Account()
        {
            //lastAccountNumber = lastAccountNumber + 1;
            //AccountNumber = ++lastAccountNumber; //increment lastAccountNumber and then assign to AccountNumber
            //AccountNumber = lastAccountNumber++; //assign to Accountnumber and then increment lastAccountNumber
            lastAccountNumber++; //increment the lastAccountNumber
            AccountNumber = lastAccountNumber; //assign the incremented value to AcccountNumber
        }

        #endregion
    }
}