using System;

class Program
{
    enum weeks
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public static void Main(string[] args)
    {
        weeks day = weeks.Monday;

        Console.WriteLine("Day is: " + day);
    }
}
