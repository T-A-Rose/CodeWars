// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        var parsedArr = numbers.Split(" ").Select(int.Parse);
        return $"{parsedArr.Max()} {parsedArr.Min()}";
    }
}