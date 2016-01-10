

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BedrockBank
{
    public static class BankFactory
    {

        //private static List<Account> accounts = new List<Account>();

        public static Account CreateAccount(string name, int ssn)
        {
            using (var db = new BankModel())
            {
                var account = new Account(name);
                account.SSN = ssn;
                //accounts.Add(account);
                db.Accounts.Add(account);
                db.SaveChanges();
                return account;
            }
        }

        public static Account CreateAccount(string name, int ssn, decimal amount, AccountType accountType)
        {
            //var account = new Account();
            //account.Name = name;
            //account.Deposit(amount);
            using (var db = new BankModel())
            {
                var account = new Account(name, amount);
                account.SSN = ssn;
                account.TypeOfAccount = accountType;
                // accounts.Add(account);
                db.Accounts.Add(account);
                db.SaveChanges();
                return account;
            }
        }

        public static IEnumerable<Account> GetAllAccountsBySSN(int ssn)
        {
            var db = new BankModel();
            
            //return accounts.Where(a => a.SSN == ssn);
            return db.Accounts.Where(a => a.SSN == ssn);
            
        }
        public static void Deposit(int accountNumber, decimal amount)
        {
            using (var db = new BankModel())
            {
                var account = db.Accounts.Where(a => a.AccountNumber == accountNumber).First();
                var original = account;
                account.Deposit(amount);
                db.Entry(original).CurrentValues.SetValues(account);
                db.SaveChanges();
            }

        }
    }
}
