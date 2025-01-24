using System;

namespace AbstractionExample
{
    // Abstract class
    abstract class Animal
    {
        // Abstract method (no implementation here)
        public abstract void MakeSound();

        // Concrete method (implemented here)
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    // Derived class
    class Dog : Animal
    {
        // Providing implementation for the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Animal animal = new Animal(); // Error: Cannot instantiate an abstract class
            Animal dog = new Dog(); // Allowed because Dog implements all abstract methods

            dog.MakeSound(); 
            dog.Sleep();    
        }
    }
}
