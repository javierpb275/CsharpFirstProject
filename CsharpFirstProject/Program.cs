using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpFirstProject.Cook;
using CsharpFirstProject.Bank;

namespace CsharpFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("pepe", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(100, DateTime.Now, "withdrawing");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(2000, DateTime.Now, "depositing");
            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(50, DateTime.Now, "Xbox game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            

            Console.ReadLine();
        }

    }
}
