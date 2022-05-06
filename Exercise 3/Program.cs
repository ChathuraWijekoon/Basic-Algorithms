using System;
namespace Exercise_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Answer(30,0));
        Console.WriteLine(Answer(25,5));
        Console.WriteLine(Answer(20,30));
        Console.WriteLine(Answer(20,25));
        Console.ReadLine();
    }

    public static bool Answer(int x, int y)
    {
        return x == 30 || y == 30 || (x + y == 30);

        // ** Same code for above statement **
        // if (x == 30 || y == 30 || (x + y == 30))
        // {
        //     return true;
        // }
    }
}

