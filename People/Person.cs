using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM
{
    public class Person
    {
    // Eigenschaften (Properties) für die Personeninformationen
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    // Konstruktor, um eine Instanz der Klasse zu erstellen
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
    }

    // Methode zur Anzeige von Personeninformationen
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Vorname: {FirstName}");
        Console.WriteLine($"Nachname: {LastName}");
        Console.WriteLine($"Geburtsdatum: {BirthDate.ToShortDateString()}");
    }
    }
}