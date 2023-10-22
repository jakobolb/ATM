using ATM;

internal class Program
{
    private static void Main(string[] args)
    {
        IBankATM atm = new BankATM();
        ATMConsoleUI atmUI = new ATMConsoleUI(atm);

        Account acc1 = new Account("Jakob", "Olberding", new DateTime(2000, 09, 27),200,"jakobolb", 1234);
        Account acc2 = new Account("David", "Olberding", new DateTime(2002, 02, 08),432,"davidolb", 4321);

        atmUI.Run();
    }
}