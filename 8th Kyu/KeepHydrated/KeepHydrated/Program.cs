using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine(Kata.Litres(1.5));

public class Kata
{
    public static int Litres(double time) => (int)Math.Floor((time * 0.5));
}