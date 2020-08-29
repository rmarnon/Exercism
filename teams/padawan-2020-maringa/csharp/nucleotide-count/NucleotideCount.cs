using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    private readonly static Dictionary<char, int> chars = new Dictionary<char, int>();

    public static IDictionary<char, int> Count(string sequence)
    {
        chars['A'] = 0;
        chars['C'] = 0;
        chars['G'] = 0;
        chars['T'] = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (!chars.ContainsKey(sequence[i]))           
                throw new ArgumentException(); 

            chars[sequence[i]]++;
        }

        return chars;
    }
}