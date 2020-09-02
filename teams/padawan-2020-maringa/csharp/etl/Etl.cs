using System;
using System.Collections.Generic;

public static class Etl
{    
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> list = new Dictionary<string, int>();

        foreach (var key in old)
        {
            foreach (var value in key.Value)
                list[value.ToLower()] = key.Key;
        }
        return list;
    }
}