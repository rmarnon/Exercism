using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide) => nucleotide
        .Replace('A', 'U')
        .Replace('T', 'A')
        .Replace('G', 'c')
        .Replace('C', 'G')        
        .Replace('c', 'C');    
}