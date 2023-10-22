namespace ATM
{
    public class ATMConsoleUI
    {
        private IBankATM _atm;
        public ATMConsoleUI(IBankATM atm)
        {
            _atm = atm;
        }

        public void Run()
        {
            Console.WriteLine("Willkommen am Bankautomaten!");
            
            Console.WriteLine("Bitte geben Sie ihren Benutzernamen ein.");
            string usernameinput = Console.ReadLine();
                    
            int passwordinput = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine("Bitte geben Sie Ihr Passwort ein:");
                string pwinput = Console.ReadLine();

                if (int.TryParse(pwinput, out passwordinput))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie ihr viertelliges Passwort ein.");
                }
            }

            if (_atm.ValidateUser(usernameinput, passwordinput, Account.AllAccounts))
            {
                Account acc = _atm.GetCurrentAccount(usernameinput, passwordinput, Account.AllAccounts);
                while (true)
                {
                Console.WriteLine("\nWählen Sie eine Aktion:");
                Console.WriteLine("1. Einzahlen");
                Console.WriteLine("2. Abheben");
                Console.WriteLine("3. Kontostand überprüfen");
                Console.WriteLine("4. Beenden");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                case "1":
                    Console.Write("Geben Sie den Einzahlungsbetrag ein: $");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        if (depositAmount > 0)
                        {
                            _atm.Deposit(acc,depositAmount);
                            Console.WriteLine($"Einzahlung von ${depositAmount} erfolgreich.");
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie einen gültigen Betrag ein.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie einen gültigen Betrag ein.");
                    }
                    break;
                case "2":
                    Console.Write("Geben Sie den Abhebungsbetrag ein: $");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                    {
                        if (withdrawalAmount > 0)
                        {
                            _atm.Withdraw(acc, withdrawalAmount);
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie einen gültigen Betrag ein.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie einen gültigen Betrag ein.");
                    }
                    break;
                case "3":
                    decimal balance = _atm.CheckBalance(acc);
                    Console.WriteLine($"Ihr aktueller Kontostand beträgt: ${balance}");
                    break;
                case "4":
                    Console.WriteLine("Vielen Dank, dass Sie unseren Bankautomaten verwendet haben. Auf Wiedersehen!");
                    return;
                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte geben Sie eine gültige Option ein.");
                    break;
                }
                }
            } 
            else
            {                             
                Console.WriteLine("Ihre Anmeldedaten sind ungültig. Sie werden abgemeldet!");
            }
        }
    }
}

