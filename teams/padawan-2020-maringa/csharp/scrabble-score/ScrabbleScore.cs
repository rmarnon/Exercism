using System.Collections.Generic;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        Dictionary<char, int> list = new Dictionary<char, int>();

        list['A'] = 1; list['E'] = 1; list['I'] = 1; list['O'] = 1; list['U'] = 1; list['L'] = 1; list['N'] = 1; list['R'] = 1; list['S'] = 1; list['T'] = 1;
        list['D'] = 2; list['G'] = 2; 
        list['B'] = 3; list['C'] = 3; list['M'] = 3; list['P'] = 3; 
        list['F'] = 4; list['H'] = 4; list['V'] = 4; list['W'] = 4; list['Y'] = 4;
        list['K'] = 5;
        list['J'] = 8; list['X'] = 8;
        list['Q'] = 10; list['Z'] = 10;

        int count = 0;

        foreach (var item in list)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input.ToUpper()[i] == item.Key)
                {
                    count += item.Value;
                }
            }           
        }
        return count;
    }
}
