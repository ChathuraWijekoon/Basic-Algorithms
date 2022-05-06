using System;
namespace Exercise_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Answer(113));
        Console.WriteLine(Answer(90));
        Console.WriteLine(Answer(89));
        Console.ReadLine();
    }

    public static bool Answer(int x)
    {
        if (Math.Abs(x-100)<=10 || Math.Abs(x-200)<=10)
        {
            return true;
        }
        return false;
    }
}