using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public static class ClockComparer
{
    public static AscendingTimeComparer Ascending { get; set; } = new AscendingTimeComparer();
    public static DescendingTimeComparer Descending { get; set; } = new DescendingTimeComparer();
    public static DescendingHourAscendingMinutesComparer DescendingHourAscendingMinutes { get; set; } = new DescendingHourAscendingMinutesComparer();
}

public class AscendingTimeComparer : IComparer<Clock>, IComparer
{
    public int Compare([AllowNull] Clock clock, [AllowNull] Clock other)
    {
        return (clock > other) ? 1 : (clock < other) ? -1 : 0;
    }

    public int Compare(object clock, object other)
    {
        if (clock is not Clock && other is not Clock)
            throw new ArgumentException();

        return (Compare(clock, other));
    }
}

public class DescendingTimeComparer : IComparer<Clock>, IComparer
{
    public int Compare([AllowNull] Clock clock, [AllowNull] Clock other)
    {
        return (clock < other) ? 1 : (clock > other) ? -1 : 0;
    }

    public int Compare(object clock, object other)
    {
        if (clock is not Clock && other is not Clock)
            throw new ArgumentException();

        return (Compare(clock, other));
    }
}

public class DescendingHourAscendingMinutesComparer : IComparer<Clock>
{
    public int Compare([AllowNull] Clock clock, [AllowNull] Clock other)
    {
        return (clock.Hours > other.Hours) ? -1
            : (clock.Hours < other.Hours) ? 1
            : (clock.Minutes < other.Minutes) ? -1
            : (clock.Minutes > other.Minutes) ? 1
            : 0;
    }
}

