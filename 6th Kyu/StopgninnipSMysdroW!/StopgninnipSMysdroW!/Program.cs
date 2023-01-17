using System.Collections.Generic;
using System.Linq;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine(Kata.SpinWords("You are almost to the last test"));
Console.ReadLine();

public class Kata
{
    public static string SpinWords(string sentence)
    {
        List<string> sentenceArr = new List<string>();

        foreach (string word in sentence.Split(" "))
        {
            if (word.Length >= 5)
            {
                sentenceArr.Add(Reverse(word));   
            } else
            {
                sentenceArr.Add(word);
            }
        }
        return String.Join(" ", sentenceArr);
    }

    private static string Reverse(string word)
    {
        char[] chars = word.ToCharArray();
        List<char> charsArr = new List<char>();
        Array.Reverse(chars);
        foreach (char c in chars)
        {
            charsArr.Add(c);
        }

       var reversedWord = string.Join("", charsArr);
       return reversedWord;
    }
}