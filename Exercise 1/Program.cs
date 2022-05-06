using System;

namespace Exercise_1;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Values(1,2));
        Console.WriteLine(Values(2,3));
        Console.WriteLine(Values(2,2));
        Console.ReadLine();
    }

    public static int Values(int x, int y)
    {
        return x == y ? (x + y)*3 : x + y;
    }
}