using System;
namespace Exercise_8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Answer(15));
        Console.WriteLine(Answer(20));
        Console.WriteLine(Answer(14));
    }

    public static bool Answer(int n)
    {
        return n % 3 == 0 || n % 7 == 0;
    }
}