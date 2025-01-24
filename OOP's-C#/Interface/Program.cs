// Interfaces.

// Single InterFace.
// using System;

// namespace MyApplication
// {
//   // Interface
//   interface IAnimal 
//   {
//     void animalSound(); 
//   }

//   class Pig : IAnimal 
//   {
//     public void animalSound() 
//     {
//       Console.WriteLine("The pig says: wee wee");
//     }
//   }

//   class Program 
//   {
//     static void Main(string[] args) 
//     {
//       Pig obj = new Pig();
//       obj.animalSound();
//     }
//   }
// }


// Multiple Interface.

using System;

namespace MyApplication
{
  interface IFirstInterface
  {
    void myMethod(); // interface method
  }

  interface ISecondInterface
  {
    void myOtherMethod(); // interface method
  }

  // Implement multiple interfaces
  class DemoClass : IFirstInterface, ISecondInterface
  {
    public void myMethod()
    {
      Console.WriteLine("Some text..");
    }
    public void myOtherMethod()
    {
      Console.WriteLine("Some other text...");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      DemoClass myObj = new DemoClass();
      myObj.myMethod();
      myObj.myOtherMethod();
    }
  }
}