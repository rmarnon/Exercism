using System.Collections.Generic;

public static class ResistorColor
{    
    public static List<string> colors = new List<string> { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color) => colors.FindIndex(x => x == color);        
    
    public static string[] Colors() => colors.ToArray();
}