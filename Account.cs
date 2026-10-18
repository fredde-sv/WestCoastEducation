using System;


namespace WestcoastEducation;

public class Account
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? SocialNumber { get; set; }
    public string? Address { get; set; }
    public string? ZipCode { get; set; }
    public string? City { get; set; }
    public string? Email { get; set; }

    public virtual string GetInfo()
    {
        return $"{FirstName} {LastName} {City}";
    }

    public void Validate()
    {
        string personName = $"{FirstName} {LastName}";

        if (string.IsNullOrWhiteSpace(FirstName))
            throw new Exception($"Förnamn måste finnas");

        if (string.IsNullOrWhiteSpace(LastName))
            throw new Exception($"{FirstName} måste finnas");

        if (string.IsNullOrWhiteSpace(PhoneNumber))
            throw new Exception($"{personName} måste ha ett telnr");

        if (string.IsNullOrWhiteSpace(SocialNumber))
            throw new Exception($"{personName} måste ha ett personnr");

        if (string.IsNullOrWhiteSpace(Address))
            throw new Exception($"{personName} Måste ha en adress");

        if (string.IsNullOrWhiteSpace(ZipCode))
            throw new Exception($"{personName} måste ha ett postnr");

        if (string.IsNullOrWhiteSpace(City))
            throw new Exception($"{personName} måste ha en stad");

        if (string.IsNullOrWhiteSpace(Email))
            throw new Exception($"{personName} måste ha en mail");
    }

}