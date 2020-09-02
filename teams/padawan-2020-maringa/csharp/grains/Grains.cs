using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n > 0 && n < 65)
        {
            return (ulong)Math.Pow(2, n - 1);
        }
        else
            throw new ArgumentOutOfRangeException();
    }

    public static ulong Total()
    {
        ulong count = 0;
        for (int i = 1; i <= 64; i++)
        {
            count += Square(i);
        }
        return count;
    }
}