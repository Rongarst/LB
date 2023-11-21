using System;

class Address
{
    public string? Index { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? House { get; set; }
    public string? Apartment { get; set; }
}

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }
    public double ConvertToUSD(double amountInUah)
    {
        return amountInUah / usdRate;
    }

    public double ConvertToEUR(double amountInUah)
    {
        return amountInUah / eurRate;
    }

    public double ConvertToPLN(double amountInUah)
    {
        return amountInUah / plnRate;
    }

    public double ConvertFromUSD(double amountInUSD)
    {
        return amountInUSD * usdRate;
    }

    public double ConvertFromEUR(double amountInEUR)
    {
        return amountInEUR * eurRate;
    }

    public double ConvertFromPLN(double amountInPLN)
    {
        return amountInPLN * plnRate;
    }
}
class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string last, string first)
    {
        lastName = last;
        firstName = first;
    }
    public void CalculateSalary(string position, int experience)
    {
        double baseSalary = 0;
        double tax = 0;

        switch (position.ToLower())
        {
            case "менеджер":
                baseSalary = 30000 + (experience * 1000);
                break;
            case "розробник":
                baseSalary = 25000 + (experience * 800);
                break;
            case "дизайнер":
                baseSalary = 20000 + (experience * 700);
                break;
            default:
                Console.WriteLine("Invalid position.");
                return;
        }
        if (baseSalary <= 10000)
        {
            tax = baseSalary * 0.1;
        }
        else if (baseSalary > 10000 && baseSalary <= 30000)
        {
            tax = baseSalary * 0.15;
        }
        else
        {
            tax = baseSalary * 0.2;
        }
        Console.WriteLine($"Працівник: {lastName} {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {baseSalary:C2}");
        Console.WriteLine($"Податковий збір: {tax:C2}");
    }
}

class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age, DateTime registrationDate)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = registrationDate;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("Інформація користувача:");
        Console.WriteLine($"Логін: {Login}");
        Console.WriteLine($"Ім'я: {FirstName} {LastName}");
        Console.WriteLine($"Вік: {Age}");
        Console.WriteLine($"Дата реєстрації: {RegistrationDate:d}");
    }
}

class Program
{
    static void Main()
    {
        Converter converter = new Converter(36.25, 39.36, 9.01);
        double amountInUah = 1000;
        Console.WriteLine($"{amountInUah} UAH = {converter.ConvertToUSD(amountInUah):0.00} USD");
        Console.WriteLine($"{amountInUah} UAH = {converter.ConvertToEUR(amountInUah):0.00} EUR");
        Console.WriteLine($"{amountInUah} UAH = {converter.ConvertToPLN(amountInUah):0.00} PLN");

        Employee employee = new Employee("Олександр", "Іванов");
        string position = "менеджер";
        int experience = 5;
        employee.CalculateSalary(position, experience);

        DateTime registrationDate = DateTime.Now;
        User user = new User("Olex_Ivanov", "Олександр", "Іванов", 25, registrationDate);
        user.DisplayUserInfo();

        Address address = new Address();
        address.Index = "12345";
        address.Country = "Україна";
        address.City = "Київ";
        address.Street = "Дегтярівська";
        address.House = "10";
        address.Apartment = "5";

        Console.WriteLine("Адресса:");
        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");
    }
}
