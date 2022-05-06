using System;

namespace Exercise_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Diff(12));
        Console.WriteLine(Diff(9));
        Console.WriteLine(Diff(11));
        Console.ReadLine();
    }

    public static int Diff(int n)
    {
        const int x = 10;

        if (n>x)
        {
            return(n-x)*3;
        }
        return x-n;
    }
}