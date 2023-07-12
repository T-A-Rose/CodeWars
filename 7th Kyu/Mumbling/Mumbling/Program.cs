Console.WriteLine(Accum("ZpglnRxqenU"));
static String Accum(string s)
{
    char[] charArr = s.ToCharArray();
    List<char> testList = new List<char>();
    for (var i = 0; i < charArr.Length; i++)
    {
        if (!testList.Any())
        {
            testList.Add(charArr[i]);
        } else if (testList[i - 1] != charArr[i])
        {
            for (int y = 0; y < i + 1; y++)
            {
                if (y == 0)
                {
                    testList.Add('-');
                    testList.Add(char.ToUpper(charArr[i]));
                }
                else
                {
                    testList.Add(charArr[i]);    
                }
            }
        }
    }

    var tempString = Path.Combine(testList.ToString());
    return tempString;
}