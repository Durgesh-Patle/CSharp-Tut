// Base Class
public class Base
{
    public string name;
    public void Intro()
    {
        Console.WriteLine($"I am Base Class from {name} Inheritance");
    }
}

// Derived Class 1
public class Derived1 : Base
{
    public void DeriveC1()
    {
        Console.WriteLine($"I am First Derived Class from {name} Inheritance");
    }
}

// Derived Class 2
public class Derived2 : Base
{
    public void DeriveC2()
    {
        Console.WriteLine($"I am Second Derived Class 2 from {name} Inheritance");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Derived1 obj1 = new Derived1();
        obj1.name = "Hierarchical";

        obj1.Intro();  //  Base class 
        obj1.DeriveC1();  //  Derived1 class 


        Derived2 obj2 = new Derived2();
        obj2.name = "Hierarchical";

        obj2.Intro();  //  Base class 
        obj2.DeriveC2();  //  Derived1 class 
    }
}
