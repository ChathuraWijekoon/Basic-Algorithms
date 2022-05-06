using System;
namespace Exercise_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Output("Python",1));
        Console.WriteLine(Output("Python",0));
        Console.WriteLine(Output("Python",4));
    }

    public static string Output(String s, int n)
    {
        return s.Remove(n,1);
    }
}