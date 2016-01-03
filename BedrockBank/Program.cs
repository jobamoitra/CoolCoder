using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            #region code from previous classes (towards end of 12/6) commented out
            /*
            var account = BankFactory.CreateAccount("Joba's Checcking", 500);
            ////Create an instance of an Account == object
            //var account = new Account();
            ////account.AccountNumber = 123;
            //account.Name = "Joba's Checking";
            ////account.Balance = 100000000;
            //account.Deposit(500);
            ////Console.WriteLine(account.Balance);   
            Console.WriteLine(
                "Name: {0}, Account Number: {1}, Account Balance: {2:c}",
                account.Name, account.AccountNumber, account.Balance
                );

            //create SavingsAccount
            var savingsAccount = BankFactory.CreateAccount("Joba's Savings", 10);
            //var savingsAccount = new Account();
            ////Account savingsAccount = new Account(); //this is the old style
            //savingsAccount.Name = "Joba's savings";
            //savingsAccount.Deposit(10);

            //Exception handling
            try
            {
                savingsAccount.Withdraw(100);
            }
            catch(ArgumentException exceptionMessage)
            {
                Console.WriteLine("Oops something went wrong : {0}", 
                    exceptionMessage.Message);
            }
            catch (Exception) //to catch all exceptions not specifically handled
            {
                Console.WriteLine("Something went wrong");
            }
            Console.WriteLine(
                "Name: {0}, Account Number: {1}, Account Balance: {2:c}",
                savingsAccount.Name, savingsAccount.AccountNumber, savingsAccount.Balance
                );
            */
            #endregion
            Console.WriteLine("*** Welcome to Bedrock Bank ***");
            Console.Write("Please login with SSN: ");
            var ssn = Console.ReadLine();
            int convertedSSN;
            if (int.TryParse(ssn, out convertedSSN) == true)
            {
                var accounts = BankFactory.GetAllAccountsBySSN(convertedSSN);
                if (accounts == null)
                {
                    Console.WriteLine("No Accounts");
                }
            }
        }
    }
}
