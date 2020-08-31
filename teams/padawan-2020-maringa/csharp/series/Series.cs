using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (numbers.Length >= sliceLength && sliceLength > 0)
        {
            string[] slice = new string[numbers.Length - sliceLength + 1];
            for (int i = 0; i < slice.Length; i++)
            {
                slice[i] = numbers.Substring(i, sliceLength);
            }
            return slice;
        }

        throw new ArgumentException();
    }
}