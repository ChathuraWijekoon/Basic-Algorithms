using System;
namespace Exercise_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Output("if else"));
        Console.WriteLine(Output("else"));
        Console.ReadLine();
    }

    public static string Output(string s)
    {
        if (s.Length > 2 && s.Substring(0,2).Equals("if"))
        {
            return s;
        }
        return "if " + s;
    }
}