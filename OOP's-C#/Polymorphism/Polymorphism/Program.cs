//  1 ... Compile-Time Polymorphism (Method Overloading)
// using System;

// namespace Polymorphism
// {
//     class Calculator
//     {
//         // Method with no parameters
//         public int Add()
//         {
//             return 0;
//         }

//         // Method with two parameters
//         public int Add(int a, int b)
//         {
//             return a + b;
//         }

//         // Method with three parameters
//         public int Add(int a, int b, int c)
//         {
//             return a + b + c;
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Calculator calc = new Calculator();
            
//             Console.WriteLine("Add() without parameters: " + calc.Add());    
//             Console.WriteLine("Add(2, 3): " + calc.Add(2, 3));                     
//             Console.WriteLine("Add(1, 2, 3): " + calc.Add(1, 2, 3));          
//         }
//     }
// }



// 2..  Compile-Time Polymorphism (Operator Overloading)

// using System;

// namespace Polymorphism
// {
//     class Complex
//     {
//         public int Real;
//         public int Imaginary ;

//         public Complex(int real, int imaginary)
//         {
//             Real = real;
//             Imaginary = imaginary;
//         }

//         // Overloading the + operator
//         public static Complex operator +(Complex c1, Complex c2)
//         {
//             return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
//         }

//         public override string ToString()
//         {
//             return $"{Real} + {Imaginary}i";
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Complex c1 = new Complex(1, 2);
//             Complex c2 = new Complex(3, 4);
//             Complex result = c1 + c2; // Using overloaded + operator

//             Console.WriteLine("Result: " + result); // Output: 4 + 6i
//         }
//     }
// }



//  Overriding Methods

using System;

namespace MyApplication
{
  class Animal  // Base class (parent) 
  {
    public virtual void animalSound()
    {
      Console.WriteLine("The animal makes a sound");
    }
  }

  class Pig : Animal  // Derived class (child) 
  {
    public override void animalSound()
    {
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Dog : Animal  // Derived class (child) 
  {
    public override void animalSound()
    {
      Console.WriteLine("The dog says: bow wow");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Animal myAnimal = new Animal();  // Create a Animal object
      Animal myPig = new Pig();  // Create a Pig object
      Animal myDog = new Dog();  // Create a Dog object
      
      myAnimal.animalSound();
      myPig.animalSound();
      myDog.animalSound();
    }
  }
}