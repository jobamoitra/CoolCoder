

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BedrockBank
{
    public static class BankFactory
    {
        public static Account CreateAccount(string name, int ssn)
        {
            var account = new Account(name);
            account.SSN = ssn;
            return account;
        }

        public static Account CreateAccount(string name, int ssn, decimal amount)
        {
            //var account = new Account();
            //account.Name = name;
            //account.Deposit(amount);
            var account = new Account(name, amount);
            account.SSN = ssn;
            return account;
        }
    }
}
