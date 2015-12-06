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
            //Create an instance of an Account == object
            var account = new Account();
            //account.AccountNumber = 123;
            account.Name = "joba's Checking";
            //account.Balance = 100000000;
            account.Deposit(500);
            //Console.WriteLine(account.Balance);   
            Console.WriteLine(
                "Name: {0}, Account Number: {1}, Account Balance: {2}",
                account.Name, account.AccountNumber, account.Balance
                );
            var savingsAccount = new Account();
            //Account savingsAccount = new Account(); //this is the old style
            savingsAccount.Name = "joba's saving";
            savingsAccount.Deposit(10);
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
                "Name: {0}, Account Number: {1}, Account Balance: {2}",
                savingsAccount.Name, savingsAccount.AccountNumber, savingsAccount.Balance
                );
        }
    }
}
