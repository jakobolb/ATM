using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM
{
    public class Account : Person
    {
        public static List<Account> AllAccounts = new List<Account>();

        public decimal Balance { get; set; }
        public List<string> Statement { get; } = new List<string>();         
        public String Username {get; }
        public int Password {get; }

        public Account(string firstName, string lastName, DateTime birthDate, decimal balance, string username, int password) : base(firstName, lastName, birthDate)
        {
            AllAccounts.Add(this);
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Balance = balance;
            Username = username;
            Password = password;
        }

        public void CloseAccount()
        {
            AllAccounts.Remove(this);
        }
    }
}