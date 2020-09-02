using System;
using System.Collections.Generic;

public static class Raindrops
{
    public static string Convert(int number)
    {
        List<int> list = new List<int>();
        string converted = "";
       
        for (int i = 1; i <= number; i++)     
            list.Add(number % i == 0 ? number / i : 0);    

        if (list.Contains(3))
            converted += "Pling";
        if (list.Contains(5))
            converted += "Plang";
        if (list.Contains(7))
            converted += "Plong";

        return converted != "" ? converted : number.ToString();
    }
}