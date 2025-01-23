// Base Class
public class Person
{
    public string Name;
    public int Age;

    public void Intro()
    {
        Console.WriteLine($"I am {Name} and I am {Age} years old.");
    }
}

// Derived Class 1
public class Designation : Person
{
    public string Desig;

    public void Work()
    {
        Console.WriteLine($"My Designation  {Desig}.");
    }
}

// Derived Class 2
public class Manager : Designation
{
    public void Manage()
    {
        Console.WriteLine("I managing a Code.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager obj = new Manager();

        obj.Name = "Durgesh";
        obj.Age = 21;
        obj.Desig = "Software Developer";

        obj.Intro();     // Base Class
        obj.Work();      // Derived Class 1
        obj.Manage();    // Derived Class 2
    }
}
