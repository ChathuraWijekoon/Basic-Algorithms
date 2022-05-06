using System;
namespace Exercise_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Swap("abcd"));
        Console.WriteLine(Swap("xy"));
    }

    public static string Swap(string s)
    {
        return s.Length > 1 ? s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0,1) : s;
    }
}