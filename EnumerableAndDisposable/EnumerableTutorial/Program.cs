// Demo program for PersonName class
Console.WriteLine("PersonName Demo");

var person1 = new PersonName("John", "Doe");
var person2 = new PersonName("Jane", "Smith", "Marie");

Console.WriteLine($"Person 1: {person1.FirstName} {person1.MiddleName} {person1.LastName}");
Console.WriteLine($"Person 2: {person2.FirstName} {person2.MiddleName} {person2.LastName}");

public class PersonName
{
    public string FirstName { get; }
    public string? MiddleName { get; }
    public string LastName { get; }

    public PersonName(string firstName, string lastName, string? middleName = null)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
}