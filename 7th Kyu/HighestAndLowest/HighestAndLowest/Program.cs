// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        int highest = int.MinValue, lowest = int.MaxValue;
        foreach (var c in numbers.Split(" "))
        {
            if (Convert.ToInt32(c) >= highest) highest = Convert.ToInt32(c);
            if (Convert.ToInt32(c) <= lowest) lowest = Convert.ToInt32(c);
        }
        return $"{highest} {lowest}";
    }
}