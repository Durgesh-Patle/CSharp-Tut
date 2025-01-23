// Base Class.
public class Base{
    public void Intro(){
        Console.WriteLine("I am Base Class");
    }
}

// Derived Class
public class Derived: Base{
    public void DerivedC1(){
        Console.WriteLine("i am Child Class");
    }
}

public class Program{
    public static void Main(string [] args){
        Derived obj=new Derived();

        obj.Intro(); // Base Class.
        obj.DerivedC1(); // Derived Class.
    }
}