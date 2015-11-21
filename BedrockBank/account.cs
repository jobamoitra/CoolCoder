using System;
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
        #region Properties
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account number
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Current balance in the account
        /// </summary>
        public decimal Balance { get; set; }
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
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;

        }
        #endregion
    }
}