// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Kata
{
    static public void main(String[] args)
    {
        Opposite(1);
    }

    public static int Opposite(int number)
    {
        var number1 = number.ToString();
        if (number1.Contains("-"))
        {
            return Convert.ToInt32(number1.Remove(0, 1));
        } else
        {
            return Convert.ToInt32(number1.Insert(0, "-"));
        }
    }
}