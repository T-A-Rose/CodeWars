using System;
using System.Diagnostics.CodeAnalysis;

public class Kata
{
    static void Main(string[] args)
    {
        //Console.WriteLine(SquareDigits(9119));
        //IsSquare(-1);
        //IsSquare(3);
        //IsSquare(4);
        //IsSquare(25);
        //IsSquare(26);
        //IsSquare(206104);
        //IsSquare(0);
        //Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
        //Order("is2 Thi1s T4est 3a");
        string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
        FriendOrFoe(names);


        Console.ReadLine();
    }

    public static int SquareDigits(int n)
    {

        string output = "";
        foreach (char c in n.ToString())
        {
            int square = int.Parse(c.ToString());
            output += (square * square);
        }

        return int.Parse(output);
    }

    public static bool IsSquare(int n)
    {

        return Math.Sqrt(n) % 1 == 0;

        if (int.TryParse(Math.Sqrt(n).ToString(), out n))
        {
            if (Math.Sqrt(n) == (n / Math.Sqrt(n)))
            {
                return true;
            }
            else return true;
        }
        else
        {
            return false;
        };
    }

    public static string AlphabetPosition(string text)
    {
        text = text.ToLower();
        string convertedLetters = "";
        char[] letters = text.ToCharArray();
        foreach (char i in letters)
        {
            if ((char.IsPunctuation(i)) || (i.ToString() == " "))
            {
                convertedLetters += "";
            }
            else if ((i.ToString() != " ") && (char.IsLetter(i)))
            {
                convertedLetters += NumberConverter(i) + " ";
            };

        }
        convertedLetters = convertedLetters.TrimEnd();
        return convertedLetters;
    }

    public static string NumberConverter(char letter)
    {
        switch (letter)
        {
            case 'a':
                return "1";
            case 'b':
                return "2";
            case 'c':
                return "3";
            case 'd':
                return "4";
            case 'e':
                return "5";
            case 'f':
                return "6";
            case 'g':
                return "7";
            case 'h':
                return "8";
            case 'i':
                return "9";
            case 'j':
                return "10";
            case 'k':
                return "11";
            case 'l':
                return "12";
            case 'm':
                return "13";
            case 'n':
                return "14";
            case 'o':
                return "15";
            case 'p':
                return "16";
            case 'q':
                return "17";
            case 'r':
                return "18";
            case 's':
                return "19";
            case 't':
                return "20";
            case 'u':
                return "21";
            case 'v':
                return "22";
            case 'w':
                return "23";
            case 'x':
                return "24";
            case 'y':
                return "25";
            case 'z':
                return "26";
            default:
                return "";
        };
    }

    public static string Solution(string str)
    {
        string reversedWord = "";
        int a = str.Length - 1;
        while (a >= 0)
        {
            reversedWord += str[a];
            a--;
        }
        return reversedWord;
    }

    public static string Order(string words)
    {
        string[] splitWords = words.Split(" ");
        string[] testArr = new string[splitWords.Length];
        int i = 0;
        
        foreach (char x in words.ToCharArray())
        {
            if (char.IsDigit(x))
            {
                int N = x - '0';
                testArr[N - 1] = splitWords[i];
                ++i;
            };    
        }

        string orderedString = string.Join(" ", testArr);
        return orderedString;
    }

    public static IEnumerable<string> FriendOrFoe(string[] names)
    {

        List<string> nameList = new();
        nameList.AddRange(names);
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i].Length != 4)
            {
                nameList.Remove(names[i]);
            };
        };
        return nameList;
    }



}