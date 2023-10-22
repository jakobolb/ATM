using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM
{
    public class BankATM :IBankATM
    {
        public decimal CheckBalance(Account acc)
        {
            return acc.Balance;
        }

        public void Deposit(Account acc, decimal amount)
        {
            acc.Balance += amount;
        }

        public void Withdraw(Account acc, decimal amount)
        {
            if (acc.Balance >= amount)
            {
                acc.Balance -= amount;
                Console.WriteLine($"Abhebung von ${amount} erfolgreich.");
            }
            else
            {
                Console.WriteLine("Nicht genügend Guthaben für diese Auszahlung vorhanden.");
            }
        }

        public bool ValidateUser(string username, int password, List<Account> allaccounts)
        {
            foreach (var item in allaccounts)
            {
                if (item.Username == username && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        
        public Account GetCurrentAccount(string username, int password, List<Account> allaccounts)
        {
            return allaccounts.FirstOrDefault(item => item.Username == username && item.Password == password);
        }
    }
}
