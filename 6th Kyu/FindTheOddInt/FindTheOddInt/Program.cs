// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Kata
{
    public static int find_it(int[] seq)
    {
        List<int> oddList = seq.OfType<int>().ToList();
        var oddCount = 0;
        var numberGroups = oddList.GroupBy(i => i);
        foreach (var x in numberGroups)
        {
            var curNum = x.Key;
            var numCount = x.Count();
            if (numCount > oddCount && numCount % 2 != 0)
            {
                oddCount = curNum;
            }
        }

        return oddCount;
    }
}

