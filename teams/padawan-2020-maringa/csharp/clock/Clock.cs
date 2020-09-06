using System;
using System.Diagnostics.CodeAnalysis;

public partial class Clock : IEquatable<Clock>
{
    internal int Hours { get; set; }
    internal int Minutes { get; set; }

    public Clock(int minutes) : this(0, minutes) { }
    
    public Clock(int hours, int minutes)
    {     
        Hours = (hours + (minutes / 60)) % 24;
        Minutes = minutes % 60;

        if (Minutes < 0)
        {
            Hours--;
            Minutes = 60 + Minutes;
        }

        if (Hours < 0)           
            Hours = 24 + Hours;       
    }
  
    public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(Hours, Minutes - minutesToSubtract);

    public bool Equals([AllowNull] Clock other) => Hours == other.Hours && Minutes == other.Minutes;

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj))
            return true;

        if (obj is null || !(obj is Clock))
            return false;

        return obj is Clock clock && Equals(clock);
    }

    public override int GetHashCode() => HashCode.Combine(Hours, Minutes);

    public int ToMinute() => Hours * 60 + Minutes;

    public override string ToString() => $"{Hours:D2}:{Minutes:D2}";    
}
