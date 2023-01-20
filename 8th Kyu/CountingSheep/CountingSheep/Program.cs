using System.Linq;

Console.WriteLine("Hello, World!");

public static class Kata
{
    public static int CountSheeps(bool[] sheeps) => sheeps.Where(x => x.Equals(true)).Count();
     
}