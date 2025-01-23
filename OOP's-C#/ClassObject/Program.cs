// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Classes And Objects.");

class Car
{
    string carName = "fortuner";
    string color = "white";

    static void Main(string[] args)
    {
        // Car obj = new Car(); // Single object

        // Multiple Objects
        Car obj1 = new Car();
        Car obj2 = new Car();

        Console.WriteLine("1 Car Name is : " + obj1.carName);
        Console.WriteLine("1 Car Color is : " + obj1.color);

        Console.WriteLine("2. Car Name is : " + obj2.carName);
        Console.WriteLine("2. Car Color is : " + obj2.color);


        //  CarFeature class ka object call.

        CarFeature objFeature=new CarFeature();
        Console.WriteLine("Car Feature is : "+ objFeature.feature);
    }
}

// Using Multiple Classes
class CarFeature{
    public string feature="7 Seater";
}



