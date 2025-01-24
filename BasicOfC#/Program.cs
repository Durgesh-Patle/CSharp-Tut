using System;

namespace HelloWorld
{
  class Program
  {
    static void MyClass()
    {
      Console.WriteLine("Hello");
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello C#");
      // MyClass();   

      // Task -1
      // Console.Write("Enter Your Name: ");
      // string name = Console.ReadLine();

      // string reName = char.ToUpper(name[0]) + name.Substring(1, name.Length - 2) + char.ToUpper(name[name.Length - 1]);

      // string reName = "";
      // for (int i = 0; i < name.Length; i++)
      // {
      //   if ((i == 0) || (i == name.Length - 1))
      //   {
      //     reName += char.ToUpper(name[i]);
      //   }
      //   else
      //   {
      //     reName += name[i];
      //   }
      // }
      // Console.WriteLine("Your Rename is :" + reName);


      // 2. Variables and Data Types.
      // int age = 25;
      // string name = "John";
      // double salary = 50000.50;
      // float f = 3.6f;
      // Console.WriteLine(f);
      // bool isEmployed = true;

      // Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}, Employed: {isEmployed}");


      // 3. User Input
      // Console.Write("Enter your name: ");
      // string name = Console.ReadLine();

      // Console.Write("Enter your age: ");
      // int age = Convert.ToInt32(Console.ReadLine());

      // Console.WriteLine($"Hello {name}, you are {age} years old.");


      // 4. Conditional Statements
      // Console.Write("Enter a number: ");
      // int number = Convert.ToInt32(Console.ReadLine());

      // if (number > 0)
      //   Console.WriteLine("The number is positive.");
      // else if (number < 0)
      //   Console.WriteLine("The number is negative.");
      // else
      //   Console.WriteLine("The number is zero.");


      // 5. Loops
      // For-Loop .
      //  for (int i = 1; i <= 5; i++)
      //   {
      //       Console.WriteLine($"Iteration {i}");
      //   }

      // While loop.
      // int i = 1;
      // while (i <= 5)
      // {
      //   Console.WriteLine($"Iteration {i}");
      //   i++;
      // }

      // 6 . Array
      // int[] numbers = { 1, 2, 3, 4, 5 };
      // foreach (int num in numbers)
      // {
      //   Console.WriteLine(num);
      // }

      // Practice 
      // 1.. User to input array Length and all elements to user and show output
      // Console.Write("Enter Number: ");
      // int n = Convert.ToInt32(Console.ReadLine());
      // int[] arr = new int[n];
      // for (int i = 0; i < n; i++)
      // {
      //   arr[i] = Convert.ToInt32(Console.ReadLine());
      //   // Console.WriteLine(i);
      // }

      // Console.Write("Array Elements: ");
      // for (int i = 0; i < n; i++)
      // {
      //   Console.Write(arr[i]+ " ");
      // }

      // 2.. Count digit from the number.
      // Console.Write("Enter Number: ");
      // int n = Convert.ToInt32(Console.ReadLine());
      // int c=0;

      // while(n>0){
      //   n/=10;
      //   c++;
      // }
      // Console.WriteLine("Count is: "+c);


      // 3... Aramstrong Number.
      // Console.Write("Enter Number: ");
      // int n = Convert.ToInt32(Console.ReadLine());
      // int c = 0;
      // int z = n;

      // while (n > 0)
      // {
      //   n /= 10;
      //   c++;
      // }

      // n = z;
      // // Console.WriteLine("Count is: " + c + n);

      // int sum = 0;
      // while (n > 0)
      // {
      //   int lastDigits = n % 10;
      //   // Console.WriteLine("Last Digits : " + lastDigits);
      //   int mul = 1;
      //   for (int i = 1; i <= c; i++)
      //   {
      //     mul *= lastDigits;
      //   }
      //   sum += mul;
      //   n /= 10;
      //   // Console.WriteLine("multy is: " + mul);
      // }
      // // Console.WriteLine("sum is: " + sum);

      // Console.WriteLine("ans is: " + (z == sum));






      // 4.... Strings.

      string str = "Hello i am C#";

      // find Strings Length.
      Console.WriteLine("String length = "+ str.Length);

      // Substring.
      // string str1 = str.Substring(2);
      // string str1 = str.Substring(2, 8);
      // Console.WriteLine("Substring = " + str1);


      // Trim String.
      // string st=" Hello I am C#        ";
      // string trimSt=st.Trim();
      // Console.WriteLine("trimST = "+ trimSt);


      // UpperCase String.
      // Console.WriteLine("UpperCase= "+ str.ToUpper());


      // LowerCase String .
      // Console.WriteLine("LowerCase = "+str.ToLower());


      //  Index Find.
      // Console.WriteLine("IndexOf = "+ str.IndexOf("C"));


      // Replace Method.
      // Console.WriteLine("Replace Methods = "+str.Replace("C#","Java"));

      //  Split Strings.
      // string [] words=str.Split(' ');
      // foreach(string i in words){
      //   Console.WriteLine(i);
      // }



      // Methods-  Parameters and Arguments.

      // MyClass();
      // MyClass("Durgesh", 21);

      // Console.WriteLine("sum = " + Add(2, 4));


      // Default Parameter
      // DefPara();



      //C# Named Arguments.
      // NamedArgu(str2:"Hello 2", str3:"Hiii 3", str1:"Byeeee 1");


      // Method Overloading = multiple methods can have the same name with different parameters.

    }

    public static void DefPara(string name = "Durgesh")
    {
      Console.WriteLine("name is " + name);
    }

    public static void MyClass(string name, int age)
    {
      Console.WriteLine("Hello i am " + name + " and age is " + age);
    }

    public static int Add(int a, int b)
    {
      return a + b;
    }

    public static void NamedArgu(string str1, string str2, string str3)
    {
      Console.WriteLine("Secound string: " + str2);
    }
  }
}


