using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        HashSet<string> list = new HashSet<string>();        

        for (int i = 0; i < strand.Length; i+=3)
        {
            string temp = strand.Substring(i, 3);
            list.Add(new Regex(@"(AUG)+").IsMatch(temp) ? "Methionine" : "");
            list.Add(new Regex(@"(U){2}[UC]+").IsMatch(temp) ? "Phenylalanine" : "");
            list.Add(new Regex(@"(U){2}[AG]+").IsMatch(temp) ? "Leucine" : "");
            list.Add(new Regex(@"(UC)[UCAG]+").IsMatch(temp) ? "Serine" : "");
            list.Add(new Regex(@"(UA)[UC]+").IsMatch(temp) ? "Tyrosine" : "");
            list.Add(new Regex(@"(UG)[UC]+").IsMatch(temp) ? "Cysteine" : "");
            list.Add(new Regex(@"(UGG)+").IsMatch(temp) ? "Tryptophan" : "");
            list.Add(new Regex(@"(UAA)+?|(UAG)+?|(UGA)+?").IsMatch(temp) ? "STOP" : "");

            if (list.Contains("STOP"))
                break;                          
        }

        list.RemoveWhere(x => x == "");
        list.RemoveWhere(x => x == "STOP");

        return list.ToArray();
    }
}