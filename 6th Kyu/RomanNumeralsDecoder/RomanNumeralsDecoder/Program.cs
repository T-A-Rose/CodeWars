// See https://aka.ms/new-console-template for more information
Console.WriteLine(RomanDecode.Solution("I"));
Console.ReadLine();


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

        for (var i = 0; i < roman.ToCharArray().Length; i++)
        {
            romanNumbersDictionary.TryGetValue(roman[i], out var num);
            if (i + 1 < roman.Length && romanNumbersDictionary[roman[i + 1]] > romanNumbersDictionary[roman[i]])
            {
                sum -= romanNumbersDictionary[roman[i]];
            }
            else
            {
                sum += romanNumbersDictionary[roman[i]];
            }
        }
        return sum;
    }
}