using System.Text.RegularExpressions;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int count = 0;

        var _1 = new Regex(@"[AEIOULNRST]");
        var _2 = new Regex(@"[DG]");
        var _3 = new Regex(@"[BCMP]");
        var _4 = new Regex(@"[FHVWY]");
        var _5 = new Regex(@"[K]");
        var _8 = new Regex(@"[JX]");
        var _10 = new Regex(@"[QZ]");

        foreach (var item in input.ToUpper())
        {
            if (_1.IsMatch(item.ToString())) count += 1;
            if (_2.IsMatch(item.ToString())) count += 2;
            if (_3.IsMatch(item.ToString())) count += 3;
            if (_4.IsMatch(item.ToString())) count += 4;
            if (_5.IsMatch(item.ToString())) count += 5;
            if (_8.IsMatch(item.ToString())) count += 8;
            if (_10.IsMatch(item.ToString())) count += 10;
        }

        return count;
    }
}
