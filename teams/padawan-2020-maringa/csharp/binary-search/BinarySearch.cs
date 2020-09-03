using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {   
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == value)
                return i;
        }
        return -1;
    }
}