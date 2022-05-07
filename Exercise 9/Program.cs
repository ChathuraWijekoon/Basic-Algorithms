using System;
namespace Exercise_9;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine(Answer("C# DOTNET"));
        Console.WriteLine(Answer("C++"));
    }

    public static bool Answer(string str)
    {
        return (str.Length < 3 && str.Equals("C#")) || (str.StartsWith("C#") && str[2] == ' ');
    }
}