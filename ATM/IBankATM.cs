using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM
{
    public interface IBankATM
    {  
    // Methode zum Einzahlen von Geld
    void Deposit(Account acc, decimal amount);

    // Methode zum Abheben von Geld
    void Withdraw(Account acc, decimal amount);

    // Methode zur Anzeige des Kontostands
    decimal CheckBalance(Account acc);

    // Methode zur Überprüfung des Logins
    bool ValidateUser (string username, int password, List<Account> allaccounts);
    
    // Methode um den angemeldeten Account zu identifizieren
    Account GetCurrentAccount (string username, int password, List<Account> allaccounts);
    }
}