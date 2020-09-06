using System;
using System.Diagnostics.CodeAnalysis;

public partial class Clock : IComparable<Clock>, IComparable
{
    public int CompareTo([AllowNull] Clock other) 
    {
        if (this > other)
            return 1;

        if (this < other)
            return -1;

        return 0;
    }

    public int CompareTo(object obj) => obj is Clock clock ? CompareTo(clock) : throw new ArgumentException();
}