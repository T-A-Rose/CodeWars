// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

RomanDecode.Solution("MCMLIV");

public class RomanDecode
{
    public static int Solution(string roman)
    {
        var sum = 0;
        Dictionary<char, int> romanNumbersDictionary = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        if (roman.Length % 2 == 0)
        {

        }
        char[] tempChars = roman.Split();
        char[] romanChars = roman.ToCharArray();
        if (romanChars.Count % 2 = 0)
        {

        }
        foreach (char c in romanChars)
        {
            romanNumbersDictionary.TryGetValue(c, out var num);
            sum += num;
        }
        return sum;
    }
}