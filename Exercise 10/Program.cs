using System;
namespace Exercise_10;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine(Value(1,2,20));
    }

    public static int Value(int x, int y, int z)
    {
        var max = Math.Max(x, Math.Max(y,z));
        return max;
    }
}