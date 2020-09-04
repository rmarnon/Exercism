using System;
using System.Linq;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        string mask = "For want of a + the - was lost.";
        string lastSubject = "And all for the want of a -.";
        string[] frase = new string[subjects.Length];
        int count = subjects.Length;

        for (int i = 0; i < subjects.Length; i++) 
        {
            while (count != 1)
            {
                frase[i] = mask.Replace("+", subjects[i]).Replace("-", subjects[i + 1]);
                count--;
                i++;
            }

            if (count == 1)
            {
                frase[i] = lastSubject.Replace("-", subjects[0]);
            }  
        }
        return frase;
    }
}