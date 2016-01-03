

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BedrockBank
{
    public static class BankFactory
    {

        private static List<Account> accounts = new List<Account>();

        public static Account CreateAccount(string name, int ssn)
        {
            var account = new Account(name);
            account.SSN = ssn;
            accounts.Add(account);
            return account;
        }

        public static Account CreateAccount(string name, int ssn, decimal amount, AccountType accountType)
        {
            //var account = new Account();
            //account.Name = name;
            //account.Deposit(amount);
            var account = new Account(name, amount);
            account.SSN = ssn;
            account.TypeOfAccount = accountType;
            accounts.Add(account);
            return account;
        }

        public static IEnumerable<Account> GetAllAccountsBySSN(int ssn)
        {
            return accounts.Where(a => a.SSN == ssn);
        }
    }
}
